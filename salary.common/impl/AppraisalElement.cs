namespace salary.impl
{
   public class AppraisalElement : IAppraisalElement
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IAppraisalCalculator Calculator { get; set; }
        public decimal Weight { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public AppraisalElement(string id, string name, IAppraisalCalculator calculator, decimal weight, string desc)
        {
            Id = id;
            Name = name;
            Description = desc;
            Calculator = calculator;
            Weight = weight;
        }

        public AppraisalElement(string id, string name, IAppraisalCalculator calculator, decimal weight)
            : this(id, name, calculator, weight, "")
        {
            
        }
    }
}
