using System.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;

namespace UC.Platform.UI
{
  public static class GridViewHelper
    {
        public static void CustomModifiedCellDrawHandler(object sender, RowCellCustomDrawEventArgs e)
        {
            GridView gridView = sender as GridView;

            if (gridView == null) return;

            DataRow row = gridView.GetDataRow(e.RowHandle);

            if (row == null || row.RowState == DataRowState.Unchanged) return;

            e.Appearance.BackColor = DataVisualizationColors.ChangedItemBackColor;
            if (e.RowHandle == gridView.FocusedRowHandle)
            {
              e.Appearance.ForeColor = DataVisualizationColors.ChangedItemForeColor;
            }
        }

        public static void SetUpColumns(GridView gridView)
        {
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.ShowInCustomizationForm = !column.Visible;
            }
        }

        public static void SetUpEditableGridView(GridView gridView)
        {
            SetUpEditableGridView(gridView, false, null, "");
        }

        public static void SetUpEditableGridView(GridView gridView, bool withDetail)
        {
            SetUpEditableGridView(gridView, withDetail, null, "");
        }

        public static void SetUpEditableGridView(GridView gridView, bool withDetail, string caption)
        {
            SetUpEditableGridView(gridView, withDetail, caption, "");
        }

        public static void SetUpEditableGridView(GridView gridView, bool withDetail, string caption, string surfix)
        {
            gridView.OptionsBehavior.AllowAddRows = DefaultBoolean.True;
            gridView.OptionsBehavior.AutoExpandAllGroups = withDetail;

            gridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;

            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            if (!string.IsNullOrEmpty(caption))
            {
                gridView.OptionsView.ShowViewCaption = true;
                gridView.ViewCaption = GetViewCaption(caption, surfix);
            }

            gridView.NewItemRowText = "点击新增";

            SetUpColumns(gridView);

            gridView.CustomDrawCell += CustomModifiedCellDrawHandler;

        }


        public static void SetUpReadOnlyGridView(GridView gridView)
        {
            SetUpReadOnlyGridView(gridView, false, null, "");
        }

        public static void SetUpReadOnlyGridView(GridView gridView, bool withDetail)
        {
            SetUpReadOnlyGridView(gridView, withDetail, null, "");
        }

        public static void SetUpReadOnlyGridView(GridView gridView, bool withDetail, string caption)
        {
            SetUpReadOnlyGridView(gridView, withDetail, caption, "");
        }

        public static void SetUpReadOnlyGridView(GridView gridView, bool withDetail, string caption, string surfix)
        {
            gridView.OptionsBehavior.AllowAddRows = DefaultBoolean.False;
            gridView.OptionsBehavior.AllowDeleteRows = DefaultBoolean.False;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            if (!string.IsNullOrEmpty(caption))
            {
                gridView.OptionsView.ShowViewCaption = true;
                gridView.ViewCaption = GetViewCaption(caption, surfix);
            }
            gridView.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            SetUpColumns(gridView);
        }

        public static string GetViewCaption(string prefix, string surfix)
        {
          return string.Format("{0}({1})", prefix, surfix);
        }

    }
}
