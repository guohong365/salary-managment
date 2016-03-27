namespace SalarySystem.Core
{
    public class BooleanParameter : ParameterBase, IParameter<bool>
    {
        public new bool Value
        {
            get { return (bool) base.Value; }
            set { base.Value = value; }
        }
    }
}
