using System;

namespace SalarySystem.Managment.Basic
{
    public class NavItemDefine
    {
        public NavItemDefine(string name, Action<string> action, int order, string toolTip)
        {
            Action = action;
            ToolTip =string.IsNullOrEmpty(toolTip) ? name : toolTip;
            Name = name;
            Order = order;
        }

        public NavItemDefine(string name, Action<string> action,int order):this(name, action, order, null)
        {
            
        }

        public NavItemDefine(string name, Action<string> action) : this(name, action, 0)
        {
            
        }
        public string Name { get; private set; }
        public int Order { get; private set; }
        public string ToolTip { get; private set; }
        public Action<string> Action { get; private set; } 
    }
}