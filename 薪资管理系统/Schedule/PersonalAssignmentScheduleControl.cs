using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using SalarySystem.Data;
using UC.Platform.Data;
using DataRowState = System.Data.DataRowState;

namespace SalarySystem.Schedule
{
    public partial class PersonalAssignmentScheduleControl : BaseEditableControl
    {
        public PersonalAssignmentScheduleControl()
        {
            InitializeComponent();
            var curdate = DateTime.Now.AddMonths(1);
            Year = curdate.Year;
            MonthFrom = curdate.Month;
            MonthTo = 12;

        }

        private readonly Dictionary<int, DataSetSalary.v_personal_assignment_scheduleDataTable>
            _personalAssignmentSchedules = new Dictionary<int, DataSetSalary.v_personal_assignment_scheduleDataTable>();

        private readonly DataSetSalary.t_assignment_performanceDataTable _assignmentPerformance =
            new DataSetSalary.t_assignment_performanceDataTable();

        private const string _ASSIGNMENT_PERFORMANCE_SQL_FORMAT =
            "select * from t_assignment_performance" +
            " where VERSION_ID='{0}'";

        private const string _PERSONAL_SCEHDULE_SQL_FORMAT =
            "SELECT " +
            "t.ID AS EMPLOYEE_ID," +
            "t.NAME AS EMPLOYEE_NAME," +
            "t1.ASSIGNMENT_ID AS DEF_ID," +
            "t1.VERSION_ID AS VERSION_ID," +
            "t1.VALUE AS VALUE," +
            "t2.NAME AS DEF_NAME," +
            "t2.TYPE AS DEF_TYPE," +
            "t2.UNIT_ID AS UNIT_ID," +
            "t3.ID AS PERF_ID," +
            "IFNULL(t3.COMPLETED, 0) AS COMPLETED," +
            "IFNULL(t3.TARGET, t1.VALUE) AS TARGET," +
            "IFNULL(t3.ASSIGNMENT_YEAR, {0}) AS ASSIGNMENT_YEAR," +
            "IFNULL(t3.ASSIGNMENT_MONTH, {1}) AS ASSIGNMENT_MONTH," +
            "IF(ISNULL(t3.ID), FALSE, TRUE) AS ASSIGNED" +
            " FROM" +
            " t_employee t" +
            " LEFT JOIN t_position_assignments t1 ON t1.POSITION_ID = t.POSITION_ID  AND t1.ENABLED = TRUE" +
            " LEFT JOIN t_assignment_define t2 ON t2.ID = t1.ASSIGNMENT_ID  AND t2.TYPE <> '1' AND t2.ENABLED = TRUE  AND t2.VERSION_ID = t1.VERSION_ID" +
            " LEFT JOIN t_assignment_performance t3 ON t.ID = t3.EMPLOYEE_ID  AND t3.VERSION_ID = t1.VERSION_ID AND t3.DEFINE_ID = t1.ASSIGNMENT_ID and t3.ASSIGNMENT_YEAR={0} and t3.ASSIGNMENT_MONTH={1}" +
            " WHERE" +
            " t.ENABLED = TRUE" +
            " AND t1.ENABLED = TRUE" +
            " AND t2.ENABLED = TRUE" +
            " AND (t3.ASSIGNMENT_YEAR={0} OR ISNULL(t3.ASSIGNMENT_YEAR))" +
            " AND (t3.ASSIGNMENT_MONTH={1} OR ISNULL(t3.ASSIGNMENT_MONTH))" +
            " AND t1.VERSION_ID='{2}'";

