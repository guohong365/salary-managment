using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SalarySystem.Data;
using UC.Platform.Data;
using UC.Platform.UI;

namespace SalarySystem.Managment.Evaluation
{
    public partial class EvaluationFormControl : BaseEditableControl
    {
        private const string _FILTER_FORMAT = "[ENABLED]=true and ([POSITION_ID]='{0}' or [POSITION_ID]='{1}')";

        private const string _EVALUATION_FROM_ITEMS_SQL_FORMAT =
            "select * from t_evaluation_form_items where VERSION_ID='{0}'";

        private readonly DataSet _dataSet = new DataSet();

        private readonly DataSetSalary.t_evaluation_formDataTable _evaluationForm =
            new DataSetSalary.t_evaluation_formDataTable();

        private readonly DataSetSalary.v_evaluation_form_detailDataTable _evaluationFormDetail =
            new DataSetSalary.v_evaluation_form_detailDataTable();

        private readonly DataSetSalary.t_evaluation_itemDataTable _evaluationItem =
            new DataSetSalary.t_evaluation_itemDataTable();

        private readonly DataSetSalary.t_evaluation_form_itemsDataTable _formItems =
            new DataSetSalary.t_evaluation_form_itemsDataTable();

        private readonly DataView _itemsView;

        #region 加载数据

        private const string _EVALUATION_FORM_DETAIL_SQL_FROMAT =
            "select * from v_evaluation_form_detail where VERSION_ID='{0}'";

        private const string _EVALUATION_FORM_SQL_FORMAT = "select * from t_evaluation_form where VERSION_ID='{0}'";
        private const string _EVALUATION_ITEM_SQL_FORMAT = "select * from t_evaluation_item where VERSION_ID='{0}'";

        private void loadData()
        {
          _evaluationFormDetail.Clear();
          _evaluationForm.Clear();
          _evaluationItem.Clear();
          _formItems.Clear();
          DBHandlerEx handler=DBHandlerEx.GetBuffer();

          try
          {
            string sql = string.Format(_EVALUATION_FROM_ITEMS_SQL_FORMAT, GlobalSettings.EvaluationVersion);
            handler.Fill(_formItems, sql);

            sql = string.Format(_EVALUATION_ITEM_SQL_FORMAT, GlobalSettings.EvaluationVersion);
            handler.Fill(_evaluationItem, sql);

            sql = string.Format(_EVALUATION_FORM_SQL_FORMAT, GlobalSettings.EvaluationVersion);
            handler.Fill(_evaluationForm, sql);

            sql = string.Format(_EVALUATION_FORM_DETAIL_SQL_FROMAT, GlobalSettings.EvaluationVersion);
            handler.Fill(_evaluationFormDetail, sql);
          }
          finally
          {
            handler.FreeBuffer();
          }
        }

        #endregion

        #region 覆盖基类

        protected override void onControlReload()
        {
            base.onControlReload();
            loadData();
            _evaluationForm.RowChanged += onRowChanged;
            _evaluationFormDetail.RowChanged += onRowChanged;
            _formItems.RowDeleted += onRowChanged;
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _evaluationForm.RowChanged -= onRowChanged;
            _evaluationFormDetail.RowChanged -= onRowChanged;
            _formItems.RowChanged -= onRowChanged;
            _formItems.RowDeleted -= onRowChanged;
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            loadData();
            _evaluationForm.RowChanged += onRowChanged;
            _evaluationFormDetail.RowChanged += onRowChanged;
            _formItems.RowChanged += onRowChanged;
            _formItems.RowDeleted += onRowChanged;
            gridViewForm.ExpandAllGroups();
        }

        #endregion

