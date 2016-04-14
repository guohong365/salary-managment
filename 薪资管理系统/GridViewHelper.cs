using System.Data;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;

namespace SalarySystem
{
    public enum VersionType
    {
        NONE=0,
        EVALUATION= 1,
        ASSIGNMENT=2,
        SALARY=3
    }
    public static class GridViewHelper
    {
        static GridViewHelper()
        {
            ChangedItemBackColor = Color.Yellow;
        }

        public static Color ChangedItemBackColor { get; set; }

        public static void GerneralCustomCellDrawHandler(object sender, RowCellCustomDrawEventArgs e)
        {
            var gridView = sender as GridView;

            if (gridView == null) return;

            var row = gridView.GetDataRow(e.RowHandle);

            if (row == null || row.RowState == DataRowState.Unchanged) return;

            e.Appearance.BackColor = ChangedItemBackColor;
        }

        public static void CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            var treeList = sender as TreeList;
            if (treeList == null) return;
            var row= treeList.GetDataRecordByNode(e.Node) as DataRowView;
            if (row != null && row.Row.RowState!= DataRowState.Unchanged)
            {
                e.Appearance.BackColor = ChangedItemBackColor;
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
            SetUpEditableGridView(gridView, false, null, VersionType.NONE);
        }

        public static void SetUpEditableGridView(GridView gridView, bool withDetail)
        {
            SetUpEditableGridView(gridView, withDetail, null, VersionType.NONE);
        }

        public static void SetUpEditableGridView(GridView gridView, bool withDetail, string caption)
        {
            SetUpEditableGridView(gridView, withDetail, caption, VersionType.NONE);
        }
        public static void SetUpEditableGridView(GridView gridView, bool withDetail, string caption, VersionType versionType)
        {
            gridView.OptionsBehavior.AllowAddRows = DefaultBoolean.True;
            gridView.OptionsBehavior.AutoExpandAllGroups = withDetail;

            gridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;

            gridView.OptionsView.NewItemRowPosition= NewItemRowPosition.Top;
            if (!string.IsNullOrEmpty(caption))
            {
                gridView.OptionsView.ShowViewCaption = true;
                gridView.ViewCaption =GetViewCaption(caption, versionType);
            }

            gridView.NewItemRowText = "点击新增";

            SetUpColumns(gridView);

            gridView.CustomDrawCell += GerneralCustomCellDrawHandler;

        }


        public static void SetUpReadOnlyGridView(GridView gridView)
        {
            SetUpReadOnlyGridView(gridView, false, null, VersionType.NONE);
        }

        public static void SetUpReadOnlyGridView(GridView gridView, bool withDetail)
        {
            SetUpReadOnlyGridView(gridView, withDetail, null, VersionType.NONE);
        }

        public static void SetUpReadOnlyGridView(GridView gridView, bool withDetail, string caption)
        {
            SetUpReadOnlyGridView(gridView, withDetail, caption, VersionType.NONE);
        }
        public static void SetUpReadOnlyGridView(GridView gridView, bool withDetail, string caption, VersionType versionType)
        {
            gridView.OptionsBehavior.AllowAddRows= DefaultBoolean.False;
            gridView.OptionsBehavior.AllowDeleteRows= DefaultBoolean.False;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            if (!string.IsNullOrEmpty(caption))
            {
                gridView.OptionsView.ShowViewCaption = true;
                gridView.ViewCaption = GetViewCaption(caption, versionType);
            }
            gridView.FocusRectStyle= DrawFocusRectStyle.RowFocus;
            SetUpColumns(gridView);
        }

        public static string GetViewCaption(string prefix, VersionType versionType)
        {
            switch (versionType)
            {
                case VersionType.EVALUATION: //考核
                    return string.Format("{0}({1})", prefix, GlobalSettings.EvaluationFullVersion);
                case VersionType.ASSIGNMENT: //任务
                    return string.Format("{0}({1})", prefix, GlobalSettings.AssignmentFullVersion);
                case VersionType.SALARY: //薪资
                    return string.Format("{0}({1})", prefix, GlobalSettings.SalaryFullVersion);
                default:
                    return prefix;
            }
        }
    }
}
