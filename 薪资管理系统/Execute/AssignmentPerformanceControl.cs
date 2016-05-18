using System;
using SalarySystem.Data;
using UC.Platform.Data;
using UC.Platform.UI;

namespace SalarySystem.Execute
{
    public partial class AssignmentPerformanceControl : DevExpress.XtraEditors.XtraUserControl
    {
        public AssignmentPerformanceControl()
        {
            InitializeComponent();
          this.Load += controlLoad;
            
        }

      private void controlLoad(object sender, EventArgs e)
      {
        if(DesignMode) return;
        gridView1.CustomDrawCell += GridViewHelper.CustomModifiedCellDrawHandler;
        repositoryItemLookUpEditUnit.DataSource = DataHolder.Unit;
        repositoryItemLookUpEditType.DataSource = DataHolder.AssignmentItemType;
        loadAssignmentDefine();
        repositoryItemLookUpEditDefine.DataSource = _assignmentDefine;
      }


      readonly DataSetSalary.t_assignment_defineDataTable _assignmentDefine=new DataSetSalary.t_assignment_defineDataTable();

        void loadAssignmentDefine()
        {
            DBHandlerEx handler = DBHandlerEx.GetBuffer();
            try
            {
                handler.Fill(_assignmentDefine,
                    string.Format("select * from t_assignment_define where VERSION_ID='{0}'",
                        GlobalSettings.AssignmentVersion));
            }
            finally
            {
                handler.FreeBuffer();
            }
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
            gridControl1.DataSource = _employeePerformance == null ? null : _employeePerformance.AssignmentPerformance;
        }
    }
}
