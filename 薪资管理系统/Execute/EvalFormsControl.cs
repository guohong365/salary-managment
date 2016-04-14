using System;
using System.Data;
using System.Windows.Forms;
using SalarySystem.Data;
using SalarySystem.Managment;
using UC.Platform.Data;

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

                #region 加载数据
                 var resultDetail =new DataSetSalary.v_evaluation_result_detailDataTable();
                var sql = string.Format(
                    "SELECT `POSITION_ID`, `FORM_ID`, `WEIGHT`, `VERSION_ID`, `FORM_NAME`, `ITEM_ID`, `SHOW_ORDER`, `ITEM_NAME`, `ITEM_DESC`, `ITEM_TYPE`, `FULL_MARK`, `EMPLOYEE_ID`, `EMPLOYEE_NAME`, `RESULT_ID`, `RESULT_DESC`, `EVALUATION_YEAY`, `EVALUATION_MONTH`, `EVALUATOR`, `EVALUATION_TIME`, `MARK` " +
                    "from v_evaluation_result_detail " +
                    "where POSITION_ID='{0}' " +
                    "and FORM_ID='{1}' " +
                    "and VERSION_ID='{2}' " +
                    "order by SHOW_ORDER",
                    _employeePerformance.Employee.POSITION_ID,
                    row["FORM_ID"],
                    GlobalSettings.EvaluationVersion);


                DBHandlerEx.FillOnce(resultDetail, sql);

                _employeePerformance.Results[(string)row["FORM_ID"]] = resultDetail;
                #endregion

                #region 准备control
                var page = xtraTabControlEvalForms.TabPages.Add((string) row["FORM_NAME"]);
                page.Tag = row["FORM_ID"];
                page.Margin=new Padding(0);
                var control = new EvalFormControl
                {
                    Dock = DockStyle.Fill,
                    ResultDetail = resultDetail,
                    Margin = new Padding(0)
                };
                page.Controls.Add(control);
                #endregion
            }
        }
    }
}
