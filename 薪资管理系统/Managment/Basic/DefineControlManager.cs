using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraNavBar;

namespace SalarySystem.Managment.Basic
{
    public class DefineControlManager
    {
        public const string KEY_GROUP_EVALUATION = "绩效考核";
        public const string KEY_GROUP_ASSIGNMENT = "任务指标";
        public const string KEY_GROUP_SALARY_STRUCTURE = "薪资结构";

        public const string KEY_EVALUATION_ITEM_TYPE = "基本考核项目类型定义";
        public const string KEY_EVALUATION_ITEM = "基本考核项目定义";
        public const string KEY_EVALUATION_FORM = "岗位考核表定义";
        public const string KEY_EXECUTION_EVALUATION_FORM = "考核实施管理";
        
        public const string KEY_SALARY_ITEM = "基本薪资构成项目定义";
        public const string KEY_EXECUTION_SALAY_STRUCT = "薪资结构实施管理";

        public const string KEY_ASSINGMENT_ITEM = "基本任务指标定义";
        public const string KEY_EXECUTION_ASSIGNMENT = "任务指标管理";

        private readonly Dictionary<string, Type> _controlDefines=new Dictionary<string, Type>();  
        public Dictionary<string, Type> ControlDefines{get { return _controlDefines; }}

        readonly List<NavGroupDefine> _navGroupDefines=new List<NavGroupDefine>(); 
        public List<NavGroupDefine> NavGroupDefines{get { return _navGroupDefines; }}

        private readonly Dictionary<string, Control> _controlsCache=new Dictionary<string, Control>(); 
        private readonly Control _container;

        void onNavItemClicked(string itemName)
        {
            var control=_container.Controls.Count>0? _container.Controls[0] : null;
            try
            {
                if (control != null)
                {
                    control.Hide();
                    _container.Controls.Remove(control);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(_container, "卸载控件出错" + e);
            }
            try
            {
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
            }
            catch (Exception e)
            {
                MessageBox.Show(_container, "创建控件失败！\n" + e);
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
                    navBarGroup.Expanded = true;
                });
            });
            navBar.LinkClicked +=item_clicked;
        }

        public DefineControlManager(Control container)
        {
            _container = container;
            #region 控件定义
            _controlDefines.Add(KEY_EVALUATION_ITEM_TYPE, typeof(EvaluationItemTypeControl));
            _controlDefines.Add(KEY_EVALUATION_ITEM, typeof(EvaluationItemControl));
            _controlDefines.Add(KEY_EVALUATION_FORM, typeof(EvaluationFormControl));
            _controlDefines.Add(KEY_EXECUTION_EVALUATION_FORM, typeof(ExecuttionEvaluationFormControl));

            _controlDefines.Add(KEY_SALARY_ITEM, typeof(SalaryItemControl));
            _controlDefines.Add(KEY_EXECUTION_SALAY_STRUCT, typeof(ExecutionSalaryStructControl));

            _controlDefines.Add(KEY_ASSINGMENT_ITEM, typeof(AssignmentItemControl));
            _controlDefines.Add(KEY_EXECUTION_ASSIGNMENT, typeof(ExecutionAssignmentControl));
            #endregion

            #region 导航栏定义

            _navGroupDefines.AddRange(new []
            {
                new NavGroupDefine(KEY_GROUP_EVALUATION, new List<NavItemDefine>(new []
                {
                    new NavItemDefine(KEY_EVALUATION_ITEM_TYPE, onNavItemClicked, 0),
                    new NavItemDefine(KEY_EVALUATION_ITEM, onNavItemClicked, 1), 
                    new NavItemDefine(KEY_EVALUATION_FORM, onNavItemClicked, 2), 
                    new NavItemDefine(KEY_EXECUTION_EVALUATION_FORM, onNavItemClicked, 3) 
                }), 0),
                new NavGroupDefine(KEY_GROUP_ASSIGNMENT, new List<NavItemDefine>(new []
                {
                    new NavItemDefine(KEY_ASSINGMENT_ITEM, onNavItemClicked, 0), 
                    new NavItemDefine(KEY_EXECUTION_ASSIGNMENT, onNavItemClicked, 1) 
                }), 1),
                new NavGroupDefine(KEY_GROUP_SALARY_STRUCTURE, new List<NavItemDefine>(new []
                {
                    new NavItemDefine(KEY_SALARY_ITEM, onNavItemClicked, 0),
                    new NavItemDefine(KEY_EXECUTION_SALAY_STRUCT, onNavItemClicked, 1)

                }), 2) 
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
