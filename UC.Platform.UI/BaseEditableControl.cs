using System;
using System.Data;
using System.Drawing;
using DevExpress.XtraEditors;

namespace UC.Platform.UI
{
  public partial class BaseEditableControl : XtraUserControl
  {
    private bool _virtualUnload = true;

    public BaseEditableControl()
    {
      InitializeComponent();
      if (VirtualUnload)
      {
        VisibleChanged += onVisableChanged;
      }
    }

    public bool VirtualUnload
    {
      get { return _virtualUnload; }
      set { _virtualUnload = value; }
    }

    public virtual bool CanClose { get; protected set; }

    public virtual void EnableSave(bool enabled)
    {
      simpleButtonSave.Enabled = enabled;
    }

    public virtual void EnableRevert(bool enabled)
    {
      simpleButtonRevert.Enabled = enabled;
    }

    public void Save()
    {
      onSave();
    }

    public void Revert()
    {
      onRevert();
    }

    protected virtual void onSave()
    {
      EnableSave(false);
      EnableRevert(false);
    }

    protected virtual void onRevert()
    {
      EnableSave(false);
      EnableRevert(false);
    }

    protected virtual void onControlLoad()
    {

    }

    protected virtual void onControlUnload()
    {

    }

    protected virtual void onControlReload()
    {

    }

    private void onLoad(object sender, EventArgs e)
    {
      panelControlButtons.Size=new Size(panelControlButtons.Width, 35);
      onControlLoad();
    }

    private void onVisableChanged(object sender, EventArgs e)
    {
      if (Visible)
      {
        onControlReload();
      }
      else
      {
        onControlUnload();
      }
    }

    private void btn_SaveModified(object sender, EventArgs e)
    {
      onSave();
    }

    private void btn_revertChanges(object sender, EventArgs e)
    {
      onRevert();
    }

    protected virtual void onRowChanged(object sender, DataRowChangeEventArgs e)
    {
      if (e.Action == DataRowAction.Add || e.Action == DataRowAction.Change || e.Action == DataRowAction.Delete)
      {
        EnableSave(true);
        EnableRevert(true);
        CanClose = false;
      }
    }

    private void buttonPanelSizeChanged(object sender, EventArgs e)
    {
      simpleButtonRevert.Location=new Point(panelControlButtons.Size.Width - 80, 6);
      simpleButtonSave.Location=new Point(panelControlButtons.Size.Width -161, 6);
    }
  }
}
