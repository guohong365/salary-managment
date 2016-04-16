using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;
using DevExpress.XtraVerticalGrid;
using SalarySystem.Data;
using UC.Platform.Data;

namespace SalarySystem.Schedule
{
    public partial class ScheduleItemControl : XtraUserControl
    {
        //private const string _SQL_MONTHLY_ASSIGNMENT_TEMPLATE =
        //    "SELECT t0.ID as EMPLOYEE_ID, " + 
        //    " t0.NAME as EMPLOYEE_NAME," + 
        //    " t0.LEADER_ID" +
        //    " t1.ASSIGNMENT_ID," + 
        //    " t1.POSITION_ID," +
        //    " t4.NAME as POSITION_NAME," +
        //    " t2.NAME," + 
        //    " t2.VERSION_ID," + 
        //    " t5.NAME as UNIT_NAME," +
        //    " t3.ID as PERF_ID," + 
        //    " ifnull(t3.TARGET,0) as TARGET," +
        //    " ifnull(t3.ASSIGNMENT_YEAR, {0}) as ASSIGNMENT_YEAR, " +
        //    " ifnull(t3.ASSIGNMENT_MONTH, {1}) as ASSIGNMENT_MONTH, " + 
        //    " t3.DESCRIPTION as PERF_DESC " +
        //    " FROM t_employee t0 " + 
        //    " left join t_position_assignments t1 on t0.POSITION_ID=t1.POSITION_ID " +
        //    " inner join t_assignment_define t2 on t2.ID=t1.ASSIGNMENT_ID and t2.type='1' " +
        //    " left join t_assignment_performance t3 on t3.EMPLOYEE_ID= t0.ID " + 
        //    " inner join t_position t4 on t4.ID=t0.POSITION_ID " +
        //    " inner join t_unit t5 on t5.ID=t2.UNIT_ID " +
        //    " where " +
        //    " t0.ENABLED=true " +
        //    " and t2.type='1' " + 
        //    " and t1.ENABLED=true " + 
        //    " and (t3.VERSION_ID=t1.VERSION_ID or t3.VERSION_ID is null) " +
        //    " and t3.ASSIGNMENT_YEAR={1} or t3.ASSIGNMENT_YEAR is null " +
        //    " and t3.ASSIGNMENT_MONTH={0} or t3.ASSIGNMENT_MONTH is null " + 
        //    " and t1.ASSIGNMENT_ID='{2}'";

        //private string getMonthlyAssignment(string id, int year, int month)
        //{
        //    return string.Format(_SQL_MONTHLY_ASSIGNMENT_TEMPLATE, year, month, id);
        //}

        //private string getMonthlyAssignmentSql(string id, int year, int monthFrom, int monthTo)
        //{
        //    string sql = "";
        //    for (int i = monthFrom; i <= monthTo; i++)
        //    {
        //        sql +="(" + getMonthlyAssignment(id, year, i) + ")";
        //        if (i < monthTo)
        //        {
        //            sql += " union all ";
        //        }
        //    }
        //    sql= string.Format("select * from ({0}) t_all", sql);
        //    return sql;
        //}

        private AssignmentScheduleDetailParameter _parameter;
        public event EventHandler DataChanged;

