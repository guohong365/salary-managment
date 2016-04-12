using System.Data;
using SalarySystem.Managment.Basic;


namespace SalarySystem.Managment.Assignment
{
    public partial class PositionAssignmentDefineControl : BaseControl
    {
        public PositionAssignmentDefineControl()
        {
            InitializeComponent();
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            treeListPosition.DataSource = new DataView(DataHolder.Position) {RowFilter = "[ENABLED]=true"};

        }
    }
}