        public EvaluationFormControl()
        {
            initDataSet();
            InitializeComponent();
            gridViewForm.ViewCaption = string.Format("考核表定义（{0}）", GlobalSettings.EvaluationFullVersion);
            gridViewItem.ViewCaption = string.Format("基本考核项目（{0}）", GlobalSettings.EvaluationFullVersion);

            repositoryItemLookUpEditType.DataSource = new DataView(DataHolder.EvaluationItemType);
            repositoryItemLookUpEditItemType.DataSource = new DataView(DataHolder.EvaluationItemType);

            _itemsView = new DataView(_evaluationItem) {RowFilter = getItemsFilter("noId")};

            gridControlEvaluationItems.DataSource = _itemsView;
            gridControlEvaluationForm.DataSource = _evaluationForm;

            repositoryItemLookUpEditPositoin.DataSource = new DataView(DataHolder.Position)
            {
                RowFilter = "[ENABLED]=true"
            };
            repositoryItemLookUpEditItemPosition.DataSource = new DataView(DataHolder.Position);
            gridViewForm.CustomDrawCell += GridViewHelper.CustomModifiedCellDrawHandler;
            gridViewFormDetail.CustomDrawCell += GridViewHelper.CustomModifiedCellDrawHandler;
        }

        private static string getItemsFilter(string positionId)
        {
            return string.Format(_FILTER_FORMAT, positionId, GlobalSettings.GENERAL_POSITION);
        }

        private void initDataSet()
        {
            _dataSet.Tables.Add(_evaluationFormDetail);
            _dataSet.Tables.Add(_evaluationForm);
            _dataSet.Tables.Add(_evaluationItem);
            DataRelation relation = new DataRelation("evaluation_form_detail", new[] {_evaluationForm.IDColumn},
                new[] {_evaluationFormDetail.FORM_IDColumn});
            _dataSet.Relations.Add(relation);
        }


        private void initNewRow(object sender, InitNewRowEventArgs e)
        {
            DataSetSalary.t_evaluation_formRow row = gridViewForm.GetDataRow(e.RowHandle) as DataSetSalary.t_evaluation_formRow;
            Debug.Assert(row != null);
            row.ID = Guid.NewGuid().ToString();
            row.VERSION_ID = GlobalSettings.EvaluationVersion;
            row.ENABLED = true;
        }

      private static void cloneRow(DataSetSalary.t_evaluation_formRow formRow,
        DataSetSalary.v_evaluation_form_detailRow detailRow, DataSetSalary.t_evaluation_itemRow itemRow)
      {
        detailRow.FORM_ID = formRow.ID;
        detailRow.ITEM_ID = itemRow.ID;
        detailRow.NAME = itemRow.NAME;
        detailRow.DESCRIPTION = itemRow.IsDESCRIPTIONNull() ? "" : itemRow.DESCRIPTION;
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
            DataSetSalary.t_evaluation_formRow formRow = gridViewForm.GetDataRow(gridViewForm.FocusedRowHandle) as DataSetSalary.t_evaluation_formRow;
            if (formRow == null) return;

            int[] rowHandles = gridViewItem.GetSelectedRows();
            Debug.Assert(rowHandles != null && rowHandles.Length > 0);
            foreach (
                DataRow itemRow in
                    from rowHandle in rowHandles
                    where gridViewItem.IsDataRow(rowHandle)
                    select gridViewItem.GetDataRow(rowHandle))
            {
                DataSetSalary.v_evaluation_form_detailRow newDetailRow =
                    _evaluationFormDetail.Newv_evaluation_form_detailRow();
                cloneRow(formRow, newDetailRow, itemRow as DataSetSalary.t_evaluation_itemRow);
                _evaluationFormDetail.Addv_evaluation_form_detailRow(newDetailRow);
                DataSetSalary.t_evaluation_form_itemsRow newFormsItem= _formItems.Newt_evaluation_form_itemsRow();
                newFormsItem.EVALUATION_FORM_ID = newDetailRow.FORM_ID;
                newFormsItem.EVALUATION_FORM_ITEM_ID = newDetailRow.ITEM_ID;
                newFormsItem.VERSION_ID = GlobalSettings.EvaluationVersion;
                newFormsItem.ENABLED = newDetailRow.USED;
                newFormsItem.SHOW_ORDER = newDetailRow.SHOW_ORDER;
                _formItems.Addt_evaluation_form_itemsRow(newFormsItem);
            }
            updateItemsFilter(gridViewForm.FocusedRowHandle);
            gridViewForm.ExpandMasterRow(gridViewForm.FocusedRowHandle);
        }

