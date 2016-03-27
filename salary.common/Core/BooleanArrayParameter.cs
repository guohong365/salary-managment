namespace SalarySystem.Core
{
    public class BooleanArrayParameter : ParameterBase, IParameter<bool[]>
    {
        public new bool[] Value
        {
            get { return (bool[]) base.Value; }
            set { base.Value = value; }
        }
    }
}