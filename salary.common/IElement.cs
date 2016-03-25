using System.Collections.Generic;
using salary.algorithm;

namespace salary
{
    public interface IElement : IItem
    {
        IAlgorithm Calculator { get; set; }
        List<IParameter> Parameters { get;}
        IParameter GetParameterByName(string name);
        decimal Weight { get; set; }
        T GetValue<T>(string name);
    }

}
