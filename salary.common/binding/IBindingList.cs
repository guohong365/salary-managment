using SalarySystem.Core;

namespace SalarySystem.Binding
{
    public interface IBindingList
    {
        void AddBiding(string propertyName, IElement data, string dataMember, ITypeConverter converter);
        void AddBiding(string propertyName, IElement data, string dataMember);
        BindingInfo FindByPropertyName(string name);
        BindingInfo FindByMemberName(string name);
        BindingInfo Find(string propertyName, string memberName);
    }
}