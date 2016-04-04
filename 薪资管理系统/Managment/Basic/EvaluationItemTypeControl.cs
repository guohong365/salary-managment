using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SalarySystem.Managment.Basic
{
    public partial class EvaluationItemTypeControl : DevExpress.XtraEditors.XtraUserControl
    {
        public EvaluationItemTypeControl()
        {
            InitializeComponent();
            gridControlEvaluationType.DataSource = DataHolder.DataSet.t_evaluation_item_type;
            gridViewEvaluationType.CustomDrawCell += GridViewHelper.GerneralCustomCellDrawHandler;
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataHolder.AdapterManager.t_evaluation_item_typeTableAdapter.Update(
                DataHolder.DataSet.t_evaluation_item_type);
        }
        private void abandon_Click(object sender, EventArgs e)
        {
            DataHolder.DataSet.t_evaluation_item_type.RejectChanges();
            gridControlEvaluationType.RefreshDataSource();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (Visible)
            {
                gridControlEvaluationType.RefreshDataSource();
                return;
            }
            if (DataHolder.DataSet.t_evaluation_item_type.All(item => item.RowState == DataRowState.Unchanged)) return;
            if (
                MessageBox.Show("数据已修改，是否保存？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DataHolder.AdapterManager.t_evaluation_item_typeTableAdapter.Update(
                    DataHolder.DataSet.t_evaluation_item_type);
            }
            else
            {
                DataHolder.DataSet.t_evaluation_item_type.RejectChanges();
            }
        }

        private void initNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var row = gridViewEvaluationType.GetDataRow(e.RowHandle);
            row["ID"] = Guid.NewGuid().ToString();
            row["ENABLED"] = true;
        }
    }
}
