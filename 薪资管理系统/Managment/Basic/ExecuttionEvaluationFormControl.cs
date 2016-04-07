using System;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace SalarySystem.Managment.Basic
{
    public partial class ExecuttionEvaluationFormControl : XtraUserControl
    {
        private readonly DataView _dataViewFormDetail;
        private readonly DataView _dataViewForm;

        public ExecuttionEvaluationFormControl()
        {
            InitializeComponent();

            GridViewHelper.SetUpEditableGridView(gridViewExecutionForm, false, "实行考核表项目", VersionType.EVALUATION);
            GridViewHelper.SetUpReadOnlyGridView(gridViewPredeinedForms, false, "预定义考核表", VersionType.EVALUATION);
            gridViewExecutionForm.CustomDrawCell += GridViewHelper.GerneralCustomCellDrawHandler;
            repositoryItemLookUpEditItemType.DataSource = new DataView(DataHolder.EvaluationItemType);
            gridControlPredifinedForms.DataSource = null;
            _dataViewFormDetail = new DataView(DataHolder.EvaluationFormDetail);
            gridControlExecutionForm.DataSource = new DataView(DataHolder.PositionEvaluationForms)
            {
                RowFilter = string.Format("[VERSION_ID]='{0}'", GlobalSettings.EvaluationVersion)
            };
            repositoryItemLookUpEditPosition.DataSource = new DataView(DataHolder.Position)
            {
                RowFilter = "[ENABLED]=true"
            };

            _dataViewForm = new DataView(DataHolder.EvaluationForm){RowFilter = getFormFilter("")};
            repositoryItemGridLookUpEditForm.DataSource = _dataViewForm;
            repositoryItemLookUpEditRepoFormPosition.DataSource = new DataView(DataHolder.Position);
        }

        private string getFormFilter(string positionId)
        {
            return string.IsNullOrEmpty(positionId)
                ? string.Format("[ENABLED]=true AND [VERSION_ID]='{0}'", GlobalSettings.EvaluationVersion)
                : string.Format("[ENABLED]=true AND [VERSION_ID]='{0}' AND ([POSITION_ID]='{1}' OR [POSITION_ID]='{2}')", GlobalSettings.EvaluationVersion,
                    positionId, GlobalSettings.GENERAL_POSITION);
        }

        private string getFormDetailFilter(string formId)
        {
            return string.Format("[FORM_ID]='{0}' AND [ENABLED]=true AND [USED]=true AND [VERSION_ID]='{1}'", formId,
                GlobalSettings.EvaluationVersion);
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

        private void onRowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add || e.Action == DataRowAction.Change || e.Action == DataRowAction.Delete)
            {
                simpleButtonSave.Enabled = true;
                simpleButtonRevert.Enabled = true;
            }
        }

        void control_load(object sender, EventArgs e)
        {
            DataHolder.PositionEvaluationForms.RowChanged += onRowChanged;
            gridViewExecutionForm.ExpandAllGroups();
        }

        private void visibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                DataHolder.PositionEvaluationForms.RowChanged += onRowChanged;
            }
            else
            {
                DataHolder.PositionEvaluationForms.RowChanged -= onRowChanged;
            }
        }
    }
}
