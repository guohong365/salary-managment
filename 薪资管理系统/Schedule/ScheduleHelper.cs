using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace SalarySystem.Schedule
{
    internal class ScheduleHelper
    {
        public static GridControl CreateMonthAssignmentGrid(string name)
        {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            GridColumn colEmployeeName = new GridColumn();
            GridColumn colPositionName = new GridColumn();
            GridColumn colName = new GridColumn();
            GridColumn colTarget = new GridColumn();
            GridColumn colUnitName = new GridColumn();

            ((System.ComponentModel.ISupportInitialize) (gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (gridView)).BeginInit();
            // 
            // gridControl
            // 
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl.Location = new System.Drawing.Point(0, 0);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl" + name ;
            gridControl.Size = new System.Drawing.Size(768, 566);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[]
            {
                gridView
            });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new[]
            {
                colEmployeeName,
                colPositionName,
                colName,
                colTarget,
                colUnitName
            });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            // 
            // colEmployeeName
            // 
            colEmployeeName.Caption = "姓名";
            colEmployeeName.FieldName = "EMPLOYEE_NAME";
            colEmployeeName.Name = "colEmployeeName";
            colEmployeeName.OptionsColumn.AllowEdit = false;
            colEmployeeName.Visible = true;
            colEmployeeName.VisibleIndex = 0;
            // 
            // colPositionName
            // 
            colPositionName.Caption = "岗位";
            colPositionName.FieldName = "POSITION_NAME";
            colPositionName.Name = "colPositionName";
            colPositionName.OptionsColumn.AllowEdit = false;
            colPositionName.Visible = true;
            colPositionName.VisibleIndex = 1;
            // 
            // colName
            // 
            colName.Caption = "任务名称";
            colName.FieldName = "NAME";
            colName.Name = "colName";
            colName.OptionsColumn.AllowEdit = false;
            colName.Visible = true;
            colName.VisibleIndex = 2;
            // 
            // colTarget
            // 
            colTarget.Caption = "任务额度";
            colTarget.FieldName = "TARGET";
            colTarget.Name = "colTarget";
            colTarget.Visible = true;
            colTarget.VisibleIndex = 3;
            // 
            // colUnitName
            // 
            colUnitName.Caption = "单位";
            colUnitName.FieldName = "UNIT_NAME";
            colUnitName.Name = "colUnitName";
            colUnitName.OptionsColumn.AllowEdit = false;
            colUnitName.Visible = true;
            colUnitName.VisibleIndex = 4;

           ((System.ComponentModel.ISupportInitialize) (gridControl)).EndInit();
           ((System.ComponentModel.ISupportInitialize) (gridView)).EndInit();
            return gridControl;
        }
    }
}