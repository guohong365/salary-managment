using System.Collections;
using System.Collections.Generic;
using SalarySystem.Core;

namespace SalarySystem.Performance
{
    public abstract class EvaluateionElementGroupBase : EvaluationElementBase, IEvaluationElementGroup 
    {
        protected EvaluateionElementGroupBase(string id, string name, string detail) : base(id, name, detail, 0)
        {
        }

        public abstract IEnumerator<IEvaluationElement> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
