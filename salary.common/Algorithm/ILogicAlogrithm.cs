using SalarySystem.Binding;
using SalarySystem.Core;

namespace SalarySystem.Algorithm
{
    public interface ILogicAlgorithm : IAlgorithm<bool>
    {
    }

    public class LogicAlgorithmBase : AlgorithmBase, ILogicAlgorithm 
    {
        public virtual bool Calculate(IElement<bool> element, IBindingList bindingList)
        {
            return true;
        }
    }
}