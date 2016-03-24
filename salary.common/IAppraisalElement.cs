namespace salary
{
    public interface IAppraisalElement
    {
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        IAppraisalCalculator Calculator { get; set; }
        decimal Weight { get; set; }
    }
}
