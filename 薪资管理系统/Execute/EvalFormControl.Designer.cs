namespace SalarySystem.Execute
{
    partial class EvalFormControl
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
            this.gridControlEvalForm = new DevExpress.XtraGrid.GridControl();
            this.gridViewEvalForm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colITEM_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditItemType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colITEM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFULL_MARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESULT_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEVALUATION_YEAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEVALUATION_MONTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEVALUATOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEVALUATION_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESULT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPLOYEE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPLOYEE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHOW_ORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFORM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERSION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWEIGHT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFORM_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOSITION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvalForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvalForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlEvalForm
            // 
            this.gridControlEvalForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEvalForm.Location = new System.Drawing.Point(0, 0);
            this.gridControlEvalForm.MainView = this.gridViewEvalForm;
            this.gridControlEvalForm.Margin = new System.Windows.Forms.Padding(0);
            this.gridControlEvalForm.Name = "gridControlEvalForm";
            this.gridControlEvalForm.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditItemType});
            this.gridControlEvalForm.Size = new System.Drawing.Size(673, 545);
            this.gridControlEvalForm.TabIndex = 1;
            this.gridControlEvalForm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEvalForm});
            // 
            // gridViewEvalForm
            // 
            this.gridViewEvalForm.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colITEM_TYPE,
            this.colITEM_NAME,
            this.colITEM_DESC,
            this.colFULL_MARK,
            this.colMARK,
            this.colRESULT_DESC,
            this.colEVALUATION_YEAY,
            this.colEVALUATION_MONTH,
            this.colEVALUATOR,
            this.colEVALUATION_TIME,
            this.colRESULT_ID,
            this.colEMPLOYEE_NAME,
            this.colEMPLOYEE_ID,
            this.colSHOW_ORDER,
            this.colITEM_ID,
            this.colFORM_NAME,
            this.colVERSION_ID,
            this.colWEIGHT,
            this.colFORM_ID,
            this.colPOSITION_ID});
            this.gridViewEvalForm.GridControl = this.gridControlEvalForm;
            this.gridViewEvalForm.Name = "gridViewEvalForm";
            this.gridViewEvalForm.OptionsView.AllowCellMerge = true;
            this.gridViewEvalForm.OptionsView.ShowFooter = true;
            this.gridViewEvalForm.OptionsView.ShowGroupedColumns = true;
            // 
            // colITEM_TYPE
            // 
            this.colITEM_TYPE.Caption = "考核项目";
            this.colITEM_TYPE.ColumnEdit = this.repositoryItemLookUpEditItemType;
            this.colITEM_TYPE.FieldName = "ITEM_TYPE";
            this.colITEM_TYPE.Name = "colITEM_TYPE";
            this.colITEM_TYPE.OptionsColumn.AllowEdit = false;
            this.colITEM_TYPE.OptionsColumn.AllowFocus = false;
            this.colITEM_TYPE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colITEM_TYPE.OptionsColumn.ReadOnly = true;
            this.colITEM_TYPE.Visible = true;
            this.colITEM_TYPE.VisibleIndex = 0;
            this.colITEM_TYPE.Width = 100;
            // 
            // repositoryItemLookUpEditItemType
            // 
            this.repositoryItemLookUpEditItemType.AutoHeight = false;
            this.repositoryItemLookUpEditItemType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditItemType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "名称4")});
            this.repositoryItemLookUpEditItemType.DisplayMember = "NAME";
            this.repositoryItemLookUpEditItemType.Name = "repositoryItemLookUpEditItemType";
            this.repositoryItemLookUpEditItemType.ValueMember = "ID";
            // 
            // colITEM_NAME
            // 
            this.colITEM_NAME.Caption = "考核内容";
            this.colITEM_NAME.FieldName = "ITEM_NAME";
            this.colITEM_NAME.Name = "colITEM_NAME";
            this.colITEM_NAME.OptionsColumn.AllowEdit = false;
            this.colITEM_NAME.OptionsColumn.AllowFocus = false;
            this.colITEM_NAME.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colITEM_NAME.OptionsColumn.ReadOnly = true;
            this.colITEM_NAME.Visible = true;
            this.colITEM_NAME.VisibleIndex = 1;
            this.colITEM_NAME.Width = 120;
            // 
            // colITEM_DESC
            // 
            this.colITEM_DESC.Caption = "考核标准";
            this.colITEM_DESC.FieldName = "ITEM_DESC";
            this.colITEM_DESC.Name = "colITEM_DESC";
            this.colITEM_DESC.OptionsColumn.AllowEdit = false;
            this.colITEM_DESC.OptionsColumn.AllowFocus = false;
            this.colITEM_DESC.OptionsColumn.ReadOnly = true;
            this.colITEM_DESC.Visible = true;
            this.colITEM_DESC.VisibleIndex = 2;
            this.colITEM_DESC.Width = 91;
            // 
            // colFULL_MARK
            // 
            this.colFULL_MARK.Caption = "满分";
            this.colFULL_MARK.FieldName = "FULL_MARK";
            this.colFULL_MARK.Name = "colFULL_MARK";
            this.colFULL_MARK.OptionsColumn.AllowEdit = false;
            this.colFULL_MARK.OptionsColumn.AllowFocus = false;
            this.colFULL_MARK.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colFULL_MARK.OptionsColumn.ReadOnly = true;
            this.colFULL_MARK.SummaryItem.DisplayFormat = "满分：{0}";
            this.colFULL_MARK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFULL_MARK.Visible = true;
            this.colFULL_MARK.VisibleIndex = 3;
            this.colFULL_MARK.Width = 60;
            // 
            // colMARK
            // 
            this.colMARK.Caption = "得分";
            this.colMARK.FieldName = "MARK";
            this.colMARK.Name = "colMARK";
            this.colMARK.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMARK.SummaryItem.DisplayFormat = "总分：{0}";
            this.colMARK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colMARK.Visible = true;
            this.colMARK.VisibleIndex = 4;
            this.colMARK.Width = 60;
            // 
            // colRESULT_DESC
            // 
            this.colRESULT_DESC.Caption = "备注";
            this.colRESULT_DESC.FieldName = "RESULT_DESC";
            this.colRESULT_DESC.Name = "colRESULT_DESC";
            this.colRESULT_DESC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRESULT_DESC.Visible = true;
            this.colRESULT_DESC.VisibleIndex = 5;
            this.colRESULT_DESC.Width = 224;
            // 
            // colEVALUATION_YEAY
            // 
            this.colEVALUATION_YEAY.FieldName = "EVALUATION_YEAY";
            this.colEVALUATION_YEAY.Name = "colEVALUATION_YEAY";
            // 
            // colEVALUATION_MONTH
            // 
            this.colEVALUATION_MONTH.FieldName = "EVALUATION_MONTH";
            this.colEVALUATION_MONTH.Name = "colEVALUATION_MONTH";
            // 
            // colEVALUATOR
            // 
            this.colEVALUATOR.FieldName = "EVALUATOR";
            this.colEVALUATOR.Name = "colEVALUATOR";
            // 
            // colEVALUATION_TIME
            // 
            this.colEVALUATION_TIME.FieldName = "EVALUATION_TIME";
            this.colEVALUATION_TIME.Name = "colEVALUATION_TIME";
            // 
            // colRESULT_ID
            // 
            this.colRESULT_ID.FieldName = "RESULT_ID";
            this.colRESULT_ID.Name = "colRESULT_ID";
            // 
            // colEMPLOYEE_NAME
            // 
            this.colEMPLOYEE_NAME.FieldName = "EMPLOYEE_NAME";
            this.colEMPLOYEE_NAME.Name = "colEMPLOYEE_NAME";
            // 
            // colEMPLOYEE_ID
            // 
            this.colEMPLOYEE_ID.FieldName = "EMPLOYEE_ID";
            this.colEMPLOYEE_ID.Name = "colEMPLOYEE_ID";
            // 
            // colSHOW_ORDER
            // 
            this.colSHOW_ORDER.FieldName = "SHOW_ORDER";
            this.colSHOW_ORDER.Name = "colSHOW_ORDER";
            // 
            // colITEM_ID
            // 
            this.colITEM_ID.FieldName = "ITEM_ID";
            this.colITEM_ID.Name = "colITEM_ID";
            // 
            // colFORM_NAME
            // 
            this.colFORM_NAME.FieldName = "FORM_NAME";
            this.colFORM_NAME.Name = "colFORM_NAME";
            // 
            // colVERSION_ID
            // 
            this.colVERSION_ID.FieldName = "VERSION_ID";
            this.colVERSION_ID.Name = "colVERSION_ID";
            // 
            // colWEIGHT
            // 
            this.colWEIGHT.FieldName = "WEIGHT";
            this.colWEIGHT.Name = "colWEIGHT";
            // 
            // colFORM_ID
            // 
            this.colFORM_ID.FieldName = "FORM_ID";
            this.colFORM_ID.Name = "colFORM_ID";
            // 
            // colPOSITION_ID
            // 
            this.colPOSITION_ID.FieldName = "POSITION_ID";
            this.colPOSITION_ID.Name = "colPOSITION_ID";
            // 
            // EvalFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlEvalForm);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EvalFormControl";
            this.Size = new System.Drawing.Size(673, 545);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvalForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvalForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEvalForm;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEvalForm;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_MARK;
        private DevExpress.XtraGrid.Columns.GridColumn colMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colRESULT_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colEVALUATION_YEAY;
        private DevExpress.XtraGrid.Columns.GridColumn colEVALUATION_MONTH;
        private DevExpress.XtraGrid.Columns.GridColumn colEVALUATOR;
        private DevExpress.XtraGrid.Columns.GridColumn colEVALUATION_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colRESULT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPLOYEE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPLOYEE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHOW_ORDER;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colFORM_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colVERSION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colWEIGHT;
        private DevExpress.XtraGrid.Columns.GridColumn colFORM_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSITION_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditItemType;
    }
}
