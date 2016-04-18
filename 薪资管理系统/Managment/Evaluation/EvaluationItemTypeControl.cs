using System;
using UC.Platform.Data;

namespace SalarySystem.Managment.Evaluation
{
    public partial class EvaluationItemTypeControl : BaseEditableControl
    {
        public EvaluationItemTypeControl()
        {
            InitializeComponent();
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            DataHolder.EvaluationItemType.RowChanged += onRowChanged;
            gridControlEvaluationType.DataSource = DataHolder.EvaluationItemType;
            gridViewEvaluationType.CustomDrawCell += GridViewHelper.GerneralCustomCellDrawHandler;
            gridViewEvaluationType.InitNewRow += initNewRow;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            DataHolder.EvaluationItemType.RowChanged += onRowChanged;
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            DataHolder.EvaluationItemType.RowChanged -= onRowChanged;
        }

        protected override void onSave()
        {
            if (DBHandlerEx.UpdateOnce(DataHolder.EvaluationItemType) >= 0)
            {
                base.onSave();
            }
            
        }

        protected override void onRevert()
        {
            base.onRevert();
            DataHolder.EvaluationItemType.RejectChanges();
        }

        
        //private void close_Click(object sender, EventArgs e)
        //{
        //    if (Visible)
        //    {
        //        gridControlEvaluationType.RefreshDataSource();
        //        return;
        //    }
        //    if (DataHolder.DataSet.t_evaluation_item_type.All(item => item.RowState == DataRowState.Unchanged)) return;
        //    if (
        //        MessageBox.Show("数据已修改，是否保存？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
        //            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        //    {
        //        DBHandlerEx.UpdateOnce(DataHolder.EvaluationItemType);
        //    }
        //    else
        //    {
        //        DataHolder.DataSet.t_evaluation_item_type.RejectChanges();
        //    }
        //}

        private void initNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var row = gridViewEvaluationType.GetDataRow(e.RowHandle);
            row["ID"] = Guid.NewGuid().ToString();
            row["ENABLED"] = true;
        }
    }
}
