using System;
using System.Data;
using System.Linq;
using SalarySystem.Data;

namespace SalarySystem.Managment.Position
{
    public partial class EmployeeListControl : DevExpress.XtraEditors.XtraUserControl
    {
        public EmployeeListControl()
        {
            InitializeComponent();
            _dataView=new DataView(DataHolder.DataSet.t_employee);
            _positionDataView=new DataView(DataHolder.DataSet.t_position) {RowFilter = "ENABLED=true"};
            _leaderDataView=new DataView(DataHolder.DataSet.t_employee) {RowFilter = "ENABLED=true"};
            gridControl1.DataSource = _dataView;
            repositoryItemLookUpEditLeader.DataSource = _leaderDataView;
            repositoryItemLookUpEditPosition.DataSource = _positionDataView;
        }

        private readonly DataView _dataView;
        private readonly DataView _positionDataView;
        private readonly DataView _leaderDataView;
        private string _currentPosition;
        public string CurrentPosition
        {
            get
            {
                return _currentPosition; 
            }
            set
            {
                _currentPosition = value;
                if (string.IsNullOrEmpty(_currentPosition))
                {
                    _dataView.RowFilter = "";
                    _positionDataView.RowFilter = "";
                    _leaderDataView.RowFilter = "";
                }
                else
                {
                    _dataView.RowFilter = string.Format("POSITION_ID={0}", _currentPosition);
                    DataSetSalary.t_positionRow row= DataHolder.DataSet.t_position.FindByID(_currentPosition);
                    if (row != null && !string.IsNullOrEmpty(row.LEADER_ID))
                    {
                        _leaderDataView.RowFilter=string.Format("ENABLED=true And POSITION_ID={0}", row.LEADER_ID);
                    }
                    
                }
                gridControl1.RefreshDataSource();
            }
        }

        private void gridDataSourceChanged(object sender, EventArgs e)
        {
            gridControl1.RefreshDataSource();
        }

        private void initNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row["POSITION_ID"] = CurrentPosition;
                //DataSetSalary.t_employeeRow employeeRow = DataHolder.DataSet.t_employee.Newt_employeeRow();
                //employeeRow.ID =  row["ID"] as string;
                //employeeRow.NAME = row["NAME"] as string;
                //employeeRow.LEADER_ID = row["LEADER_ID"] as string;
                //employeeRow.POSITION_ID = CurrentPosition;
                //employeeRow.DESCRIPTION = row["DESCRIPTION"] as string;
                //employeeRow.ENTRY_TIME = (DateTime) row["ENTRY_TIME"];
                //employeeRow.DISMISSION_TIME = (DateTime) row["DISMISSION_TIME"];
                //employeeRow.ENABLED = (bool) row["ENABLED"];
                //DataHolder.DataSet.t_employee.Addt_employeeRow(employeeRow);
            }
        }

        private void customDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(e.RowHandle);
            if (row == null)
            {
                return;
            }
            if (e.Column.FieldName == "DISMISSION_TIME")
            {
                if (row.IsNull("DISMISSION_TIME"))
                {
                    e.Handled = true;
                    e.DisplayText = "";
                }
            }
            else if(e.Column.FieldName=="LEADER_ID")
            {
                if (row.IsNull("LEADER_ID"))
                {
                    e.Handled = true;
                    e.DisplayText = "";
                }
            } else if (e.Column.FieldName == "DESCRIPTION")
            {
                if (row.IsNull("DESCRIPTION"))
                {
                    e.Handled = true;
                    e.DisplayText = "";
                }
            }
           
        }
    }
}
