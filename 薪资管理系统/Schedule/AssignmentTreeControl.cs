using System.Data;
using SalarySystem.Data;

namespace SalarySystem.Schedule
{
    public partial class AssignmentTreeControl : DevExpress.XtraEditors.XtraUserControl
    {
        public AssignmentTreeControl()
        {
            InitializeComponent();
        }

        private DataSetSalary.v_position_tree_auto_assignmentDataTable _positionTreeAutoAssignment;

        public int Month
        {
            get
            {
                MonthAssignmentScheduleParameter parameter = Tag as MonthAssignmentScheduleParameter;
                return parameter == null ? 0 : parameter.Month;
            }
        }

        public DataSetSalary.v_position_tree_auto_assignmentDataTable PositionTreeAutoAssignment
        {
            get { return _positionTreeAutoAssignment; }
            set
            {
                _positionTreeAutoAssignment = value;
                treeList1.DataSource = new DataView(_positionTreeAutoAssignment);
                treeList1.ExpandAll();
            }
        }

        public void Generate(decimal total, int month)
        {
            ScheduleHelper.Monthly.GenerateMonthAssignment(treeList1, total, month);
        }
    }
}
