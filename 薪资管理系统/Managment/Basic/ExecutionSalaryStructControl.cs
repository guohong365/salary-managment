using System;
using System.Diagnostics;
using System.Data;
using DevExpress.XtraEditors.Controls;
using Platform.DBHelper;
using SalarySystem.Data;

namespace SalarySystem.Managment.Basic
{
    public partial class ExecutionSalaryStructControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly DataView _detailView;
        private readonly DataView _itemView;
        public ExecutionSalaryStructControl()
        {
            InitializeComponent();
            GridViewHelper.SetUpEditableGridView(gridViewExecSalaryDetai, false, "薪资构成", VersionType.SALARY);

            gridControlExecSalaryDetai.DataSource = null;
            _detailView=new DataView(DataHolder.SalaryStructDetail);
            _itemView = new DataView(DataHolder.SalaryItem)
            {
                RowFilter = string.Format("[ENABLED]=true AND [VERSION_ID]={0}", GlobalSettings.SalaryVersion)
            };

            treeListPosition.DataSource = new DataView(DataHolder.Position){RowFilter = "[ENABLED]=true"};
            gridControlExecSalaryDetai.DataSource = null;

            repositoryItemLookUpEditItemDataSource.DataSource = new DataView(DataHolder.SalaryDataSourceType);

            repositoryItemLookUpEditItemType.DataSource = new DataView(DataHolder.SalaryItemType);

            repositoryItemLookUpEditPosition.DataSource = new DataView(DataHolder.Position);
            repositoryItemLookUpEditLookUpPosition.DataSource = new DataView(DataHolder.Position);

        }

        string getDetailViewFilter(string positionId)
        {
            return string.Format("[VERSION_ID]='{0}' AND [POSITION_ID]='{1}'", GlobalSettings.SalaryVersion, positionId);
        }

        string getItemListFilter(string positionId)
        {
            return string.Format("[POSITION_ID]='{0}' OR [POSITION_ID]='{1}'", GlobalSettings.GENERAL_POSITION, positionId);
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
            DataHolder.SalaryStructDetail.RowChanged += onRowChanged;
            gridViewExecSalaryDetai.ExpandAllGroups();
            treeListPosition.ExpandAll();
        }
        private void visibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                DataHolder.SalaryStructDetail.RowChanged += onRowChanged;
            }
            else
            {
                DataHolder.SalaryStructDetail.RowChanged -= onRowChanged;
            }
        }

        private void save_items(object sender, EventArgs e)
        {
            DataTable changedTable = DataHolder.SalaryStructDetail.GetChanges();
            if (changedTable != null)
            {
                foreach (DataSetSalary.v_salary_struct_detailRow row in changedTable.Rows)
                {
                    var detail = DataHolder.PositionSalaryItems.FindByPOSITION_IDSALARY_ITEM_ID(row.POSITION_ID,row.SALARY_ITEM_ID);
                    if (detail != null)
                    {
                        detail.ENABLED = row.ENABLED;
                        detail.VERSION_ID = GlobalSettings.SalaryVersion;
                    }
                    else
                    {
                        detail = DataHolder.PositionSalaryItems.Newt_position_salary_itemsRow();
                        detail.POSITION_ID = row.POSITION_ID;
                        detail.SALARY_ITEM_ID = row.SALARY_ITEM_ID;
                        detail.ENABLED = row.ENABLED;
                        detail.VERSION_ID = GlobalSettings.SalaryVersion;
                        DataHolder.PositionSalaryItems.Addt_position_salary_itemsRow(detail);
                    }
                }
                DBHandler.UpdateOnce(DataHolder.PositionSalaryItems);
                //DataHolder.PositionSalaryItemsTableAdapter.Update(DataHolder.PositionSalaryItems);
                DataHolder.SalaryStructDetail.AcceptChanges();
            }
            simpleButtonSave.Enabled = false;
            simpleButtonRevert.Enabled = false;
        }

        private void abandon_items(object sender, EventArgs e)
        {
            DataHolder.SalaryStructDetail.RejectChanges();
            simpleButtonSave.Enabled = false;
            simpleButtonRevert.Enabled = false;
        }

        private void initNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            Debug.Assert(treeListPosition.FocusedNode!=null);

            var row = gridViewExecSalaryDetai.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row["POSITION_ID"] = treeListPosition.FocusedNode.GetValue("ID");
                row["ENABLED"] = true;
                row["VERSION_ID"] = GlobalSettings.SalaryVersion;
            }
        }

        private void focusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node == null)
            {
                gridControlExecSalaryDetai.DataSource = null;
                return;
            }
            var position = (string) e.Node.GetValue("ID");
            _detailView.RowFilter = getDetailViewFilter(position);

            repositoryItemGridLookUpEdit1View.ActiveFilterString = getItemListFilter(position);
            if (gridControlExecSalaryDetai.DataSource == null)
            {
                gridControlExecSalaryDetai.DataSource = _detailView;
            }

        }

        private void repositoryItemGridLookUpEditItem_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if(e.Value==null || e.Value==DBNull.Value)return;

            string itemId = (string) e.Value;
            if(string.IsNullOrEmpty(itemId))return;
            DataRow row = gridViewExecSalaryDetai.GetDataRow(gridViewExecSalaryDetai.FocusedRowHandle);
            var itemRow = DataHolder.SalaryItem.FindByID(itemId);
            if (row == null) return;
            row["NAME"] = itemRow.NAME;
            row["DESCRIPTION"] = itemRow.DESCRIPTION;
            row["TYPE"] = itemRow.TYPE;
            row["VALUE"] = itemRow.VALUE;
            row["FIT_POSITION_ID"] = itemRow.POSITION_ID;
            row["DATA_SOURCE_TYPE"] = itemRow.DATA_SOURCE_TYPE;
        }

        private void gridViewExecSalaryDetai_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (gridViewExecSalaryDetai.FocusedColumn != colSALARY_ITEM_ID) return;
            if (repositoryItemGridLookUpEditItem.DataSource == null)
            {
                repositoryItemGridLookUpEditItem.DataSource = _itemView;
            }
            var row = gridViewExecSalaryDetai.GetDataRow(gridViewExecSalaryDetai.FocusedRowHandle);
            if (row == null) return;
            if (!string.IsNullOrEmpty((string)row["POSITION_ID"]))
            {
                repositoryItemGridLookUpEdit1View.ActiveFilterString = string.Format("[POSITION_ID]='{0}' OR [POSITION_ID]='{1}'", row["POSITION_ID"],
                    GlobalSettings.GENERAL_POSITION);
            }
        }
    }
}
