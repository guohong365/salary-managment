using SalarySystem.Binding;
using SalarySystem.Core;

namespace SalarySystem.Algorithm
{
    [Algorithm(Name = "加法", Description = "两个数相加")]
    [Parameter(Name = "被加数", Type = typeof(decimal))]
    [Parameter(Name = "加数", Type = typeof(decimal))]
    public class AddAlgorithm : AlgorithmBase, IArithmeticAlgorithm
    {
        public decimal Calculate(IArithmeticAlgorithm element, IBindingList bindingList)
        {
            return 0;
        }

        public decimal Calculate(IElement<decimal> element, IBindingList bindingList)
        {
            return 0;
        }
    }
}
