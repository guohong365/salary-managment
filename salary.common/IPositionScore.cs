namespace salary
{
    public interface IPositionScore
    {
        IPosition Position { get; set; }
        IElement AppraisalElement { get; set;}
        decimal Weight { get; set; }
    }
}