        private void remove_items(object sender, EventArgs e)
        {
            GridView gridView = (GridView) gridViewForm.GetDetailView(gridViewForm.FocusedRowHandle, 0);
            var handles = gridView.GetSelectedRows();
          foreach (
            DataSetSalary.t_evaluation_form_itemsRow itemsRow in
              (from rowHandle in handles where gridView.IsDataRow(rowHandle) select gridView.GetDataRow(rowHandle))
                .Cast<DataSetSalary.v_evaluation_form_detailRow>()
                .Select(row => _formItems.FindByEVALUATION_FORM_IDEVALUATION_FORM_ITEM_ID(row.FORM_ID, row.ITEM_ID))
                .Where(itemsRow => itemsRow != null))
          {
            itemsRow.Delete();
          }
          gridView.DeleteSelectedRows();
        }

        protected override void onRevert()
        {
            base.onRevert();
            _evaluationFormDetail.RejectChanges();
            _evaluationForm.RejectChanges();
        }

        private void updateItemsFilter(int rowHandle)
        {
            if (gridViewForm.IsDataRow(rowHandle))
            {
                DataSetSalary.t_evaluation_formRow row = gridViewForm.GetDataRow(rowHandle) as DataSetSalary.t_evaluation_formRow;
                if (row != null)
                {
                    gridViewForm.ExpandMasterRow(rowHandle);
                    GridView gridView = (GridView) gridViewForm.GetDetailView(rowHandle, 0);
                    string inStr = "";
                    if (gridView != null && gridView.DataRowCount > 0)
                    {
                        var list = new List<string>(gridView.DataRowCount);
                        for (int i = 0; i < gridView.RowCount; i++)
                        {
                            if (!gridView.IsDataRow(i)) continue;
                            DataSetSalary.v_evaluation_form_detailRow itemRow = (DataSetSalary.v_evaluation_form_detailRow) gridView.GetDataRow(i);
                            list.Add(itemRow.ITEM_ID);
                        }
                        inStr = string.Join("','", list.ToArray());
                    }
                    string preFilter = getItemsFilter(row.POSITION_ID ?? "");
                    string filter = string.IsNullOrEmpty(inStr)
                        ? preFilter
                        : string.Format("{0} AND [ID] NOT IN ('{1}')", preFilter, inStr);
                    _itemsView.RowFilter = filter;
                    return;
                }
            }
            _itemsView.RowFilter = "[POSITION_ID]='noselect'"; // getItemsFilter("");
        }

        private void form_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            updateItemsFilter(e.FocusedRowHandle);
        }

        protected override void onSave()
        {
            DBHandlerEx handler = DBHandlerEx.GetBuffer();
            try
            {
                handler.BeginTransaction();
                handler.Update(_evaluationForm.GetChanges());

                //TODO 优化

                //_formItems
                handler.Update(_formItems.GetChanges());
                _formItems.AcceptChanges();
                _evaluationForm.AcceptChanges();
                _evaluationFormDetail.AcceptChanges();
                handler.EndTransaction(true);
                base.onSave();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                handler.FreeBuffer();
            }
        }

        private void setAddItemButtimEnable()
        {
            if (gridViewForm.IsDataRow(gridViewForm.FocusedRowHandle))
            {
                int[] rowHandles = gridViewItem.GetSelectedRows();
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

        private void setRemoveItemButtonEnable(GridView gridView)
        {
            int[] rowHandles = gridView.GetSelectedRows();
            if (rowHandles != null)
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

        private void detailCellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView) sender;
            DataSetSalary.v_evaluation_form_detailRow row = (DataSetSalary.v_evaluation_form_detailRow) gridView.GetDataRow(e.RowHandle);
            if(e.Column.Name==colUSED.Name)
            {
                DataSetSalary.t_evaluation_form_itemsRow item=_formItems.FindByEVALUATION_FORM_IDEVALUATION_FORM_ITEM_ID(row.FORM_ID, row.ITEM_ID);
                item.ENABLED = row.USED;
            }
            if (e.Column.Name == colSHOW_ORDER.Name)
            {
                DataSetSalary.t_evaluation_form_itemsRow item = _formItems.FindByEVALUATION_FORM_IDEVALUATION_FORM_ITEM_ID(row.FORM_ID, row.ITEM_ID);
                item.SHOW_ORDER = row.SHOW_ORDER;
            }
        }
    }
}