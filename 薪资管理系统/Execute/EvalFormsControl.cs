using System;
using System.Data;
using System.Windows.Forms;

namespace SalarySystem.Execute
{
    public partial class EvalFormsControl : DevExpress.XtraEditors.XtraUserControl
    {
        private EmployeePerformance _employeePerformance;

        public EvalFormsControl()
        {
            InitializeComponent();
        }
        
        private void onControlLoad(object sender, EventArgs e)
        {
        }

        public EmployeePerformance EmployeePerformance
        {
            get
            {
                return _employeePerformance;
            }
            set
            {
                _employeePerformance = value;
                onParamChanged();
            }
        }

        private void onParamChanged()
        {
            xtraTabControlEvalForms.TabPages.Clear();
            if (_employeePerformance == null)
            {
                return;
                //throw new NoNullAllowedException();
            }

            foreach (DataRow row in _employeePerformance.FormsIdName.Rows)
            {
                #region 准备control
                var page = xtraTabControlEvalForms.TabPages.Add(Convert.ToString(row["FORM_NAME"]));
                page.Tag = row["FORM_ID"];
                page.Margin=new Padding(0);
                var control = new EvalFormControl
                {
                    Dock = DockStyle.Fill,
                    ResultDetail = EmployeePerformance.EvaluationResults[Convert.ToString(row["FORM_ID"])],
                    Margin = new Padding(0)
                };
                page.Controls.Add(control);
                #endregion
            }
        }
    }
}
