using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraTab;
using SalarySystem.Data;
using UC.Platform.Data;

namespace SalarySystem.Schedule
{
    public partial class AssignmentScheduleControl : BaseEditableControl
    {
        private const string _SQL_ANNUAL_ASSIGNMENT_TEMPLAT =
            "select distinct t0.ASSIGNMENT_ID as "+ScheduleHelper.Annual.COL_DEF_ID+"," +
            "ifnull(t1.ID,\'\') as "+ScheduleHelper.Annual.COL_TASK_ID+"," +
            "ifnull(t1.NAME,\'\') as "+ScheduleHelper.Annual.COL_TASK_NAME+"," +
            "ifnull(t1.DESCRIPTION,\'\') as "+ScheduleHelper.Annual.COL_TASK_DESC+"," +
            "ifnull(t1.ASSIGNMENT_YEAR, {0}) as "+ScheduleHelper.Annual.COL_YEAR +"," +
            "ifnull(t1.ASSIGNMENT_MONTH, {1}) as " + ScheduleHelper.Annual.COL_MONTH+ "," +
            "ifnull(t1.TARGET, 0) as " + ScheduleHelper.Annual.COL_TARGET+ "," +
            "ifnull(t1.CREATE_TIME, current_date()) as " + ScheduleHelper.Annual.COL_CREATE_TIME + "," +
            "ifnull(t1.VERSION_ID, t2.VERSION_ID) as " + ScheduleHelper.Annual.COL_VERSION_ID + "," +
            "ifnull(t1.EXEC_STATE, 0) as " + ScheduleHelper.Annual.COL_STATE + "," +
            "ifnull(t1.CREATOR_ID, \'nobody\') as " + ScheduleHelper.Annual.COL_CREATOR + "," +
            "t2.NAME as " + ScheduleHelper.Annual.COL_DEF_NAME + "," +
            "cast(t3.VALUE as decimal) as " + ScheduleHelper.Annual.COL_RATE + " " +
            "from t_position_assignments t0 " +
            "left join t_annual_assignment t1 on " +
                "t1.ASSIGNMENT_ID=t0.ASSIGNMENT_ID " +
                "and t1.VERSION_ID=t1.VERSION_ID " +
                "and t1.ASSIGNMENT_YEAR={0} " +
                "and t1.ASSIGNMENT_MONTH={1} " +
            "inner join t_assignment_define t2 on t0.ASSIGNMENT_ID=t2.ID " +
            "left join t_settings t3 on cast(substr(t3.NAME, -2) as unsigned)= {1} " +
            "where " +
            "t0.ENABLED=true " +
            "and t2.TYPE = \'1\' " +
            "and t3.NAME like \'assignment.schedule%\' " +
            "and t2.VERSION_ID=\'{2}\'";

        private static string getSqlAnnualAssignmentOneMonth(int year, int month)
        {
            //string sqlFormat = "select * from ({0}) t_all";
            return string.Format(_SQL_ANNUAL_ASSIGNMENT_TEMPLAT, year, month, GlobalSettings.AssignmentVersion);
        }

        private static string getAnnualAssignmentSql(string id, int year, int monthFrom, int monthTo)
        {
            string sql = "";
            for (int i = monthFrom; i <= monthTo; i++)
            {
                sql += "(" + getSqlAnnualAssignmentOneMonth(year, i) + ")";
                if (i < monthTo)
                {
                    sql += " union all ";
                }
            }
            return string.IsNullOrEmpty(id) ? string.Format("select * from ({0}) t_all", year) :
                string.Format("select * from ({0}) t_all where t_all.{2}='{1}' ", sql, id, ScheduleHelper.Annual.COL_DEF_ID);
        }

        public AssignmentScheduleControl()
        {
            InitializeComponent();
            spinEditYear.Value = DateTime.Now.Year;
            spinEditMonthFrom.Value = DateTime.Now.Month;
            spinEditMonthTo.Value = 12;
        }

        private const string _SQL_ASSIGNMENT_LIST = "select * from v_auto_assignment_list where VERSION_ID={0}";

        private readonly Dictionary<DataSetSalary.v_auto_assignment_listRow, DataSet> _annualSchedules=new Dictionary<DataSetSalary.v_auto_assignment_listRow, DataSet>();
        protected void loadData(int year, int monthFrom, int monthTo)
        {
            var assignmentList=new DataSetSalary.v_auto_assignment_listDataTable();
            var ret=DBHandlerEx.FillOnce(assignmentList, string.Format(_SQL_ASSIGNMENT_LIST, GlobalSettings.AssignmentVersion));
            if (ret < 0)
            {
                MessageBox.Show("加载数据出错...");
                return;
            }
            if(ret==0)
            {
                MessageBox.Show("当前版本没有定义任何自动分配类型任务。请先定义任务...");
                return;
            }
            _annualSchedules.Clear();
            xtraTabControlScheduleItems.TabPages.Clear();
            assignmentList.Rows.Cast<DataSetSalary.v_auto_assignment_listRow>().ToList().ForEach(row =>
            {
                DataSet dataSet=new DataSet();
                if (loadAnnualSchedule(dataSet, year, monthFrom, monthTo, row.ASSIGNMENT_ID) < 0)
                {
                    MessageBox.Show("加载年度计划错误...");
                    return;
                }
                _annualSchedules.Add(row, dataSet);
                dataSet.Tables[0].RowChanged += onRowChanged;
                XtraTabPage page = xtraTabControlScheduleItems.TabPages.Add(row.NAME);
                ScheduleItemControl control = new ScheduleItemControl
                {
                    Dock = DockStyle.Fill,
                    Tag = row
                };
                control.DataChanged += dataChanged;
                control.SetScheduleItem(new AssignmentScheduleDetailParameter(dataSet.Tables[0], row.ASSIGNMENT_ID,
                    row.UNIT_NAME, row.NAME, monthFrom, monthTo, year));
                page.Controls.Add(control);
            });
        }

        private void dataChanged(object sender, EventArgs e)
        {
            onRowChanged(sender, new DataRowChangeEventArgs(null, DataRowAction.Change));
        }


        private static int loadAnnualSchedule(DataSet dataSet, int year, int monthFrom, int monthTo, string assignmentID)
        {
            string sql = getAnnualAssignmentSql(assignmentID, year, monthFrom, monthTo);
            int ret= DBHandlerEx.FillNoNameOnce(dataSet, sql);
            if (ret < 0 || dataSet.Tables.Count==0) return ret;
            ScheduleHelper.Annual.AddAnnualSumarry(dataSet.Tables[0]);
            return ret;
        }

        private void onLoadData(object sender, EventArgs e)
        {
            int year = (int)spinEditYear.Value;
                int monthFrom = (int) spinEditMonthFrom.Value;
                int monthTo = (int) spinEditMonthTo.Value;
            loadData(year, monthFrom, monthTo);
        }

        private void onYearEditEnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                onLoadData(sender, new EventArgs());
            }
        }

        protected override void onSave()
        {
            base.onSave();
            foreach (XtraTabPage page in xtraTabControlScheduleItems.TabPages)
            {
                ScheduleItemControl control = page.Controls[0] as ScheduleItemControl;
                if (control != null)
                {
                    control.Save();
                }
            }
        }
    }
}
