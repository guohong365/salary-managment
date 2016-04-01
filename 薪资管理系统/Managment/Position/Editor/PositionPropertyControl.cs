using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using SalarySystem.Data;
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

        protected PositionPropertyControl(DataRow position, int editType)
            :base(position, editType)
        {
        }

        private void PositionPropertyControl_FillControls(int type, DataRow row)
        {
            DataSetSalary.t_positionRow position = row as DataSetSalary.t_positionRow;
            Debug.Assert(position != null, "position != null");
            lookUpEditLeaderPosition.EditValue = position.ID;
        }

        private void PositionPropertyControl_Retrive(ref DataRow item)
        {
            DataSetSalary.t_positionRow position = item as DataSetSalary.t_positionRow;
            Debug.Assert(position != null, "position != null");
            position.LEADER_ID=lookUpEditLeaderPosition.EditValue as string;
        }
    }
}
