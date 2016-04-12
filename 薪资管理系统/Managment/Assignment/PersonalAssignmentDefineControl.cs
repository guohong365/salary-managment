using System.Data;
using SalarySystem.Data;
using SalarySystem.Managment.Basic;
using UC.Platform.Data.DBHelper;


namespace SalarySystem.Managment.Assignment
{
    public partial class PersonalAssignmentDefineControl : BaseControl
    {
        public PersonalAssignmentDefineControl()
        {
            InitializeComponent();
            GridViewHelper.SetUpEditableGridView(gridView1, false, "岗位任务定义", VersionType.ASSIGNMENT);
        }

        private readonly DataSetSalary.v_personal_assignment_detailDataTable _dataTable =
            new DataSetSalary.v_personal_assignment_detailDataTable();

        private DataView _dataView;
        readonly string _sql = string.Format("select * from v_personal_assignment_detail where VERSION_ID='{0}'", GlobalSettings.AssignmentVersion);
        protected override void onControlLoad()
        {
            base.onControlLoad();
            
            DBHandlerEx.FillOnce(_dataTable, _sql);
            _dataView=new DataView(_dataTable);
            _dataTable.RowChanged += onRowChanged;

            repositoryItemLookUpEditType.DataSource = DataHolder.AssignmentItemType;
            repositoryItemLookUpEditUnit.DataSource = DataHolder.Unit;
            repositoryItemLookUpEditPosition.DataSource = DataHolder.Position;

            gridControl1.DataSource = _dataView;

        }

        protected override void onControlReload()
        {
            base.onControlReload();
            _dataTable.Clear();
            DBHandlerEx.FillOnce(_dataTable, _sql);
            _dataTable.RowChanged += onRowChanged;
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _dataTable.RowChanged -= onRowChanged;
        }

        protected override void onSave()
        {
            base.onSave();
            foreach (DataSetSalary.v_personal_assignment_detailRow detailRow in _dataTable)
            {
                DataSetSalary.t_position_assignmentsRow row =
                    DataHolder.PositionAssignments.FindByASSIGNMENT_IDPOSITION_ID(detailRow.DEFINE_ID, detailRow.ID);
                if (row != null)
                {
                    row.ENABLED = detailRow.USED;
                    row.WEIGHT = 100;
                    row.VALUE = detailRow.VALUE;
                }
                else
                {
                    row = DataHolder.PositionAssignments.Newt_position_assignmentsRow();
                    row.ASSIGNMENT_ID = detailRow.DEFINE_ID;
                    row.POSITION_ID = detailRow.ID;
                    row.ENABLED = detailRow.USED;
                    row.WEIGHT = 100;
                    row.VALUE = detailRow.VALUE;
                    row.VERSION_ID = detailRow.VERSION_ID;
                    DataHolder.PositionAssignments.Addt_position_assignmentsRow(row);
                }
            }
            DBHandlerEx.UpdateOnce(DataHolder.PositionAssignments);
            _dataTable.AcceptChanges();
        }

        protected override void onRevert()
        {
            base.onRevert();
            _dataTable.RejectChanges();
        }
    }
}
