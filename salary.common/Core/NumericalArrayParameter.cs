namespace SalarySystem.Core
{
    public class NumericalArrayParameter : ParameterBase, IParameter<decimal[]>
    {
        public new decimal[] Value
        {
            get { return (decimal[]) base.Value; }
            set { base.Value = value; }
        }
    }
}