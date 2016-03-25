using System.Collections.Generic;
using System.Data;
using salary.algorithm;
using salary.binding;

namespace salary.impl
{
    public abstract class ElementBase : ItemBase, IElement
    {
        protected ElementBase()
        {
            Parameters = new List<IParameter>();
        }
        public virtual IAlgorithm Calculator { get; set; }
        public virtual List<IParameter> Parameters { get; private set; }
        public virtual IParameter GetParameterByName(string name)
        {
            return Parameters.Find(item => item.Name == name);
        }
        public virtual decimal Weight { get; set; }
        public virtual T GetValue<T>(string name)
        {
            IParameter parameter = GetParameterByName(name);
            if (parameter == null)
            {
                throw new NoNullAllowedException();
            }
            return (T) parameter.Value;
        }
    }
}
