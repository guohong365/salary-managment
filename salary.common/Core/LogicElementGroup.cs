using System.Diagnostics;
using System.Linq;

namespace SalarySystem.Core
{
    public abstract class LogicElementGroup : ElementGroupBase, IElement<bool>
    {
        public override void Add(IElement element)
        {
            Debug.Assert(element.GetType().IsInstanceOfType(typeof(BooleanElement)));
            base.Add(element);
        }

        public override void Remove(IElement element)
        {
            Debug.Assert(element.GetType().IsInstanceOfType(typeof(BooleanElement)));
            base.Remove(element);
        }

        public virtual new bool Value { get; set; }
    }
}