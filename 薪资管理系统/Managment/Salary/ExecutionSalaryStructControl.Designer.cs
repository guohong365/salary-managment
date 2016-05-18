namespace SalarySystem.Managment.Salary
{
    partial class ExecutionSalaryStructControl
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
      this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
      this.treeListPosition = new DevExpress.XtraTreeList.TreeList();
      this.colNAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
      this.gridControlExecSalaryDetai = new DevExpress.XtraGrid.GridControl();
      this.gridViewExecSalaryDetai = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colENABLED = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repositoryItemCheckEditEnabled = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.colNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repositoryItemLookUpEditItemType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.colVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFUNC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repositoryItemLookUpEditFormular = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).BeginInit();
      this.panelControlButtons.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
      this.panelControlMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
      this.splitContainerControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.treeListPosition)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControlExecSalaryDetai)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewExecSalaryDetai)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditEnabled)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditFormular)).BeginInit();
      this.SuspendLayout();
      // 
      // panelControlButtons
      // 
      this.panelControlButtons.Location = new System.Drawing.Point(0, 448);
      this.panelControlButtons.Size = new System.Drawing.Size(760, 35);
      // 
      // simpleButtonRevert
      // 
      this.simpleButtonRevert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.simpleButtonRevert.Location = new System.Drawing.Point(680, 6);
      // 
      // simpleButtonSave
      // 
      this.simpleButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.simpleButtonSave.Location = new System.Drawing.Point(599, 6);
      // 
      // panelControlMain
      // 
      this.panelControlMain.Controls.Add(this.splitContainerControl1);
      this.panelControlMain.Size = new System.Drawing.Size(760, 448);
      // 
      // splitContainerControl1
      // 
      this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
      this.splitContainerControl1.Name = "splitContainerControl1";
      this.splitContainerControl1.Panel1.Controls.Add(this.treeListPosition);
      this.splitContainerControl1.Panel1.Text = "Panel1";
      this.splitContainerControl1.Panel2.Controls.Add(this.gridControlExecSalaryDetai);
      this.splitContainerControl1.Panel2.Text = "Panel2";
      this.splitContainerControl1.Size = new System.Drawing.Size(760, 448);
      this.splitContainerControl1.SplitterPosition = 220;
      this.splitContainerControl1.TabIndex = 0;
      this.splitContainerControl1.Text = "splitContainerControl1";
      // 
      // treeListPosition
      // 
      this.treeListPosition.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colNAME});
      this.treeListPosition.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeListPosition.Location = new System.Drawing.Point(0, 0);
      this.treeListPosition.LookAndFeel.UseWindowsXPTheme = true;
      this.treeListPosition.Name = "treeListPosition";
      this.treeListPosition.OptionsBehavior.AutoPopulateColumns = false;
      this.treeListPosition.OptionsBehavior.Editable = false;
      this.treeListPosition.OptionsView.ShowIndicator = false;
      this.treeListPosition.ParentFieldName = "LEADER_ID";
      this.treeListPosition.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow;
      this.treeListPosition.Size = new System.Drawing.Size(220, 448);
      this.treeListPosition.TabIndex = 0;
      this.treeListPosition.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.focusedNodeChanged);
      // 
      // colNAME
      // 
      this.colNAME.Caption = "岗位名称";
      this.colNAME.FieldName = "NAME";
      this.colNAME.Name = "colNAME";
      this.colNAME.OptionsColumn.FixedWidth = true;
      this.colNAME.Visible = true;
      this.colNAME.VisibleIndex = 0;
      this.colNAME.Width = 60;
      // 
      // gridControlExecSalaryDetai
      // 
      this.gridControlExecSalaryDetai.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridControlExecSalaryDetai.Location = new System.Drawing.Point(0, 0);
      this.gridControlExecSalaryDetai.MainView = this.gridViewExecSalaryDetai;
      this.gridControlExecSalaryDetai.Name = "gridControlExecSalaryDetai";
      this.gridControlExecSalaryDetai.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditItemType,
            this.repositoryItemLookUpEditFormular,
            this.repositoryItemCheckEditEnabled});
      this.gridControlExecSalaryDetai.Size = new System.Drawing.Size(535, 448);
      this.gridControlExecSalaryDetai.TabIndex = 0;
      this.gridControlExecSalaryDetai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewExecSalaryDetai});
      // 
      // gridViewExecSalaryDetai
      // 
      this.gridViewExecSalaryDetai.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colENABLED,
            this.colNAME1,
            this.colTYPE,
            this.colVALUE,
            this.colFUNC_ID,
            this.colDESCRIPTION});
      this.gridViewExecSalaryDetai.GridControl = this.gridControlExecSalaryDetai;
      this.gridViewExecSalaryDetai.Name = "gridViewExecSalaryDetai";
      // 
      // colENABLED
      // 
      this.colENABLED.AppearanceHeader.Options.UseTextOptions = true;
      this.colENABLED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.colENABLED.Caption = "启用";
      this.colENABLED.ColumnEdit = this.repositoryItemCheckEditEnabled;
      this.colENABLED.FieldName = "ENABLED";
      this.colENABLED.MaxWidth = 80;
      this.colENABLED.Name = "colENABLED";
      this.colENABLED.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
      this.colENABLED.OptionsFilter.AllowFilter = false;
      this.colENABLED.Visible = true;
      this.colENABLED.VisibleIndex = 0;
      this.colENABLED.Width = 50;
      // 
      // repositoryItemCheckEditEnabled
      // 
      this.repositoryItemCheckEditEnabled.AutoHeight = false;
      this.repositoryItemCheckEditEnabled.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.repositoryItemCheckEditEnabled.Name = "repositoryItemCheckEditEnabled";
      this.repositoryItemCheckEditEnabled.ValueChecked = ((long)(1));
      this.repositoryItemCheckEditEnabled.ValueUnchecked = ((long)(0));
      // 
      // colNAME1
      // 
      this.colNAME1.Caption = "项目";
      this.colNAME1.FieldName = "NAME";
      this.colNAME1.Name = "colNAME1";
      this.colNAME1.OptionsColumn.AllowEdit = false;
      this.colNAME1.Visible = true;
      this.colNAME1.VisibleIndex = 1;
      // 
      // colTYPE
      // 
      this.colTYPE.Caption = "类型";
      this.colTYPE.ColumnEdit = this.repositoryItemLookUpEditItemType;
      this.colTYPE.FieldName = "TYPE";
      this.colTYPE.Name = "colTYPE";
      this.colTYPE.OptionsColumn.AllowEdit = false;
      this.colTYPE.Visible = true;
      this.colTYPE.VisibleIndex = 2;
      // 
      // repositoryItemLookUpEditItemType
      // 
      this.repositoryItemLookUpEditItemType.AutoHeight = false;
      this.repositoryItemLookUpEditItemType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.repositoryItemLookUpEditItemType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Name6")});
      this.repositoryItemLookUpEditItemType.DisplayMember = "NAME";
      this.repositoryItemLookUpEditItemType.Name = "repositoryItemLookUpEditItemType";
      this.repositoryItemLookUpEditItemType.NullText = "";
      this.repositoryItemLookUpEditItemType.ValueMember = "ID";
      // 
      // colVALUE
      // 
      this.colVALUE.Caption = "取值";
      this.colVALUE.FieldName = "VALUE";
      this.colVALUE.Name = "colVALUE";
      this.colVALUE.OptionsColumn.AllowEdit = false;
      this.colVALUE.Visible = true;
      this.colVALUE.VisibleIndex = 3;
      // 
      // colFUNC_ID
      // 
      this.colFUNC_ID.Caption = "公式";
      this.colFUNC_ID.ColumnEdit = this.repositoryItemLookUpEditFormular;
      this.colFUNC_ID.FieldName = "FUNC_ID";
      this.colFUNC_ID.Name = "colFUNC_ID";
      this.colFUNC_ID.OptionsColumn.AllowEdit = false;
      this.colFUNC_ID.Visible = true;
      this.colFUNC_ID.VisibleIndex = 4;
      // 
      // repositoryItemLookUpEditFormular
      // 
      this.repositoryItemLookUpEditFormular.AutoHeight = false;
      this.repositoryItemLookUpEditFormular.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.repositoryItemLookUpEditFormular.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Name2")});
      this.repositoryItemLookUpEditFormular.DisplayMember = "NAME";
      this.repositoryItemLookUpEditFormular.Name = "repositoryItemLookUpEditFormular";
      this.repositoryItemLookUpEditFormular.NullText = "";
      this.repositoryItemLookUpEditFormular.ShowFooter = false;
      this.repositoryItemLookUpEditFormular.ShowHeader = false;
      this.repositoryItemLookUpEditFormular.ValueMember = "ID";
      // 
      // colDESCRIPTION
      // 
      this.colDESCRIPTION.Caption = "说明";
      this.colDESCRIPTION.FieldName = "DESCRIPTION";
      this.colDESCRIPTION.Name = "colDESCRIPTION";
      this.colDESCRIPTION.OptionsColumn.AllowEdit = false;
      this.colDESCRIPTION.Visible = true;
      this.colDESCRIPTION.VisibleIndex = 5;
      // 
      // ExecutionSalaryStructControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "ExecutionSalaryStructControl";
      this.Size = new System.Drawing.Size(760, 483);
      ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).EndInit();
      this.panelControlButtons.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
      this.panelControlMain.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
      this.splitContainerControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.treeListPosition)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControlExecSalaryDetai)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewExecSalaryDetai)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditEnabled)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditFormular)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList treeListPosition;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNAME;
        private DevExpress.XtraGrid.GridControl gridControlExecSalaryDetai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewExecSalaryDetai;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditItemType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditFormular;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditEnabled;
    }
}
