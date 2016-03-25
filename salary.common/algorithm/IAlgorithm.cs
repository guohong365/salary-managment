using salary.binding;

namespace salary.algorithm
{
    public interface IAlgorithm : IItem
    {
        object Calculate(IElement element, IBindingList bindingList);
    }
    public interface IAlgorithm<out T>
    {
        T Calculate(IElement element, IBindingList bindingList);
    }

    public interface ILevelAlgorithm : IAlgorithm<int>
    {
        
    }
    public interface IArithmeticAlgorithm : IAlgorithm<decimal>
    {
    }

    public interface ILogicAlogrithm : IAlgorithm<bool>
    {
    }
}
