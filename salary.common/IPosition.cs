namespace salary
{
    public interface IPosition
    {
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        IPosition LeaderPosition { get; set; }
        string LeaderPositionId { get; }
        bool Enabled { get; set; }
    }
}