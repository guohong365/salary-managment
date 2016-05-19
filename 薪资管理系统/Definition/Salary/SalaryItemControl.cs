using System;
using System.Data;
using SalarySystem.Data;
using UC.Platform.Data;
using UC.Platform.UI;

namespace SalarySystem.Definition.Salary
{
    public partial class SalaryItemControl : BaseEditableControl
    {
        private readonly DataSetSalary.t_salary_itemDataTable _salaryItem=new DataSetSalary.t_salary_itemDataTable();
      readonly DataSetSalary.t_salary_functionDataTable _salaryFunction=new DataSetSalary.t_salary_functionDataTable();
        private const string _SALARY_ITEM_SQL_FORMAT = "select * from t_salary_item where VERSION_ID={0}";
        private const string _SALARY_FUNCTION_SQL_FORMAT = "select * from t_salary_function where ENABLED=true";
        void loadData()
        {
            var sql = string.Format(_SALARY_ITEM_SQL_FORMAT,GlobalSettings.SalaryVersion);
            DBHandlerEx handler = DBHandlerEx.GetBuffer();
            try
            {
                handler.Fill(_salaryItem, sql);
                handler.Fill(_salaryFunction, _SALARY_FUNCTION_SQL_FORMAT);
            }
            finally
            {
                handler.FreeBuffer();
            }
        }
        public SalaryItemControl()
        {
            InitializeComponent();

            loadData();

            repositoryItemLookUpEditItemType.DataSource = new DataView(DataHolder.SalaryItemType)
            {
                RowFilter = "ENABLED=true"
            };

            gridControlSalaryItem.DataSource = new DataView(_salaryItem)
            {
                RowFilter = string.Format("[VERSION_ID]='{0}'", GlobalSettings.SalaryVersion)
            };

            repositoryItemLookUpEditPosition.DataSource = new DataView(DataHolder.Position)
            {
                RowFilter = "[ENABLED]=true"
            };
            repositoryItemLookUpEditFunction.DataSource = _salaryFunction;

            GridViewHelper.SetUpEditableGridView(gridViewSalaryItem, false, "基本薪资构成项目", GlobalSettings.SalaryVersion);

        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            _salaryItem.RowChanged += onRowChanged;
            gridViewSalaryItem.InitNewRow += initNewRow;
            gridViewSalaryItem.ExpandAllGroups();
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _salaryItem.RowChanged -= onRowChanged;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
                _salaryItem.RowChanged += onRowChanged;
            gridViewSalaryItem.ExpandAllGroups();
        }

        protected override void onSave()
        {
            if (DBHandlerEx.UpdateOnce(_salaryItem) >= 0)
            {
                base.onSave();
            }
        }

        protected override void onRevert()
        {
            base.onRevert();
            _salaryItem.RejectChanges();
        }

        private void initNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSetSalary.t_salary_itemRow row = gridViewSalaryItem.GetDataRow(e.RowHandle) as DataSetSalary.t_salary_itemRow;
            if (row != null)
            {
                row.ID = Guid.NewGuid().ToString();
                row.ENABLED = true;
                row.VERSION_ID = GlobalSettings.SalaryVersion;
            }
        }
    }
}
