using System;
using System.Windows.Forms;
using salary.utilities;

namespace salary.main.employee
{
    public partial class EmployeeManagerControl : UserControl
    {
        public EmployeeManagerControl()
        {
            InitializeComponent();
        }

        void addEmployee(IEmployee employee)
        {
            TreeNode[] nodes;
            TreeNodeCollection parentCollection=null;
            if (employee.Leader != null)
            {
                nodes = treeView1.Nodes.Find(employee.Id, true);
                if (nodes.Length > 0)
                {
                    parentCollection = nodes[0].Nodes;
                }
            }
            if (parentCollection == null)
            {
                parentCollection = treeView1.Nodes;
            }
            TreeNode node = parentCollection.Add(employee.Id, employee.Name);
            node.Tag = employee;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeEditForm form=new EmployeeEditForm(EditPurpose.FOR_NEW);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                ListViewItem item = listView1.Items.Add(form.Employee.Id);
                item.SubItems.Add(form.Employee.Name);
                item.SubItems.Add(form.Employee.Position != null ? form.Employee.Position.Name : "");
                item.SubItems.Add(form.Employee.EntryTime.ToString("yyyy-MM-dd"));
                item.SubItems.Add(form.Employee.Seniority.ToString("N"));
                item.SubItems.Add(form.Employee.Leader != null ? form.Employee.Leader.Name : "");
                item.SubItems.Add(form.Employee.SalaryLevel != null ? form.Employee.SalaryLevel.Name : "");
                item.Tag = form.Employee;
            }
        }

        private void EmployeeManagerControl_Load(object sender, EventArgs e)
        {

        }
    }
}
