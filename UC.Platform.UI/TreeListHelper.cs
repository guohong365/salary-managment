using System.Data;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace UC.Platform.UI
{
  public static class TreeListHelper
  {
    public static void CustomDrawModifiedNodeCellHandler(object sender, CustomDrawNodeCellEventArgs e)
    {
      TreeList treeList = sender as TreeList;
      if (treeList == null) return;
      DataRowView row = treeList.GetDataRecordByNode(e.Node) as DataRowView;
      if (row != null && row.Row.RowState != DataRowState.Unchanged)
      {
        e.Appearance.BackColor = DataVisualizationColors.ChangedItemBackColor;
      }
    }
    public static void SetAllChildCheck(TreeListNode node, bool isChecked)
    {
      foreach (TreeListNode listNode in node.Nodes)
      {
        listNode.Checked = isChecked;
        if (listNode.HasChildren)
        {
          SetAllChildCheck(listNode, isChecked);
        }
      }
    }
  }
}