using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
using SalarySystem.Data;
using UC.Platform.Data;

namespace SalarySystem.Managment.Salary
{
    public partial class FunctionDefineControl : BaseEditableControl
    {
        public FunctionDefineControl()
        {
            initDataSet();
            InitializeComponent();
        }

        private readonly DataSetSalary.t_salary_functionDataTable _salaryFunction = new DataSetSalary.t_salary_functionDataTable();

        private readonly DataSetSalary.t_salary_function_parameterDataTable _salaryFunctionParameter =
            new DataSetSalary.t_salary_function_parameterDataTable();

        private const string _FUNCTION_LOAD_SQL = "select * from t_salary_function";
        private const string _PARAMETER_LOAD_SQL = "select * from t_salary_function_parameter";

        readonly DataSet _dataSet =new DataSet();

        private void initDataSet()
        {
            _dataSet.Tables.Add(_salaryFunction);
            _dataSet.Tables.Add(_salaryFunctionParameter);
            DataRelation relation=new DataRelation("function_parameter", _salaryFunction.IDColumn, _salaryFunctionParameter.FUNC_IDColumn);
            _dataSet.Relations.Add(relation);
        }

        void loadData()
        {
            var handler=DBHandlerEx.GetBuffer();
            try
            {
                handler.Fill(_salaryFunction, _FUNCTION_LOAD_SQL);
                handler.Fill(_salaryFunctionParameter, _PARAMETER_LOAD_SQL);
            }
            finally
            {
                handler.FreeBuffer();
            }

        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            loadData();
            gridControlFunction.DataSource = _salaryFunction;
            _salaryFunction.RowChanged += onRowChanged;
            _salaryFunctionParameter.RowChanged += onRowChanged;
            gridViewFunction.InitNewRow += initNewFunctionRow;
            repositoryItemLookUpEditType.DataSource = DataHolder.ParameterType;
            gridViewParameter.InitNewRow += initNewParameterRow;
            gridViewFunction.ShowingEditor += showingFunctionEditor;
            gridViewFunction.ShownEditor += shownFunctionEditor;
            gridViewParameter.ShowingEditor += showingParameterEditor;
        }


        private static void initNewParameterRow(object sender, InitNewRowEventArgs e)
        {
            GridView gridView = (GridView) sender;
            var rowView = gridView.SourceRow as DataRowView;
            Debug.Assert(rowView!=null);
            var parentRow = rowView.Row as DataSetSalary.t_salary_functionRow;
            var row = gridView.GetDataRow(e.RowHandle) as DataSetSalary.t_salary_function_parameterRow;
            Debug.Assert(row!=null);
            Debug.Assert(parentRow!=null);
            row.FUNC_ID = parentRow.ID;
            row.ID = Guid.NewGuid().ToString();
            row.TYPE = "System.Int32";
            row.LENGTH =0;
        }

        private static void initNewFunctionRow(object sender, InitNewRowEventArgs e)
        {
            GridView gridView = (GridView) sender;
            var row=gridView.GetDataRow(e.RowHandle) as DataSetSalary.t_salary_functionRow;
            Debug.Assert(row!=null);
            row.ID = Guid.NewGuid().ToString();
            row.ENABLED = true;
            row.PREDEFINED = false;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            _salaryFunction.RowChanged += onRowChanged;
            _salaryFunctionParameter.RowChanged += onRowChanged;
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _salaryFunction.RowChanged -= onRowChanged;
            _salaryFunctionParameter.RowChanged -= onRowChanged;
        }

        protected override void onSave()
        {
            var handler = DBHandlerEx.GetBuffer();
            try
            {
                handler.BeginTransaction();
                handler.Update(_salaryFunction);
                handler.Update(_salaryFunctionParameter);
                _dataSet.AcceptChanges();
                base.onSave();
            }
            finally
            {
                handler.FreeBuffer();
            }
        }

        protected override void onRevert()
        {
            base.onRevert();
            _dataSet.RejectChanges();
        }

        

        private void functionEditorButtonClicked(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //show 公式编辑器
        }

        private void showingFunctionEditor(object sender, CancelEventArgs e)
        {
            var gridView = sender as GridView;
            if (gridView == null || !gridControlFunction.MainView.Equals(gridView) ||
                gridView.IsNewItemRow(gridView.FocusedRowHandle)) return;
            
            var row = gridView.GetDataRow(gridView.FocusedRowHandle) as DataSetSalary.t_salary_functionRow;
            Debug.Assert(row!=null);
            if (row.PREDEFINED)
            {
                if(gridView.FocusedColumn.FieldName!="SQL_STMT")
                e.Cancel = true;
            }
        }
        private static void shownFunctionEditor(object sender, EventArgs e)
        {
            var gridView = (GridView) sender;
            if (gridView.IsNewItemRow(gridView.FocusedRowHandle))
            {
                gridView.ActiveEditor.Properties.ReadOnly = false;
                return;
            }
            var row = gridView.GetDataRow(gridView.FocusedRowHandle) as DataSetSalary.t_salary_functionRow;
            Debug.Assert(row!=null);
            if (row.PREDEFINED)
            {
                gridView.ActiveEditor.Properties.ReadOnly = true;
            }
        }

        private static void showingParameterEditor(object sender, CancelEventArgs e)
        {
            var gridView = (GridView) sender;
            Debug.Assert(gridView!=null);
            if (gridView.IsNewItemRow(gridView.FocusedRowHandle))
            {
                return;
            }
            var row = gridView.GetDataRow(gridView.FocusedRowHandle) as DataSetSalary.t_salary_function_parameterRow;
            Debug.Assert(row!=null);
            if (gridView.FocusedColumn.FieldName != "LENGTH") return;
            if(row.IsNull("TYPE")) return;
            if (DataHolder.ParameterType.FindBySYSTEM_TYPE(row.TYPE).FIXED)
                e.Cancel = true;
        }
    }
}
