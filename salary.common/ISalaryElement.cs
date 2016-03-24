namespace salary
{
    public interface ISalaryElement
    {
        string Name { get; set; }
        string Description { get; set; }
        ISalaryCalculator Calculator { get; set; }
    }
}