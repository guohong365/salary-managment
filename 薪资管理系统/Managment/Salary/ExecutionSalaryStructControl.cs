using System;
using System.Data;
using System.Diagnostics;
using DevExpress.XtraEditors.Controls;
using SalarySystem.Data;
using UC.Platform.Data;

namespace SalarySystem.Managment.Salary
{
    public partial class ExecutionSalaryStructControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly DataView _detailView;
        private readonly DataView _itemView;

        private readonly DataSetSalary.v_salary_struct_detailDataTable _salaryStructDetail =
            new DataSetSalary.v_salary_struct_detailDataTable();

        readonly DataSetSalary.t_salary_itemDataTable _salaryItem=new DataSetSalary.t_salary_itemDataTable();
        private const string _SALARY_STRUCT_DETAIL_SQL_FORMAT =
            "select * from v_salary_struct_detail where VERSION_ID='{0}'";

        private const string _SALARY_ITEM_SQL_FORMAT = "select * from t_salary_item where ENABLED=true and VERSION_ID='{0}'";

        int loadSalaryStructDetail()
        {
            string sql = string.Format(_SALARY_STRUCT_DETAIL_SQL_FORMAT, GlobalSettings.SalaryVersion);
            return DBHandlerEx.FillOnce(_salaryStructDetail, sql);
        }

        int loadSalaryItem()
        {
            string sql = string.Format(_SALARY_ITEM_SQL_FORMAT, GlobalSettings.SalaryVersion);
            return DBHandlerEx.FillOnce(_salaryItem, sql);
        }

        void loadData()
        {
            if (loadSalaryItem() < 0 || loadSalaryStructDetail() < 0)
            {
                throw new Exception();
            }
        }

        public ExecutionSalaryStructControl()
        {
            InitializeComponent();
            GridViewHelper.SetUpEditableGridView(gridViewExecSalaryDetai, false, "薪资构成", VersionType.SALARY);

            loadData();

            gridControlExecSalaryDetai.DataSource = null;
            _detailView=new DataView(_salaryStructDetail);
            _itemView = new DataView(_salaryItem);

            treeListPosition.DataSource = new DataView(DataHolder.Position){RowFilter = "[ENABLED]=true"};
            gridControlExecSalaryDetai.DataSource = null;

            repositoryItemLookUpEditItemType.DataSource = new DataView(DataHolder.SalaryItemType);

            repositoryItemLookUpEditPosition.DataSource = new DataView(DataHolder.Position);
            repositoryItemLookUpEditLookUpPosition.DataSource = new DataView(DataHolder.Position);

        }

        static string getDetailViewFilter(string positionId)
        {
            return string.Format("[POSITION_ID]='{0}'", positionId);
        }

        static string getItemListFilter(string positionId)
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
            _salaryStructDetail.RowChanged += onRowChanged;
            gridViewExecSalaryDetai.ExpandAllGroups();
            treeListPosition.ExpandAll();
        }
        private void visibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                _salaryStructDetail.RowChanged += onRowChanged;
            }
            else
            {
                _salaryStructDetail.RowChanged -= onRowChanged;
            }
        }

        private void save_items(object sender, EventArgs e)
        {
            DataTable changedTable = _salaryStructDetail.GetChanges();
            if (changedTable != null)
            {
                var positionSalaryItem = new DataSetSalary.t_position_salary_itemsDataTable();
                DBHandlerEx.FillOnce(positionSalaryItem,
                    string.Format("select * from t_position_salary_items where VERSION_ID='{0}'",
                        GlobalSettings.SalaryVersion));
                foreach (DataSetSalary.v_salary_struct_detailRow row in changedTable.Rows)
                {
                    var detail = positionSalaryItem.FindByPOSITION_IDSALARY_ITEM_ID(row.POSITION_ID,row.SALARY_ITEM_ID);
                    if (detail != null)
                    {
                        detail.ENABLED = row.ENABLED;
                        detail.VERSION_ID = GlobalSettings.SalaryVersion;
                    }
                    else
                    {
                        detail = positionSalaryItem.Newt_position_salary_itemsRow();
                        detail.POSITION_ID = row.POSITION_ID;
                        detail.SALARY_ITEM_ID = row.SALARY_ITEM_ID;
                        detail.ENABLED = row.ENABLED;
                        detail.VERSION_ID = GlobalSettings.SalaryVersion;
                        positionSalaryItem.Addt_position_salary_itemsRow(detail);
                    }
                }
                DBHandlerEx.UpdateOnce(positionSalaryItem);
                _salaryStructDetail.AcceptChanges();
            }
            simpleButtonSave.Enabled = false;
            simpleButtonRevert.Enabled = false;
        }

        private void abandon_items(object sender, EventArgs e)
        {
            _salaryStructDetail.RejectChanges();
            simpleButtonSave.Enabled = false;
            simpleButtonRevert.Enabled = false;
        }

        private void initNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            Debug.Assert(treeListPosition.FocusedNode!=null);

            var row = gridViewExecSalaryDetai.GetDataRow(e.RowHandle) as DataSetSalary.v_salary_struct_detailRow;
            if (row != null)
            {
                row.POSITION_ID= (string) treeListPosition.FocusedNode.GetValue("ID");
                row.ENABLED= true;
                row.VERSION_ID = GlobalSettings.SalaryVersion;
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
            var row = gridViewExecSalaryDetai.GetDataRow(gridViewExecSalaryDetai.FocusedRowHandle) as DataSetSalary.v_salary_struct_detailRow;
            var itemRow = _salaryItem.FindByID(itemId);
            if (row == null) return;
            row.NAME = itemRow.NAME;
            row.DESCRIPTION = itemRow.DESCRIPTION;
            row.TYPE = itemRow.TYPE;
            row.VALUE = itemRow.VALUE;
            row.FIT_POSITION_ID = itemRow.POSITION_ID;
            row.FUNC_ID = itemRow.FUNC_ID;
        }

        private void gridViewExecSalaryDetai_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (gridViewExecSalaryDetai.FocusedColumn != colSALARY_ITEM_ID) return;
            if (repositoryItemGridLookUpEditItem.DataSource == null)
            {
                repositoryItemGridLookUpEditItem.DataSource = _itemView;
            }
            var row = gridViewExecSalaryDetai.GetDataRow(gridViewExecSalaryDetai.FocusedRowHandle) as DataSetSalary.v_salary_struct_detailRow;
            if (row == null) return;
            if (!string.IsNullOrEmpty(row.POSITION_ID))
            {
                repositoryItemGridLookUpEdit1View.ActiveFilterString = string.Format("[POSITION_ID]='{0}' OR [POSITION_ID]='{1}'",
                    row.POSITION_ID, GlobalSettings.GENERAL_POSITION);
            }
        }
    }
}
