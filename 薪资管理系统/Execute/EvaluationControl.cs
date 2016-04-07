using SalarySystem.Managment.Basic;

namespace SalarySystem.Execute
{
    public partial class ExecutionControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ExecutionControlManager _manager;
        protected ExecutionControlManager Manager{get { return _manager; }}
        public ExecutionControl()
        {
            InitializeComponent();
            _manager=new ExecutionControlManager(splitContainerControl1.Panel2, navBarControl1);
            _manager.InitNavBar();
        }
    }
}
