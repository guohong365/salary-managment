using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using SalarySystem.Data;
using SalarySystem.Managment.Editor;

namespace SalarySystem.Managment.Employee.Editor
{
    public partial class EmployeePropertyControl : ItemControl
    {
        private class EditorFactory :IItemEditorFactory
        {
            public ItemControl CreateEditorControl(DataRow item, int editType)
            {
                return new EmployeePropertyControl(item, editType);
            }
        }
        public new static IItemEditorFactory GetFactory()
        {
            return new EditorFactory();
        }

        [DesignOnly(true)]
        public EmployeePropertyControl()
        {
            InitializeComponent();
            dateEditDismissionTime.Properties.NullDate = DateTime.MinValue;
        }

        protected EmployeePropertyControl(DataRow employeeRow, int editType)
            :base(employeeRow, editType)
        {
            InitializeComponent();
            dateEditDismissionTime.Properties.NullDate = DateTime.MinValue;
            lookUpEditPosition.Properties.DataSource = Enumerable.Where(DataHolder.DataSet.t_position, item => item.ENABLED);
        }

        private void readonlyAll()
        {
            dateTimePickerEntryTime.Properties.ReadOnly = true;
            lookUpEditPosition.Properties.ReadOnly = true;
            lookUpEditLeader.Properties.ReadOnly = true;
            dateEditDismissionTime.Properties.ReadOnly = true;
        }
        void fillPosition()
        {
            lookUpEditPosition.Properties.DataSource = Enumerable.Where(DataHolder.DataSet.t_position, item => item.ENABLED);
        }

        private void EmployeePropertyControl_Load(object sender, EventArgs e)
        {
            fillPosition();
            if (EditType == (int) EditPurpose.FOR_VIEW)
            {
                readonlyAll();
            }
        }

        private void EmployeePropertyControl_FillControls(int type, DataRow row)
        {
            DataSetSalary.t_employeeRow employee = row as DataSetSalary.t_employeeRow;
            Debug.Assert(employee != null, "employee != null");
            dateTimePickerEntryTime.EditValue = employee.ENTRY_TIME;
            lookUpEditPosition.EditValue = employee.POSITION_ID;
            lookUpEditLeader.EditValue = employee.LEADER_ID;
            dateEditDismissionTime.EditValue = employee.DISMISSION_TIME;
        }

        private void EmployeePropertyControl_Retrive(ref DataRow row)
        {
            DataSetSalary.t_employeeRow employee = row as DataSetSalary.t_employeeRow;
            Debug.Assert(employee != null, "employee != null");
            employee.ENTRY_TIME = dateTimePickerEntryTime.DateTime;
            employee.POSITION_ID = lookUpEditPosition.EditValue as string;
            employee.LEADER_ID = lookUpEditLeader.EditValue as string;
            employee.DISMISSION_TIME = dateEditDismissionTime.DateTime;
        }

        private void lookUpEditPosition_EditValueChanged(object sender, EventArgs e)
        {
            string positionId = lookUpEditPosition.EditValue as string;
            if (positionId != null)
            {
                string leaderId = DataHolder.DataSet.t_position.FindByID(positionId).LEADER_ID;
                lookUpEditLeader.Properties.DataSource =
                    Enumerable.Where(DataHolder.DataSet.t_employee, item => item.ENABLED && item.POSITION_ID == leaderId);
            }
        }

    }
}
