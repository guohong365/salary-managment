using System.Collections.Generic;
using System.Linq;
using SalarySystem.Core;

namespace SalarySystem.Performance
{
    public class EvaluationForm : EvaluateionElementGroupBase, IEvaluationForm, ICopyable<EvaluationForm>
    {
        private readonly List<EvaluationFormItem> _items=new List<EvaluationFormItem>();

        public EvaluationForm(string id, string name, string detail) : base(id, name, detail)
        {
        }

        public List<EvaluationFormItem> Items { get { return _items; } } 
        public override IEnumerator<IEvaluationElement> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public override bool Ready
        {
            get
            {
                return base.Ready && _items.Count > 0;
            }
        }

        public override decimal FullMark
        {
            get
            {
                return Items.Where(item => item.Enabled).Sum(item => item.FullMark);
            }
            set { }
        }
        public virtual new decimal Value
        {
            get { return Items.Where(item => item.Enabled).Sum(item => item.Value)/FullMark; }
            set { }
        }

        public override IEvaluationElement CopyFrom(IEvaluationElement anther)
        {
            return CopyFrom((EvaluationForm)anther);
        }

        public override IItem CopyFrom(IItem anther)
        {
            return CopyFrom((EvaluationForm)anther);
        }

        public override object CopyFrom(object another)
        {
            return CopyFrom((EvaluationForm)another);
        }

        public virtual EvaluationForm CopyFrom(EvaluationForm anther)
        {
            base.CopyFrom(anther);
            _items.Clear();
            foreach (var item in anther.Items)
            {
                _items.Add((EvaluationFormItem) item.Clone());
            }
            return this;
        }
    }
}