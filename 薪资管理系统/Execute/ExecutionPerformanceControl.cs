
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using SalarySystem.Data;
using UC.Platform.Data;

namespace SalarySystem.Execute
{
    public partial class ExecutionPerformanceControl : BaseEditableControl
    {

        private EmployeePerformance _currentEmployeePerformance;

        private EmployeePerformance CurrentEmployeePerformance
        {
            get
            {
                return _currentEmployeePerformance;
            }
            set
            {
                _currentEmployeePerformance = value;
                onCurrentEmployeeChanged();
            }
        }

        private void onCurrentEmployeeChanged()
        {
            if (CurrentEmployeePerformance == null) return;

            labelControlEmployee.Text = CurrentEmployeePerformance.Employee.NAME;
            textEditEvalYear.EditValue = CurrentEmployeePerformance.Year;
            textEditEvalMonth.EditValue = CurrentEmployeePerformance.Month;
            dateEditEvalTIme.EditValue = CurrentEmployeePerformance.EvaluationTime;
            lookUpEditEvaluator.EditValue = CurrentEmployeePerformance.EvaluatorId;
            evalFormsControl1.EmployeePerformance = CurrentEmployeePerformance;
        }

        public ExecutionPerformanceControl()
        {
            InitializeComponent();
            repositoryItemLookUpEditPosition.DataSource = new DataView(DataHolder.Position);
            labelControlEmployee.Text = "";
            DateTime evalTime = DateTime.Now.AddMonths(-1);
            textEditEvalYear.EditValue = evalTime.Year;
            textEditEvalMonth.EditValue = evalTime.Month;
            dateEditEvalTIme.EditValue = DateTime.Now;
            lookUpEditEvaluator.EditValue = "";
            textEditEvalYear.EditValueChanged += commonDataChange;
            textEditEvalMonth.EditValueChanged += commonDataChange;
            dateEditEvalTIme.EditValueChanged += commonDataChange;
            lookUpEditEvaluator.EditValueChanged += commonDataChange;
        }

        void commonDataChange(object sender, EventArgs e)
        {
            if(CurrentEmployeePerformance==null) return;
            if (sender.Equals(textEditEvalYear))
            {
                CurrentEmployeePerformance.Year = (int) textEditEvalYear.EditValue;
            }
            else if (sender.Equals(textEditEvalMonth))
            {
                CurrentEmployeePerformance.Month = (int) textEditEvalMonth.EditValue;
            } else if (sender.Equals(dateEditEvalTIme))
            {
                CurrentEmployeePerformance.EvaluationTime = (DateTime) dateEditEvalTIme.EditValue;
            } else if (sender.Equals(lookUpEditEvaluator))
            {
                CurrentEmployeePerformance.EvaluatorId = (string) lookUpEditEvaluator.EditValue;
            }
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            gridControlEmployee.DataSource = new DataView(DataHolder.Employee) { RowFilter = "[ENABLED]=true", Sort = "[POSITION_ID]" };
            gridViewEmploye.ExpandAllGroups();
            lookUpEditEvaluator.Properties.DataSource = new DataView(DataHolder.Employee) {RowFilter = "[ENABLED]=true"};

        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            if (CurrentEmployeePerformance == null || !CurrentEmployeePerformance.IsDirty)
            {
                return;
            }
            //ask save data
            if (
                MessageBox.Show("数据未保存，是否保存？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Save();
            }
            else
            {
                Revert();
            }
            CurrentEmployeePerformance = null;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            CurrentEmployeePerformance = null;
        }

        private void saveEvaluationResults(DBHandlerEx handler)
        {
            Debug.Assert(CurrentEmployeePerformance!=null);
            var resultsDataTable =new DataSetSalary.t_evaluation_resultsDataTable();
            handler.Fill(resultsDataTable,
                string.Format("select * " +
                              "from t_evaluation_results " +
                              " where EMPLOYEE_ID='{0}'" +
                              " and VERSION_ID='{1}'" +
                              " and EVALUATION_YEAR={2}" +
                              " and EVALUATION_MONTH={3}",
                              CurrentEmployeePerformance.Employee.ID,
                              GlobalSettings.EvaluationVersion,
                              textEditEvalYear.EditValue,
                              textEditEvalMonth.EditValue));
            CurrentEmployeePerformance.EvaluationResults.ToList().ForEach(result =>
            {
                var resultDetail =(DataSetSalary.v_evaluation_result_detailDataTable) result.Value.GetChanges();
                if(resultDetail==null || resultDetail.Rows.Count==0) return;
                resultDetail.ToList().ForEach(detailRow =>
                {
                    DataSetSalary.t_evaluation_resultsRow resultsRow = null;
                    bool isNew = false;
                    if (!detailRow.IsRESULT_IDNull())
                    {
                        resultsRow = resultsDataTable.FindByID(detailRow.RESULT_ID);
                    }
                    if (resultsRow == null)
                    {
                        resultsRow = resultsDataTable.Newt_evaluation_resultsRow();
                        isNew = true;
                        resultsRow.ID = Guid.NewGuid().ToString();
                    }
                    
                    resultsRow.DESCRIPTION = detailRow.RESULT_DESC;
                    resultsRow.EMPLOYEE_ID = detailRow.EMPLOYEE_ID;
                    resultsRow.EVALUATION_FORM_ID = detailRow.FORM_ID;
                    resultsRow.EVALUATION_ITEM_ID = detailRow.ITEM_ID;
                    resultsRow.EVALUATION_YEAR = detailRow.EVALUATION_YEAR;
                    resultsRow.EVALUATION_MONTH = detailRow.EVALUATION_MONTH;
                    resultsRow.EVALUATION_TIME = detailRow.EVALUATION_TIME;
                    resultsRow.EVALUATOR = detailRow.EVALUATOR;
                    resultsRow.MARK = detailRow.MARK;
                    resultsRow.VERSION_ID = detailRow.VERSION_ID;
                    if (isNew)
                    {
                        resultsDataTable.Addt_evaluation_resultsRow(resultsRow);
                    }
                });
            });
            handler.Update(resultsDataTable);
        }

        protected override void onSave()
        {
            base.onSave();
            if (CurrentEmployeePerformance == null) return;

            var handler=DBHandlerEx.GetBuffer();
            handler.BeginTransaction();
            try
            {
                saveEvaluationResults(handler);
                handler.EndTransaction(true);
            }
            catch
            {
                handler.EndTransaction(false);
            }
            finally
            {
                handler.FreeBuffer();
            }
        }

        protected override void onRevert()
        {
            base.onRevert();
            if (CurrentEmployeePerformance != null)
            {
                CurrentEmployeePerformance.EvaluationResults.Values.ToList().ForEach(item=>item.RejectChanges());
            }
        }

        private void focusedEmployeeChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var row = gridViewEmploye.GetDataRow(e.FocusedRowHandle) as DataSetSalary.t_employeeRow;
            if (row == null) return;

            if (CurrentEmployeePerformance!=null && CurrentEmployeePerformance.IsDirty)
            {
                var dialogResult = MessageBox.Show("数据未保存，是否保存？", "警告", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        Save();
                        break;
                    case DialogResult.No:
                        Revert();
                        break;
                    case DialogResult.Cancel:
                        gridViewEmploye.FocusedRowHandle = e.PrevFocusedRowHandle;
                        return;
                }
            }
            var forms = LoadFroms(row.POSITION_ID);
            if (forms == null)
            {
                MessageBox.Show("加载考核表错误！");
                return;
            }

            var performance = new EmployeePerformance(row, forms, (string) lookUpEditEvaluator.EditValue,
                (int) textEditEvalYear.EditValue,
                (int) textEditEvalMonth.EditValue, dateEditEvalTIme.DateTime);
            foreach (DataRow formRow in forms.Rows)
            {
                string formId = Convert.ToString(formRow["FORM_ID"]);
                var result = LoadEvaluationResultsDetail((int) textEditEvalYear.EditValue, (int) textEditEvalMonth.EditValue,formId, row.ID);
                if (result == null)
                {
                    throw new Exception("加载考核表["+Convert.ToString(formRow["FORM_NAME"])+"]");
                }
                result.RowChanged += onRowChanged;
                performance.EvaluationResults[formId] = result;
            }
            CurrentEmployeePerformance = performance;
            evalFormsControl1.EmployeePerformance = CurrentEmployeePerformance;
        }

