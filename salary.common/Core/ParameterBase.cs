namespace SalarySystem.Core
{
    public abstract class ParameterBase : ItemBase, IParameter
    {
        public object Value { get; set; }
    }
}
