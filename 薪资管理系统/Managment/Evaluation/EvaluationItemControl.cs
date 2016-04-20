using System;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using SalarySystem.Data;
using UC.Platform.Data;

namespace SalarySystem.Managment.Evaluation
{
    public partial class EvaluationItemControl : BaseEditableControl
    {
        public EvaluationItemControl()
        {
            InitializeComponent();
            
        }

        private void initNewRow(object sender, InitNewRowEventArgs e)
        {
            var row = gridView1.GetDataRow(e.RowHandle) as DataSetSalary.t_evaluation_itemRow;
            if(row!=null)
            {
                row.ID = Guid.NewGuid().ToString();
                row.VERSION_ID = GlobalSettings.EvaluationVersion;
                row.ENABLED = true;
            }
        }

        private readonly DataSetSalary.t_evaluation_itemDataTable _evaluationItem = new DataSetSalary.t_evaluation_itemDataTable();

        private const string _EVALUATION_ITEM_SQL_FORMAT =
            "select * from t_evaluation_item where VERSION_ID='{0}'";

        void loadEvaluationItem()
        {
            _evaluationItem.Clear();
            string sql = string.Format(_EVALUATION_ITEM_SQL_FORMAT, GlobalSettings.EvaluationVersion);
            if (DBHandlerEx.FillOnce(_evaluationItem, sql) < 0)
            {
                throw  new Exception("load failed.");
            }
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            gridView1.ViewCaption = string.Format("考核项目定义（{0}）", GlobalSettings.EvaluationFullVersion);
            loadEvaluationItem();
            gridControl1.DataSource =_evaluationItem;
            var dataView = new DataView(DataHolder.EvaluationItemType)
            {
                RowFilter = "[ENABLED]=true"
            };
            repositoryItemLookUpEditType.DataSource = dataView;
            dataView = new DataView(DataHolder.Position) { RowFilter = "ENABLED=true" };
            repositoryItemLookUpEditPosition.DataSource = dataView;
            gridView1.ExpandAllGroups();
            gridView1.CustomDrawCell += GridViewHelper.GerneralCustomCellDrawHandler;
            gridView1.InitNewRow += initNewRow;
            _evaluationItem.RowChanged += onRowChanged;
        }
        
        protected override void onSave()
        {
            if (DBHandlerEx.UpdateOnce(_evaluationItem) >= 0)
            {
                base.onSave();
            }
        }

        protected override void onRevert()
        {
            base.onRevert();
            _evaluationItem.RejectChanges();
        }
    }
}
