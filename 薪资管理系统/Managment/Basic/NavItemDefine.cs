using System;
using System.Windows.Forms;

namespace SalarySystem.Managment.Basic
{
    public interface INavItemDefine
    {
         string Name { get;}
         int Order { get;  }
         string ToolTip { get;  }
         Action<NavItemDefine> Action { get; }
         Control ThisControl { get; }
    }

    public class NavItemDefine : INavItemDefine
    {
        public NavItemDefine(string name, Type type, Action<INavItemDefine> action, int order, string toolTip)
        {
            ControlType = type;
            Action = action;
            ToolTip = string.IsNullOrEmpty(toolTip) ? name : toolTip;
            Name = name;
            Order = order;
        }

        public NavItemDefine(string name, Type type, Action<INavItemDefine> action, int order)
            : this(name, type, action, order, null)
        {

        }

        public NavItemDefine(string name, Type type, Action<INavItemDefine> action)
            : this(name, type, action, 0)
        {
        }

        public Type ControlType{get; private set;}
        public string Name { get; private set; }
        public int Order { get; private set; }
        public string ToolTip { get; private set; }
        public Action<NavItemDefine> Action { get; private set; }
        private Control _thisControl;
        public Control ThisControl
        {
            get { return _thisControl ?? (_thisControl = (Control) Activator.CreateInstance(ControlType)); }
        }
    }
}