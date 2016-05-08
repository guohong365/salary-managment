using System;
using System.ComponentModel;
using System.Data;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SalarySystem.Data;
using UC.Platform.Data;
using UC.Platform.UI;

namespace SalarySystem.Managment.Evaluation
{
  public partial class ExecutionEvaluationFormControl : BaseEditableControl
  {
    private const string _EVALUATION_FORM_DETAIL_SQL_FORMAT =
      "select * from" +
      " v_evaluation_form_detail " +
      " where" +
      " VERSION_ID='{0}'" +
      " and USED = true" +
      " and ENABLED= true";

    private const string _POSITION_EVALUATION_FORMS_SQL_FORMAT =
      "select * from t_position_evaluation_forms " +
      " where VERSION_ID='{0}'";

    private const string _EVALUATION_FORM_SQL_FORMAT =
      "select * from t_evaluation_form where VERSION_ID='{0}' and ENABLED=true";

    private readonly DataSetSalary.t_evaluation_formDataTable _evaluationForm =
      new DataSetSalary.t_evaluation_formDataTable();

    private readonly DataSetSalary.v_evaluation_form_detailDataTable _evaluationFormDetail =
      new DataSetSalary.v_evaluation_form_detailDataTable();

    private readonly DataSetSalary.t_position_evaluation_formsDataTable _positionEvaluationForms =
      new DataSetSalary.t_position_evaluation_formsDataTable();

    private DataView _dataViewForm;
    private DataView _dataViewFormDetail;

    public ExecutionEvaluationFormControl()
    {
      InitializeComponent();

      GridViewHelper.SetUpEditableGridView(gridViewExecutionForm, false, "实行考核表项目", GlobalSettings.EvaluationVersion);
      GridViewHelper.SetUpReadOnlyGridView(gridViewPredeinedForms, false, "预定义考核表", GlobalSettings.EvaluationVersion);
      gridViewExecutionForm.CustomDrawCell += GridViewHelper.CustomModifiedCellDrawHandler;
    }

    private int loadEvaluationFormDetail()
    {
      string sql = string.Format(_EVALUATION_FORM_DETAIL_SQL_FORMAT, GlobalSettings.EvaluationVersion);
      return DBHandlerEx.FillOnce(_evaluationFormDetail, sql);
    }

    private int loadPositionEvaluationForms()
    {
      string sql = string.Format(_POSITION_EVALUATION_FORMS_SQL_FORMAT, GlobalSettings.EvaluationVersion);
      return DBHandlerEx.FillOnce(_positionEvaluationForms, sql);
    }

    private int loadEvaluationForm()
    {
      string sql = string.Format(_EVALUATION_FORM_SQL_FORMAT, GlobalSettings.EvaluationVersion);
      return DBHandlerEx.FillOnce(_evaluationForm, sql);
    }

    private static string getFormFilter(string positionId)
    {
      return string.IsNullOrEmpty(positionId)
        ? "[ENABLED]=true"
        : string.Format("[ENABLED]=true AND ([POSITION_ID]='{0}' OR [POSITION_ID]='{1}')", positionId,
          GlobalSettings.GENERAL_POSITION);
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
      DataSetSalary.t_position_evaluation_formsRow row;
      if (e.Column == colPOSITION_ID)
      {
        //如果当前 FROM的适用岗位不是通用岗位或不等于当前选择岗位则清空该值
        row = gridViewExecutionForm.GetDataRow(e.RowHandle) as DataSetSalary.t_position_evaluation_formsRow;
        if (row == null) return;
        if (row.IsNull("EVALUATION_FORM_ID")) //新行跳过
          return;
        string formId = row.EVALUATION_FORM_ID;
        DataSetSalary.t_evaluation_formRow fromRow = _evaluationForm.FindByID(formId);
        //如果原先form的适用岗位不匹配，则清空form选择
        if (fromRow.POSITION_ID == (string) e.Value || fromRow.POSITION_ID == GlobalSettings.GENERAL_POSITION)
          return;
        row.EVALUATION_FORM_ID = "";
        return;
      }
      if (e.Column != colEVALUATION_FORM_ID) return;
      DataSetSalary.t_evaluation_formRow formRow = _evaluationForm.FindByID((string) e.Value);
      if (formRow == null || formRow.POSITION_ID == GlobalSettings.GENERAL_POSITION) return;
      row = gridViewExecutionForm.GetDataRow(e.RowHandle) as DataSetSalary.t_position_evaluation_formsRow;
      if (row == null) return;
      row.POSITION_ID = formRow.POSITION_ID;
    }

    private void focusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      if (!gridViewExecutionForm.IsDataRow(e.FocusedRowHandle))
      {
        SetFormId("");
        return;
      }
      DataRow row = gridViewExecutionForm.GetDataRow(e.FocusedRowHandle);
      if (row != null && !row.IsNull("EVALUATION_FORM_ID"))
      {
        SetFormId((string) row["EVALUATION_FORM_ID"]);
      }
    }

    private void gridViewExecutionForm_ShowingEditor(object sender, CancelEventArgs e)
    {
      if (gridViewExecutionForm.FocusedColumn == colEVALUATION_FORM_ID)
      {
        if (repositoryItemGridLookUpEditForm.DataSource == null)
        {
          repositoryItemGridLookUpEditForm.DataSource = _dataViewForm;
        }
        DataSetSalary.t_position_evaluation_formsRow row =
          gridViewExecutionForm.GetDataRow(gridViewExecutionForm.FocusedRowHandle) as
            DataSetSalary.t_position_evaluation_formsRow;
        if (row == null) return;
        if (!row.IsNull("POSITION_ID") && row.POSITION_ID != string.Empty)
        {
          gridViewRepForm.ActiveFilterString = string.Format(
            "[POSITION_ID]='{0}' OR [POSITION_ID]='{1}'", row.POSITION_ID,
            GlobalSettings.GENERAL_POSITION);
        }
      }
    }

    private void initNewRow(object sender, InitNewRowEventArgs e)
    {
      DataSetSalary.t_position_evaluation_formsRow row =
        (DataSetSalary.t_position_evaluation_formsRow) gridViewExecutionForm.GetDataRow(e.RowHandle);
      row.ENABLED = true;
      row.VERSION_ID = GlobalSettings.EvaluationVersion;
    }

    protected override void onSave()
    {
      if (DBHandlerEx.UpdateOnce(_positionEvaluationForms) >= 0)
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

      _dataViewForm = new DataView(_evaluationForm) {RowFilter = getFormFilter("")};
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