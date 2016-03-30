namespace SalarySystem.Core
{
    public abstract class ElementBase : ItemBase, IElement, ICopyable<IElement>
    {
        private decimal _weight;
        private decimal _value;

        protected ElementBase():this("", "")
        {
        }
        
        public virtual decimal Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public virtual decimal Value { get { return _value; } set { _value = value; } }

        protected ElementBase(string id, string name, decimal weight, decimal value, bool enabled, string desc)
            : base(id, name, desc, enabled)
        {
            _weight = weight;
            _value = value;
        }

        protected ElementBase(string id, string name, decimal weight) : this(id, name, weight, 0, true, "")
        {
            
        }

        protected ElementBase(string id, string name) : this(id, name, new decimal(1.0))
        {
            
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
