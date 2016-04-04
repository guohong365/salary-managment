using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SalarySystem.Data;

namespace SalarySystem.Managment.Basic
{
    public partial class EvaluationFormControl : XtraUserControl
    {
        private const string _FILTER_FORMAT = "[ENABLED]=true and ([POSITION_ID]='{0}' or [POSITION_ID]='{2}')  and [VERSION_ID]='{1}'";

        string getItemsFilter(string positionId)
        {
            return string.Format(_FILTER_FORMAT, positionId, GlobalSettings.EvaluationVersion, GlobalSettings.GENERAL_POSITION);
        }

        private readonly DataView _itemsView;
        public EvaluationFormControl()
        {
            InitializeComponent();
            gridViewForm.ViewCaption = string.Format("考核表定义（{0}）",GlobalSettings.EvaluationFullVersion);
            gridViewItem.ViewCaption = string.Format("基本考核项目（{0}）", GlobalSettings.EvaluationFullVersion);

            repositoryItemLookUpEditType.DataSource = new DataView(DataHolder.EvaluationItemType);
            repositoryItemLookUpEditItemType.DataSource = new DataView(DataHolder.EvaluationItemType);            
            _itemsView = new DataView(DataHolder.EvaluationItem) { RowFilter = getItemsFilter("noId") };
            gridControlEvaluationItems.DataSource = _itemsView;
            gridControlEvaluationForm.DataSource = new DataView(DataHolder.EvaluationForm)
            {
                RowFilter = string.Format("[VERSION_ID]='{0}'", GlobalSettings.EvaluationVersion)
            };
            repositoryItemLookUpEditPositoin.DataSource = new DataView(DataHolder.Position) {RowFilter = "[ENABLED]=true"};
            repositoryItemLookUpEditItemPosition.DataSource = new DataView(DataHolder.Position);
            gridViewForm.CustomDrawCell += GridViewHelper.GerneralCustomCellDrawHandler;
            gridViewFormDetail.CustomDrawCell += GridViewHelper.GerneralCustomCellDrawHandler;
        }
        
        private void initNewRow(object sender, InitNewRowEventArgs e)
        {
            var row = gridViewForm.GetDataRow(e.RowHandle);
            row["ID"] = Guid.NewGuid().ToString();
            row["VERSION_ID"] = GlobalSettings.EvaluationVersion;
            row["ENABLED"] = true;
        }

        static void cloneRow(DataSetSalary.t_evaluation_formRow formRow, DataSetSalary.v_evaluation_form_detailRow detailRow, DataSetSalary.t_evaluation_itemRow itemRow)
        {
            detailRow.FORM_ID = formRow.ID;
            detailRow.ITEM_ID = itemRow.ID;
            detailRow.NAME = itemRow.NAME;
            detailRow.DESCRIPTION = itemRow.DESCRIPTION;
            detailRow.TYPE = itemRow.TYPE;
            detailRow.FULL_MARK = itemRow.FULL_MARK;
            detailRow.ENABLED = itemRow.ENABLED;
            detailRow.VERSION_ID = itemRow.VERSION_ID;
            detailRow.POSITION_ID = itemRow.POSITION_ID;
            detailRow.SHOW_ORDER = 0;
            detailRow.USED = false;
        }
        
        private void add_items(object sender, EventArgs e)
        {
            DataRow formRow = gridViewForm.GetDataRow(gridViewForm.FocusedRowHandle);
            Debug.Assert(formRow!=null);
            var rowHandles = gridViewItem.GetSelectedRows();
            Debug.Assert(rowHandles!=null && rowHandles.Length>0);
            foreach (var itemRow in from rowHandle in rowHandles where gridViewItem.IsDataRow(rowHandle) select gridViewItem.GetDataRow(rowHandle))
            {
                Debug.Assert(itemRow!=null);
                var newDetailRow =DataHolder.EvaluationFormDetail.Newv_evaluation_form_detailRow();
                cloneRow(formRow as DataSetSalary.t_evaluation_formRow, newDetailRow, itemRow as DataSetSalary.t_evaluation_itemRow);
                DataHolder.EvaluationFormDetail.Addv_evaluation_form_detailRow(newDetailRow);
            }
            updateItemsFilter(gridViewForm.FocusedRowHandle);
            gridViewForm.ExpandMasterRow(gridViewForm.FocusedRowHandle);
        }

        private void remove_items(object sender, EventArgs e)
        {
            GridView gridView = gridViewForm.GetDetailView(gridViewForm.FocusedRowHandle, 0) as GridView;
            Debug.Assert(gridView != null, "gridView != null");
            gridView.DeleteSelectedRows();
        }

        private void abandon_forms(object sender, EventArgs e)
        {
            DataHolder.EvaluationForm.RejectChanges();
            DataHolder.EvaluationFormDetail.RejectChanges();
            simpleButtonSave.Enabled = false;
            simpleButtonRevert.Enabled = false;
        }

