using System;
using System.Data;
using DevExpress.XtraEditors;
using Platform.DBHelper;

namespace SalarySystem.Managment.Basic
{
    public partial class SalaryItemControl : XtraUserControl
    {
        public SalaryItemControl()
        {
            InitializeComponent();

            repositoryItemLookUpEditItemType.DataSource = new DataView(DataHolder.SalaryItemType)
            {
                RowFilter = "ENABLED=true"
            };

            gridControlSalaryItem.DataSource = new DataView(DataHolder.SalaryItem)
            {
                RowFilter = string.Format("[VERSION_ID]='{0}'", GlobalSettings.SalaryVersion)
            };

            repositoryItemLookUpEditPosition.DataSource = new DataView(DataHolder.Position)
            {
                RowFilter = "[ENABLED]=true"
            };

            repositoryItemLookUpEditDataSourceType.DataSource = new DataView(DataHolder.SalaryDataSourceType)
            {
                RowFilter = "[ENABLED]=true"
            };

            GridViewHelper.SetUpEditableGridView(gridViewSalaryItem, false, "基本薪资构成项目", VersionType.SALARY);

        }
        private void onRowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add || e.Action == DataRowAction.Change || e.Action == DataRowAction.Delete)
            {
                simpleButtonSave.Enabled = true;
                simpleButtonRevert.Enabled = true;
            }
        }
        void control_load(object sender, EventArgs e)
        {
            DataHolder.SalaryItem.RowChanged += onRowChanged;
            gridViewSalaryItem.ExpandAllGroups();
        }
        private void visibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                DataHolder.SalaryItem.RowChanged += onRowChanged;
            }
            else
            {
                DataHolder.SalaryItem.RowChanged -= onRowChanged;
            }
        }

        private void save_items(object sender, EventArgs e)
        {
            DBHandler.UpdateOnce(DataHolder.SalaryItem);
            simpleButtonSave.Enabled = false;
            simpleButtonRevert.Enabled = false;
        }

        private void abandon_items(object sender, EventArgs e)
        {
            DataHolder.SalaryItem.RejectChanges();
            simpleButtonSave.Enabled = false;
            simpleButtonRevert.Enabled = false;
        }

        private void initNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var row = gridViewSalaryItem.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row["ID"] = Guid.NewGuid().ToString();
                row["ENABLED"] = true;
                row["VERSION_ID"] = GlobalSettings.SalaryVersion;
                row["DATA_SOURCE_TYPE"] = GlobalSettings.TYPE_SALARY_DATA_SOURCE_INLINE;
            }
        }
    }
}
