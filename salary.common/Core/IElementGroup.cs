using System.Collections.Generic;

namespace SalarySystem.Core
{
    public interface IElementGroup : IElement
    {
        void Add(IElement element);
        void Remove(IElement element);
        IEnumerable<IElement> GetEnumerable();
    }
}
