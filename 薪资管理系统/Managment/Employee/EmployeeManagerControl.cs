using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SalarySystem.Managment.Editor;
using SalarySystem.Managment.Employee.Editor;
using UC.Platform.Data.DBHelper;

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
            ItemEditForm form=new ItemEditForm(EmployeePropertyControl.GetFactory(), "新增员工", DataHolder.DataSet.t_employee.NewRow(),  (int) EditPurpose.FOR_NEW);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                DBHandlerEx.UpdateOnce(form.Row);
                gridControlEmployee.RefreshDataSource();
            }
            else
            {
                DataHolder.DataSet.t_employee.RejectChanges();
            }
        }

        void modifyEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void EmployeeManagerControl_Load(object sender, EventArgs e)
        {
            gridControlEmployee.DataSource = DataHolder.DataSet.t_employee;
        }

    }
}
