using System.Collections.Generic;
using System.Windows.Forms;

namespace SalarySystem.Managment.Basic
{
    public class NavGroupDefine
    {
        public NavGroupDefine(string name, IEnumerable<INavItemDefine> items, int order, string toolTip)
        {
            Items.AddRange(items);
            Order = order;
            Name = name;
            ToolTip = string.IsNullOrEmpty(toolTip)? name :toolTip;
        }

        public NavGroupDefine(string name, IEnumerable<NavItemDefine> items, int order)
            : this(name, items, order, null)
        {
        }

        public NavGroupDefine(string name, IEnumerable<NavItemDefine> items)
            : this(name, items, 0)
        {
            
        }

        
        public string Name { get; private set; }
        public string ToolTip { get; private set; }
        public int Order { get; private set; }
        public List<INavItemDefine> Items { get; private set; } 
    }
}