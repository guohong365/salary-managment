using SalarySystem.Data;
using UC.Platform.Data;

namespace SalarySystem.Schedule
{
    public partial class AssignmentScheduleControl : BaseEditableControl
    {
        public AssignmentScheduleControl()
        {
            InitializeComponent();
        }

        private DataSetSalary.t_annual_assignmentDataTable annualAssignment =
            new DataSetSalary.t_annual_assignmentDataTable();

        private DataSetSalary.t_assignment_performanceDataTable assignmentPerformance =
            new DataSetSalary.t_assignment_performanceDataTable();

        private const string sqlAnnualAssignemt = "";

        protected override void onControlLoad()
        {
            base.onControlLoad();

            DBHandlerEx.FillOnce(annualAssignment, "");

            DBHandlerEx.FillOnce(assignmentPerformance, "");

        }
    }
}
