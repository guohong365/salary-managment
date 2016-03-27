namespace SalarySystem.Core
{
    public class BooleanElement : ElementBase, IElement<bool>
    {
        public new virtual bool Value
        {
            get
            {
                return (bool) base.Value;
            }
            set
            {
                base.Value = value;
            }
        }
    }
}