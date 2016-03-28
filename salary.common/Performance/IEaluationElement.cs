using SalarySystem.Core;

namespace SalarySystem.Performance
{
    public interface IEvaluationElement : IElement
    {
        decimal FullMark { get; set; }
    }
}
