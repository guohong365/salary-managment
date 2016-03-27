using SalarySystem.Binding;
using SalarySystem.Core;

namespace SalarySystem.Algorithm
{
    public interface IAlgorithm : IItem
    {
        object Calculate(IElement element, IBindingList bindingList);
    }
    public interface IAlgorithm<T>
    {
        T Calculate(IElement<T> element, IBindingList bindingList);
    }

    public interface ILevelAlgorithm : IAlgorithm<int>
    {
        
    }
}
