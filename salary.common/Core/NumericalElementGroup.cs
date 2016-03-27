using System.Diagnostics;
using System.Linq;

namespace SalarySystem.Core
{
    public class NumericalElementGroup : ElementGroupBase, IElement<decimal>
    {
        public override void Add(IElement element)
        {
            Debug.Assert(element.GetType().IsInstanceOfType(typeof (NumericalElement)));
            base.Add(element);
        }

        public override void Remove(IElement element)
        {
            Debug.Assert(element.GetType().IsInstanceOfType(typeof (NumericalElement)));
            base.Remove(element);
        }

        public new virtual decimal Value
        {
            get
            {
                return Elements.Sum(element => Weight*(decimal) element.Value);
            }
            set { }
        }

    }
}