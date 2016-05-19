using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using SalarySystem.Data;
using UC.Platform.Data;
using UC.Platform.UI;
using DataRow = System.Data.DataRow;

namespace SalarySystem.Definition.Salary
{
    public partial class SalaryItemGroupControl : BaseEditableControl
    {
        public SalaryItemGroupControl()
        {
            InitializeComponent();
            GridViewHelper.SetUpEditableGridView(gridViewItemGroup,false, "薪资项目分组定义");
        }

        readonly DataSetSalary.t_salary_item_groupDataTable _salaryItemGroup = new DataSetSalary.t_salary_item_groupDataTable();

        void loadGroup()
        {
            string sql = string.Format("select * from t_salary_item_group where VERSION_ID='{0}'", GlobalSettings.SalaryVersion);
            DBHandlerEx handler = DBHandlerEx.GetBuffer();
            try
            {
                handler.Fill(_salaryItemGroup, sql);
            }
            finally
            {
                handler.FreeBuffer();
            }
        }

        private readonly DataSetSalary.t_salary_itemDataTable _salaryItem = new DataSetSalary.t_salary_itemDataTable();
        void loadItems()
        {
            string sql = string.Format("select * from t_salary_item where ENABLED=true and VERSION_ID='{0}'", GlobalSettings.SalaryVersion);
            DBHandlerEx handler = DBHandlerEx.GetBuffer();
            try
            {
                handler.Fill(_salaryItem, sql);
            }
            finally
            {
                handler.FreeBuffer();
            }
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            loadGroup();
            loadItems();
            gridControlItemGroup.DataSource = _salaryItemGroup;
            gridViewItemGroup.InitNewRow += initNewRow;
            _salaryItemGroup.RowChanged += onRowChanged;
            repositoryItemGridLookUpEditItem.DataSource = _salaryItem;
        }

        CriteriaOperator getItemFilter(int rowHandle)
        {
            DataSetSalary.t_salary_item_groupRow currentRow = gridViewItemGroup.GetDataRow(rowHandle) as DataSetSalary.t_salary_item_groupRow;
            List<string> ids= (
                from itemGroupRow in 
                    _salaryItemGroup 
                where currentRow==null || itemGroupRow.ID != currentRow.ID select itemGroupRow.ITEM_ID).ToList();
            InOperator inOpt = new InOperator("ID", ids);
            UnaryOperator opt = new UnaryOperator(UnaryOperatorType.Not, inOpt);
            return opt;
            //return String.Join(",", ids);
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            _salaryItemGroup.RowChanged += onRowChanged;
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _salaryItemGroup.RowChanged -= onRowChanged;
        }

      private static void initNewRow(object sender, InitNewRowEventArgs e)
      {
        GridView gridView = (GridView) sender;
        DataRow row = gridView.GetDataRow(e.RowHandle);
        DataSetSalary.t_salary_item_groupRow dataRow = (DataSetSalary.t_salary_item_groupRow) row;
        dataRow.ID = Guid.NewGuid().ToString();
        dataRow.ENABLED = true;
        dataRow.SHOW_ORDER = 0;
        dataRow.VERSION_ID = GlobalSettings.SalaryVersion;

      }

      protected override void onRevert()
        {
            base.onRevert();
            _salaryItemGroup.RejectChanges();
        }

        protected override void onSave()
        {
            DBHandlerEx handler = DBHandlerEx.GetBuffer();
            try
            {
                handler.Update(_salaryItemGroup);
                base.onSave();
            }
            finally
            {
                handler.FreeBuffer();
            }
        }

        private void onPopup(object sender, EventArgs e)
        {
            GridLookUpEdit itemSelector = (GridLookUpEdit) sender;
            CriteriaOperator filter = getItemFilter(gridViewItemGroup.FocusedRowHandle);
            itemSelector.Properties.View.ActiveFilterCriteria = filter;
        }
    }
}
