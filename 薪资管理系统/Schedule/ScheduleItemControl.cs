using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SalarySystem.Schedule
{
    public partial class ScheduleItemControl : DevExpress.XtraEditors.XtraUserControl
    {
        private AnnualSchedule _annualSchedule=new AnnualSchedule();
        public ScheduleItemControl()
        {
            InitializeComponent();
            vGridControl1.DataSource =new[]{_annualSchedule};
            vGridControl2.DataSource = _annualSchedule.MonthValues;
        }

    }
}
