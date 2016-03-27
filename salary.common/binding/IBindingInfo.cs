using SalarySystem.Core;

namespace SalarySystem.Binding
{
   public interface IBindingInfo
    {
        string PropertyName { get; }
        IElement Data { get; }
        string DataMemberName { get; }
        ITypeConverter TypeConverter { get; }
    }
}
