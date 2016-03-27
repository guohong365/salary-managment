using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SalarySystem.Management.Position;
using SalarySystem.Utilities;

namespace SalarySystem.Management.Employee
{
    public partial class EmployeeManagerControl : XtraUserControl
    {
        public EmployeeManagerControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeEditForm form=new EmployeeEditForm(EditPurpose.FOR_NEW);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                DataHolder.Employees.Add(form.Employee);
                treeList1.RefreshDataSource();
            }
        }

        private void EmployeeManagerControl_Load(object sender, EventArgs e)
        {
            treeList1.DataSource = DataHolder.Employees;
            treeList1.ExpandAll();
        }
    }
}