        void updateItemsFilter(int rowHandle)
        {
            if (gridViewForm.IsDataRow(rowHandle))
            {
                var row = gridViewForm.GetDataRow(rowHandle);
                if (row != null)
                {
                    var gridView = (GridView)gridViewForm.GetDetailView(rowHandle, 0);
                    var inStr = "";
                    if (gridView!=null && gridView.DataRowCount > 0)
                    {
                        var list = new List<string>(gridView.DataRowCount);
                        for (var i = 0; i < gridView.RowCount; i++)
                        {
                            if (!gridView.IsDataRow(i)) continue;
                            var itemRow = gridView.GetDataRow(i);
                            list.Add((string)itemRow["ITEM_ID"]);
                        }
                        inStr = string.Join("','", list);
                    }
                    var preFilter = getItemsFilter(((string)row["POSITION_ID"]) ?? "");
                    var filter = string.IsNullOrEmpty(inStr) ? preFilter : string.Format("{0} AND [ID] NOT IN ('{1}')", preFilter, inStr);
                    _itemsView.RowFilter = filter;
                    return;
                }
            }
            _itemsView.RowFilter = getItemsFilter("");
        }
        private void form_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            updateItemsFilter(e.FocusedRowHandle);
        }

        private void save_forms(object sender, EventArgs e)
        {
            DataHolder.EvaluationFormTableAdapter.Update(DataHolder.EvaluationForm);
            var table=DataHolder.EvaluationFormDetail.GetChanges();
            if (table == null || table.Rows.Count==0) return;
            foreach (DataRow row in table.Rows)
            {
                var formId =(string) row["FORM_ID"];
                var itemId = (string) row["ITEM_ID"];
                var formItems= DataHolder.EvaluationFormItems.FindByEVALUATION_FORM_IDEVALUATION_FORM_ITEM_ID(formId, itemId);
                if (formItems == null)
                {
                    formItems = DataHolder.EvaluationFormItems.Newt_evaluation_form_itemsRow();
                    formItems["EVALUATION_FORM_ID"] = row["FORM_ID"];
                    formItems["EVALUATION_FORM_ITEM_ID"] = row["ITEM_ID"];
                    formItems["VERSION_ID"] = GlobalSettings.EvaluationVersion;
                    formItems["ENABLED"] = row["USED"];
                    formItems["SHOW_ORDER"] = row["SHOW_ORDER"];
                    DataHolder.EvaluationFormItems.Addt_evaluation_form_itemsRow(formItems);
                }
                else
                {
                    formItems["VERSION_ID"] = GlobalSettings.EvaluationVersion;
                    formItems["ENABLED"] = row["USED"];
                    formItems["SHOW_ORDER"] = row["SHOW_ORDER"];
                }

            }
            DataHolder.EvaluationFormItemsTableAdapter.Update(DataHolder.EvaluationFormItems);
            DataHolder.EvaluationFormDetail.AcceptChanges();
            simpleButtonSave.Enabled = false;
            simpleButtonRevert.Enabled = false;
        }

        void setAddItemButtimEnable()
        {
            if (gridViewForm.IsDataRow(gridViewForm.FocusedRowHandle))
            {
                var rowHandles = gridViewItem.GetSelectedRows();
                if (rowHandles == null)
                {
                    simpleButtonAddItems.Enabled = false;
                    return;
                }
                simpleButtonAddItems.Enabled = rowHandles.Any(handle => gridViewItem.IsDataRow(handle));
                return;
            }
            simpleButtonAddItems.Enabled = false;
        }

        void setRemoveItemButtonEnable(GridView gridView)
        {
            var rowHandles = gridView.GetSelectedRows();
            if (rowHandles !=null)
            {
                simpleButtonRemoveItems.Enabled = rowHandles.Any(gridView.IsDataRow);
                return;
            }
            simpleButtonRemoveItems.Enabled = false;
        }

        private void items_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            setAddItemButtimEnable();
            updateItemsFilter(gridViewForm.FocusedRowHandle);
        }

        private void detail_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            setRemoveItemButtonEnable(sender as GridView);
            updateItemsFilter(gridViewForm.FocusedRowHandle);
        }

        private void visibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                DataHolder.EvaluationForm.RowChanged += onRowChanged;
                DataHolder.EvaluationFormDetail.RowChanged += onRowChanged;
            }
            else
            {
                DataHolder.EvaluationForm.RowChanged -= onRowChanged;
                DataHolder.EvaluationFormDetail.RowChanged -= onRowChanged;
            }
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
            DataHolder.EvaluationForm.RowChanged += onRowChanged;
            DataHolder.EvaluationFormDetail.RowChanged += onRowChanged;
            gridViewForm.ExpandAllGroups();
        }


    }
}
