using System;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using SalarySystem.Data;
using UC.Platform.Data;
using UC.Platform.UI;

namespace SalarySystem.Definition.Assignment
{
    public partial class AssignmentDefineControl : BaseEditableControl
    {
        public AssignmentDefineControl()
        {
            InitializeComponent();

        }

        private DataView _itemView;
        readonly DataSetSalary.t_assignment_defineDataTable _assignmentDefine=new DataSetSalary.t_assignment_defineDataTable();
        private const string _ASSGINMENT_DEFINE_SQL_FORMAT = "select * from t_assignment_define where VERSION_ID='{0}'";
        void loadAssignmentDefine()
        {
            string sql = string.Format(_ASSGINMENT_DEFINE_SQL_FORMAT, GlobalSettings.AssignmentVersion);
            if (DBHandlerEx.FillOnce(_assignmentDefine, sql) < 0)
            {
                throw new Exception();
            }

        }
        protected override void onControlLoad()
        {
            base.onControlLoad();
            loadAssignmentDefine();
            GridViewHelper.SetUpEditableGridView(gridViewDetails, false, "任务指标定义", GlobalSettings.AssignmentVersion);
            _itemView = new DataView(_assignmentDefine);
            gridControlDetail.DataSource = _itemView;
            repositoryItemLookUpEditType.DataSource = new DataView(DataHolder.AssignmentItemType);
            repositoryItemLookUpEditUnit.DataSource = new DataView(DataHolder.Unit);
            repositoryItemLookUpEditPosition.DataSource = new DataView(DataHolder.Position);
            gridViewDetails.InitNewRow += initNewRow;
            gridViewDetails.ExpandAllGroups();
            _assignmentDefine.RowChanged += rowChanged;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            _assignmentDefine.RowChanged += rowChanged;
            gridViewDetails.ExpandAllGroups();
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _assignmentDefine.RowChanged -= rowChanged;
        }

        protected override void onSave()
        {
            if (DBHandlerEx.UpdateOnce(_assignmentDefine) <= 0) return;
            _assignmentDefine.AcceptChanges();
            base.onSave();
        }

        protected override void onRevert()
        {
            base.onRevert();
            _assignmentDefine.RejectChanges();
        }

        private void rowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add || e.Action == DataRowAction.Change || e.Action == DataRowAction.Delete)
            {
                EnableSave(true);
                EnableRevert(true);
                CanClose = false;
            }
        }

        private void initNewRow(object sender, InitNewRowEventArgs e)
        {
            DataSetSalary.t_assignment_defineRow row = gridViewDetails.GetDataRow(e.RowHandle) as DataSetSalary.t_assignment_defineRow;
            if (row == null) return;
            row.ID = Guid.NewGuid().ToString();
            row.ENABLED = true;
            row.VERSION_ID= GlobalSettings.AssignmentVersion;
            row.DEFAULT_VALUE = 0;
        }
    }
}
