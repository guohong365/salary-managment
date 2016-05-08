using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace UC.Platform.UI
{
    public delegate int GetCheckedCountHandler(object sender);

    public delegate object GetCheckedValueHandler(object sender, int dataRowHanlde, bool isChecked);


    public class CheckedAllGridViewHelper
    {
        public GridColumn Column { get; set; }
        public GridView View { get; set; }
        private RepositoryItemCheckEdit _checkEdit;
        private CheckEditViewInfo _checkInfo;
        private CheckEditPainter _checkPainter;
        public event GetCheckedCountHandler GetCheckedCount;
        public event GetCheckedValueHandler GetCheckedValue;

      public virtual void BindToView(GridView view, GridColumn column)
      {
        
        View = view;
        Column = column;
        _checkEdit = (RepositoryItemCheckEdit)View.GridControl.RepositoryItems.Add("CheckEdit");
        _checkInfo = (CheckEditViewInfo)_checkEdit.CreateViewInfo();
        _checkPainter = (CheckEditPainter)_checkEdit.CreatePainter();
        View.CustomDrawColumnHeader += customDrawCheckAllColumnHeader;
        View.Click += headerClicked;
      }

      protected virtual Rectangle calcCheckRect(ColumnHeaderCustomDrawEventArgs e)
        {
            Rectangle bounds =e.Bounds;
            SizeF textSize= e.Graphics.MeasureString(e.Column.Caption, e.Appearance.GetFont());
            Size checkSize = _checkInfo.CalcBestFit(e.Graphics);
            switch (e.Appearance.HAlignment)
            {
                case HorzAlignment.Default:
                case HorzAlignment.Near:
                    e.Info.CaptionRect = bounds;
                    bounds.X = (int) (bounds.X + textSize.Width);
                    break;
                case HorzAlignment.Center:
                    e.Info.CaptionRect =new Rectangle(bounds.X, bounds.Y, bounds.Width-checkSize.Width, bounds.Height);
                    bounds.X = (int) (e.Info.CaptionRect.X + e.Info.CaptionRect.Width/2.0 + textSize.Width/2.0);
                    break;
                case HorzAlignment.Far:
                    e.Info.CaptionRect =
                        new Rectangle(bounds.X, bounds.Y, bounds.Width - checkSize.Width,bounds.Height);
                    bounds.X = e.Info.CaptionRect.X + e.Info.CaptionRect.Width;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            bounds.Width = checkSize.Width;
            return bounds;
        }

        protected virtual void customDrawCheckAllColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (!ReferenceEquals(e.Column, Column)) return;
            Rectangle checkRectangle = calcCheckRect(e);
            checkRectangle.Inflate(2, 2);
            e.Painter.DrawObject(e.Info);
            _checkInfo.CheckInfo.Caption = e.Column.Caption;
            _checkInfo.Bounds = checkRectangle;
            _checkInfo.CalcViewInfo(e.Graphics);
            int selectedCount = onGetCheckedCount();
            if (selectedCount == 0)
            {
              _checkInfo.EditValue = false;
            }
            else if (selectedCount == View.DataRowCount)
            {
              _checkInfo.EditValue = true;
            }
            else
            {
              _checkInfo.EditValue = _checkEdit.ValueGrayed;
            }
            ControlGraphicsInfoArgs args = new ControlGraphicsInfoArgs(_checkInfo, new GraphicsCache(e.Graphics), _checkInfo.Bounds);
            _checkPainter.Draw(args);
            args.Cache.Dispose();
            foreach (DrawElementInfo innerElement in e.Info.InnerElements.Cast<DrawElementInfo>().Where(innerElement => innerElement.Visible))
            {
                ObjectPainter.DrawObject(e.Cache, innerElement.ElementPainter, innerElement.ElementInfo);
            }
            e.Handled = true;
        }

        protected virtual void headerClicked(object sender, EventArgs e)
        {
            Point pt = View.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = View.CalcHitInfo(pt);
            if (!(info.InColumn && ReferenceEquals(info.Column, Column))) return;
            selectAll(onGetCheckedCount() != View.DataRowCount);
        }

      protected void selectAll(bool isChecked)
        {
            for (int i = 0; i < View.DataRowCount; i++)
            {
                View.SetRowCellValue(i, Column, onGetCheckedValue(i, isChecked));
            }
        }

      private int defaultGetCheckedCount(object sender)
      {
        CheckedAllGridViewHelper helper = (CheckedAllGridViewHelper) sender;
        int count = 0;
        if (helper.View != null && helper.Column!=null)
        {
          for (int i = 0; i < helper.View.RowCount; i++)
          {
            if (!helper.View.IsDataRow(i)) continue;

            if (!string.IsNullOrEmpty(helper.Column.FieldName))
            {
              object val = helper.View.GetRowCellValue(i, Column);
              try
              {
                count += Convert.ToBoolean(val) ? 1 : 0;
              }
              catch
              {
                // ignored
              }
            }
          }
        }
        return count;
      }

        protected virtual int onGetCheckedCount()
        {
          GetCheckedCountHandler handler = GetCheckedCount;
          if (handler == null) return defaultGetCheckedCount(this);
          return handler(this);
        }

        protected virtual object onGetCheckedValue(int dataRowHanle, bool ischecked)
        {
            GetCheckedValueHandler handler = GetCheckedValue;
          if (handler == null) return ischecked;
          return handler(this, dataRowHanle, ischecked);
        }
    }
}