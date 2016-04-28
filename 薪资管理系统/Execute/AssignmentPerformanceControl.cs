namespace SalarySystem.Execute
{
    public partial class AssignmentPerformanceControl : DevExpress.XtraEditors.XtraUserControl
    {
        public AssignmentPerformanceControl()
        {
            InitializeComponent();
            gridView1.CustomDrawCell += GridViewHelper.GerneralCustomCellDrawHandler;
        }

        private EmployeePerformance _employeePerformance;

        public EmployeePerformance EmployeePerformance
        {
            get { return _employeePerformance; }
            set
            {
                _employeePerformance = value;
                onEmployeePerformanceChanged();
            }
        }

        private void onEmployeePerformanceChanged()
        {
            gridControl1.DataSource = _employeePerformance.AssignmentPerformance;
        }
    }
}
