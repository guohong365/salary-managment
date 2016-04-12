using System.Data;
using SalarySystem.Data;
using SalarySystem.Managment.Basic;
using UC.Platform.Data.DBHelper;


namespace SalarySystem.Managment.Assignment
{
    public partial class TeamAssignmentControl : BaseControl
    {
        public TeamAssignmentControl()
        {
            InitializeComponent();
        }

        private DataSetSalary.v_team_assignment_detailDataTable _dataView;
        protected override void onControlLoad()
        {
            base.onControlLoad();
            _dataView=new DataSetSalary.v_team_assignment_detailDataTable();
            DBHandlerEx.FillOnce(_dataView, "select * from v_team_assignment_detail");
            treeList1.DataSource = _dataView;
            treeList1.ExpandAll();
            _dataView.RowChanged += onRowChanged;
            repositoryItemLookUpEdit1.DataSource = DataHolder.Position;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            _dataView.RowChanged += onRowChanged;
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _dataView.RowChanged -= onRowChanged;
        }
    }
}
