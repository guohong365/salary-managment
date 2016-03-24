using System;
using System.Drawing;
using System.Windows.Forms;

namespace salary
{
    public partial class SetUpForm : Form
    {
        public ISetup SetUp { get; set; }
        public SetUpForm(ISetup setup)
        {
            SetUp = setup;
            InitializeComponent();
            UserControl control = setup.GetControl();
            if (control != null)
            {
                Size size = control.Size;
                size.Height = size.Height + functionPanel.Height;
                control.Dock = DockStyle.Fill;
                ClientSize = size;
                mainPanel.Controls.Add(control);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ret=SetUp.Save();
            if (ret != 0)
            {
                MessageBox.Show(this, SetUp.GetErrorMessage(ret));
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SetUpForm_Load(object sender, EventArgs e)
        {
            SetUp.Init();
        }

        private void SetUpFrom_Unload(object sender, EventArgs e)
        {
            SetUp.Deinit();
        }
    }
}
