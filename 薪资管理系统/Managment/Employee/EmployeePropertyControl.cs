using System;
using DevExpress.XtraEditors;
using SalarySystem.Utilities;

namespace SalarySystem.Management.Employee
{
    public partial class EmployeePropertyControl : XtraUserControl
    {
        public EmployeePropertyControl()
        {
            InitializeComponent();
        }

        public EditPurpose Purpose { get; set; }
        public IEmployee Employee { get; set; }

        private void fill()
        {
            textBoxId.Text = Employee.Id;
            textBoxName.Text = Employee.Name;
            dateTimePickerEntryTime.EditValue = Employee.EntryTime;
            comboBoxPosition.SelectedItem = Employee.Position;
            comboBoxLeader.SelectedItem = Employee.Leader;
            comboBoxSalaryLevel.SelectedItem = Employee.SalaryLevel;
        }

        private void readonlyAll()
        {
            textBoxId.Properties.ReadOnly = true;
            textBoxName.Properties.ReadOnly = true;
            dateTimePickerEntryTime.Enabled = false;
            comboBoxPosition.Enabled = false;
            comboBoxLeader.Enabled = false;
            comboBoxSalaryLevel.Enabled = false;
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

        public void Retrive()
        {
            Employee.Id = textBoxId.Text.Trim();
            Employee.Name = textBoxName.Text.Trim();
            Employee.Position = comboBoxPosition.SelectedItem as IPosition;
            Employee.Leader = comboBoxLeader.SelectedItem as IEmployee;
            Employee.SalaryLevel = comboBoxSalaryLevel.SelectedItem as ISalaryLevel;
            Employee.EntryTime = dateTimePickerEntryTime.DateTime;

        }

        private void EmployeePropertyControl_Load(object sender, EventArgs e)
        {
            fillPosition();
            switch (Purpose)
            {
                case EditPurpose.FOR_NEW:
                    if (Employee == null)
                    {
                        Employee = new SalarySystem.Employee("","", DateTime.Now, null, null);
                    }
                    break;
                case EditPurpose.FOR_EDIT:
                    if (Employee == null)
                    {
                        throw new Exception("null employee");
                    }
                    fill();
                    break;
                case EditPurpose.FOR_VIEW:
                    fill();
                    readonlyAll();
                    break;
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

    }
}
