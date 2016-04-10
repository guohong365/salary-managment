using System.Data;
using Platform.DBHelper;
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
            _manager = new ExecutionControlManager(splitContainerControl1.Panel2, navBarControl1);
            _manager.InitNavBar();
        }
        private void ok(){
        DataTable dataTable = new DataTable();
            DBHandler.FillOnce(dataTable, string.Format(
                "select distinct FORM_ID, FORM_NAME " +
                "from v_evaluation_result_detail " +
                "where POSITION_ID='{0}'",""));
        }
    }
}
