using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using SalarySystem.Config;
using SalarySystem.Execute;
using SalarySystem.Managment;
using SalarySystem.Managment.Basic;
using SalarySystem.Managment.Employee;
using SalarySystem.Managment.Position;

namespace SalarySystem
{
    public partial class MainForm : XtraForm
    {
        private readonly Hashtable _pages = new Hashtable();
        public MainForm()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            Text = string.Format("薪酬管理系统 绩效考核版本：[{0}] 任务指标版本：[{1}] 薪资构成版本：[{2}]", 
                GlobalSettings.EvaluationFullVersion,
                GlobalSettings.AssignmentFullVersion,
                GlobalSettings.SalaryFullVersion);
        }

        bool takeCachedPage(string name)
        {
            XtraTabPage page = xtraTabControl1.TabPages.Count > 0 ? xtraTabControl1.TabPages.FirstOrDefault(item => item.Text == name) : null;
            if (page != null)
            {
                xtraTabControl1.SelectedTabPage = page;
                return true;
            }
            if (_pages.ContainsKey(name))
            {
                page = _pages[name] as XtraTabPage;
            }
            if (page != null)
            {
                xtraTabControl1.TabPages.Add(page);
                xtraTabControl1.SelectedTabPage = page;
                return true;
            }
            return false;
        }

        void addControl(string name, UserControl control)
        {
            XtraTabPage page=new XtraTabPage {Text = name};
            control.Dock = DockStyle.Fill;
            page.Controls.Add(control);
            _pages.Add(name, page);
            try
            {
                xtraTabControl1.TabPages.Add(page);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            xtraTabControl1.SelectedTabPage = page;
        }

        private void employeeManagment(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!takeCachedPage("员工管理"))
            {
                addControl("员工管理", new EmployeeManagerControl());
            }
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabPage page = xtraTabControl1.SelectedTabPage;
            if (!_pages.ContainsKey(page.Text))
            {
                _pages.Add(page.Text, page);
            }
            xtraTabControl1.TabPages.Remove(page);
        }

        private void positionManagment(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!takeCachedPage("岗位管理"))
            {
                addControl("岗位管理", new PositionManagerControl());
            }
        }

        private void appraisalElementManagment(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void basic_define(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!takeCachedPage("基本定义"))
            {
                addControl("基本定义", new BasicDefineControl());
            }
        }

        private void employee_performance(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!takeCachedPage("员工表现"))
            {
                addControl("员工表现",new ExecutionPerformanceControl());
            }
        }

        private void onSystemConfig(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!takeCachedPage("系统设置"))
            {
                addControl("系统配置", new ConfigManagmentControl());
            }
        }
    }
}
