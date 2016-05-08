using System;
using System.Data;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SalarySystem.Data;
using UC.Platform.UI;

namespace SalarySystem.Execute
{
    public partial class EvalFormControl : DevExpress.XtraEditors.XtraUserControl
    {
        public EvalFormControl()
        {
            InitializeComponent();
            repositoryItemLookUpEditItemType.DataSource = new DataView(DataHolder.EvaluationItemType);
            gridViewEvalForm.CustomDrawCell += customDrawCell;
        }

        private static void customDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "MARK" || e.Column.FieldName == "RESULT_DESC")
            {
              GridViewHelper.CustomModifiedCellDrawHandler(sender, e);
            }
        }

        private DataSetSalary.v_evaluation_result_detailDataTable _resultDetail;

        public DataSetSalary.v_evaluation_result_detailDataTable ResultDetail
        {
            get
            {
                return _resultDetail;
            }
            set
            {
                _resultDetail = value;
                onResultDetailChanged();
            }
        }

        private void onResultDetailChanged()
        {
            gridControlEvalForm.DataSource = _resultDetail;
        }

        private void validatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = sender as GridView;
            Debug.Assert(gridView!=null);

            DataSetSalary.v_evaluation_result_detailRow row = gridView.GetDataRow(gridView.FocusedRowHandle) as DataSetSalary.v_evaluation_result_detailRow;
            Debug.Assert(row!=null);

            if (gridView.FocusedColumn.FieldName == "MARK")
            {
                if (e.Value == null || string.IsNullOrEmpty(e.Value.ToString()))
                {
                    e.ErrorText = "不能为空！";
                    e.Valid = false;
                    return;
                }
                try
                {
                    decimal val = Convert.ToDecimal(e.Value);
                    e.Valid = val <= row.FULL_MARK;
                    e.ErrorText = e.Valid ? "" : "实得分数不能超过项目满分！";
                }
                catch
                {
                    e.Valid = false;
                    e.ErrorText = "格式错误！请输入数字。";
                }
            }
            
        }
    }
}