        protected virtual void onDataChanged()
        {
            EventHandler handler = DataChanged;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        public AssignmentScheduleDetailParameter AssignmentScheduleDetailParameter
        {
            get { return _parameter; }
            set
            {
                _parameter = value;
            }
        }

        protected DataTable AnnualAssignment
        {
            get { return _parameter == null ? null : _parameter.AnnualSchedule; }
        }

        public ScheduleItemControl()
        {
            InitializeComponent();
        }

        void loadannualAssignment()
        {
            vGridControl2.DataSource = AnnualAssignment;
        }

        private readonly IDictionary<int, AssignmentTreeControl> _monthlyAssignmentPageControls = new Dictionary<int, AssignmentTreeControl>();

        private void onRowcHanged(object sender, DataRowChangeEventArgs e)
        {
            onDataChanged();
        }

        private bool _isLoading;
        public void SetScheduleItem(AssignmentScheduleDetailParameter parameter)
        {
            _isLoading = true;
            AssignmentScheduleDetailParameter = parameter;
            labelControlUnit.Text = ItemUnitName;
            textEditAmount.EditValue = 0;

            decimal total = AnnualAssignment.Rows.Cast<DataRow>().ToList().Sum(item => (decimal)item[ScheduleHelper.Annual.COL_TARGET]);
                textEditAmount.EditValue = total;

            loadannualAssignment();
            loadMonthly(ItemId, Year, MonthFrom, MonthTo);
            _isLoading = false;
        }

        protected int Year
        {
            get { return AssignmentScheduleDetailParameter.Year; }
        }

        protected string ItemId
        {
            get { return AssignmentScheduleDetailParameter.ItemId; }
        }

        protected int MonthFrom
        {
            get { return AssignmentScheduleDetailParameter.MonthFrom; }
        }

        protected int MonthTo
        {
            get { return AssignmentScheduleDetailParameter.MonthTo; }
        }

        protected string ItemUnitName
        {
            get { return AssignmentScheduleDetailParameter.ItemUnitName; }
        }



        private void generateAssignment(object sender, EventArgs e)
        {
            var page = xtraTabControl1.SelectedTabPage;
            var parameter = page.Tag as MonthAssignmentScheduleParameter;
            if (parameter == null)
            {
                //TODO error;
                return;
            }
            if (ScheduleHelper.Annual.GetMonthScheduleState(AnnualAssignment, parameter.Month) == 1)
            {
                if(MessageBox.Show(this, "任务已生成，是否重新生成", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.No)
                    return;
            }
            decimal total = ScheduleHelper.Annual.GetMonthAmont(AnnualAssignment, parameter.Month);
            _monthlyAssignmentPageControls[parameter.Month].Generate(total, parameter.Month);

        }
        #region 处理年度计划
        private void customDrawRowValueCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs e)
        {
            VGridControl vGridControl = sender as VGridControl;
            if (vGridControl == null) return;

            DataRow row = AnnualAssignment.Rows[e.RecordIndex];
            if (row == null) return;

            if (row[ScheduleHelper.Annual.COL_DEF_ID].Equals(ScheduleHelper.Annual.SUMMARY_ID))
            {
                if (e.Row.Name == "rowMonth")
                {
                    e.CellText = "总计";
                }
                else
                {
                    if (
                        (e.Row.Name == "rowRate" && (decimal)e.CellValue != 100) ||
                        (e.Row.Name == "rowValue" && (decimal)e.CellValue > (decimal)textEditAmount.EditValue)
                        )
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                if (e.Row.Name == "rowMonth")
                {
                    switch (Convert.ToInt64(row[ScheduleHelper.Annual.COL_STATE]))
                    {
                        case 0: // - 未分配
                            e.Appearance.BackColor = Color.WhiteSmoke;
                            break;
                        case 1: // - 已分配
                            e.Appearance.BackColor = Color.CadetBlue;
                            break;
                        case 2: // - 已执行
                            e.Appearance.BackColor = Color.Orange;
                            break;
                        case 3: // - 执行完成
                            e.Appearance.BackColor = Color.Gray;
                            break;
                    }
                }
                else
                {
                    if (row.RowState != DataRowState.Unchanged)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                    }

                }
            }
        }

        private void amountEditValueChanged(object sender, ConvertEditValueEventArgs e)
        {
            if (_isLoading) return;
            recalcAnnualScheduleValue((decimal)textEditAmount.EditValue);
        }

        private void recalcAnnualScheduleValue(decimal total)
        {
            var rows = AnnualAssignment.Rows;

            decimal fixedSum = 0;
            decimal reservedRate = 0;
            int reservedCount = 0;
            foreach (DataRow item in rows)
            {
                if (!item[ScheduleHelper.Annual.COL_DEF_ID].Equals(ScheduleHelper.Annual.SUMMARY_ID))
                {
                    if (Convert.ToInt64(item[ScheduleHelper.Annual.COL_STATE]) == 0)
                    {
                        reservedCount++;
                        reservedRate += (decimal)item[ScheduleHelper.Annual.COL_RATE];
                    }
                    else
                    {
                        fixedSum += (decimal)item[ScheduleHelper.Annual.COL_TARGET];
                    }
                }
            }
            if (reservedCount == 0 && reservedRate > 0) return;
            decimal reservedSum = total - fixedSum;
            foreach (DataRow item in rows)
            {
                if (item[ScheduleHelper.Annual.COL_DEF_ID].Equals(ScheduleHelper.Annual.SUMMARY_ID))
                {
                    item[ScheduleHelper.Annual.COL_TARGET] = total * (decimal)item[ScheduleHelper.Annual.COL_RATE] / 100;
                }
                else
                {
                    item[ScheduleHelper.Annual.COL_TARGET] = reservedSum * (decimal)item[ScheduleHelper.Annual.COL_RATE] / reservedRate;
                }
            }
        }
        private void onAmountKeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateAnnualSchedule();
            }
        }

