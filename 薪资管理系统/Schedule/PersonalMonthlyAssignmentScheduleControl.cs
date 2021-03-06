﻿using System;
using System.Diagnostics;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SalarySystem.Data;
using UC.Platform.UI;

namespace SalarySystem.Schedule
{
    public partial class PersonalMonthlyAssignmentScheduleControl : XtraUserControl
    {
        public PersonalMonthlyAssignmentScheduleControl()
        {
            InitializeComponent();
            repositoryItemLookUpEditUnit.DataSource = DataHolder.Unit;
            repositoryItemLookUpEditType.DataSource = DataHolder.AssignmentItemType;
        }

        private DataSetSalary.v_personal_assignment_scheduleDataTable _dataTable;
        public DataSetSalary.v_personal_assignment_scheduleDataTable DataTable
        {
            get
            {
                return _dataTable;
            }
            set
            {
                _dataTable = value;
                gridControl1.DataSource = value;
            }
        }

        private void customDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            var row = gridView1.GetDataRow(e.RowHandle) as DataSetSalary.v_personal_assignment_scheduleRow;
            if (row==null) return;

            if (!row.IsPERF_IDNull())
            {
                e.Appearance.ForeColor = Color.Teal;
            }
            GridViewHelper.CustomModifiedCellDrawHandler(sender, e);
        }

        private void cellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            var gridView = sender as GridView;
            Debug.Assert(gridView != null);
            if (e.Column.FieldName == "ASSIGNED")
            {
                var row = gridView.GetDataRow(e.RowHandle) as DataSetSalary.v_personal_assignment_scheduleRow;
                Debug.Assert(row != null);
                row.TARGET = Convert.ToBoolean(e.Value) ? row.VALUE : 0;
            }
        }
    }
}
