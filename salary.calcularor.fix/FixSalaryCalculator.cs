using SalarySystem;

namespace salary.calculator.fix
{
    [SalaryCalcularor(Name = "固定金额项目", Description = "工资构成为正负固定金额。", SettingControl = typeof(FixSalaryCalculatorSettingControl))]
    public class FixSalaryCalculator : ISalaryCalculator
    {
        public FixSalaryCalculator()
        {
            
        }
        public FixSalaryCalculator(string name, string description, decimal value)
        {
            Value = value;
            Description = description;
            Name = name;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Value { get; private set; }
        public decimal Calculate()
        {
            return Value;
        }
        public bool Setup()
        {
            return true;
        }
    }
}