        void loadAssignmentPerformance()
        {
            string sql = string.Format(_ASSIGNMENT_PERFORMANCE_SQL_FORMAT, GlobalSettings.AssignmentVersion);
            var handler = DBHandlerEx.GetBuffer();
            try
            {
                handler.Fill(_assignmentPerformance, sql);
            }
            finally
            {
                handler.FreeBuffer();
            }
        }
        void loadPersonalMonthSchedule(int year, int monthFrom, int monthTo)
        {
            var handler= DBHandlerEx.GetBuffer();
            try
            {
                _personalAssignmentSchedules.Clear();
                xtraTabControlAssignments.TabPages.Clear();
                for (int month = monthFrom; month <= monthTo; month++)
                {
                    string sql = string.Format(_PERSONAL_SCEHDULE_SQL_FORMAT, year, month,
                        GlobalSettings.AssignmentVersion);
                    var table = new DataSetSalary.v_personal_assignment_scheduleDataTable();
                    handler.Fill(table, sql);
                    _personalAssignmentSchedules.Add(month, table);
                    var page= xtraTabControlAssignments.TabPages.Add(string.Format("{0}月", month));
                    var control = new PersonalMonthlyAssignmentScheduleControl
                    {
                        Dock = DockStyle.Fill,
                        DataTable = table
                    };
                    page.Controls.Add(control);
                }
            }
            finally
            {
                handler.FreeBuffer();
            }
        }

        public int Year
        {
            get { return Convert.ToInt32(spinEditYear.EditValue); }
            set { spinEditYear.EditValue = value; }
        }

        public int MonthFrom
        {
            set
            {
                spinEditMonthFrom.EditValue = value;
            }
            get
            {
                return Convert.ToInt32(spinEditMonthFrom.EditValue);
            }
        }

        public int MonthTo
        {
            set
            {
                spinEditMonthTo.EditValue = value;
            }
            get
            {
                return Convert.ToInt32(spinEditMonthTo.EditValue);
            }
        }
        void loadSchedule(object sender, EventArgs e)
        {
            loadPersonalMonthSchedule(Year, MonthFrom, MonthTo);
            _personalAssignmentSchedules.Values.ToList().ForEach(item => item.RowChanged += onRowChanged);

        }

        
        protected override void onSave()
        {
            var handler = DBHandlerEx.GetBuffer();
            try
            {
                _personalAssignmentSchedules.ToList().ForEach(
                    pair =>
                    {
                        var personalTable =pair.Value;
                        Debug.Assert(personalTable != null);
                        foreach (DataSetSalary.v_personal_assignment_scheduleRow scheduleRow in 
                            from row in personalTable where row.RowState!= DataRowState.Unchanged select row)
                        {
                            if (scheduleRow.IsPERF_IDNull())
                            {
                                if (scheduleRow.ASSIGNED) //新分配
                                {
                                    var newRow = _assignmentPerformance.Newt_assignment_performanceRow();
                                    newRow.ID = Guid.NewGuid().ToString();
                                    newRow.EMPLOYEE_ID = scheduleRow.EMPLOYEE_ID;
                                    newRow.COMPLETED = scheduleRow.COMPLETED;
                                    newRow.TARGET = scheduleRow.TARGET;
                                    newRow.ASSIGNMENT_YEAR = scheduleRow.ASSIGNMENT_YEAR;
                                    newRow.ASSIGNMENT_MONTH = scheduleRow.ASSIGNMENT_MONTH;
                                    newRow.DESCRIPTION = "";
                                    newRow.VERSION_ID = scheduleRow.VERSION_ID;
                                    newRow.DEFINE_ID = scheduleRow.DEF_ID;
                                    _assignmentPerformance.Addt_assignment_performanceRow(newRow);
                                }
                                continue;
                            }
                            string perfId = scheduleRow.PERF_ID;
                            var oldRow=_assignmentPerformance.FindByID(perfId);
                            Debug.Assert(oldRow!=null);
                            if (scheduleRow.ASSIGNED)
                            {
                                oldRow.TARGET = scheduleRow.TARGET; //只允许修改
                            }
                            else
                            {
                                oldRow.Delete();
                            }
                        }
                    });
                handler.Update(_assignmentPerformance);
                _personalAssignmentSchedules.Values.ToList().ForEach(item=>item.AcceptChanges());
                base.onSave();
            }
            finally
            {
                handler.FreeBuffer();
            }
        }

        protected override void onRevert()
        {
            base.onRevert();
            _personalAssignmentSchedules.Values.ToList().ForEach(item=>item.RejectChanges());
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            loadAssignmentPerformance();
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            _personalAssignmentSchedules.Values.ToList().ForEach(item=>item.RowChanged+=onRowChanged);
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _personalAssignmentSchedules.Values.ToList().ForEach(item => item.RowChanged -= onRowChanged);
        }
    }
}
