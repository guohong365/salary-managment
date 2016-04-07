using System.Windows.Forms;
using DevExpress.XtraNavBar;
using SalarySystem.Managment.Basic;

namespace SalarySystem.Execute
{
    public class ExecutionControlManager: NavBarControlManagerBase
    {
        protected const string KEY_GROUP_ASSIGNMENT_SCHEDULE = "任务计划";
        protected const string KEY_ASSIGNMENT_SCHEDULE="任务指派";
        protected const string KEY_GROUP_EXECUTED_EVALUATION = "员工考评";
        protected const string KEY_EXECUTED_EVALUATION = "员工考评工资";
        protected const string KEY_SALARY_DETAIL = "工资明细";


        public ExecutionControlManager(Control container, NavBarControl navBarControl) : base(container, navBarControl)
        {
            NavGroupDefines.AddRange(new[]
            {
                new NavGroupDefine(KEY_GROUP_ASSIGNMENT_SCHEDULE, new[]
                {
                   new NavItemDefine(KEY_ASSIGNMENT_SCHEDULE, typeof(AssignmentScheduleControl), onNavItemClicked, 0)
                }, 0),
                new NavGroupDefine(KEY_GROUP_EXECUTED_EVALUATION, new[]
                {
                    new NavItemDefine(KEY_EXECUTED_EVALUATION, typeof(ExecutionEvaluationControl), onNavItemClicked, 0),
                    new NavItemDefine(KEY_SALARY_DETAIL, typeof(SalaryDetailControl), onNavItemClicked, 1)
                })
            });
        }
    }
}
