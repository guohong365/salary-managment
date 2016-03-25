using System;
using salary.utilities;

namespace salary
{
    public class ParameterInfo : ItemBase, IParameterInfo
    {
        public ParameterInfo(string id,string name , string descripton,Type realType, ITypeConverter converter) : base(id, name, descripton)
        {
            RealType = realType;
            TypeConverter = converter;

        }

        public string TypeName
        {
            get
            {
                return TypeHelpper.GetSimpleTypeName(RealType);
            }
        }

        public Type RealType { get; protected set; }
        public ITypeConverter TypeConverter { get; set; }
    }
}