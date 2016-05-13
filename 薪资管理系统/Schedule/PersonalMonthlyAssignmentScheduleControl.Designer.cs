namespace SalarySystem.Schedule
{
    partial class PersonalMonthlyAssignmentScheduleControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vpersonalassignmentscheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colASSIGNED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPLOYEE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEF_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEF_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTARGET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPLETED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpersonalassignmentscheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vpersonalassignmentscheduleBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditUnit,
            this.repositoryItemLookUpEditType});
            this.gridControl1.Size = new System.Drawing.Size(666, 505);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vpersonalassignmentscheduleBindingSource
            // 
            this.vpersonalassignmentscheduleBindingSource.DataMember = "v_personal_assignment_schedule";
            this.vpersonalassignmentscheduleBindingSource.DataSource = this.dataSetSalary;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colASSIGNED,
            this.colEMPLOYEE_NAME,
            this.colDEF_NAME,
            this.colDEF_TYPE,
            this.colTARGET,
            this.colVALUE,
            this.colCOMPLETED,
            this.colUNIT_ID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.customDrawCell);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.cellValueChanging);
            // 
            // colASSIGNED
            // 
            this.colASSIGNED.Caption = "分配";
            this.colASSIGNED.FieldName = "ASSIGNED";
            this.colASSIGNED.Name = "colASSIGNED";
            this.colASSIGNED.Visible = true;
            this.colASSIGNED.VisibleIndex = 0;
            // 
            // colEMPLOYEE_NAME
            // 
            this.colEMPLOYEE_NAME.Caption = "姓名";
            this.colEMPLOYEE_NAME.FieldName = "EMPLOYEE_NAME";
            this.colEMPLOYEE_NAME.Name = "colEMPLOYEE_NAME";
            this.colEMPLOYEE_NAME.OptionsColumn.AllowEdit = false;
            this.colEMPLOYEE_NAME.Visible = true;
            this.colEMPLOYEE_NAME.VisibleIndex = 1;
            // 
            // colDEF_NAME
            // 
            this.colDEF_NAME.Caption = "任务名称";
            this.colDEF_NAME.FieldName = "DEF_NAME";
            this.colDEF_NAME.Name = "colDEF_NAME";
            this.colDEF_NAME.OptionsColumn.AllowEdit = false;
            this.colDEF_NAME.Visible = true;
            this.colDEF_NAME.VisibleIndex = 2;
            // 
            // colDEF_TYPE
            // 
            this.colDEF_TYPE.Caption = "任务类型";
            this.colDEF_TYPE.ColumnEdit = this.repositoryItemLookUpEditType;
            this.colDEF_TYPE.FieldName = "DEF_TYPE";
            this.colDEF_TYPE.Name = "colDEF_TYPE";
            this.colDEF_TYPE.OptionsColumn.AllowEdit = false;
            this.colDEF_TYPE.Visible = true;
            this.colDEF_TYPE.VisibleIndex = 3;
            this.colDEF_TYPE.Width = 84;
            // 
            // repositoryItemLookUpEditType
            // 
            this.repositoryItemLookUpEditType.AutoHeight = false;
            this.repositoryItemLookUpEditType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditType.DisplayMember = "NAME";
            this.repositoryItemLookUpEditType.Name = "repositoryItemLookUpEditType";
            this.repositoryItemLookUpEditType.ValueMember = "ID";
            // 
            // colTARGET
            // 
            this.colTARGET.Caption = "任务额度";
            this.colTARGET.FieldName = "TARGET";
            this.colTARGET.Name = "colTARGET";
            this.colTARGET.Visible = true;
            this.colTARGET.VisibleIndex = 4;
            // 
            // colVALUE
            // 
            this.colVALUE.Caption = "预定额度";
            this.colVALUE.FieldName = "VALUE";
            this.colVALUE.Name = "colVALUE";
            this.colVALUE.OptionsColumn.AllowEdit = false;
            this.colVALUE.Visible = true;
            this.colVALUE.VisibleIndex = 5;
            // 
            // colCOMPLETED
            // 
            this.colCOMPLETED.Caption = "完成额度";
            this.colCOMPLETED.FieldName = "COMPLETED";
            this.colCOMPLETED.Name = "colCOMPLETED";
            this.colCOMPLETED.OptionsColumn.AllowEdit = false;
            this.colCOMPLETED.Visible = true;
            this.colCOMPLETED.VisibleIndex = 6;
            // 
            // colUNIT_ID
            // 
            this.colUNIT_ID.Caption = "单位";
            this.colUNIT_ID.ColumnEdit = this.repositoryItemLookUpEditUnit;
            this.colUNIT_ID.FieldName = "UNIT_ID";
            this.colUNIT_ID.Name = "colUNIT_ID";
            this.colUNIT_ID.OptionsColumn.AllowEdit = false;
            this.colUNIT_ID.Visible = true;
            this.colUNIT_ID.VisibleIndex = 7;
            this.colUNIT_ID.Width = 90;
            // 
            // repositoryItemLookUpEditUnit
            // 
            this.repositoryItemLookUpEditUnit.AutoHeight = false;
            this.repositoryItemLookUpEditUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUnit.DisplayMember = "NAME";
            this.repositoryItemLookUpEditUnit.Name = "repositoryItemLookUpEditUnit";
            this.repositoryItemLookUpEditUnit.ValueMember = "ID";
            // 
            // v_personal_assignment_scheduleTableAdapter
            // 
            // 
            // PersonalMonthlyAssignmentScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PersonalMonthlyAssignmentScheduleControl";
            this.Size = new System.Drawing.Size(666, 505);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpersonalassignmentscheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource vpersonalassignmentscheduleBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colASSIGNED;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPLOYEE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDEF_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDEF_TYPE;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditType;
        private DevExpress.XtraGrid.Columns.GridColumn colTARGET;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPLETED;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUnit;
    }
}
