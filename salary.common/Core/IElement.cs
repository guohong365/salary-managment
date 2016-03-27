using System.Collections.Generic;
using SalarySystem.Algorithm;

namespace SalarySystem.Core
{
    public interface IElement : IItem
    {
        IAlgorithm Calculator { get; set; }
        List<IParameter> Parameters { get;}
        void AddParameter(IParameter parameter);
        void RemoveParameter(IParameter parameter);
        IParameter GetParameterByName(string name);
        decimal Weight { get; set; }
        object Value { get; set; }
    }

    public interface IElement<T>
    {
        T Value { get; set; }
    }
}
