namespace SalarySystem.Managment.Basic
{
    partial class EvaluationItemControl
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
            this.colENABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPOSITION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFULL_MARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERSION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditType)).BeginInit();
            this.SuspendLayout();
            // 
            // colENABLED
            // 
            this.colENABLED.Caption = "启用";
            this.colENABLED.FieldName = "ENABLED";
            this.colENABLED.MaxWidth = 35;
            this.colENABLED.Name = "colENABLED";
            this.colENABLED.Visible = true;
            this.colENABLED.VisibleIndex = 0;
            this.colENABLED.Width = 62;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 432);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(608, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton2.Location = new System.Drawing.Point(528, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "放弃";
            this.simpleButton2.Click += new System.EventHandler(this.abandon_clicked);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton1.Location = new System.Drawing.Point(447, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "保存";
            this.simpleButton1.Click += new System.EventHandler(this.save_clicked);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditType,
            this.repositoryItemLookUpEditPosition});
            this.gridControl1.Size = new System.Drawing.Size(608, 432);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colENABLED,
            this.colPOSITION_ID,
            this.colTYPE,
            this.colID,
            this.colNAME,
            this.colFULL_MARK,
            this.colDESCRIPTION,
            this.colVERSION_ID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", null, "（共 {0} 项"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FULL_MARK", null, "满分={0}）")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AutoPopulateColumns = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPOSITION_ID, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTYPE, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.ViewCaption = "考核项目定义";
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.initNewRow);
            // 
            // colPOSITION_ID
            // 
            this.colPOSITION_ID.Caption = "适用岗位";
            this.colPOSITION_ID.ColumnEdit = this.repositoryItemLookUpEditPosition;
            this.colPOSITION_ID.FieldName = "POSITION_ID";
            this.colPOSITION_ID.MaxWidth = 80;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "岗位编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "岗位名称")});
            this.repositoryItemLookUpEditPosition.DisplayMember = "NAME";
            this.repositoryItemLookUpEditPosition.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.repositoryItemLookUpEditPosition.Name = "repositoryItemLookUpEditPosition";
            this.repositoryItemLookUpEditPosition.NullText = "";
            this.repositoryItemLookUpEditPosition.ValueMember = "ID";
            // 
            // colTYPE
            // 
            this.colTYPE.Caption = "类型";
            this.colTYPE.ColumnEdit = this.repositoryItemLookUpEditType;
            this.colTYPE.FieldName = "TYPE";
            this.colTYPE.MaxWidth = 100;
            this.colTYPE.Name = "colTYPE";
            this.colTYPE.Visible = true;
            this.colTYPE.VisibleIndex = 2;
            this.colTYPE.Width = 100;
            // 
            // repositoryItemLookUpEditType
            // 
            this.repositoryItemLookUpEditType.AutoHeight = false;
            this.repositoryItemLookUpEditType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "类型")});
            this.repositoryItemLookUpEditType.DisplayMember = "NAME";
            this.repositoryItemLookUpEditType.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.repositoryItemLookUpEditType.Name = "repositoryItemLookUpEditType";
            this.repositoryItemLookUpEditType.NullText = "";
            this.repositoryItemLookUpEditType.ValueMember = "ID";
            // 
            // colID
            // 
            this.colID.Caption = "项目编号";
            this.colID.FieldName = "ID";
            this.colID.MaxWidth = 120;
            this.colID.Name = "colID";
            this.colID.Width = 120;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "项目名称";
            this.colNAME.FieldName = "NAME";
            this.colNAME.MaxWidth = 150;
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 3;
            this.colNAME.Width = 150;
            // 
            // colFULL_MARK
            // 
            this.colFULL_MARK.Caption = "满分";
            this.colFULL_MARK.FieldName = "FULL_MARK";
            this.colFULL_MARK.MaxWidth = 50;
            this.colFULL_MARK.Name = "colFULL_MARK";
            this.colFULL_MARK.Visible = true;
            this.colFULL_MARK.VisibleIndex = 4;
            this.colFULL_MARK.Width = 50;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "说明";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 5;
            this.colDESCRIPTION.Width = 87;
            // 
            // colVERSION_ID
            // 
            this.colVERSION_ID.FieldName = "VERSION_ID";
            this.colVERSION_ID.Name = "colVERSION_ID";
            // 
            // EvaluationItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "EvaluationItemControl";
            this.Size = new System.Drawing.Size(608, 472);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_MARK;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colVERSION_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditType;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSITION_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPosition;
    }
}
