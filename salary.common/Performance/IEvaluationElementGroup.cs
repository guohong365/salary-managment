using System.Collections.Generic;

namespace SalarySystem.Performance
{
    public interface IEvaluationElementGroup : IEvaluationElement, IEnumerable<IEvaluationElement>
    {
    }
}