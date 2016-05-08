using System.Collections.Generic;

namespace UC.Platform.UI
{
    public class NavGroupDefine
    {
        public NavGroupDefine(string name, IEnumerable<INavItemDefine> items, int order)
        {
            _items.AddRange(items);
            _order = order;
            _name = name;
        }

        public NavGroupDefine(string name, IEnumerable<INavItemDefine> items)
            : this(name, items, 0)
        {
            
        }

        private readonly string _name;
        private readonly int _order;
        private readonly List<INavItemDefine> _items=new List<INavItemDefine>(); 
        public string Name { get { return _name; }}
        public int Order { get { return _order; }}
        public List<INavItemDefine> Items { get { return _items; }} 
    }
}