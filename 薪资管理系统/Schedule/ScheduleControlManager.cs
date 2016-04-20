namespace SalarySystem.Schedule
{
   public class ScheduleControlManager : NavBarControlManagerBase
    {
       private const string _KEY_SCHEDULE_GROUP = "任务计划";
       private const string _KEY_ANNUAL_SCHECULE = "年度计划";
       private const string _KEY_PERSIONAL_SCHEDULE = "岗位任务分配";

       private const string _KEY_CONFIG_GROUP="基本配置";
       private const string _KEY_DEFAULT_MONTHLY_WEIGHT = "年度计划默认月份占比";

       public ScheduleControlManager()
       {
           defineNavGroups();
       }

       private void defineNavGroups()
       {
           NavGroupDefines.AddRange(new []
           {
               new NavGroupDefine(_KEY_CONFIG_GROUP, new []
               {
                   new NavItemDefine(_KEY_DEFAULT_MONTHLY_WEIGHT, typeof(AutoAssignmentWeightControl), onNavItemClicked, 0)
               }, 0), 
               new NavGroupDefine(_KEY_SCHEDULE_GROUP, new []
               {
                   new NavItemDefine(_KEY_ANNUAL_SCHECULE, typeof(AssignmentScheduleControl), onNavItemClicked, 0), 
                   new NavItemDefine(_KEY_PERSIONAL_SCHEDULE, typeof(PersonalAssignmentScheduleControl), onNavItemClicked, 1)
               }, 1)
           });
       }
    }
}
