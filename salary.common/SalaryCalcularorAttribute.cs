using System;

namespace SalarySystem
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SalaryCalcularorAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Type SettingControl;
    }
}
