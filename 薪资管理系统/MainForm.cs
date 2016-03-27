using System.Collections;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;
        }

        private void employeeManagment(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!takeCachedPage("员工管理"))
            {
                addControl("员工管理", new EmployeeManagerControl());
            }
        }

        private void xtraTabControl1_CloseButtonClick(object sender, System.EventArgs e)
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
    }
}
