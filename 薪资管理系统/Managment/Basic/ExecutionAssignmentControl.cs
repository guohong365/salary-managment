using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using Platform.DBHelper;
using SalarySystem.Data;

namespace SalarySystem.Managment.Basic
{
    public partial class ExecutionAssignmentControl : BaseControl
    {
        public ExecutionAssignmentControl()
        {
            InitializeComponent();
            _detailView = new DataView(DataHolder.AssignmentDetail) { RowFilter = string.Format("[VERSION_ID]={0}", GlobalSettings.AssignmentVersion) };
            _itemView = new DataView(DataHolder.AssignmentItem) { RowFilter = string.Format("[ENABLED]=true AND [VERSION_ID]={0}", GlobalSettings.AssignmentVersion) };
        }

        private readonly DataView _detailView;
        private readonly DataView _itemView;
        protected override void onControlLoad()
        {
            base.onControlLoad();
            GridViewHelper.SetUpEditableGridView(gridViewDetails, false, "任务指标管理", VersionType.ASSIGNMENT);

            treeListPosition.DataSource = new DataView(DataHolder.Position) {RowFilter = "[ENABLED]=true"};

            
            gridControlDetail.DataSource = null;

            repositoryItemLookUpEditType.DataSource = new DataView(DataHolder.AssignmentItemType);
            repositoryItemLookUpEdit1Type.DataSource = new DataView(DataHolder.AssignmentItemType);
            repositoryItemLookUpEditUnit.DataSource = new DataView(DataHolder.Unit);
            repositoryItemLookUpEdit2Unit.DataSource = new DataView(DataHolder.Unit);
            repositoryItemLookUpEditPosition.DataSource = new DataView(DataHolder.Position);
            repositoryItemLookUpEdit3Position.DataSource = new DataView(DataHolder.Position);

            
            repositoryItemGridLookUpEditItem.DataSource = null;

            repositoryItemGridLookUpEditItem.ParseEditValue += repositoryItemGridLookUpEditParseEditValue;

            DataHolder.AssignmentDetail.RowChanged += rowChanged;
            gridViewDetails.InitNewRow += initNewRow;
            gridViewDetails.ShowingEditor += gridViewDetailShowingEditor;
            treeListPosition.FocusedNodeChanged += focusedNodeChanged;


            treeListPosition.ExpandAll();
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            DataHolder.AssignmentDetail.RowChanged += rowChanged;
            gridViewDetails.ExpandAllGroups();
            treeListPosition.ExpandAll();
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            DataHolder.AssignmentDetail.RowChanged -= rowChanged;
        }

        protected override void onSave()
        {
            base.onSave();
            DataTable changedTable = DataHolder.AssignmentDetail.GetChanges();
            if (changedTable != null)
            {
                foreach (DataSetSalary.v_assignment_detailRow row in changedTable.Rows)
                {
                    var detail = DataHolder.PositionAssignments.FindByASSIGNMENT_IDPOSITION_ID(row.ASSIGNMENT_ID,
                        row.POSITION_ID);
                    if (detail != null)
                    {
                        detail.ENABLED = row.ENABLED;
                        detail.VERSION_ID = GlobalSettings.AssignmentVersion;
                    }
                    else
                    {
                        detail = DataHolder.PositionAssignments.Newt_position_assignmentsRow();
                        detail.POSITION_ID = row.POSITION_ID;
                        detail.ASSIGNMENT_ID = row.ASSIGNMENT_ID;
                        detail.ENABLED = row.ENABLED;
                        detail.VERSION_ID = GlobalSettings.AssignmentVersion;
                        DataHolder.PositionAssignments.Addt_position_assignmentsRow(detail);
                    }
                }
                DBHandler.UpdateOnce(DataHolder.PositionAssignments);
                DataHolder.AssignmentDetail.AcceptChanges();
            }
        }

        protected override void onRevert()
        {
            base.onRevert();
            DataHolder.AssignmentDetail.RejectChanges();
        }

        private void rowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add || e.Action == DataRowAction.Change || e.Action == DataRowAction.Delete)
            {
                EnableSave(true);
                EnableRevert(true);
                CanClose = false;
            }
        }

        private void initNewRow(object sender, InitNewRowEventArgs e)
        {
            Debug.Assert(treeListPosition.FocusedNode!=null);

            var row = gridViewDetails.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row["POSITION_ID"] = treeListPosition.FocusedNode.GetValue("ID");
                row["ENABLED"] = true;
                row["VERSION_ID"] = GlobalSettings.AssignmentVersion;
            }
        }

        string getDetailViewFilter(string positionId)
        {
            return string.Format("[VERSION_ID]='{0}' AND [POSITION_ID]='{1}'", GlobalSettings.AssignmentVersion, positionId);
        }

        string getItemListFilter(string positionId)
        {
            return string.Format("[POSITION_ID]='{0}' OR [POSITION_ID]='{1}'", GlobalSettings.GENERAL_POSITION, positionId);
        }

        private void focusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node == null)
            {
                gridControlDetail.DataSource = null;
                gridViewDetails.OptionsView.NewItemRowPosition= NewItemRowPosition.None;
                gridViewDetails.OptionsBehavior.ReadOnly = true;
                gridViewDetails.OptionsBehavior.Editable = false;
                return;
            }
            gridViewDetails.OptionsView.NewItemRowPosition= NewItemRowPosition.Top;
            gridViewDetails.OptionsBehavior.ReadOnly = false;
            gridViewDetails.OptionsBehavior.Editable = true;
            var position = (string)e.Node.GetValue("ID");

            _detailView.RowFilter = getDetailViewFilter(position);

            repositoryItemGridLookUpEdit1View.ActiveFilterString = getItemListFilter(position);
            if (gridControlDetail.DataSource == null)
            {
                gridControlDetail.DataSource = _detailView;
            }

        }

        private void repositoryItemGridLookUpEditParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (e.Value == null || e.Value == DBNull.Value) return;

            var itemId = (string)e.Value;
            if (string.IsNullOrEmpty(itemId)) return;
            DataRow row = gridViewDetails.GetDataRow(gridViewDetails.FocusedRowHandle);
            var itemRow = DataHolder.AssignmentItem.FindByID(itemId);
            if (row == null) return;
            row["NAME"] = itemRow.NAME;
            row["DESCRIPTION"] = itemRow.DESCRIPTION;
            row["TYPE"] = itemRow.TYPE;
            row["TARGET"] = itemRow.TARGET;
            row["UNIT"] = itemRow.UNIT;
            row["FIT_POSITION_ID"] = itemRow.POSITION_ID;
        }

        private void gridViewDetailShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridViewDetails.FocusedColumn != colASSIGNMENT_ID) return;
            if (repositoryItemGridLookUpEditItem.DataSource == null)
            {
                repositoryItemGridLookUpEditItem.DataSource = _itemView;
            }
            var row = gridViewDetails.GetDataRow(gridViewDetails.FocusedRowHandle);
            if (row == null) return;
            if (!string.IsNullOrEmpty((string)row["POSITION_ID"]))
            {
                repositoryItemGridLookUpEdit1View.ActiveFilterString = string.Format("[POSITION_ID]='{0}' OR [POSITION_ID]='{1}'", row["POSITION_ID"],
                    GlobalSettings.GENERAL_POSITION);
            }
        }
    }
}
