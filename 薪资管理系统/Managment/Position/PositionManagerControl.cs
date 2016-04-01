using System;
using System.Data;
using System.Linq;
using DevExpress.XtraEditors;

namespace SalarySystem.Managment.Position
{
    public partial class PositionManagerControl : XtraUserControl
    {
        public PositionManagerControl()
        {
            InitializeComponent();
        }

        private void PostManagerControl_Load(object sender, EventArgs e)
        {
            treeList1.DataSource = DataHolder.DataSet.t_position;
            treeList1.ExpandAll();
        }

        private void position_focused_changed(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                string current= e.Node.GetValue("ID") as string;
                employeeListControl1.CurrentPosition = current;
            }
        }
    }
}
