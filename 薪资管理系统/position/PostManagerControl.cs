using DevExpress.XtraEditors;

namespace salary.main.position
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
