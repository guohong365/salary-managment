using System;
using SalarySystem.Core;

namespace SalarySystem
{
    public interface IParameterInfo : IItem
    {
        string TypeName { get; }
        Type RealType { get; }
        ITypeConverter TypeConverter { get; }
    }
}