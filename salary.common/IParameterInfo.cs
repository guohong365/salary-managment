using System;

namespace salary
{
    public interface IParameterInfo : IItem
    {
        string TypeName { get; }
        Type RealType { get; }
        ITypeConverter TypeConverter { get; }
    }
}