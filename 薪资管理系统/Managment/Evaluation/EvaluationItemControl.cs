using System;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
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
            DataRow row = gridView1.GetDataRow(e.RowHandle);
            if(row!=null)
            {
                row["ID"] = Guid.NewGuid().ToString();
                row["VERSION_ID"] = GlobalSettings.EvaluationVersion;
                row["ENABLED"] = true;
            }
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            gridView1.ViewCaption = string.Format("考核项目定义（{0}）", GlobalSettings.EvaluationFullVersion);
            gridControl1.DataSource = DataHolder.EvaluationItem;
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
            DataHolder.EvaluationItem.RowChanged += onRowChanged;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            DataHolder.EvaluationItem.RowChanged += onRowChanged;
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            DataHolder.EvaluationItem.RowChanged -= onRowChanged;
        }

        protected override void onSave()
        {
            if (DBHandlerEx.UpdateOnce(DataHolder.EvaluationItem) >= 0)
            {
                base.onSave();
            }
        }

        protected override void onRevert()
        {
            base.onRevert();
            DataHolder.EvaluationItem.RejectChanges();
        }
    }
}
