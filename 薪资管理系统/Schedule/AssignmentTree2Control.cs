using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using SalarySystem.Data;

namespace SalarySystem.Schedule
{
    public partial class AssignmentTree2Control : XtraUserControl
    {
        public AssignmentTree2Control()
        {
            InitializeComponent();
            treeList1.RootValue = "";
            treeList1.OptionsView.ShowRoot = true;
            treeList1.OptionsView.ShowVertLines = true;
        }

        private DataSetSalary.v_employee_tree_assignmentDataTable _employeeTreeAssignment;

        public DataSetSalary.v_employee_tree_assignmentDataTable EmployeeTreeAssignment
        {
            get { return _employeeTreeAssignment; }
            set
            {
                _employeeTreeAssignment = value;
                treeList1.DataSource = EmployeeTreeAssignment;
                treeList1.ExpandAll();
            }
        }

        public TreeList TreeList
        {
            get { return treeList1; }
            set { treeList1 = value; }
        }
    }
    
}
