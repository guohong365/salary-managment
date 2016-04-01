using System.Collections.Generic;

namespace SalarySystem.Managment.Basic
{
    public class NavGroupDefine
    {
        public NavGroupDefine(string name, List<NavItemDefine> items, int order, string toolTip)
        {
            Items = items;
            Order = order;
            Name = name;
            ToolTip = string.IsNullOrEmpty(toolTip)? name :toolTip;
        }

        public NavGroupDefine(string name, List<NavItemDefine> items, int order):this(name, items, order, null)
        {
        }

        public NavGroupDefine(string name, List<NavItemDefine> items) : this(name, items, 0)
        {
            
        }

        public string Name { get; private set; }
        public string ToolTip { get; private set; }
        public int Order { get; private set; }
        public List<NavItemDefine> Items { get; private set;} 
    }
}