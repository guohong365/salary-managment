using System.Collections.Generic;
using System.Linq;

namespace SalarySystem.Core
{
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

        public override bool Ready
        {
            get { return base.Ready && Elements.Count > 0 && Elements.All(item => item.Ready); }
        }
    }
}