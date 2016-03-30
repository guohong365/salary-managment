namespace SalarySystem.Core
{
    public class BooleanElement : ElementBase, IElement<bool>
    {
        public new virtual bool Value
        {
            get
            {
                return base.Value!=0;
            }
            set
            {
                base.Value = value?1:0;
            }
        }
    }
}