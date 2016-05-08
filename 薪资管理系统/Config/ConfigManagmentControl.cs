using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using SalarySystem.Schedule;
using UC.Platform.UI;

namespace SalarySystem.Config
{
    public partial class ConfigManagmentControl : XtraUserControl
    {
        private readonly ConfigControlManager _configControlManager;
        public ConfigManagmentControl()
        {
            InitializeComponent();
            _configControlManager = new ConfigControlManager(splitContainerControl1.Panel2, navBarControl1);
            _configControlManager.InitNavBar();
        }
        protected ConfigControlManager NavBarManager{ get { return _configControlManager; }}

        protected class ConfigControlManager : NavBarControlManagerBase
        {
            private const string _KEY_GROUP_SYSTEM_CONFIG = "系统配置";
            private const string _KEY_GROUP_APPLICATION_CONFIG = "业务配置";

            private const string _KEY_ITEM_DEFAULT_ASSIGNMENT_SCHEDULE_WEIGHT = "自动分配任务默认占比";

            internal ConfigControlManager(Control container, NavBarControl navBarControl) : base(container, navBarControl)
            {
                NavGroupDefines.AddRange(new []
                {
                    new NavGroupDefine(_KEY_GROUP_SYSTEM_CONFIG, new INavItemDefine[]{}, 0),
                    new NavGroupDefine(_KEY_GROUP_APPLICATION_CONFIG, new []
                    {
                        new NavItemDefine(_KEY_ITEM_DEFAULT_ASSIGNMENT_SCHEDULE_WEIGHT, typeof(AutoAssignmentWeightControl), onNavItemClicked, 0), 
                    }, 1), 
                });
            }
        }
    }
}
