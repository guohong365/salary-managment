using DevExpress.XtraEditors;
using SalarySystem.Data;
using SalarySystem.Data.SalaryDataSetTableAdapters;

namespace SalarySystem.Managment.Position
{
    public partial class PositionManagerControl : XtraUserControl
    {
        public PositionManagerControl()
        {
            InitializeComponent();
        }

        private void PostManagerControl_Load(object sender, System.EventArgs e)
        {
            treeList1.DataSource = DataHolder.DataSet;
            treeList1.ExpandAll();
        }

        private void selected_position_changed(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                SalaryDataSet.t_positionRow currentRow = e.Node.Tag as SalaryDataSet.t_positionRow;
                if (currentRow != null)
                {
                    DataHolder.AdapterManager.t_employeeTableAdapter.Fill(DataHolder.DataSet.t_employee, currentRow.ID);
                }
            }
        }
    }
}
