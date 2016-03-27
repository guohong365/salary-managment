using System.Collections.Generic;
using SalarySystem.Core;

namespace SalarySystem.Binding
{
    public  class BindingList : IBindingList
    {
        private readonly List<BindingInfo> _bindingInfos=new List<BindingInfo>(); 
        public void AddBiding(string propertyName, IElement data, string dataMember, ITypeConverter converter)
        {
            _bindingInfos.Add(new BindingInfo(propertyName, data, dataMember, converter));
        }

        public void AddBiding(string propertyName, IElement data, string dataMember)
        {
            _bindingInfos.Add(new BindingInfo(propertyName, data, dataMember));
        }

        public BindingInfo FindByPropertyName(string name)
        {
            return _bindingInfos.Find(item => item.PropertyName == name);
        }

        public BindingInfo FindByMemberName(string name)
        {
            return _bindingInfos.Find(item => item.DataMemberName == name);
        }

        public BindingInfo Find(string propertyName, string memberName)
        {
            return _bindingInfos.Find(item => item.PropertyName == propertyName && item.DataMemberName == memberName);
        }
    }
}
