namespace SalarySystem.Core
{
    public interface INumericalElement : IElement<decimal>
    {
        
    }

    public class NumericalElement : ElementBase, INumericalElement
    {
        public new virtual decimal Value
        {
            get
            {
                return (decimal) base.Value;
            }
            set
            {
                base.Value = value;
            }
        }
    }
}
