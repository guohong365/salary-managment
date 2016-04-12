using System;
using System.Data;
using System.Linq;
using SalarySystem.Managment.Basic;
using UC.Platform.Data.DBHelper;

namespace SalarySystem.Config
{
    public partial class AutoAssignmentWeightControl : BaseControl
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
                        e.DisplayText = string.Format("{0:P}", decVal);
                        break;
                }
            }
        }

        private void onEditValueChanged(object sender, System.EventArgs e)
        {

        }
    }
}
