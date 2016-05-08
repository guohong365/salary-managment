using System;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using SalarySystem.Data;
using UC.Platform.Data;
using UC.Platform.UI;

namespace SalarySystem.Managment.Employee
{
    public partial class EmployeeManagerControl : BaseEditableControl
    {
        public EmployeeManagerControl()
        {
            InitializeComponent();
            GridViewHelper.SetUpEditableGridView(gridViewEmployee, false, "员工管理");
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            gridControlEmployee.DataSource = DataHolder.Employee;

            repositoryItemLookUpEditPosition.DataSource = new DataView(DataHolder.Position)
            {
                RowFilter = string.Format("[ENABLED]=true and [ID]<>'{0}'", GlobalSettings.GENERAL_POSITION)
            };
            repositoryItemLookUpEditLeader.DataSource=new DataView(DataHolder.Employee)
            {
                RowFilter = "[ENABLED]=true"
            };
            DataHolder.Employee.RowChanged += onRowChanged;
            gridViewEmployee.InitNewRow += initNewRow;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            DataHolder.Employee.RowChanged += onRowChanged;
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            DataHolder.Employee.RowChanged -= onRowChanged;
        }

        private static void initNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView gridView = (GridView) sender;
            DataSetSalary.t_employeeRow row = (DataSetSalary.t_employeeRow) gridView.GetDataRow(e.RowHandle);
            row.ENABLED = true;
            row.ENTRY_TIME=DateTime.Now;
        }

        protected override void onRevert()
        {
            base.onRevert();
            DataHolder.Employee.RejectChanges();
        }

        protected override void onSave()
        {
            DBHandlerEx handler = DBHandlerEx.GetBuffer();
            try
            {
                handler.Update(DataHolder.Employee);
                base.onSave();
            }
            finally
            {
                handler.FreeBuffer();
            }
        }
    }
}
