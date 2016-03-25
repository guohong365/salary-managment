using System;
using System.Collections.Generic;
using System.Data;
using salary.binding;

namespace salary.algorithm
{
    [Algorithm(Name = "加法", Description = "两个数相加")]
    [Parameter(Name = "被加数", Type = typeof(decimal))]
    [Parameter(Name = "加数", Type = typeof(decimal))]
    public class AddAlgorithm : AlgorithmBase, IArithmeticAlgorithm
    {
        public new decimal Calculate(IElement element, IBindingList bindingList)
        {
            BindingInfo bindingInfo1=bindingList.FindByPropertyName("被加数");
            BindingInfo bindingInfo2 = bindingList.FindByPropertyName("加数");
            if (bindingInfo1 == null || bindingInfo2 == null)
            {
                throw new NoNullAllowedException();
            }
            decimal v1 = element.GetValue<decimal>(bindingInfo1.DataMemberName);
            decimal v2 = element.GetValue<decimal>(bindingInfo2.DataMemberName);
            return v1 + v2;
        }
    }
}
