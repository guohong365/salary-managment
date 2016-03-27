using System;
using System.ComponentModel;
using SalarySystem.Core;
using SalarySystem.Managment.Editor;
using SalarySystem.Utilities;

namespace SalarySystem.Managment.Employee.Editor
{
    public partial class EmployeePropertyControl : ItemControl
    {
        private class EditorFactory :IItemEditorFactory
        {
            public ItemControl CreateEditorControl(IItem item, int editType)
            {
                return new EmployeePropertyControl(item as SalarySystem.Employee, editType);
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

        protected EmployeePropertyControl(SalarySystem.Employee employee, int editType)
            :base(employee, editType)
        {
            InitializeComponent();
            dateEditDismissionTime.Properties.NullDate = DateTime.MinValue;
        }

        private void readonlyAll()
        {
            dateTimePickerEntryTime.Properties.ReadOnly = true;
            comboBoxPosition.Properties.ReadOnly = true;
            comboBoxLeader.Properties.ReadOnly = true;
            comboBoxSalaryLevel.Properties.ReadOnly = true;
            dateEditDismissionTime.Properties.ReadOnly = true;
        }

        void fillLeader(string leaderPositionId)
        {
            comboBoxLeader.Properties.Items.Clear();
            comboBoxLeader.Properties.Items.AddRange(DataHolder.Employees.FindAll(item=>item.Position!=null && item.Position.Id==leaderPositionId).ToArray());
        }

        void fillPosition()
        {
            comboBoxPosition.Properties.Items.AddRange(DataHolder.Positions.ToArray());
        }

        void fillSalayLevel(string positionId)
        {
            comboBoxSalaryLevel.Properties.Items.Clear();
            comboBoxSalaryLevel.Properties.Items.AddRange(DataHolder.SalaryLevels.FindAll(item=>item.Position!=null && item.Position.Id==positionId).ToArray());
        }

        private void EmployeePropertyControl_Load(object sender, EventArgs e)
        {
            fillPosition();
            if (EditType == (int) EditPurpose.FOR_VIEW)
            {
                readonlyAll();
            }
        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPosition.SelectedItem != null)
            {
                SalarySystem.Position position = comboBoxPosition.SelectedItem as SalarySystem.Position;
                if (position != null)
                {
                    if (position.LeaderPosition != null)
                    {
                        fillLeader(position.LeaderPosition.Id);
                    }
                    fillSalayLevel(position.Id);
                }
            }
        }

        private void EmployeePropertyControl_FillControls(int type, IItem item)
        {
            SalarySystem.Employee employee = (SalarySystem.Employee) item;
            dateTimePickerEntryTime.EditValue = employee.EntryTime;
            comboBoxPosition.SelectedItem = employee.Position;
            comboBoxLeader.SelectedItem = employee.Leader;
            comboBoxSalaryLevel.SelectedItem = employee.SalaryLevel;
            dateEditDismissionTime.EditValue = employee.DimissionTime;
        }

        private void EmployeePropertyControl_Retrive(ref IItem item)
        {
            SalarySystem.Employee employee = (SalarySystem.Employee) item;
            employee.EntryTime = dateTimePickerEntryTime.DateTime;
            employee.Position = (IPosition) comboBoxPosition.SelectedItem;
            employee.Leader = (IEmployee) comboBoxLeader.SelectedItem;
            employee.SalaryLevel = (ISalaryLevel) comboBoxSalaryLevel.SelectedItem;
            employee.DimissionTime = dateEditDismissionTime.DateTime;
        }

    }
}
