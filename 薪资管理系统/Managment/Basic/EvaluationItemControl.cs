using System;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace SalarySystem.Managment.Basic
{
    public partial class EvaluationItemControl : XtraUserControl
    {
        public EvaluationItemControl()
        {
            InitializeComponent();
            gridView1.ViewCaption = string.Format("考核项目定义（{0}）", GlobalSettings.EvaluationFullVersion);
            gridControl1.DataSource = DataHolder.EvaluationItem;
            var dataView = new DataView(DataHolder.EvaluationItemType)
            {
                RowFilter = "[ENABLED]=true"
            };
            repositoryItemLookUpEditType.DataSource = dataView;
            dataView=new DataView(DataHolder.Position){RowFilter = "ENABLED=true"};
            repositoryItemLookUpEditPosition.DataSource = dataView;
            gridView1.ExpandAllGroups();
            gridView1.CustomDrawCell += GridViewHelper.GerneralCustomCellDrawHandler;
        }

        private void initNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(e.RowHandle);
            if(row!=null)
            {
                row["ID"] = Guid.NewGuid().ToString();
                row["VERSION_ID"] = GlobalSettings.EvaluationVersion;
                row["ENABLED"] = true;
            }
        }

        private void save_clicked(object sender, EventArgs e)
        {
            DataHolder.EvaluationItemTableAdapter.Update(DataHolder.EvaluationItem);
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = false;
        }

        private void abandon_clicked(object sender, EventArgs e)
        {
            DataHolder.EvaluationItem.RejectChanges();
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = false;
        }
    }
}
