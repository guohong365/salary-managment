namespace salary.binding
{
   public interface IBindingInfo
    {
        string PropertyName { get; }
        IElement Data { get; }
        string DataMemberName { get; }
        ITypeConverter TypeConverter { get; }
    }
}
