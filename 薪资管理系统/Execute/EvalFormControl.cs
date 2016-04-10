using System.Data;
using SalarySystem.Data;

namespace SalarySystem.Execute
{
    public partial class EvalFormControl : DevExpress.XtraEditors.XtraUserControl
    {
        public EvalFormControl()
        {
            InitializeComponent();
            repositoryItemLookUpEditItemType.DataSource = new DataView(DataHolder.EvaluationItemType);
        }

        private DataSetSalary.v_evaluation_result_detailDataTable _resultDetail;

        public DataSetSalary.v_evaluation_result_detailDataTable ResultDetail
        {
            get
            {
                return _resultDetail;
            }
            set
            {
                _resultDetail = value;
                onResultDetailChanged();
            }
        }

        private void onResultDetailChanged()
        {
            gridControlEvalForm.DataSource = _resultDetail;
        }
    }
}
