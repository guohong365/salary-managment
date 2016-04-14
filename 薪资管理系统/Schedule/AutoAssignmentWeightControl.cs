using System.Data;
using System.Drawing;
using UC.Platform.Data;

namespace SalarySystem.Schedule
{
    public partial class AutoAssignmentWeightControl : BaseEditableControl
    {
        public AutoAssignmentWeightControl()
        {
            InitializeComponent();
        }

        private DataView _dataView;
        protected override void onControlLoad()
        {
            base.onControlLoad();
            GridViewHelper.SetUpEditableGridView(gridView1, false, "默认任务分配月度占比");
            _dataView=new DataView(DataHolder.Settings)            
            {
                RowFilter = "[NAME] LIKE 'assignment.schedule%'",
                Sort = "[NAME]"
            };
            gridControl1.DataSource = _dataView;

            DataHolder.Settings.RowChanged += onRowChanged;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            DataHolder.Settings.RowChanged += onRowChanged;
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            DataHolder.Settings.RowChanged -= onRowChanged;
        }

        protected override void onSave()
        {
            base.onSave();
            if (DBHandlerEx.UpdateOnce(DataHolder.Settings.GetChanges())>=0)
            {
                DataHolder.Settings.AcceptChanges();
            }
        }

        protected override void onRevert()
        {
            base.onRevert();
            DataHolder.Settings.RejectChanges();
        }

        private void onCustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gridView1.IsDataRow(e.RowHandle))
            {
                switch (e.Column.FieldName)
                {
                    case "NAME":
                        string strVal = e.CellValue.ToString();
                        strVal = strVal.Substring(strVal.LastIndexOf('.') + 1);
                        string month = strVal + "月";
                        e.DisplayText = month;
                        break;
                    case "VALUE":
                        decimal decVal = decimal.Parse(e.CellValue.ToString());
                        e.DisplayText = string.Format("{0}%", decVal);
                        break;
                }
            }
        }

        private void onCustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            if(e.Info.DisplayText==string.Empty) return;
            if (e.Column.FieldName == "VALUE")
            {
                decimal val = (decimal) (e.Info.Value);
                if ( val != 100)
                {
                    e.Appearance.ForeColor = Color.Red;
                    e.Info.DisplayText += "（分配占比累计和"+(val < 100 ?"少于": "超出")+"100%！）";
                }
                else
                {
                    e.Appearance.Reset();
                }
            }
        }
    }
}
