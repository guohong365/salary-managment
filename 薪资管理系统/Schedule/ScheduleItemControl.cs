using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraVerticalGrid;
using UC.Platform.Data;

namespace SalarySystem.Schedule
{
    public partial class ScheduleItemControl : DevExpress.XtraEditors.XtraUserControl
    {
        private const string _SQL_ANNUAL_ASSIGNMENT_TEMPLAT =
            "select distinct t0.ASSIGNMENT_ID as DEF_ID,ifnull(t1.ID,\'\') as ID,ifnull(t1.NAME,\'\') as NAME,ifnull(t1.DESCRIPTION,\'\') as DESCRIPTION,ifnull(t1.ASSIGNMENT_YEAR, {0}) as YEAR,ifnull(t1.ASSIGNMENT_MONTH, {1}) as MONTH,ifnull(t1.TARGET, 0) as TARGET,ifnull(t1.CREATE_TIME, current_date()) as CREATE_TIME,ifnull(t1.VERSION_ID, t2.VERSION_ID) as VERSION_ID,ifnull(t1.EXEC_STATE, 0) as STATE,ifnull(t1.CREATOR_ID, \'nobody\') as CREATOR,t2.NAME as DEF_NAME,cast(t3.VALUE as decimal) as RATE from t_position_assignments t0 left join t_annual_assignment t1 on t1.ASSIGNMENT_ID=t0.ASSIGNMENT_ID and t1.VERSION_ID=t1.VERSION_ID and t1.ASSIGNMENT_YEAR={0} and t1.ASSIGNMENT_MONTH={1} inner join t_assignment_define t2 on t0.ASSIGNMENT_ID=t2.ID left join t_settings t3 on cast(substr(t3.NAME, -2) as unsigned)= {1} where t0.ENABLED=true and t2.TYPE = \'1\' and t3.NAME like \'assignment.schedule%\' and t2.VERSION_ID=\'{2}\'";

        private string getSqlAnnualAssignmentOneMonth(int year, int month)
        {
            //string sqlFormat = "select * from ({0}) t_all";
            return string.Format(_SQL_ANNUAL_ASSIGNMENT_TEMPLAT, year, month, GlobalSettings.AssignmentVersion);
        }

        private string getAnnualAssignmentSql(string id, int year)
        {
            string sql = "";
            for (int i = 0; i < 12; i++)
            {
                sql += "(" + getSqlAnnualAssignmentOneMonth(year, i + 1) + ")";
                if (i < 11)
                {
                    sql += " union all ";
                }
            }
            return string.IsNullOrEmpty(id) ? string.Format("select * from ({0}) t_all", year) :
                string.Format("select * from ({0}) t_all where t_all.DEF_ID='{1}'", sql, id);
        }

        private const string _SQL_MONTHLY_ASSIGNMENT_TEMPLATE = "SELECT t0.ID as EMPLOYEE_ID, " + "t0.NAME as EMPLOYEE_NAME," + "t1.ASSIGNMENT_ID," + "t1.POSITION_ID," + "t2.NAME," + "t2.VERSION_ID," + "t3.ID as PERF_ID," + "ifnull(t3.TARGET,0) as TARGET," + "ifnull(t3.ASSIGNMENT_YEAR, {0}) as ASSIGNMENT_YEAR," + "ifnull(t3.ASSIGNMENT_MONTH, {1}) as ASSIGNMENT_MONTH," + "t3.DESCRIPTION as PERF_DESC" + "FROM t_employee t0 " + "left join t_position_assignments t1 on t0.POSITION_ID=t1.POSITION_ID" + "inner join t_assignment_define t2 on t2.ID=t1.ASSIGNMENT_ID" + "left join t_assignment_performance t3 on t3.EMPLOYEE_ID= t0.ID" + "where t0.ENABLED=true " + "and t2.type='1' " + "and t1.ENABLED=true " + "and (t3.VERSION_ID=t1.VERSION_ID or t3.VERSION_ID is null) " + "and t3.ASSIGNMENT_YEAR={1} or t3.ASSIGNMENT_YEAR is null " + "and t3.ASSIGNMENT_MONTH={0} or t3.ASSIGNMENT_MONTH is null " + "and t1.ASSIGNMENT_ID='{2}'";

        private string getMonthlyAssignment(string id, int year, int month)
        {
            return string.Format(_SQL_MONTHLY_ASSIGNMENT_TEMPLATE, year, month, id);
        }


        
        private readonly DataSet _annualAssignment=new DataSet();

        public ScheduleItemControl()
        {
            InitializeComponent();
        }

        void loadMonthlyAssignment()
        {
            _annualAssignment.Clear();
            DBHandlerEx.FillNoNameOnce(_annualAssignment, getAnnualAssignmentSql(ItemId, Year));
            vGridControl2.DataSource = _annualAssignment.Tables.Count>0 ? _annualAssignment.Tables[0]:null;
        }

        public void SetScheduleItem(int year, string id)
        {
            Year = year;
            ItemId = id;
            loadMonthlyAssignment();
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

    }
}
