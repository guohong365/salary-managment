﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraNavBar;

namespace SalarySystem.Managment.Basic
{
    public class NavBarControlManagerBase : INavBarContorlManager
    {   
        private class _itemComparer : IComparer<INavItemDefine>, IComparer<NavGroupDefine>
        {
            public static readonly _itemComparer Comparer=new _itemComparer();
            public int Compare(INavItemDefine x, INavItemDefine y)
            {
                return x.Order - y.Order;
            }

            public int Compare(NavGroupDefine x, NavGroupDefine y)
            {
                return x.Order - y.Order;
            }
        }
        private readonly Control _contrainerControl;
        private readonly List<NavGroupDefine> _navGroupDefines=new List<NavGroupDefine>();
        private readonly NavBarControl _navBarControl;
        public Control ContainerControl { get { return _contrainerControl; } }
        public List<NavGroupDefine> NavGroupDefines { get { return _navGroupDefines; } }
       
        public NavBarControlManagerBase(Control container, NavBarControl navBarControl)
        {
            _contrainerControl = container;
            _navBarControl = navBarControl;
        }

        public virtual void InitNavBar()
        {
            onBuildNavBar(_navBarControl);
        }

        protected virtual void ItemClickedHandler(object sender, NavBarLinkEventArgs e)
        {
            NavItemDefine itemDefine = e.Link.Item.Tag as NavItemDefine;
            if (itemDefine != null) itemDefine.Action(itemDefine);
        }

        protected virtual void onNavItemClicked(INavItemDefine item)
        {
            var currentControl = ContainerControl.Controls.Count > 0 ? ContainerControl.Controls[0] : null;
            try
            {
                if (currentControl != null)
                {
                    currentControl.Hide();
                    ContainerControl.Controls.Remove(currentControl);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(ContainerControl, "卸载控件出错" + e);
            }

            try
            {

                Debug.Assert(item != null, "item != null");
                item.ThisControl.Dock = DockStyle.Fill;
                ContainerControl.Controls.Clear();
                ContainerControl.Controls.Add(item.ThisControl);
                item.ThisControl.Visible = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(ContainerControl, "加载控件失败！\n" + e);
            }

        }
        protected virtual void onBuildNavBar(NavBarControl navBarControl)
        {
            _navGroupDefines.Sort(_itemComparer.Comparer);
            _navGroupDefines.ForEach(item => item.Items.Sort(_itemComparer.Comparer));
            navBarControl.Items.Clear();
            navBarControl.Groups.Clear();
            _navGroupDefines.ForEach(group =>
            {
                NavBarGroup navBarGroup = new NavBarGroup(group.Name);
                navBarControl.Groups.Add(navBarGroup);
                navBarGroup.DragDropFlags = NavBarDragDrop.None;

                group.Items.ForEach(item =>
                {
                    NavBarItem navBarItem = new NavBarItem(item.Name) {Tag = item};
                    navBarControl.Items.Add(navBarItem);
                    navBarGroup.ItemLinks.Add(navBarItem);
                    navBarGroup.Expanded = true;
                });
            });
            navBarControl.LinkClicked += ItemClickedHandler;
        }

    }
}