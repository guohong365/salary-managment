using System;
using SalarySystem.Core;
using SalarySystem.Utilities;

namespace SalarySystem
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ParameterAttribute: Attribute, IItem
    {
        public ParameterAttribute()
        {
            Ready = true;
            Enabled = true;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Ready { get; private set; }
        public bool Enabled { get; set; }

        public string TypeName
        {
            get { return TypeHelpper.GetSimpleTypeName(Type); }
        }

        public Type Type { get; set; }
        public Type ConverterType { get; set; }
    }
}
