using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SalarySystem.Core
{
    public interface IElementGroup : IElement
    {
        void Add(IElement element);
        void Remove(IElement element);
        List<IElement> Elements { get; }
    }
    
    public abstract class ElementGroupBase : ElementBase, IElementGroup
    {
        protected ElementGroupBase()
        {
            Elements = new List<IElement>();
        }

        public virtual void Add(IElement element)
        {
            Elements.Add(element);
        }

        public virtual void Remove(IElement element)
        {
            Elements.Remove(element);
        }

        public virtual List<IElement> Elements { get; private set; }
    }

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

        public virtual new decimal Value
        {
            get
            {
                return Elements.Sum(element => Weight*(decimal) element.Value);
            }
            set { }
        }
    }

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

        public abstract new bool Value { get; set; }
    }

    public class AndLogicElementGroup : LogicElementGroup
    {
        public override bool Value
        {
            get
            {
                return Elements.All(element => (bool) element.Value);
            }
            set { }
        }
    }

    public class OrLogicElementGroup : LogicElementGroup
    {
        public override bool Value {
            get
            { return Elements.Any(element => (bool) element.Value); }
            set { }
        }
    }
}
