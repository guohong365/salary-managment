using System.Collections.Generic;
using System.Linq;

namespace SalarySystem.Core
{
    public abstract class ElementGroupBase : ElementBase, IElementGroup
    {
        private readonly List<IElement> _elements = new List<IElement>();

        protected ElementGroupBase(string id, string name, decimal weight, bool enabled, string desc) :
            base(id, name, weight, 0, enabled, desc)
        {
        }

        protected ElementGroupBase(string id, string name, decimal weight, string desc) :
            this(id, name, weight, true, desc)
        {

        }

        protected ElementGroupBase(string id, string name, string desc)
            : this(id, name, (decimal) 1.0, desc)
        {

        }

        protected ElementGroupBase(string id, string name)
            : this(id, name, "")
        {
            
        }

        protected ElementGroupBase() : this("", "")
        {
            
        }

        public virtual void Add(IElement element)
        {
            _elements.Add(element);
        }

        public virtual void Remove(IElement element)
        {
            _elements.Remove(element);
        }

        public virtual IEnumerable<IElement> GetEnumerable()
        {
            return _elements;
        }

        public override bool Ready
        {
            get { return base.Ready && _elements.Count > 0 && _elements.All(item => item.Ready); }
        }
    }
}