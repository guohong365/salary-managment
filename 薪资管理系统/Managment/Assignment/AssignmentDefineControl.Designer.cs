namespace SalarySystem.Managment.Assignment
{
    partial class AssignmentDefineControl
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
            this.gridControlDetail = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colENABLED1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOSITION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFAULT_VALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDESCRIPTION1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERSION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 369);
            this.panelControl1.Size = new System.Drawing.Size(634, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(554, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(473, 9);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlDetail);
            this.panelControl2.Size = new System.Drawing.Size(634, 369);
            // 
            // gridControlDetail
            // 
            this.gridControlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetail.Location = new System.Drawing.Point(2, 2);
            this.gridControlDetail.MainView = this.gridViewDetails;
            this.gridControlDetail.Name = "gridControlDetail";
            this.gridControlDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditType,
            this.repositoryItemLookUpEditUnit,
            this.repositoryItemLookUpEditPosition});
            this.gridControlDetail.Size = new System.Drawing.Size(630, 365);
            this.gridControlDetail.TabIndex = 1;
            this.gridControlDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetails});
            // 
            // gridViewDetails
            // 
            this.gridViewDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colENABLED1,
            this.colPOSITION_ID,
            this.colTYPE,
            this.colNAME1,
            this.colDEFAULT_VALUE,
            this.colUNIT_ID,
            this.colDESCRIPTION1,
            this.colVERSION_ID,
            this.colID1});
            this.gridViewDetails.GridControl = this.gridControlDetail;
            this.gridViewDetails.Name = "gridViewDetails";
            this.gridViewDetails.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colENABLED1
            // 
            this.colENABLED1.Caption = "启用";
            this.colENABLED1.FieldName = "ENABLED";
            this.colENABLED1.MaxWidth = 35;
            this.colENABLED1.Name = "colENABLED1";
            this.colENABLED1.Visible = true;
            this.colENABLED1.VisibleIndex = 0;
            this.colENABLED1.Width = 35;
            // 
            // colPOSITION_ID
            // 
            this.colPOSITION_ID.Caption = "适用岗位";
            this.colPOSITION_ID.ColumnEdit = this.repositoryItemLookUpEditPosition;
            this.colPOSITION_ID.FieldName = "POSITION_ID";
            this.colPOSITION_ID.Name = "colPOSITION_ID";
            this.colPOSITION_ID.Visible = true;
            this.colPOSITION_ID.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEditPosition
            // 
            this.repositoryItemLookUpEditPosition.AutoHeight = false;
            this.repositoryItemLookUpEditPosition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPosition.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Name4")});
            this.repositoryItemLookUpEditPosition.DisplayMember = "NAME";
            this.repositoryItemLookUpEditPosition.Name = "repositoryItemLookUpEditPosition";
            this.repositoryItemLookUpEditPosition.NullText = "";
            this.repositoryItemLookUpEditPosition.ShowHeader = false;
            this.repositoryItemLookUpEditPosition.ValueMember = "ID";
            // 
            // colTYPE
            // 
            this.colTYPE.Caption = "任务类型";
            this.colTYPE.ColumnEdit = this.repositoryItemLookUpEditType;
            this.colTYPE.FieldName = "TYPE";
            this.colTYPE.MaxWidth = 100;
            this.colTYPE.Name = "colTYPE";
            this.colTYPE.Visible = true;
            this.colTYPE.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEditType
            // 
            this.repositoryItemLookUpEditType.AutoHeight = false;
            this.repositoryItemLookUpEditType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Name6")});
            this.repositoryItemLookUpEditType.DisplayMember = "NAME";
            this.repositoryItemLookUpEditType.Name = "repositoryItemLookUpEditType";
            this.repositoryItemLookUpEditType.NullText = "";
            this.repositoryItemLookUpEditType.ShowHeader = false;
            this.repositoryItemLookUpEditType.ValueMember = "ID";
            // 
            // colNAME1
            // 
            this.colNAME1.Caption = "任务名称";
            this.colNAME1.FieldName = "NAME";
            this.colNAME1.MaxWidth = 150;
            this.colNAME1.Name = "colNAME1";
            this.colNAME1.Visible = true;
            this.colNAME1.VisibleIndex = 3;
            // 
            // colDEFAULT_VALUE
            // 
            this.colDEFAULT_VALUE.Caption = "默认值";
            this.colDEFAULT_VALUE.FieldName = "DEFAULT_VALUE";
            this.colDEFAULT_VALUE.Name = "colDEFAULT_VALUE";
            this.colDEFAULT_VALUE.Visible = true;
            this.colDEFAULT_VALUE.VisibleIndex = 4;
            // 
            // colUNIT_ID
            // 
            this.colUNIT_ID.Caption = "计量单位";
            this.colUNIT_ID.ColumnEdit = this.repositoryItemLookUpEditUnit;
            this.colUNIT_ID.FieldName = "UNIT_ID";
            this.colUNIT_ID.Name = "colUNIT_ID";
            this.colUNIT_ID.Visible = true;
            this.colUNIT_ID.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEditUnit
            // 
            this.repositoryItemLookUpEditUnit.AutoHeight = false;
            this.repositoryItemLookUpEditUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUnit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Name5")});
            this.repositoryItemLookUpEditUnit.DisplayMember = "NAME";
            this.repositoryItemLookUpEditUnit.Name = "repositoryItemLookUpEditUnit";
            this.repositoryItemLookUpEditUnit.NullText = "";
            this.repositoryItemLookUpEditUnit.ShowHeader = false;
            this.repositoryItemLookUpEditUnit.ValueMember = "ID";
            // 
            // colDESCRIPTION1
            // 
            this.colDESCRIPTION1.Caption = "说明";
            this.colDESCRIPTION1.FieldName = "DESCRIPTION";
            this.colDESCRIPTION1.Name = "colDESCRIPTION1";
            this.colDESCRIPTION1.Visible = true;
            this.colDESCRIPTION1.VisibleIndex = 6;
            // 
            // colVERSION_ID
            // 
            this.colVERSION_ID.FieldName = "VERSION_ID";
            this.colVERSION_ID.Name = "colVERSION_ID";
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            // 
            // AssignmentDefineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AssignmentDefineControl";
            this.Size = new System.Drawing.Size(634, 409);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED1;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSITION_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditType;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFAULT_VALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION1;
        private DevExpress.XtraGrid.Columns.GridColumn colVERSION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
    }
}
