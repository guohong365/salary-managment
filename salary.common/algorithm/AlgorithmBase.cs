using SalarySystem.Binding;
using SalarySystem.Core;

namespace SalarySystem.Algorithm
{
    public abstract class AlgorithmBase : ItemBase, IAlgorithm
    {
        public virtual object Calculate(IElement element, IBindingList bindingList)
        {
            throw new System.NotImplementedException();
        }
    }
}
