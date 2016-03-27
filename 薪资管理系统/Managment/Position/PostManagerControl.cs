using DevExpress.XtraEditors;

namespace SalarySystem.Management.Position
{
    public partial class PostManagerControl : XtraUserControl
    {
        public PostManagerControl()
        {
            InitializeComponent();
        }

        private void PostManagerControl_Load(object sender, System.EventArgs e)
        {
            treeList1.DataSource = DataHolder.Positions;
        }
    }
}
