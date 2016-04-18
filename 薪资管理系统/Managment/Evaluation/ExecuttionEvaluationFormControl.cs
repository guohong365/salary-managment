using System;
using System.Data;
using DevExpress.XtraGrid.Views.Base;
using SalarySystem.Data;
using UC.Platform.Data;

namespace SalarySystem.Managment.Evaluation
{
    public partial class ExecuttionEvaluationFormControl : BaseEditableControl
    {
        private DataView _dataViewFormDetail;
        private DataView _dataViewForm;

        private readonly DataSetSalary.v_evaluation_form_detailDataTable _evaluationFormDetail =
            new DataSetSalary.v_evaluation_form_detailDataTable();

        private const string _EVALUATION_FORM_DETAIL_SQL_FORMAT = 
            "select * from" +
            " v_evaluation_form_detail " +
            " where" +
            " VERSION_ID='{0}'" +
            " and USED = true" +
            " and ENABLED= true";
        int loadEvaluationFormDetail()
        {
            string sql = string.Format(_EVALUATION_FORM_DETAIL_SQL_FORMAT, GlobalSettings.EvaluationVersion);
            return DBHandlerEx.FillOnce(_evaluationFormDetail, sql);
        }

        private readonly DataSetSalary.t_position_evaluation_formsDataTable _positionEvaluationForms =
            new DataSetSalary.t_position_evaluation_formsDataTable();

        private const string _POSITION_EVALUATION_FORMS_SQL_FORMAT =
            "select * from t_position_evaluation_forms " +
            " where VERSION_ID='{0}'";
        int loadPositionEvaluationForms()
        {
            string sql = string.Format(_POSITION_EVALUATION_FORMS_SQL_FORMAT, GlobalSettings.EvaluationVersion);
            return DBHandlerEx.FillOnce(_positionEvaluationForms, sql);
        }

        readonly DataSetSalary.t_evaluation_formDataTable _evaluationForm=new DataSetSalary.t_evaluation_formDataTable();

        private const string _EVALUATION_FORM_SQL_FORMAT =
            "select * from t_evaluation_form where VERSION_ID='{0}' and ENABLED=true";

        int loadEvaluationForm()
        {
            string sql = string.Format(_EVALUATION_FORM_SQL_FORMAT, GlobalSettings.EvaluationVersion);
            return DBHandlerEx.FillOnce(_evaluationForm, sql);
        }

        public ExecuttionEvaluationFormControl()
        {
            InitializeComponent();

            GridViewHelper.SetUpEditableGridView(gridViewExecutionForm, false, "实行考核表项目", VersionType.EVALUATION);
            GridViewHelper.SetUpReadOnlyGridView(gridViewPredeinedForms, false, "预定义考核表", VersionType.EVALUATION);
            gridViewExecutionForm.CustomDrawCell += GridViewHelper.GerneralCustomCellDrawHandler;

            
        }

        private static string getFormFilter(string positionId)
        {
            return string.IsNullOrEmpty(positionId)
                ? string.Format("[ENABLED]=true")
                : string.Format("[ENABLED]=true AND ([POSITION_ID]='{0}' OR [POSITION_ID]='{1}')", positionId, GlobalSettings.GENERAL_POSITION);
        }

        private static string getFormDetailFilter(string formId)
        {
            return string.Format("[FORM_ID]='{0}'", formId);
        }

        public void SetFormId(string formId)
        {
            _dataViewFormDetail.RowFilter = getFormDetailFilter(formId);
            if (gridControlPredifinedForms.DataSource == null)
            {
                gridControlPredifinedForms.DataSource = _dataViewFormDetail;
            }
        }

