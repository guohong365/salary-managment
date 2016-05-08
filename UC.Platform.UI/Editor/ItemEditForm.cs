using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace UC.Platform.UI.Editor
{
  public partial class ItemEditForm : DevExpress.XtraEditors.XtraForm
  {
    private readonly IItemEditor _editor;

    [Browsable(false)]
    public DataRow Row
    {
      get { return _editor.Row; }
    }

    [DesignOnly(true)]
    public ItemEditForm()
    {
      InitializeComponent();
    }

    public ItemEditForm(IItemEditorFactory factory, string title, DataRow item, int editType)
    {
      InitializeComponent();
      _editor = factory.CreateEditorControl(item, editType);
      Control control = _editor as Control;
      Debug.Assert(control != null);
      Size size = control.Size;
      size.Height += 40;
      ClientSize = size;
      control.Dock = DockStyle.Fill;
      panelMain.Controls.Add(control);
      Text = title;
    }

    protected void onOk(object sender, EventArgs e)
    {
      if (_editor.ValidateItem())
      {
        DialogResult = DialogResult.OK;
      }
    }

    protected void onCancel(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }
  }
}