        #region 加载数据

        private const string _EVALUATION_FORMS_SQL_FORMAT =
            "select " +
            " distinct FORM_ID, FORM_NAME " +
            " from v_evaluation_result_detail " +
            " where POSITION_ID='{0}'" +
            " and VERSION_ID='{1}'";

        public DataTable LoadFroms(string positionId, string versionId)
        {
            string sql = string.Format(_EVALUATION_FORMS_SQL_FORMAT, positionId, versionId);
            DataTable table = new DataTable();
            return DBHandlerEx.FillOnce(table, sql) >= 0 ? table : null;
        }

        public DataTable LoadFroms(string positionId)
        {
            return LoadFroms(positionId, GlobalSettings.EvaluationVersion);
        }
        private const string _EVALUATION_RESULTS_SQL_FORMAT =
            "SELECT " +
            "POSITION_ID," +
            "FORM_ID," +
            "WEIGHT, " +
            "VERSION_ID," +
            "FORM_NAME," +
            "ITEM_ID," +
            "SHOW_ORDER," +
            "ITEM_NAME," +
            "ITEM_DESC," +
            "ITEM_TYPE," +
            "FULL_MARK," +
            "EMPLOYEE_ID," +
            "EMPLOYEE_NAME," +
            "RESULT_ID," +
            "RESULT_DESC," +
            "ifnull(EVALUATION_YEAR, {0}) as EVALUATION_YEAR," +
            "ifnull(EVALUATION_MONTH, {1}) as EVALUATION_MONTH," +
            "ifnull(EVALUATOR, 'nobody') as EVALUATOR," +
            "ifnull(EVALUATION_TIME, current_time()) as EVALUATION_TIME," +
            "ifnull(MARK, 0) as MARK" +
            " from " +
            " v_evaluation_result_detail " +
            " where" +
            " FORM_ID='{2}' " +
            " and EMPLOYEE_ID='{3}'" +
            " and VERSION_ID='{4}' " +
            " and (EVALUATION_YEAR={0} or isnull(EVALUATION_YEAR))" +
            " and (EVALUATION_MONTH={1} or isnull(EVALUATION_MONTH))" +
            " order by SHOW_ORDER";

        public DataSetSalary.v_evaluation_result_detailDataTable LoadEvaluationResultsDetail(int year, int month,string formId, string employeeId, string versionId)
        {
            var resultDetail = new DataSetSalary.v_evaluation_result_detailDataTable();
            var sql = string.Format(_EVALUATION_RESULTS_SQL_FORMAT,year, month, formId, employeeId, versionId);
            return DBHandlerEx.FillOnce(resultDetail, sql) >= 0 ? resultDetail : null;
        }

        public DataSetSalary.v_evaluation_result_detailDataTable LoadEvaluationResultsDetail(int year, int month,string formId,
            string employeeId)
        {
            return LoadEvaluationResultsDetail(year, month, formId, employeeId, GlobalSettings.EvaluationVersion);
        }
        #endregion
    }
}
