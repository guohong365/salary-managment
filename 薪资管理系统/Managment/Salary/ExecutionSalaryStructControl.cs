using System;
using System.Data;
using SalarySystem.Data;
using UC.Platform.Data;

namespace SalarySystem.Managment.Salary
{
    public partial class ExecutionSalaryStructControl : BaseEditableControl
    {
        private readonly DataSetSalary.v_salary_struct_detailDataTable _salaryStructDetail =
            new DataSetSalary.v_salary_struct_detailDataTable();

        private const string _SALARY_STRUCT_DETAIL_SQL_FORMAT =
            "select " +
            "t.ID," +
            "t.NAME," +
            "t.DESCRIPTION," +
            "t.TYPE," +
            "t.VALUE," +
            "t.VERSION_ID," +
            "t.FUNC_ID," +
            "ifnull(t1.POSITION_ID, '{0}') as POSITION_ID," +
            "if(isnull(t1.ENABLED), false, t.ENABLED) as ENABLED" +
            " from t_salary_item t" +
            " left join t_position_salary_items t1 on t1.SALARY_ITEM_ID=t.ID and t1.POSITION_ID='{0}' and t.VERSION_ID=t1.VERSION_ID" +
            " where " +
            " t.ENABLED=true " +
            " and (t1.POSITION_ID='{0}' or (isnull(t1.POSITION_ID) and t.POSITION_ID='9999999999'))" +
            " and t.VERSION_ID='{1}'";

        void loadSalaryStructDetail(string positionId)
        {
            string sql = string.Format(_SALARY_STRUCT_DETAIL_SQL_FORMAT, positionId, GlobalSettings.SalaryVersion);
            var handler = DBHandlerEx.GetBuffer();
            _salaryStructDetail.Clear();
            try
            {
                handler.Fill(_salaryStructDetail, sql);
            }
            finally
            {
                handler.FreeBuffer();
            }
        }

        public ExecutionSalaryStructControl()
        {
            InitializeComponent();
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            GridViewHelper.SetUpEditableGridView(gridViewExecSalaryDetai, false, "薪资构成", VersionType.SALARY);

            gridControlExecSalaryDetai.DataSource = null;

            treeListPosition.DataSource = new DataView(DataHolder.Position)
            {
                RowFilter = string.Format("[ENABLED]=true and [ID]<>'{0}'", GlobalSettings.GENERAL_POSITION)
            };
            gridControlExecSalaryDetai.DataSource = null;

            repositoryItemLookUpEditItemType.DataSource = new DataView(DataHolder.SalaryItemType);

            repositoryItemLookUpEditFormular.DataSource = new DataView(DataHolder.SalaryFunction);
            _salaryStructDetail.RowChanged += onRowChanged;
            gridViewExecSalaryDetai.ExpandAllGroups();
            treeListPosition.ExpandAll();
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _salaryStructDetail.RowChanged -= onRowChanged;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            _salaryStructDetail.RowChanged += onRowChanged;
            gridViewExecSalaryDetai.ExpandAllGroups();
            treeListPosition.ExpandAll();
        }

        string PositionId
        {
            get
            {
                return treeListPosition.FocusedNode==null ?"": Convert.ToString(treeListPosition.FocusedNode.GetValue("ID"));
            }
        }

        protected override void onSave()
        {
            base.onSave();
            DataTable changedTable = _salaryStructDetail.GetChanges();
            if (changedTable == null || changedTable.Rows.Count==0) return;
            string delSql =
                string.Format("delete from t_position_salary_items where POSITION_ID='{0}' and VERSION_ID='{1}'",
                    PositionId, GlobalSettings.SalaryVersion);
            DataSetSalary.t_position_salary_itemsDataTable positionSalaryItem = new DataSetSalary.t_position_salary_itemsDataTable();
            foreach (DataSetSalary.v_salary_struct_detailRow row in changedTable.Rows)
            {
                if(!row.ENABLED) continue;
                var detail = positionSalaryItem.Newt_position_salary_itemsRow();
                detail.POSITION_ID = row.POSITION_ID;
                detail.SALARY_ITEM_ID = row.ID;
                detail.ENABLED = row.ENABLED;
                detail.VERSION_ID = GlobalSettings.SalaryVersion;
                positionSalaryItem.Addt_position_salary_itemsRow(detail);
            }
            var handler = DBHandlerEx.GetBuffer();
            try
            {
                handler.ExecuteNonQuery(delSql);
                handler.Update(positionSalaryItem);
                _salaryStructDetail.AcceptChanges();
                base.onSave();
            }
            finally
            {
                handler.FreeBuffer();
            }
        }

        protected override void onRevert()
        {
            base.onRevert();
            _salaryStructDetail.RejectChanges();
        }

        private void focusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node == null)
            {
                gridControlExecSalaryDetai.DataSource = null;
                return;
            }
            //var position = (string) e.Node.GetValue("ID");
            loadSalaryStructDetail(PositionId);
            if (gridControlExecSalaryDetai.DataSource == null)
            {
                gridControlExecSalaryDetai.DataSource = _salaryStructDetail;
            }

        }
    }
}
