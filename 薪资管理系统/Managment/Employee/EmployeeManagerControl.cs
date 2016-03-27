using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SalarySystem.Managment.Editor;
using SalarySystem.Managment.Employee.Editor;
using SalarySystem.Utilities;

namespace SalarySystem.Managment.Employee
{
    public partial class EmployeeManagerControl : XtraUserControl
    {
        public EmployeeManagerControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemEditForm form=new ItemEditForm(EmployeePropertyControl.GetFactory(), "新增员工", new SalarySystem.Employee(),  (int) EditPurpose.FOR_NEW);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                DataHolder.Employees.Add((IEmployee) form.Item);
                gridControlEmployee.RefreshDataSource();
            }
        }

        void modifyEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void EmployeeManagerControl_Load(object sender, EventArgs e)
        {
            gridControlEmployee.DataSource = DataHolder.Employees;
        }

    }
}
