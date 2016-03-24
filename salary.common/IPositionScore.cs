namespace salary
{
    public interface IPositionScore
    {
        IPosition Position { get; set; }
        IAppraisalElement AppraisalElement { get; set;}
        decimal Weight { get; set; }
    }
}
