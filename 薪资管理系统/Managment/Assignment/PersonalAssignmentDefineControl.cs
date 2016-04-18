using System;
using System.Data;
using SalarySystem.Data;
using UC.Platform.Data;


namespace SalarySystem.Managment.Assignment
{
    public partial class PersonalAssignmentDefineControl : BaseEditableControl
    {
        public PersonalAssignmentDefineControl()
        {
            InitializeComponent();
            GridViewHelper.SetUpEditableGridView(gridView1, false, "岗位任务定义", VersionType.ASSIGNMENT);
        }

        private readonly DataSetSalary.v_personal_assignment_detailDataTable _personalAssignmentDetail =
            new DataSetSalary.v_personal_assignment_detailDataTable();

        private DataView _dataView;

        private const string _PERSONAL_ASSIGNMENT_SQL_FORMAT =
            "select * from v_personal_assignment_detail where VERSION_ID='{0}'";
        protected override void onControlLoad()
        {
            base.onControlLoad();
            string sql = getLoadSql();
            if (DBHandlerEx.FillOnce(_personalAssignmentDetail, sql) < 0)
            {
                throw new Exception("load data failed");
            }
            _dataView=new DataView(_personalAssignmentDetail);
            _personalAssignmentDetail.RowChanged += onRowChanged;

            repositoryItemLookUpEditType.DataSource = DataHolder.AssignmentItemType;
            repositoryItemLookUpEditUnit.DataSource = DataHolder.Unit;
            repositoryItemLookUpEditPosition.DataSource = DataHolder.Position;

            gridControl1.DataSource = _dataView;

        }

        static string getLoadSql()
        {
            return string.Format(_PERSONAL_ASSIGNMENT_SQL_FORMAT, GlobalSettings.AssignmentVersion);
        }
        protected override void onControlReload()
        {
            base.onControlReload();
            _personalAssignmentDetail.Clear();

            DBHandlerEx.FillOnce(_personalAssignmentDetail, getLoadSql());
            _personalAssignmentDetail.RowChanged += onRowChanged;
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _personalAssignmentDetail.RowChanged -= onRowChanged;
        }


        protected override void onSave()
        {
            base.onSave();
            var positionAssignments=new DataSetSalary.t_position_assignmentsDataTable();
            if (DBHandlerEx.FillOnce(positionAssignments,
                string.Format("select * from t_position_assignments where VERSION_ID={0}",
                    GlobalSettings.AssignmentVersion)) < 0)
            {
                throw new Exception("load positionAssignments failed.");
            }
            foreach (var detailRow in _personalAssignmentDetail)
            {
                var row =positionAssignments.FindByASSIGNMENT_IDPOSITION_ID(detailRow.DEFINE_ID, detailRow.ID);
                if (row != null)
                {
                    row.ENABLED = detailRow.USED!=0;
                    row.WEIGHT = 100;
                    row.VALUE = detailRow.VALUE;
                }
                else
                {
                    row = positionAssignments.Newt_position_assignmentsRow();
                    row.ASSIGNMENT_ID = detailRow.DEFINE_ID;
                    row.POSITION_ID = detailRow.ID;
                    row.ENABLED = detailRow.USED!=0;
                    row.WEIGHT = 100;
                    row.VALUE = detailRow.VALUE;
                    row.VERSION_ID = detailRow.VERSION_ID;
                    positionAssignments.Addt_position_assignmentsRow(row);
                }
            }
            if (DBHandlerEx.UpdateOnce(positionAssignments) < 0)
            {
                throw new Exception("save positionAssignments failed.");
            }
            _personalAssignmentDetail.AcceptChanges();
        }

        protected override void onRevert()
        {
            base.onRevert();
            _personalAssignmentDetail.RejectChanges();
        }
    }
}
