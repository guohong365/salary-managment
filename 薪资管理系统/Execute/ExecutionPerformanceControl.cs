
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using SalarySystem.Data;
using SalarySystem.Managment.Basic;
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
            DataSetSalary.t_evaluation_resultsDataTable resultsDataTable =
                new DataSetSalary.t_evaluation_resultsDataTable();
            handler.Fill(resultsDataTable,
                "select * from t_evaluation_resuts where EMPLOYEE_ID='" + CurrentEmployeePerformance.Employee.ID + "'");
            CurrentEmployeePerformance.Results.ToList().ForEach(result =>
            {
                DataSetSalary.v_evaluation_result_detailDataTable resultDetail =
                    (DataSetSalary.v_evaluation_result_detailDataTable) result.Value.GetChanges();
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
                    resultsRow.EVALUATION_YEAY = detailRow.EVALUATION_YEAY;
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
                CurrentEmployeePerformance.Results.Values.ToList().ForEach(item=>item.RejectChanges());
            }
        }


        private void dirtyChangedHandler(object sender, EventArgs e)
        {
            Debug.Assert(CurrentEmployeePerformance!=null);
            EnableSave(CurrentEmployeePerformance.IsDirty);
            EnableRevert(CurrentEmployeePerformance.IsDirty);
        }

        private void focusedEmployeeChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var row = gridViewEmploye.GetDataRow(e.FocusedRowHandle) as DataSetSalary.t_employeeRow;
            if (row == null)
            {
                CurrentEmployeePerformance = null;
           }
            else
            {
                if (CurrentEmployeePerformance != null && (string)row["ID"] == CurrentEmployeePerformance.Employee.ID)
                {
                    if (CurrentEmployeePerformance.IsDirty)
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
                }
                var sql = string.Format(
                    "select distinct FORM_ID, FORM_NAME " +
                    "from v_evaluation_result_detail " +
                    "where POSITION_ID='{0}'", row.POSITION_ID);
                DataSet dataSet=DBHandlerEx.FillOnce(sql, "v_evaluation_result_detail");
                CurrentEmployeePerformance = new EmployeePerformance(row, dataSet.Tables[0], (string) lookUpEditEvaluator.EditValue, (int) textEditEvalYear.EditValue,
                    (int) textEditEvalMonth.EditValue, dateEditEvalTIme.DateTime);
                CurrentEmployeePerformance.DirtyChanged += dirtyChangedHandler;
            }
        }
    }
}