        private void cellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column == colPOSITION_ID)
            {
                //如果当前 FROM的适用岗位不是通用岗位或不等于当前选择岗位则清空该值
                var row = gridViewExecutionForm.GetDataRow(e.RowHandle);
                if (row != null && !row.IsNull("EVALUATION_FORM_ID"))
                {
                    string formId = (string)row["EVALUATION_FORM_ID"];
                    var fromRow = DataHolder.EvaluationForm.FindByID(formId);
                    if (fromRow !=  null)
                    {
                        if (fromRow.POSITION_ID != (string)e.Value && fromRow.POSITION_ID != GlobalSettings.GENERAL_POSITION)
                        {
                            row["EVALUATION_FORM_ID"] = "";
                        }
                    }
                }
                //设置当前岗位的过来值
                //_dataViewForm.RowFilter = getFormFilter((string)e.Value);
            }
            if (e.Column == colEVALUATION_FORM_ID)
            {
                var formRow = DataHolder.EvaluationForm.FindByID((string) e.Value);
                if (formRow != null && formRow.POSITION_ID != GlobalSettings.GENERAL_POSITION)
                {
                    var row = gridViewExecutionForm.GetDataRow(e.RowHandle);
                    row["POSITION_ID"] = formRow.POSITION_ID;
                }
            }
        }

        private void focusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (!gridViewExecutionForm.IsDataRow(e.FocusedRowHandle))
            {
                SetFormId("");
                return;
            }
            var row = gridViewExecutionForm.GetDataRow(e.FocusedRowHandle);
            if (row != null && !row.IsNull("EVALUATION_FORM_ID"))
            {
                SetFormId((string) row["EVALUATION_FORM_ID"]);
            }
        }

        private void gridViewExecutionForm_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (gridViewExecutionForm.FocusedColumn == colEVALUATION_FORM_ID)
            {
                if (repositoryItemGridLookUpEditForm.DataSource == null)
                {
                    repositoryItemGridLookUpEditForm.DataSource = _dataViewForm;
                }
                var row = gridViewExecutionForm.GetDataRow(gridViewExecutionForm.FocusedRowHandle);
                if (row != null)
                {
                    if (!string.IsNullOrEmpty((string) row["POSITION_ID"]))
                    {
                        gridViewRepForm.ActiveFilterString=string.Format("[POSITION_ID]='{0}' OR [POSITION_ID]='{1}'", row["POSITION_ID"],
                                GlobalSettings.GENERAL_POSITION);
                    }
                }
            }
        }

        private void initNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var row = gridViewExecutionForm.GetDataRow(e.RowHandle);
            row["ENABLED"] = true;
            row["VERSION_ID"] = GlobalSettings.EvaluationVersion;
        }

        protected override void onSave()
        {
            if(DBHandlerEx.UpdateOnce(_positionEvaluationForms)>=0)
            {
                base.onSave();
            }
            
        }

        protected override void onRevert()
        {
            base.onRevert();
            _positionEvaluationForms.RejectChanges();
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            if (loadEvaluationFormDetail() < 0 ||
                loadPositionEvaluationForms() < 0 ||
                loadEvaluationForm() < 0)
            {
                throw new Exception("加载数据错误！");
            }
            _positionEvaluationForms.RowChanged += onRowChanged;
            repositoryItemLookUpEditItemType.DataSource = new DataView(DataHolder.EvaluationItemType);
            gridControlPredifinedForms.DataSource = null;
            _dataViewFormDetail = new DataView(_evaluationFormDetail);
            gridControlExecutionForm.DataSource = new DataView(_positionEvaluationForms);
            repositoryItemLookUpEditPosition.DataSource = new DataView(DataHolder.Position)
            {
                RowFilter = "[ENABLED]=true"
            };

            _dataViewForm = new DataView(_evaluationForm) { RowFilter = getFormFilter("") };
            repositoryItemGridLookUpEditForm.DataSource = _dataViewForm;
            repositoryItemLookUpEditRepoFormPosition.DataSource = new DataView(DataHolder.Position);
            gridViewExecutionForm.ExpandAllGroups();
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            _positionEvaluationForms.RowChanged += onRowChanged;
            gridViewExecutionForm.ExpandAllGroups();
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _positionEvaluationForms.RowChanged -= onRowChanged;

        }
    }
}
