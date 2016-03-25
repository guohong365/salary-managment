namespace salary
{
    public interface IPosition : IElement
    {
        IPosition LeaderPosition { get; set; }
        string LeaderPositionId { get; }
    }
}