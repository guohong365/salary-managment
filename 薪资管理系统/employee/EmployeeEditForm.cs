using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using salary.utilities;

namespace salary.main.employee
{
    public partial class EmployeeEditForm : XtraForm
    {
        public IEmployee Employee
        {
            get
            {
                return employeePropertyControl1.Employee;
            }
            set
            {
                employeePropertyControl1.Employee = value;
            }
        }

   
        public EmployeeEditForm(EditPurpose purpose)
        {
            InitializeComponent();
            employeePropertyControl1.Purpose = purpose;
            if (purpose == EditPurpose.FOR_VIEW)
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save data
            employeePropertyControl1.Retrive();
            DialogResult = DialogResult.OK;
        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {

        }



    }
}
