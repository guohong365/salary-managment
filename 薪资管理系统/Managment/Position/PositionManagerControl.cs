using DevExpress.XtraEditors;

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
            gridControlPosition.DataSource = DataHolder.Positions;
            
        }
    }
}
