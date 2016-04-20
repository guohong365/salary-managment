using System.Drawing;
using DevExpress.XtraEditors;
using SalarySystem.Data;

namespace SalarySystem.Schedule
{
    public partial class PersonalMonthlyAssignmentScheduleControl : XtraUserControl
    {
        public PersonalMonthlyAssignmentScheduleControl()
        {
            InitializeComponent();
            repositoryItemLookUpEditUnit.DataSource = DataHolder.Unit;
            repositoryItemLookUpEditType.DataSource = DataHolder.AssignmentItemType;
        }

        private DataSetSalary.v_personal_assignment_scheduleDataTable _dataTable;
        public DataSetSalary.v_personal_assignment_scheduleDataTable DataTable
        {
            get
            {
                return _dataTable;
            }
            set
            {
                _dataTable = value;
                gridControl1.DataSource = value;
            }
        }

        private void customDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            var row = gridView1.GetDataRow(e.RowHandle) as DataSetSalary.v_personal_assignment_scheduleRow;
            if (row==null) return;

            if (!row.IsPERF_IDNull())
            {
                e.Appearance.ForeColor = Color.Teal;
            }
            GridViewHelper.GerneralCustomCellDrawHandler(sender, e);
        }
    }
}
