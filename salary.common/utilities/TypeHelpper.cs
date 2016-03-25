using System;
using System.Linq;
using System.Reflection;

namespace salary.utilities
{
    public static class TypeHelpper
    {
        public static string GetSimpleTypeName(Type type)
        {
            if (type == null)
            {
                return "null";
            }
            if (type.IsValueType)
            {
                if (type == typeof (byte) || type == typeof (Byte))
                {
                    return "字节";
                }
                if (type == typeof (char) || type == typeof (Char))
                {
                    return "字符";
                }
                if (type == typeof (Int16) || type == typeof (Int32) || type == typeof (Int64) || 
                    type==typeof(UInt16) || type==typeof(UInt32)|| type==typeof(UInt64) ||
                    type == typeof (int) || type==typeof(uint) ||type == typeof (long) ||
                    type== typeof(ulong)) 
                {
                    return "整数";
                }
                if (
                    type == typeof (float) || type == typeof (double) || type ==
                    typeof (Double) || type == typeof (decimal) || type == typeof (Decimal))
                {
                    return "小数";
                }
                if (type == typeof (bool) || type == typeof (Boolean))
                {
                    return "布尔";
                }
                if (type == typeof (string) || type == typeof (String))
                {
                    return "字符串";
                }
            }
            return "对象";
        }


    }
}