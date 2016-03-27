using System.Diagnostics;

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

        public new abstract bool Value { get; set; }
    }
}