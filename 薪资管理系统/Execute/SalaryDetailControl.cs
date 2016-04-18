using System;
using System.Data;
using DevExpress.XtraGrid.Views.Base;

namespace SalarySystem.Execute
{
    public partial class SalaryDetailControl : BaseEditableControl
    {
        public SalaryDetailControl()
        {
            InitializeComponent();
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            gridControlEmployee.DataSource = new DataView(DataHolder.Employee)
            {
                RowFilter = "[ENABLED]=true"
            };
        }

        private void onEmployeeFocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var row = gridViewEmployee.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                loadSalaryDetail(Convert.ToString(row["ID"]));
            }
        }

        private void loadSalaryDetail(string employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