        private void updateAnnualSchedule()
        {
            recalcAnnualScheduleValue((decimal) textEditAmount.EditValue);
        }

        private void onScheduleShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (vGridControl2.FocusedRecord <= 0 ||
                vGridControl2.FocusedRecord >= AnnualAssignment.Rows.Count) return;
            DataRow row = AnnualAssignment.Rows[vGridControl2.FocusedRecord];
            e.Cancel = row[ScheduleHelper.Annual.COL_DEF_ID].Equals(ScheduleHelper.Annual.SUMMARY_ID) && Convert.ToInt64(row[ScheduleHelper.Annual.COL_STATE]) != 0;
        }

        private void onShecduleValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (vGridControl2.FocusedRow.Name != "rowRate") return;
            e.Valid=Convert.ToDecimal(e.Value) < 100;
            e.ErrorText = "分配占比超过100%";
        }

        private void onScheduleValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e)
        {
            switch (e.Row.Name)
            {
                case "rowRate":
                    AnnualAssignment.Rows[e.RecordIndex][ScheduleHelper.Annual.COL_TARGET] = Convert.ToDecimal(textEditAmount.EditValue) * Convert.ToDecimal(e.Value) / 100;
                    break;
                case "rowValue":
                    AnnualAssignment.Rows[e.RecordIndex][ScheduleHelper.Annual.COL_RATE] =
                        Convert.ToDecimal(textEditAmount.EditValue) == 0
                            ? AnnualAssignment.Rows[e.RecordIndex][ScheduleHelper.Annual.COL_RATE]
                            : (int)(Convert.ToDecimal(e.Value)/Convert.ToDecimal(textEditAmount.EditValue) * 10000)/(decimal)100;
                    break;
            }

            ScheduleHelper.Annual.RecalcAnnaualSumarry(AnnualAssignment);
        }

        private void onInvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode= ExceptionMode.DisplayError;
            vGridControl2.HideEditor();
        }

        #endregion

        #region 处理月度计划

        void loadMonthly(string id, int year, int monthFrom, int monthTo)
        {
            xtraTabControl1.TabPages.Clear();
            _monthlyAssignmentPageControls.Clear();
            for (int month = monthFrom; month <= monthTo; month ++)
            {
                XtraTabPage page = xtraTabControl1.TabPages.Add(string.Format("{0}月", month));
                var dataTable= loadMonthlyAssignment(id, year, month);
                AssignmentTreeControl control =new AssignmentTreeControl
                {
                    Dock = DockStyle.Fill,
                    Tag = new MonthAssignmentScheduleParameter(id, year, month),
                    PositionTreeAutoAssignment = dataTable
                };
                _monthlyAssignmentPageControls.Add(month, control);
                page.Tag = new MonthAssignmentScheduleParameter(id, year, month);
                int state = ScheduleHelper.Annual.GetMonthScheduleState(AnnualAssignment, month);
                page.Appearance.Header.BackColor = _colors[state];
                page.Appearance.HeaderActive.BackColor = _activeColors[state];
                page.Controls.Add(control);
                dataTable.RowChanged += onRowcHanged;
            }
        }

        private DataSetSalary.v_position_tree_auto_assignmentDataTable loadMonthlyAssignment(string id, int year, int month)
        {
            string sql = getMonthlyAssignmentSql(id, year, month);
            DataSetSalary.v_position_tree_auto_assignmentDataTable dataTable=new DataSetSalary.v_position_tree_auto_assignmentDataTable();
            DBHandlerEx.FillOnce(dataTable, sql);
            return dataTable;
        }

        private string getMonthlyAssignmentSql(string id, int year, int month)
        {
            const string sql = "select * from (" +
                               "select " +
                               "t1.ID AS ID," +
                               "t1.LEADER_ID AS LEADER_ID," +
                               "t1.NAME AS NAME," +
                               "t2.ID AS DEFINE_ID," +
                               "t2.NAME AS DEFINE_NAME," +
                               "t2.VERSION_ID AS VERSION_ID," +
                               "t3.VALUE AS WEIGHT," +
                               "null AS EMPLOYEE_ID," +
                               "null AS EMPLOYEE_NAME," +
                               "null AS PERF_ID," +
                               "null as POSITION_ID, " +
                               "0 AS TARGET," +
                               "0 AS COMPLETED," +
                               "{1} AS ASSIGNMENT_YEAR," +
                               "{2} AS ASSIGNMENT_MONTH," +
                               "t6.NAME AS UNIT_NAME," +
                               "0 as ICON" +
                               " FROM" +
                               " t_position t1" +
                               " left JOIN t_assignment_define t2 ON (t1.ID = t2.POSITION_ID  OR t2.POSITION_ID = '9999999999') and t2.type='1'" +
                               " left JOIN t_position_assignments t3 ON t1.ID = t3.POSITION_ID AND t3.ASSIGNMENT_ID = t2.ID  AND t2.VERSION_ID = t3.VERSION_ID" +
                               " JOIN t_unit t6 ON t6.ID = t2.UNIT_ID" +
                               " WHERE" +
                               " t1.ENABLED = TRUE" +
                               " AND t1.ID <> '9999999999'" +
                               " AND t2.ENABLED = TRUE" +
                               " AND t3.ENABLED = TRUE" +
                               " and t2.ID='{0}'" +
                               " and t2.VERSION_ID='{3}'" +

                               //"select " +
                               //"ID," +
                               //"LEADER_ID," +
                               //"NAME," +
                               //"null as DEFINE_ID," +
                               //"null as DEFINE_NAME," +
                               //"null as VERSION_ID," +
                               //"0 as WEIGHT," +
                               //"null as EMPLOYEE_ID," +
                               //"null as EMPLOYEE_NAME," +
                               //"null as POSITION_ID," +
                               //"null as PERF_ID," +
                               //"0 as TARGET," +
                               //"0 as COMPLETED," +
                               //"{1} as ASSIGNMENT_YEAR," +
                               //"{2} as ASSIGNMENT_MONTH," +
                               //"null as UNIT_NAME," +
                               //"0 as ICON " +
                               //" from t_position" +
                               //" where " +
                               //" enabled = true " +
                               //" and id<>'9999999999'" +
                               " union all " +
                               " select " +
                               " if(not isnull(EMPLOYEE_ID), EMPLOYEE_ID, ID) as ID," +
                               " if(not isnull(EMPLOYEE_ID), POSITION_ID, LEADER_ID) as LEADER_ID," +
                               " if(not isnull(EMPLOYEE_ID), EMPLOYEE_NAME, NAME) as NAME," +
                               " DEFINE_ID," +
                               " DEFINE_NAME," +
                               " VERSION_ID," +
                               " WEIGHT," +
                               " EMPLOYEE_ID," +
                               " EMPLOYEE_NAME," +
                               " ifnull(PERF_ID,'') as PERF_ID," +
                               " POSITION_ID, " +
                               " ifnull(TARGET,0) as TARGET," +
                               " ifnull(COMPLETED,0) as COMPLETED," +
                               " ifnull(ASSIGNMENT_YEAR, 2016) as ASSIGNMENT_YEAR," +
                               " ifnull(ASSIGNMENT_MONTH,4) as ASSIGNMENT_MONTH," +
                               " UNIT_NAME, " +
                               " if(not isnull(EMPLOYEE_ID), 1, 0) as ICON " +
                               " from v_position_tree_auto_assignment " +
                               " where " +
                               " DEFINE_ID='{0}' " +
                               " and (ASSIGNMENT_YEAR={1} or isnull(ASSIGNMENT_YEAR))" +
                               " and (ASSIGNMENT_MONTH={2} or isnull(ASSIGNMENT_MONTH)) " +
                               " and VERSION_ID='{3}') t" +
                               " group by ID, EMPLOYEE_ID";


            const string formatStr = "select " +
                                     "ID," +
                                     "LEADER_ID," +
                                     "NAME,DEFINE_ID," +
                                     "DEFINE_NAME," +
                                     "VERSION_ID," +
                                     "WEIGHT," +
                                     "EMPLOYEE_ID," +
                                     "EMPLOYEE_NAME," +
                                     "ifnull(PERF_ID,'') as PERF_ID," +
                                     "ifnull(TARGET,0) as TARGET," +
                                     "ifnull(COMPLETED,0) as COMPLETED," +
                                     "ifnull(ASSIGNMENT_YEAR, {1}) as ASSIGNMENT_YEAR," +
                                     "ifnull(ASSIGNMENT_MONTH,{2}) as ASSIGNMENT_MONTH," +
                                     "UNIT_NAME" +
                                     " from v_position_tree_auto_assignment" +
                                     " where DEFINE_ID='{0}' " +
                                     " and (ASSIGNMENT_YEAR={1} or isnull(ASSIGNMENT_YEAR)) " +
                                     " and (ASSIGNMENT_MONTH={2} or isnull(ASSIGNMENT_MONTH))" +
                                     " and VERSION_ID='{3}'";
            return string.Format(sql, id, year, month, GlobalSettings.AssignmentVersion);
        }

        private readonly Color[] _colors =
        {
            Color.LightGray,
            Color.Teal,
            Color.DarkOrange,
            Color.Green
        };

        private readonly Color[] _activeColors =
        {
            Color.WhiteSmoke,
            Color.LightSeaGreen,
            Color.Orange,
            Color.LightGreen
        };


        private void onMontlySchedulePageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (e.Page == null) return;
            MonthAssignmentScheduleParameter parameter = e.Page.Tag as MonthAssignmentScheduleParameter;
            if (parameter == null) return;
            int state = ScheduleHelper.Annual.GetMonthScheduleState(AnnualAssignment, parameter.Month);
            simpleButtonGen.Enabled = state <= 1;
        }

        #endregion
    }
                

    public class MonthAssignmentScheduleParameter
    {
        public MonthAssignmentScheduleParameter(string itemId, int year, int month)
        {
            Month = month;
            Year = year;
            ItemId = itemId;
        }

        public int Year { get; private set; }
        public int Month { get; private set; }
        public string ItemId { get;private set; }
    }
}
