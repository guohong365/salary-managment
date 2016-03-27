using System.ComponentModel;
using SalarySystem.Managment.Editor;

namespace SalarySystem.Managment.Position.Editor
{
    public partial class PositionPropertyControl : ItemControl
    {
        [DesignOnly(true)]
        public PositionPropertyControl()
        {
            InitializeComponent();
        }

        protected PositionPropertyControl(IPosition position, int editType)
            :base(position, editType)
        {
        }

        private void PositionPropertyControl_FillControls(int type, Core.IItem item)
        {
            IPosition position = (IPosition) item;
            comboBoxEditLeaderPosition.SelectedItem = position.LeaderPosition;
        }

        private void PositionPropertyControl_Retrive(ref Core.IItem item)
        {
            IPosition position = (IPosition) item;
            position.LeaderPosition = position.LeaderPosition;
        }
    }
}
