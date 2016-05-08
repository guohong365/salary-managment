using System;
using System.Data;
using System.Linq;
using SalarySystem.Data;
using UC.Platform.Data;
using UC.Platform.UI;


namespace SalarySystem.Managment.Assignment
{
    public partial class PersonalAssignmentDefineControl : BaseEditableControl
    {
      private readonly CheckedAllGridViewHelper _checkedAllGridView=new CheckedAllGridViewHelper();
        public PersonalAssignmentDefineControl()
        {
            InitializeComponent();
            //GridViewHelper.SetUpEditableGridView(gridViewPersionalAssignment, false, "岗位任务定义", VersionType.ASSIGNMENT);
          _checkedAllGridView.BindToView(gridViewPersonalAssignment, colUSED);
        }

        private readonly DataSetSalary.v_personal_assignment_detailDataTable _personalAssignmentDetail =
            new DataSetSalary.v_personal_assignment_detailDataTable();

        private DataView _dataView;

 private const string _PERSONAL_ASSIGNMENT_SQL_FORMAT =
            "select * from v_personal_assignment_detail where VERSION_ID='{0}'";

        void loadData()
        {
            _personalAssignmentDetail.Clear();
            string sql = getLoadSql();
            if (DBHandlerEx.FillOnce(_personalAssignmentDetail, sql) < 0)
            {
                throw new Exception("load data failed");
            }
        }
        protected override void onControlLoad()
        {
            base.onControlLoad();
            loadData();
            _dataView=new DataView(_personalAssignmentDetail);
            _personalAssignmentDetail.RowChanged += onRowChanged;
          _checkedAllGridView.GetCheckedCount += getCheckCount;
            repositoryItemLookUpEditItemType.DataSource = DataHolder.AssignmentItemType;

            //repositoryItemLookUpEditType.DataSource = DataHolder.AssignmentItemType;
            repositoryItemLookUpEditUnit.DataSource = DataHolder.Unit;
            repositoryItemLookUpEditPosition.DataSource = DataHolder.Position;

            gridControlPersonalAssignment.DataSource = _dataView;
            gridViewPersonalAssignment.CustomDrawCell += GridViewHelper.CustomModifiedCellDrawHandler;
        }

      private int getCheckCount(object sender)
      {
        return _personalAssignmentDetail.Count(item => item.USED);
      }

      static string getLoadSql()
        {
            return string.Format(_PERSONAL_ASSIGNMENT_SQL_FORMAT, GlobalSettings.AssignmentVersion);
        }
        protected override void onControlReload()
        {
            base.onControlReload();
           loadData();
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
            DataSetSalary.t_position_assignmentsDataTable positionAssignments = new DataSetSalary.t_position_assignmentsDataTable();
            if (DBHandlerEx.FillOnce(positionAssignments,
                string.Format("select * from t_position_assignments where VERSION_ID={0}",
                    GlobalSettings.AssignmentVersion)) < 0)
            {
                throw new Exception("load positionAssignments failed.");
            }
            foreach (DataSetSalary.v_personal_assignment_detailRow detailRow in _personalAssignmentDetail)
            {
                DataSetSalary.t_position_assignmentsRow row = positionAssignments.FindByASSIGNMENT_IDPOSITION_ID(detailRow.DEFINE_ID, detailRow.ID);
                if (row != null)
                {
                    row.ENABLED = detailRow.USED;
                    row.WEIGHT = 100;
                    row.VALUE = detailRow.VALUE;
                }
                else
                {
                    row = positionAssignments.Newt_position_assignmentsRow();
                    row.ASSIGNMENT_ID = detailRow.DEFINE_ID;
                    row.POSITION_ID = detailRow.ID;
                    row.ENABLED = detailRow.USED;
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
