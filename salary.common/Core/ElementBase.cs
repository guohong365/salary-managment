using System.Collections.Generic;
using SalarySystem.Algorithm;

namespace SalarySystem.Core
{
    public abstract class ElementBase : ItemBase, IElement
    {
        protected ElementBase()
        {
            Parameters = new List<IParameter>();
        }
        public virtual IAlgorithm Calculator { get; set; }
        public virtual List<IParameter> Parameters { get; private set; }
        public virtual void AddParameter(IParameter parameter)
        {
            Parameters.Add(parameter);
        }

        public virtual void RemoveParameter(IParameter parameter)
        {
            Parameters.Remove(parameter);
        }

        public virtual IParameter GetParameterByName(string name)
        {
            return Parameters.Find(item => item.Name == name);
        }
        public virtual decimal Weight { get; set; }
        public virtual object Value { get; set; }
    }
}
