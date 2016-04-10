using DevExpress.XtraEditors;
using SalarySystem.Managment.Basic;

namespace SalarySystem.Managment
{

    public partial class BasicDefineControl : XtraUserControl
    {
        private readonly DefineControlManager _manager;
        public BasicDefineControl()
        {
            InitializeComponent();
            _manager=new DefineControlManager(splitContainerControl1.Panel2, navBarControl1);
            _manager.InitNavBar();
        }
        public DefineControlManager Manager{get { return _manager; }}
    }
}
