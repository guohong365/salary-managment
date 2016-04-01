using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SalarySystem.Managment.Editor
{
    public partial class ItemEditForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ItemControl _control;
        [Browsable(false)]
        public DataRow Row
        {
            get { return _control.Row; }
        }

        [DesignOnly(true)]
        public ItemEditForm()
        {
            InitializeComponent();
        }

        public ItemEditForm(IItemEditorFactory factory,string title, DataRow item, int editType)
        {
            InitializeComponent();
            _control = factory.CreateEditorControl(item, editType);
            Size size = _control.Size;
            size.Height += 40;
            ClientSize = size;
            _control.Dock= DockStyle.Fill;
            panelMain.Controls.Add(_control);
            Text = title;
        }

        protected void onOk(object sender, EventArgs e)
        {
            if (_control.ValidateItem())
            {
                DialogResult= DialogResult.OK;
            }
        }

        protected void onCancel(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}