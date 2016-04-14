using System;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using SalarySystem.Managment.Basic;
using UC.Platform.Data;

namespace SalarySystem.Managment.Assignment
{
    public partial class AssignmentDefineControl : BaseEditableControl
    {
        public AssignmentDefineControl()
        {
            InitializeComponent();

        }

        private DataView _itemView;
        protected override void onControlLoad()
        {
            base.onControlLoad();
            
            GridViewHelper.SetUpEditableGridView(gridViewDetails, false, "任务指标定义", VersionType.ASSIGNMENT);
            _itemView = new DataView(DataHolder.AssignmentDefine) { RowFilter = string.Format("[VERSION_ID]={0}", GlobalSettings.AssignmentVersion) };
            gridControlDetail.DataSource = _itemView;
            repositoryItemLookUpEditType.DataSource = new DataView(DataHolder.AssignmentItemType);
            repositoryItemLookUpEditUnit.DataSource = new DataView(DataHolder.Unit);
            repositoryItemLookUpEditPosition.DataSource = new DataView(DataHolder.Position);
            gridViewDetails.InitNewRow += initNewRow;
            gridViewDetails.ExpandAllGroups();
            DataHolder.AssignmentDefine.RowChanged += rowChanged;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            DataHolder.AssignmentDefine.RowChanged += rowChanged;
            gridViewDetails.ExpandAllGroups();
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            DataHolder.AssignmentDefine.RowChanged -= rowChanged;
        }

        protected override void onSave()
        {
            base.onSave();
            DataTable changedTable = DataHolder.AssignmentDefine.GetChanges();
            if (changedTable == null || changedTable.Rows.Count <= 0) return;
            if (DBHandlerEx.UpdateOnce(changedTable) > 0)
            {
                DataHolder.AssignmentDefine.AcceptChanges();
            }
        }

        protected override void onRevert()
        {
            base.onRevert();
            DataHolder.AssignmentDefine.RejectChanges();
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
            var row = gridViewDetails.GetDataRow(e.RowHandle);
            if (row == null) return;
            row["ID"] = Guid.NewGuid().ToString();
            row["ENABLED"] = true;
            row["VERSION_ID"] = GlobalSettings.AssignmentVersion;
            row["DEFAULT_VALUE"] = 0;
        }
    }
}
