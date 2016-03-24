using System.Windows.Forms;
using salary.main.employee;

namespace salary.main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuEmployeeManager_Click(object sender, System.EventArgs e)
        {
            TabPage page=new TabPage("员工管理");
            UserControl control=new EmployeeManagerControl();
            control.Dock = DockStyle.Fill;
            page.Controls.Add(control);
            this.tabControl1.TabPages.Add(page);
        }
    }
}
