using SalarySystem.Core;

namespace SalarySystem.Binding
{
   public class BindingInfo :IBindingInfo
    {
       public BindingInfo(string propertyName, IElement data, string dataMemberName, ITypeConverter typeConverter)
       {
           TypeConverter = typeConverter;
           DataMemberName = dataMemberName;
           PropertyName = propertyName;
       }

       public BindingInfo(string propertyName, IElement data, string dataMemberName):this(propertyName, data, dataMemberName, null)
       {
       }

       public string PropertyName { get; private set; }
       public IElement Data { get; private set; }
       public string DataMemberName { get; private set; }
       public ITypeConverter TypeConverter { get; private set; }
    }
}
