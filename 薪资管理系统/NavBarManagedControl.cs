using DevExpress.XtraEditors;

namespace SalarySystem
{
    public partial class NavBarManagedControl : XtraUserControl
    {
        protected readonly INavBarContorlManager Manager;
        public NavBarManagedControl()
        {
            InitializeComponent();
        }

        public NavBarManagedControl(INavBarContorlManager manager)
        {
            InitializeComponent();
            Manager = manager;
            if (Manager == null) return;
            Manager.ContainerControl = splitContainerControl1.Panel2;
            Manager.NavBarControl = navBarControl1;
            Manager.InitNavBar();
        }

    }
}
