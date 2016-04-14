using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraTab;
using SalarySystem.Data;
using UC.Platform.Data;

namespace SalarySystem.Schedule
{
    public partial class AssignmentScheduleControl : BaseEditableControl
    {
        public AssignmentScheduleControl()
        {
            InitializeComponent();
        }

        private DataSetSalary.t_annual_assignmentDataTable annualAssignment =
            new DataSetSalary.t_annual_assignmentDataTable();

        private DataSetSalary.t_assignment_performanceDataTable assignmentPerformance =
            new DataSetSalary.t_assignment_performanceDataTable();

        private const string sqlAnnualAssignemt = "";

        private const string _SQL_ASSIGNMENT_LIST = "select * from v_auto_assignment_list";

        protected override void onControlLoad()
        {
            base.onControlLoad();
            DataTable assignment_list = new DataTable("v_auto_assignment_list");
            DBHandlerEx.FillOnce(assignment_list, _SQL_ASSIGNMENT_LIST);
            assignment_list.Rows.Cast<DataRow>().ToList().ForEach(row =>
            {
                xtraTabControlScheduleItems.TabPages.Clear();
                XtraTabPage page = xtraTabControlScheduleItems.TabPages.Add((string) row["NAME"]);
                ScheduleItemControl control = new ScheduleItemControl()
                {
                    Dock = DockStyle.Fill
                };
                control.SetScheduleItem(2016, (string) row["ASSIGNMENT_ID"]);
                page.Controls.Add(control);
            });
        }
    }
}
