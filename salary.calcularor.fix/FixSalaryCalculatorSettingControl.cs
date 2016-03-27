using System.Windows.Forms;
using SalarySystem;

namespace salary.calculator.fix
{
    public partial class FixSalaryCalculatorSettingControl : UserControl, ISetup
    {
        public FixSalaryCalculatorSettingControl()
        {
            InitializeComponent();
        }

        public int Save()
        {
            return 0;
        }

        public int Init()
        {
            return 0;
        }

        public int Check()
        {
            return 0;
        }

        public string GetErrorMessage(int error)
        {
            return "";
        }

        public UserControl GetControl()
        {
            return this;
        }

        public void Deinit()
        {
            
        }
    }
}
