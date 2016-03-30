using SalarySystem.Core;

namespace SalarySystem.Performance
{
    public class EvaluationElementBase : ElementBase, IEvaluationElement, ICopyable<IEvaluationElement>
    {
        private decimal _fullMark;

        protected EvaluationElementBase(string id, string name, string detail, decimal fullMark) :
            base(id,name, (decimal) 1.0, 0, true, detail)
        {
            _fullMark = fullMark;
        }

        public virtual decimal FullMark { get { return _fullMark; } set { _fullMark = value; } }

        public override bool Ready
        {
            get { return base.Ready && FullMark >0; }
        }

        public override object CopyFrom(object another)
        {
            return CopyFrom((IEvaluationElement)another);
        }

        public override IItem CopyFrom(IItem anther)
        {
            return CopyFrom((IEvaluationElement)anther);
        }

        public virtual IEvaluationElement CopyFrom(IEvaluationElement anther)
        {
            base.CopyFrom(anther);
            _fullMark = anther.FullMark;
            return this;
        }
    }
}