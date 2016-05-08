using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Menu;
using DevExpress.XtraTreeList.Nodes;
using SalarySystem.Data;
using UC.Platform.Data;
using UC.Platform.UI;

namespace SalarySystem.Managment.Position
{
    public partial class PositionManagerControl : BaseEditableControl
    {
        public PositionManagerControl()
        {
            InitializeComponent();
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            treeList1.DataSource=new DataView(DataHolder.DataSet.t_position){RowFilter = string.Format("ID<>'{0}'", GlobalSettings.GENERAL_POSITION)};
            treeList1.ExpandAll();
            DataHolder.Position.RowChanged += onRowChanged;
          treeList1.CustomDrawNodeCell += TreeListHelper.CustomDrawModifiedNodeCellHandler;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            DataHolder.Position.RowChanged += onRowChanged;
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            DataHolder.Position.RowChanged -= onRowChanged;
        }

        protected override void onRevert()
        {
            base.onRevert();
            DataHolder.Position.RejectChanges();
        }

        protected override void onSave()
        {
            DBHandlerEx handler = DBHandlerEx.GetBuffer();
            try
            {
                handler.Update(DataHolder.Position);
                base.onSave();
            }
            finally
            {
                handler.FreeBuffer();
            }
        }

        private void onAfterCheckNode(object sender, NodeEventArgs e)
        {
            if (e.Node.Checked)
            {
                TreeListNode parentNode = e.Node;
                while (parentNode != null && !parentNode.Checked)
                {
                    parentNode.Checked = true;
                    parentNode = parentNode.ParentNode;
                }
            }
            else
            {
                TreeListHelper.SetAllChildCheck(e.Node, false);
            }
        }



        private void customDrawNodeCheckBox(object sender, CustomDrawNodeCheckBoxEventArgs e)
        {
            DataRowView rowView=(DataRowView) treeList1.GetDataRecordByNode(e.Node);
            DataSetSalary.t_positionRow row = (DataSetSalary.t_positionRow) rowView.Row;
            CheckObjectInfoArgs args = (CheckObjectInfoArgs) e.ObjectArgs;
            args.CheckState=row.ENABLED? CheckState.Checked:CheckState.Unchecked;
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeList treeList =(TreeList) sender ;
                TreeListHitInfo info = treeList.CalcHitInfo(e.Location);
                if ((info.HitInfoType == HitInfoType.RowIndicator || info.HitInfoType==HitInfoType.Cell) && info.Node!=null)
                {
                    TreeListMenu menu = new TreeListMenu(treeList);
                    DataRowView rowView = (DataRowView)treeList.GetDataRecordByNode(info.Node);
                  menu.Items.Add(string.IsNullOrEmpty((string) rowView["ID"])
                    ? new DXMenuItem("修改编号", onModifyId) {Tag = info.Node}
                    : new DXMenuItem("添加岗位", onAddNewPosition) {Tag = info.Node});
                  if (rowView.Row.RowState.HasFlag(DataRowState.Added))
                    {
                        menu.Items.Add(new DXMenuItem("删除", onDeleteNewPosition) {Tag = info.Node});
                    }
                    menu.Show(e.Location);
                }
            }
        }

        private void onModifyId(object sender, EventArgs e)
        {
            TreeListNode node = (TreeListNode)((DXMenuItem)sender).Tag;
            TreeList treeList = node.TreeList;
            treeList.FocusedNode = node;
            treeList.FocusedColumn = 列ID;
            treeList.ShowEditor();
        }

        private static void onDeleteNewPosition(object sender, EventArgs e)
        {
            TreeListNode node = (TreeListNode) ((DXMenuItem) sender).Tag;
            node.TreeList.DeleteNode(node);
        }

        private void onAddNewPosition(object sender, EventArgs e)
        {
            DataSetSalary.t_positionRow newRow = DataHolder.Position.Newt_positionRow();
            DXMenuItem menuItem = (DXMenuItem) sender;
            TreeListNode parentNode = (TreeListNode) menuItem.Tag;
            newRow.NAME="新岗位";
            newRow.ID = "";
            newRow.ENABLED = true;
            TreeList treeList = parentNode.TreeList;
            treeList.AppendNode(newRow, parentNode);
            treeList.SetColumnError(列ID, "请修改编号...", ErrorType.Critical);
            treeList.SetColumnError(列NAME, "请修改岗位名称...", ErrorType.Warning);
        }

        private void invalidNodeException(object sender, InvalidNodeExceptionEventArgs e)
        {
            e.ExceptionMode= ExceptionMode.NoAction;
        }

        private void validateNode(object sender, ValidateNodeEventArgs e)
        {
            TreeList treeList = (TreeList) sender;
             DataSetSalary.t_positionRow row = (DataSetSalary.t_positionRow) ((DataRowView)treeList1.GetDataRecordByNode(e.Node)).Row;
            if (string.IsNullOrEmpty(row.ID))
            {
                e.Valid = false;
                treeList.SetColumnError(列ID, "岗位编号不能为空...", ErrorType.Critical);
            }
            if (row.NAME == "新岗位")
            {
                e.Valid = false;
                treeList.SetColumnError(列NAME, "请修改岗位名称...", ErrorType.Warning);
            }
            if (string.IsNullOrEmpty(row.NAME))
            {
                e.Valid = false;
                treeList.SetColumnError(列NAME, "岗位名称不能为空...", ErrorType.Critical);
            }
        }
    }
}
