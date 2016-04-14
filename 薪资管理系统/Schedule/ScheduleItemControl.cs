using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraTab;
using DevExpress.XtraVerticalGrid;
using SalarySystem.Data;
using UC.Platform.Data;

namespace SalarySystem.Schedule
{
    public partial class ScheduleItemControl : XtraUserControl
    {
        private const string _SQL_MONTHLY_ASSIGNMENT_TEMPLATE =
            "SELECT t0.ID as EMPLOYEE_ID, " + 
            " t0.NAME as EMPLOYEE_NAME," + 
            " t1.ASSIGNMENT_ID," + 
            " t1.POSITION_ID," +
            " t4.NAME as POSITION_NAME," +
            " t2.NAME," + 
            " t2.VERSION_ID," + 
            " t5.NAME as UNIT_NAME," +
            " t3.ID as PERF_ID," + 
            " ifnull(t3.TARGET,0) as TARGET," +
            " ifnull(t3.ASSIGNMENT_YEAR, {0}) as ASSIGNMENT_YEAR, " +
            " ifnull(t3.ASSIGNMENT_MONTH, {1}) as ASSIGNMENT_MONTH, " + 
            " t3.DESCRIPTION as PERF_DESC " +
            " FROM t_employee t0 " + 
            " left join t_position_assignments t1 on t0.POSITION_ID=t1.POSITION_ID " +
            " inner join t_assignment_define t2 on t2.ID=t1.ASSIGNMENT_ID and t2.type='1' " +
            " left join t_assignment_performance t3 on t3.EMPLOYEE_ID= t0.ID " + 
            " inner join t_position t4 on t4.ID=t0.POSITION_ID " +
            " inner join t_unit t5 on t5.ID=t2.UNIT_ID " +
            " where " +
            " t0.ENABLED=true " +
            " and t2.type='1' " + 
            " and t1.ENABLED=true " + 
            " and (t3.VERSION_ID=t1.VERSION_ID or t3.VERSION_ID is null) " +
            " and t3.ASSIGNMENT_YEAR={1} or t3.ASSIGNMENT_YEAR is null " +
            " and t3.ASSIGNMENT_MONTH={0} or t3.ASSIGNMENT_MONTH is null " + 
            " and t1.ASSIGNMENT_ID='{2}'";

        private string getMonthlyAssignment(string id, int year, int month)
        {
            return string.Format(_SQL_MONTHLY_ASSIGNMENT_TEMPLATE, year, month, id);
        }

        private string getMonthlyAssignmentSql(string id, int year)
        {
            string sql = "";
            for (int i = 0; i < 12; i++)
            {
                sql +="(" + getMonthlyAssignment(id, year, i + 1) + ")";
                if (i < 11)
                {
                    sql += " union all ";
                }
            }
            sql= string.Format("select * from ({0}) t_all", sql);
            return sql;
        }


        
        private DataSet _annualAssignment;

        public ScheduleItemControl()
        {
            InitializeComponent();
        }

        void loadannualAssignment()
        {
            vGridControl2.DataSource = _annualAssignment != null && _annualAssignment.Tables.Count > 0
                ? _annualAssignment.Tables[0]
                : null;
        }

        private readonly DataSet _monthlyAssignment=new DataSet();
        void loadMonthlyAssignment(int year, string id)
        {
            xtraTabControl1.TabPages.Clear();
            _monthlyAssignment.Clear();
            string sql = getMonthlyAssignmentSql(id, year);
            DBHandlerEx.FillNoNameOnce(_monthlyAssignment, sql);

            for (int month = 0; month < 12; month++)
            {
                XtraTabPage page = xtraTabControl1.TabPages.Add(string.Format("{0}月", month + 1));
                GridControl control = ScheduleHelper.CreateMonthAssignmentGrid(page.Text);
                control.Dock=DockStyle.Fill;
                control.DataSource = new DataView(_monthlyAssignment.Tables[0])
                {
                    RowFilter = string.Format("[ASSIGNMENT_MONTH]={0}", month + 1)
                };
                page.Controls.Add(control);
            }
        }

        private bool _isLoading;
        public void SetScheduleItem(int year, DataSetSalary.v_auto_assignment_listRow row, DataSet dataSet)
        {
            _isLoading = true;
            Year = year;
            ItemId = row.ASSIGNMENT_ID;

            labelControlUnit.Text = DataHolder.Unit.FindByID(row.UNIT_ID).NAME;
            textEditAmount.EditValue = 0;
            if (dataSet.Tables.Count > 0)
            {
                decimal total = dataSet.Tables[0].Rows.Cast<DataRow>().ToList().Sum(item => (decimal)item["TARGET"]);
                textEditAmount.EditValue = total;
            }
           
            _annualAssignment = dataSet;
            loadannualAssignment();
            loadMonthlyAssignment(Year, ItemId);
            _isLoading = false;
        }

        protected int Year { get; set; }

        protected string ItemId { get; set; }

        private void customDrawRowValueCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs e)
        {
            VGridControl vGridControl = sender as VGridControl;
            if (vGridControl != null)
            {
                DataRowView row= vGridControl.GetRecordObject(e.RecordIndex) as DataRowView;
                if(row==null) return;
                switch (Convert.ToInt64(row["STATE"]))
                {
                    case 0: // - 未分配
                        e.Appearance.BackColor = Color.LightGray;
                        break;
                    case 1: // - 已分配
                        e.Appearance.BackColor = Color.CadetBlue;
                        break;
                    case 2: // - 已执行
                        e.Appearance.BackColor = Color.Orange;
                        break;
                    case 3: // - 执行完成
                        e.Appearance.BackColor = Color.Green;
                        break;
                }
            }
        }

        private void amountEditValueChanged(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            if(_isLoading) return;
            recalcAnnualSchedule((decimal) textEditAmount.EditValue);
        }

        private void recalcAnnualSchedule(decimal total)
        {
            foreach (DataRow row in _annualAssignment.Tables[0].Rows )
            {
                row["TARGET"] = total*(decimal) row["RATE"]/100;
            }
        }

        private void generateAssignment(object sender, EventArgs e)
        {
        }

        private void onAmountKeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updageAnnualSchedule();
            }
        }

        private void updageAnnualSchedule()
        {
            recalcAnnualSchedule((decimal) textEditAmount.EditValue);
        }
    }
}
