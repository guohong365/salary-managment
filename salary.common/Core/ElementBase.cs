using System.Collections.Generic;
using System.Linq;
using SalarySystem.Algorithm;

namespace SalarySystem.Core
{
    public abstract class ElementBase : ItemBase, IElement, ICopyable<IElement>
    {
        private decimal _weight;
        private object _value;

        protected ElementBase()
        {
            Parameters = new List<IParameter>();
        }
        public virtual IAlgorithm Calculator { get; set; }
        public virtual List<IParameter> Parameters { get; private set; }
        public virtual void AddParameter(IParameter parameter)
        {
            Parameters.Add(parameter);
        }

        public virtual void RemoveParameter(IParameter parameter)
        {
            Parameters.Remove(parameter);
        }

        public virtual IParameter GetParameterByName(string name)
        {
            return Parameters.Find(item => item.Name == name);
        }

        public virtual decimal Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public virtual object Value { get { return _value; } set { _value = value; } }

        protected ElementBase(string id, string name, decimal weight, bool enabled, string desc)
            : base(id, name, desc, enabled)
        {
            _weight = weight;
        }

        protected ElementBase(string id, string name, decimal weight) : this(id, name, weight, true, "")
        {
            
        }

        protected ElementBase(string id, string name) : this(id, name, new decimal(1.0))
        {
            
        }

        public override bool Ready
        {
            get { return base.Ready && (Parameters.Count <= 0 || Parameters.All(item=>item.Ready)); }
        }

        public override IItem CopyFrom(IItem anther)
        {
            return CopyFrom((IElement) anther);
        }

        public override object CopyFrom(object another)
        {
            return CopyFrom((IElement)another);
        }

        public IElement CopyFrom(IElement anther)
        {
            base.CopyFrom(anther);
            _weight = anther.Weight;
            _value = anther.Value;
            return this;
        }
    }
}
