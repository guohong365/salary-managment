using System.Data;
using System.Diagnostics;

namespace SalarySystem.Managment.Basic
{
    public partial class EvaluationItemControl : DevExpress.XtraEditors.XtraUserControl
    {
        public EvaluationItemControl()
        {
            InitializeComponent();
        }

        private void initNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(e.RowHandle);
            if(row!=null)
            {
                Debug.Assert(GlobalSettings.CurrentEvaluationRepository!=null);
                row["VERSION_ID"] = GlobalSettings.CurrentEvaluationRepository.ID;
            }
        }
    }
}
