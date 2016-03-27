using SalarySystem.Core;

namespace SalarySystem
{
    public interface IPosition : IElement
    {
        IPosition LeaderPosition { get; set; }
        string LeaderPositionId { get; }
    }
}