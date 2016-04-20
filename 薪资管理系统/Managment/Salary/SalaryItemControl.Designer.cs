namespace SalarySystem.Managment.Salary
{
    partial class SalaryItemControl
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
            this.dataSetSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.gridControlSalaryItem = new DevExpress.XtraGrid.GridControl();
            this.gridViewSalaryItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colENABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOSITION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditItemType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFUNC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditFunction = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERSION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalaryItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSalaryItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 481);
            this.panelControl1.Size = new System.Drawing.Size(593, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(393, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(312, 9);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlSalaryItem);
            this.panelControl2.Size = new System.Drawing.Size(593, 481);
            // 
            // dataSetSalaryBindingSource
            // 
            this.dataSetSalaryBindingSource.DataSource = this.dataSetSalary;
            this.dataSetSalaryBindingSource.Position = 0;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControlSalaryItem
            // 
            this.gridControlSalaryItem.DataMember = "t_salary_item";
            this.gridControlSalaryItem.DataSource = this.dataSetSalaryBindingSource;
            this.gridControlSalaryItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSalaryItem.Location = new System.Drawing.Point(2, 2);
            this.gridControlSalaryItem.MainView = this.gridViewSalaryItem;
            this.gridControlSalaryItem.Name = "gridControlSalaryItem";
            this.gridControlSalaryItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditItemType,
            this.repositoryItemLookUpEditPosition,
            this.repositoryItemLookUpEditFunction});
            this.gridControlSalaryItem.Size = new System.Drawing.Size(589, 477);
            this.gridControlSalaryItem.TabIndex = 3;
            this.gridControlSalaryItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSalaryItem});
            // 
            // gridViewSalaryItem
            // 
            this.gridViewSalaryItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colENABLED,
            this.colPOSITION_ID,
            this.colTYPE,
            this.colNAME,
            this.colVALUE,
            this.colFUNC_ID,
            this.colDESCRIPTION,
            this.colID,
            this.colVERSION_ID});
            this.gridViewSalaryItem.GridControl = this.gridControlSalaryItem;
            this.gridViewSalaryItem.Name = "gridViewSalaryItem";
            // 
            // colENABLED
            // 
            this.colENABLED.Caption = "有效";
            this.colENABLED.FieldName = "ENABLED";
            this.colENABLED.MaxWidth = 35;
            this.colENABLED.Name = "colENABLED";
            this.colENABLED.Visible = true;
            this.colENABLED.VisibleIndex = 0;
            this.colENABLED.Width = 35;
            // 
            // colPOSITION_ID
            // 
            this.colPOSITION_ID.Caption = "适用岗位";
            this.colPOSITION_ID.ColumnEdit = this.repositoryItemLookUpEditPosition;
            this.colPOSITION_ID.FieldName = "POSITION_ID";
            this.colPOSITION_ID.MaxWidth = 100;
            this.colPOSITION_ID.Name = "colPOSITION_ID";
            this.colPOSITION_ID.Visible = true;
            this.colPOSITION_ID.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEditPosition
            // 
            this.repositoryItemLookUpEditPosition.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemLookUpEditPosition.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.repositoryItemLookUpEditPosition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPosition.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "岗位名称")});
            this.repositoryItemLookUpEditPosition.DisplayMember = "NAME";
            this.repositoryItemLookUpEditPosition.Name = "repositoryItemLookUpEditPosition";
            this.repositoryItemLookUpEditPosition.NullText = "";
            this.repositoryItemLookUpEditPosition.ShowFooter = false;
            this.repositoryItemLookUpEditPosition.ShowHeader = false;
            this.repositoryItemLookUpEditPosition.ValueMember = "ID";
            // 
            // colTYPE
            // 
            this.colTYPE.Caption = "类型";
            this.colTYPE.ColumnEdit = this.repositoryItemLookUpEditItemType;
            this.colTYPE.FieldName = "TYPE";
            this.colTYPE.MaxWidth = 100;
            this.colTYPE.Name = "colTYPE";
            this.colTYPE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colTYPE.Visible = true;
            this.colTYPE.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEditItemType
            // 
            this.repositoryItemLookUpEditItemType.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemLookUpEditItemType.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemLookUpEditItemType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditItemType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Name16")});
            this.repositoryItemLookUpEditItemType.DisplayMember = "NAME";
            this.repositoryItemLookUpEditItemType.Name = "repositoryItemLookUpEditItemType";
            this.repositoryItemLookUpEditItemType.NullText = "";
            this.repositoryItemLookUpEditItemType.ShowFooter = false;
            this.repositoryItemLookUpEditItemType.ShowHeader = false;
            this.repositoryItemLookUpEditItemType.ValueMember = "ID";
            // 
            // colNAME
            // 
            this.colNAME.Caption = "名称";
            this.colNAME.FieldName = "NAME";
            this.colNAME.MaxWidth = 150;
            this.colNAME.Name = "colNAME";
            this.colNAME.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 3;
            // 
            // colVALUE
            // 
            this.colVALUE.Caption = "取值";
            this.colVALUE.FieldName = "VALUE";
            this.colVALUE.MaxWidth = 400;
            this.colVALUE.Name = "colVALUE";
            this.colVALUE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colVALUE.Visible = true;
            this.colVALUE.VisibleIndex = 4;
            // 
            // colFUNC_ID
            // 
            this.colFUNC_ID.Caption = "计算公式";
            this.colFUNC_ID.ColumnEdit = this.repositoryItemLookUpEditFunction;
            this.colFUNC_ID.FieldName = "FUNC_ID";
            this.colFUNC_ID.Name = "colFUNC_ID";
            this.colFUNC_ID.Visible = true;
            this.colFUNC_ID.VisibleIndex = 6;
            // 
            // repositoryItemLookUpEditFunction
            // 
            this.repositoryItemLookUpEditFunction.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemLookUpEditFunction.AutoHeight = false;
            this.repositoryItemLookUpEditFunction.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.repositoryItemLookUpEditFunction.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditFunction.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DISPLAY_FORMULA", "公式")});
            this.repositoryItemLookUpEditFunction.DisplayMember = "DISPLAY_FORMULA";
            this.repositoryItemLookUpEditFunction.Name = "repositoryItemLookUpEditFunction";
            this.repositoryItemLookUpEditFunction.NullText = "";
            this.repositoryItemLookUpEditFunction.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemLookUpEditFunction.ValueMember = "ID";
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "说明";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 5;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colVERSION_ID
            // 
            this.colVERSION_ID.FieldName = "VERSION_ID";
            this.colVERSION_ID.Name = "colVERSION_ID";
            this.colVERSION_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // SalaryItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SalaryItemControl";
            this.Size = new System.Drawing.Size(593, 521);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalaryItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSalaryItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dataSetSalaryBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private DevExpress.XtraGrid.GridControl gridControlSalaryItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSalaryItem;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSITION_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNC_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditFunction;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colVERSION_ID;
    }
}
