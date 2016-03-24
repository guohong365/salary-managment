namespace salary.performance.product
{
    public class ProductValueCalculator: IAppraisalCalculator
    {
        public ProductValueCalculator(string id, string name, string description)
        {
            Description = description;
            Name = name;
            Id = id;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Calculate()
        {
            return 1;
        }
    }
}
