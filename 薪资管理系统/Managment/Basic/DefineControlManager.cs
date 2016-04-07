using System.Windows.Forms;
using DevExpress.XtraNavBar;

namespace SalarySystem.Managment.Basic
{
    public class DefineControlManager : NavBarControlManagerBase
    {
        protected const string KEY_GROUP_EVALUATION = "绩效考核";
        protected const string KEY_GROUP_ASSIGNMENT = "任务指标";
        protected const string KEY_GROUP_SALARY_STRUCTURE = "薪资结构";

        protected const string KEY_EVALUATION_ITEM_TYPE = "基本考核项目类型定义";
        protected const string KEY_EVALUATION_ITEM = "基本考核项目定义";
        protected const string KEY_EVALUATION_FORM = "岗位考核表定义";
        protected const string KEY_EXECUTION_EVALUATION_FORM = "考核实施管理";

        protected const string KEY_SALARY_ITEM = "基本薪资构成项目定义";
        protected const string KEY_EXECUTION_SALAY_STRUCT = "薪资结构实施管理";

        protected const string KEY_ASSINGMENT_ITEM = "基本任务指标定义";
        protected const string KEY_EXECUTION_ASSIGNMENT = "任务指标管理";
        
        
        public DefineControlManager(Control container, NavBarControl navBarControl)
            :base(container, navBarControl)
        {
            #region 导航栏定义

            NavGroupDefines.AddRange(new []
            {
                new NavGroupDefine(KEY_GROUP_EVALUATION, new []
                {
                    new NavItemDefine(KEY_EVALUATION_ITEM_TYPE, typeof(EvaluationItemTypeControl),  onNavItemClicked, 0),
                    new NavItemDefine(KEY_EVALUATION_ITEM,typeof(EvaluationItemControl), onNavItemClicked, 1), 
                    new NavItemDefine(KEY_EVALUATION_FORM, typeof(EvaluationFormControl), onNavItemClicked, 2), 
                    new NavItemDefine(KEY_EXECUTION_EVALUATION_FORM, typeof(ExecuttionEvaluationFormControl), onNavItemClicked, 3) 
                }, 0),
                new NavGroupDefine(KEY_GROUP_ASSIGNMENT, new[]
                {
                    new NavItemDefine(KEY_ASSINGMENT_ITEM, typeof(AssignmentItemControl), onNavItemClicked, 0), 
                    new NavItemDefine(KEY_EXECUTION_ASSIGNMENT, typeof(ExecutionAssignmentControl), onNavItemClicked, 1) 
                }, 1),
                new NavGroupDefine(KEY_GROUP_SALARY_STRUCTURE, new []
                {
                    new NavItemDefine(KEY_SALARY_ITEM, typeof(SalaryItemControl), onNavItemClicked, 0),
                    new NavItemDefine(KEY_EXECUTION_SALAY_STRUCT, typeof(ExecutionAssignmentControl), onNavItemClicked, 1)

                }, 2) 
            });
            #endregion
        }
    }
}
