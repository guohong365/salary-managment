namespace SalarySystem.Managment.Assignment
{
    partial class PersonalAssignmentDefineControl
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
            this.vpersonalassignmentdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFINE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDEFINE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDEFINE_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIT_POSITION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colWEIGHT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERSION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLEADER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFINE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFAULT_VALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpositionassignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpersonalassignmentdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpositionassignmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 444);
            this.panelControl1.Size = new System.Drawing.Size(723, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(317, 12);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(227, 12);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Size = new System.Drawing.Size(723, 444);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vpersonalassignmentdetailBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditPosition,
            this.repositoryItemLookUpEditType,
            this.repositoryItemLookUpEditUnit});
            this.gridControl1.Size = new System.Drawing.Size(719, 440);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vpersonalassignmentdetailBindingSource
            // 
            this.vpersonalassignmentdetailBindingSource.DataMember = "v_personal_assignment_detail";
            this.vpersonalassignmentdetailBindingSource.DataSource = this.dataSetSalary;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSED,
            this.colNAME,
            this.colDEFINE_TYPE,
            this.colDEFINE_NAME,
            this.colVALUE,
            this.colUNIT_ID,
            this.colDEFINE_DESC,
            this.colFIT_POSITION_ID,
            this.colWEIGHT,
            this.colVERSION_ID,
            this.colLEADER_ID,
            this.colID,
            this.colDEFINE_ID,
            this.colDEFAULT_VALUE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colUSED
            // 
            this.colUSED.Caption = "启用";
            this.colUSED.FieldName = "USED";
            this.colUSED.Name = "colUSED";
            this.colUSED.Visible = true;
            this.colUSED.VisibleIndex = 0;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "岗位名称";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.OptionsColumn.AllowEdit = false;
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 1;
            // 
            // colDEFINE_TYPE
            // 
            this.colDEFINE_TYPE.Caption = "任务类型";
            this.colDEFINE_TYPE.ColumnEdit = this.repositoryItemLookUpEditType;
            this.colDEFINE_TYPE.FieldName = "DEFINE_TYPE";
            this.colDEFINE_TYPE.Name = "colDEFINE_TYPE";
            this.colDEFINE_TYPE.OptionsColumn.AllowEdit = false;
            this.colDEFINE_TYPE.Visible = true;
            this.colDEFINE_TYPE.VisibleIndex = 2;
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
            // colDEFINE_NAME
            // 
            this.colDEFINE_NAME.Caption = "任务名称";
            this.colDEFINE_NAME.FieldName = "DEFINE_NAME";
            this.colDEFINE_NAME.Name = "colDEFINE_NAME";
            this.colDEFINE_NAME.OptionsColumn.AllowEdit = false;
            this.colDEFINE_NAME.Visible = true;
            this.colDEFINE_NAME.VisibleIndex = 3;
            // 
            // colVALUE
            // 
            this.colVALUE.Caption = "任务额度";
            this.colVALUE.FieldName = "VALUE";
            this.colVALUE.Name = "colVALUE";
            this.colVALUE.Visible = true;
            this.colVALUE.VisibleIndex = 4;
            // 
            // colUNIT_ID
            // 
            this.colUNIT_ID.Caption = "单位";
            this.colUNIT_ID.ColumnEdit = this.repositoryItemLookUpEditUnit;
            this.colUNIT_ID.FieldName = "UNIT_ID";
            this.colUNIT_ID.Name = "colUNIT_ID";
            this.colUNIT_ID.OptionsColumn.AllowEdit = false;
            this.colUNIT_ID.Visible = true;
            this.colUNIT_ID.VisibleIndex = 5;
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
            // colDEFINE_DESC
            // 
            this.colDEFINE_DESC.Caption = "任务说明";
            this.colDEFINE_DESC.FieldName = "DEFINE_DESC";
            this.colDEFINE_DESC.Name = "colDEFINE_DESC";
            this.colDEFINE_DESC.OptionsColumn.AllowEdit = false;
            this.colDEFINE_DESC.Visible = true;
            this.colDEFINE_DESC.VisibleIndex = 6;
            // 
            // colFIT_POSITION_ID
            // 
            this.colFIT_POSITION_ID.Caption = "适用岗位";
            this.colFIT_POSITION_ID.ColumnEdit = this.repositoryItemLookUpEditPosition;
            this.colFIT_POSITION_ID.FieldName = "FIT_POSITION_ID";
            this.colFIT_POSITION_ID.Name = "colFIT_POSITION_ID";
            this.colFIT_POSITION_ID.OptionsColumn.AllowEdit = false;
            this.colFIT_POSITION_ID.Visible = true;
            this.colFIT_POSITION_ID.VisibleIndex = 7;
            // 
            // repositoryItemLookUpEditPosition
            // 
            this.repositoryItemLookUpEditPosition.AutoHeight = false;
            this.repositoryItemLookUpEditPosition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPosition.DisplayMember = "NAME";
            this.repositoryItemLookUpEditPosition.Name = "repositoryItemLookUpEditPosition";
            this.repositoryItemLookUpEditPosition.ValueMember = "ID";
            // 
            // colWEIGHT
            // 
            this.colWEIGHT.FieldName = "WEIGHT";
            this.colWEIGHT.Name = "colWEIGHT";
            // 
            // colVERSION_ID
            // 
            this.colVERSION_ID.FieldName = "VERSION_ID";
            this.colVERSION_ID.Name = "colVERSION_ID";
            // 
            // colLEADER_ID
            // 
            this.colLEADER_ID.FieldName = "LEADER_ID";
            this.colLEADER_ID.Name = "colLEADER_ID";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colDEFINE_ID
            // 
            this.colDEFINE_ID.FieldName = "DEFINE_ID";
            this.colDEFINE_ID.Name = "colDEFINE_ID";
            // 
            // colDEFAULT_VALUE
            // 
            this.colDEFAULT_VALUE.FieldName = "DEFAULT_VALUE";
            this.colDEFAULT_VALUE.Name = "colDEFAULT_VALUE";
            // 
            // tpositionassignmentsBindingSource
            // 
            this.tpositionassignmentsBindingSource.DataMember = "t_position_assignments";
            this.tpositionassignmentsBindingSource.DataSource = this.dataSetSalary;
            // 
            // PersonalAssignmentDefineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PersonalAssignmentDefineControl";
            this.Size = new System.Drawing.Size(723, 484);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpersonalassignmentdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpositionassignmentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource vpersonalassignmentdetailBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tpositionassignmentsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUSED;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFINE_TYPE;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditType;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFINE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFINE_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colFIT_POSITION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colWEIGHT;
        private DevExpress.XtraGrid.Columns.GridColumn colVERSION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLEADER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFINE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFAULT_VALUE;

    }
}
