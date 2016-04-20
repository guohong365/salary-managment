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
            this.gridControlPersonalAssignment = new DevExpress.XtraGrid.GridControl();
            this.gridViewPersonalAssignment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFINE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditItemType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDEFINE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFAULT_VALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFIT_POSITION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDEFINE_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPersonalAssignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPersonalAssignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 444);
            this.panelControl1.Size = new System.Drawing.Size(723, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(643, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(562, 9);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlPersonalAssignment);
            this.panelControl2.Size = new System.Drawing.Size(723, 444);
            // 
            // gridControlPersonalAssignment
            // 
            this.gridControlPersonalAssignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPersonalAssignment.Location = new System.Drawing.Point(2, 2);
            this.gridControlPersonalAssignment.MainView = this.gridViewPersonalAssignment;
            this.gridControlPersonalAssignment.Name = "gridControlPersonalAssignment";
            this.gridControlPersonalAssignment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditItemType,
            this.repositoryItemLookUpEditUnit,
            this.repositoryItemLookUpEditPosition});
            this.gridControlPersonalAssignment.Size = new System.Drawing.Size(719, 440);
            this.gridControlPersonalAssignment.TabIndex = 0;
            this.gridControlPersonalAssignment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPersonalAssignment});
            // 
            // gridViewPersonalAssignment
            // 
            this.gridViewPersonalAssignment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSED,
            this.colNAME,
            this.colDEFINE_TYPE,
            this.colDEFINE_NAME,
            this.colVALUE,
            this.colDEFAULT_VALUE,
            this.colUNIT_ID,
            this.colFIT_POSITION_ID,
            this.colDEFINE_DESC});
            this.gridViewPersonalAssignment.GridControl = this.gridControlPersonalAssignment;
            this.gridViewPersonalAssignment.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "DEFINE_ID", null, "共{0}项")});
            this.gridViewPersonalAssignment.Name = "gridViewPersonalAssignment";
            // 
            // colUSED
            // 
            this.colUSED.Caption = "启用";
            this.colUSED.FieldName = "USED";
            this.colUSED.MaxWidth = 35;
            this.colUSED.Name = "colUSED";
            this.colUSED.Visible = true;
            this.colUSED.VisibleIndex = 0;
            this.colUSED.Width = 35;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "岗位";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.OptionsColumn.AllowEdit = false;
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 1;
            // 
            // colDEFINE_TYPE
            // 
            this.colDEFINE_TYPE.Caption = "任务类型";
            this.colDEFINE_TYPE.ColumnEdit = this.repositoryItemLookUpEditItemType;
            this.colDEFINE_TYPE.FieldName = "DEFINE_TYPE";
            this.colDEFINE_TYPE.Name = "colDEFINE_TYPE";
            this.colDEFINE_TYPE.OptionsColumn.AllowEdit = false;
            this.colDEFINE_TYPE.Visible = true;
            this.colDEFINE_TYPE.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEditItemType
            // 
            this.repositoryItemLookUpEditItemType.AutoHeight = false;
            this.repositoryItemLookUpEditItemType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditItemType.DisplayMember = "NAME";
            this.repositoryItemLookUpEditItemType.Name = "repositoryItemLookUpEditItemType";
            this.repositoryItemLookUpEditItemType.ValueMember = "ID";
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
            // colDEFAULT_VALUE
            // 
            this.colDEFAULT_VALUE.Caption = "默认额度";
            this.colDEFAULT_VALUE.FieldName = "DEFAULT_VALUE";
            this.colDEFAULT_VALUE.Name = "colDEFAULT_VALUE";
            this.colDEFAULT_VALUE.OptionsColumn.AllowEdit = false;
            this.colDEFAULT_VALUE.Visible = true;
            this.colDEFAULT_VALUE.VisibleIndex = 5;
            // 
            // colUNIT_ID
            // 
            this.colUNIT_ID.Caption = "单位";
            this.colUNIT_ID.ColumnEdit = this.repositoryItemLookUpEditUnit;
            this.colUNIT_ID.FieldName = "UNIT_ID";
            this.colUNIT_ID.MaxWidth = 35;
            this.colUNIT_ID.Name = "colUNIT_ID";
            this.colUNIT_ID.OptionsColumn.AllowEdit = false;
            this.colUNIT_ID.Visible = true;
            this.colUNIT_ID.VisibleIndex = 6;
            this.colUNIT_ID.Width = 35;
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
            // colDEFINE_DESC
            // 
            this.colDEFINE_DESC.Caption = "任务说明";
            this.colDEFINE_DESC.FieldName = "DEFINE_DESC";
            this.colDEFINE_DESC.Name = "colDEFINE_DESC";
            this.colDEFINE_DESC.OptionsColumn.AllowEdit = false;
            this.colDEFINE_DESC.Visible = true;
            this.colDEFINE_DESC.VisibleIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPersonalAssignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPersonalAssignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPersonalAssignment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPersonalAssignment;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFINE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFINE_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFINE_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFAULT_VALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colFIT_POSITION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSED;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditItemType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPosition;

    }
}
