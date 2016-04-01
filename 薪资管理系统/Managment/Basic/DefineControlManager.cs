using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraNavBar;

namespace SalarySystem.Managment.Basic
{
    public class DefineControlManager
    {
        public static string KeyGroupEvaluation = "绩效考核";
        public static string KeyGroupAssignment = "任务指标";
        public static string KeyGroupSalaryStructure = "薪资结构";

        public static string KeyEvaluationItemType = "考核项目类型定义";
        public static string KeyEvaluationItem = "考核项目定义";

        private readonly Dictionary<string, Type> _controlDefines=new Dictionary<string, Type>();  
        public Dictionary<string, Type> ControlDefines{get { return _controlDefines; }}

        readonly List<NavGroupDefine> _navGroupDefines=new List<NavGroupDefine>(); 
        public List<NavGroupDefine> NavGroupDefines{get { return _navGroupDefines; }}

        private readonly Dictionary<string, Control> _controlsCache=new Dictionary<string, Control>(); 
        private readonly Control _container;

        void onNavItemClicked(string itemName)
        {
            Control control=_container.Controls.Count>0? _container.Controls[0] : null;
            if (control != null)
            {
                control.Hide();
                _container.Controls.Remove(control);
            }
            if (!_controlsCache.TryGetValue(itemName, out control))
            {
                Type type;
                if (!_controlDefines.TryGetValue(itemName, out type))
                {
                    throw new Exception();
                }
                control = Activator.CreateInstance(type) as Control;
                _controlsCache.Add(itemName, control);
            }
            Debug.Assert(control != null, "control != null");
            control.Dock= DockStyle.Fill;
            _container.Controls.Clear();
            _container.Controls.Add(control);
            control.Visible = true;
        }
        private void item_clicked(object sender, NavBarLinkEventArgs e)
        {
            NavItemDefine itemDefine = e.Link.Item.Tag as NavItemDefine;
            Debug.Assert(itemDefine != null, "itemDefine != null");
            itemDefine.Action(e.Link.Caption);
        }
        public void BuildNavBar(NavBarControl navBar)
        {
            _navGroupDefines.Sort(ItemComparer.Comparer);
            _navGroupDefines.ForEach(item=>item.Items.Sort(ItemComparer.Comparer));
            navBar.Items.Clear();
            navBar.Groups.Clear();
            _navGroupDefines.ForEach(group =>
            {
                NavBarGroup navBarGroup=new NavBarGroup(group.Name);
                navBar.Groups.Add(navBarGroup);
                navBarGroup.DragDropFlags = NavBarDragDrop.None;

                group.Items.ForEach(item =>
                {
                    NavBarItem navBarItem=new NavBarItem(item.Name) {Tag = item};
                    navBar.Items.Add(navBarItem);
                    navBarGroup.ItemLinks.Add(navBarItem);
                });
            });
            navBar.LinkClicked +=item_clicked;
        }

        public DefineControlManager(Control container)
        {
            _container = container;
            #region 控件定义
            _controlDefines.Add(KeyEvaluationItemType, typeof(EvaluationItemTypeControl));
            _controlDefines.Add(KeyEvaluationItem, typeof(EvaluationItemControl));
            #endregion

            #region 导航栏定义

            _navGroupDefines.AddRange(new []
            {
                new NavGroupDefine(KeyGroupEvaluation, new List<NavItemDefine>(new []
                {
                    new NavItemDefine(KeyEvaluationItemType, onNavItemClicked, 0),
                    new NavItemDefine(KeyEvaluationItem, onNavItemClicked, 1) 
                })),
                new NavGroupDefine(KeyGroupAssignment, new List<NavItemDefine>()),
                new NavGroupDefine(KeyGroupSalaryStructure, new List<NavItemDefine>()) 
            });
            #endregion
        }

        private class ItemComparer : IComparer<NavItemDefine>, IComparer<NavGroupDefine>
        {
            public static readonly ItemComparer Comparer=new ItemComparer();
            public int Compare(NavItemDefine x, NavItemDefine y)
            {
                return x.Order - y.Order;
            }

            public int Compare(NavGroupDefine x, NavGroupDefine y)
            {
                return x.Order - y.Order;
            }
        }
    }
}
