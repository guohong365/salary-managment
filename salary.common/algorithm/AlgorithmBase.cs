using salary.binding;

namespace salary.algorithm
{
    public abstract class AlgorithmBase : ItemBase, IAlgorithm
    {
        public virtual object Calculate(IElement element, IBindingList bindingList)
        {
            throw new System.NotImplementedException();
        }
    }
}
