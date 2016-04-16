namespace SalarySystem.Managment.Assignment
{
    partial class AutoAssignmentRateDefineControl
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
            DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.列NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列DEFINE_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列WEIGHT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.列USED = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列FIT_POSITION_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列DEFINE_DESC = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列DEFINE_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列DEFINE_TYPE = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列UNIT_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列IS_NEW = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列VERSION_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.vteamassignmentdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlAssignmentDefine = new DevExpress.XtraGrid.GridControl();
            this.gridViewAssignmentDefine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFAULT_VALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERSION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOSITION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_team_assignment_detailTableAdapter = new SalarySystem.Data.DataSetSalaryTableAdapters.v_team_assignment_detailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vteamassignmentdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAssignmentDefine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAssignmentDefine)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 466);
            this.panelControl1.Size = new System.Drawing.Size(818, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(1341, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(1260, 9);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.splitContainerControl1);
            this.panelControl2.Size = new System.Drawing.Size(818, 466);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "名称1")});
            this.repositoryItemLookUpEdit1.DisplayMember = "NAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // treeList1
            // 
            this.treeList1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.treeList1.Appearance.Empty.Options.UseBackColor = true;
            this.treeList1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.treeList1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.EvenRow.Options.UseBackColor = true;
            this.treeList1.Appearance.EvenRow.Options.UseForeColor = true;
            this.treeList1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.treeList1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeList1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeList1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.treeList1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.treeList1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.treeList1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.treeList1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.treeList1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.treeList1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.treeList1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.treeList1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.GroupButton.Options.UseBackColor = true;
            this.treeList1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.treeList1.Appearance.GroupButton.Options.UseForeColor = true;
            this.treeList1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.treeList1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.treeList1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.treeList1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.treeList1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.treeList1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.treeList1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.treeList1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.treeList1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.treeList1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.treeList1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.treeList1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.treeList1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.treeList1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.treeList1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeList1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.treeList1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.treeList1.Appearance.HorzLine.Options.UseBackColor = true;
            this.treeList1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.treeList1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.OddRow.Options.UseBackColor = true;
            this.treeList1.Appearance.OddRow.Options.UseForeColor = true;
            this.treeList1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.treeList1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.treeList1.Appearance.Preview.Options.UseBackColor = true;
            this.treeList1.Appearance.Preview.Options.UseForeColor = true;
            this.treeList1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.treeList1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.Row.Options.UseBackColor = true;
            this.treeList1.Appearance.Row.Options.UseForeColor = true;
            this.treeList1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.treeList1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeList1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.treeList1.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.treeList1.Appearance.TreeLine.Options.UseBackColor = true;
            this.treeList1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.treeList1.Appearance.VertLine.Options.UseBackColor = true;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.列NAME,
            this.列DEFINE_NAME,
            this.列WEIGHT,
            this.列USED,
            this.列FIT_POSITION_ID,
            this.列DEFINE_DESC,
            this.列DEFINE_ID,
            this.列DEFINE_TYPE,
            this.列UNIT_ID,
            this.列IS_NEW,
            this.列VERSION_ID});
            this.treeList1.DataSource = this.vteamassignmentdetailBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList1.OptionsView.EnableAppearanceOddRow = true;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowRowFooterSummary = true;
            this.treeList1.ParentFieldName = "LEADER_ID";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.treeList1.RootValue = "<Null>";
            this.treeList1.Size = new System.Drawing.Size(596, 462);
            this.treeList1.TabIndex = 0;
            this.treeList1.CustomDrawRowFooterCell += new DevExpress.XtraTreeList.CustomDrawRowFooterCellEventHandler(this.customDrawRowFooterCell);
            this.treeList1.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.cellValueChange);
            // 
            // 列NAME
            // 
            this.列NAME.Caption = "岗位名称";
            this.列NAME.FieldName = "NAME";
            this.列NAME.Name = "列NAME";
            this.列NAME.OptionsColumn.AllowEdit = false;
            this.列NAME.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列NAME.OptionsColumn.ShowInCustomizationForm = false;
            this.列NAME.Visible = true;
            this.列NAME.VisibleIndex = 0;
            this.列NAME.Width = 104;
            // 
            // 列DEFINE_NAME
            // 
            this.列DEFINE_NAME.Caption = "任务名称";
            this.列DEFINE_NAME.FieldName = "DEFINE_NAME";
            this.列DEFINE_NAME.Name = "列DEFINE_NAME";
            this.列DEFINE_NAME.OptionsColumn.AllowEdit = false;
            this.列DEFINE_NAME.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列DEFINE_NAME.OptionsColumn.ShowInCustomizationForm = false;
            this.列DEFINE_NAME.Visible = true;
            this.列DEFINE_NAME.VisibleIndex = 1;
            this.列DEFINE_NAME.Width = 119;
            // 
            // 列WEIGHT
            // 
            this.列WEIGHT.Caption = "占比(%)";
            this.列WEIGHT.ColumnEdit = this.repositoryItemTextEdit1;
            this.列WEIGHT.FieldName = "WEIGHT";
            this.列WEIGHT.Name = "列WEIGHT";
            this.列WEIGHT.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列WEIGHT.OptionsColumn.ShowInCustomizationForm = false;
            this.列WEIGHT.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum;
            this.列WEIGHT.Visible = true;
            this.列WEIGHT.VisibleIndex = 2;
            this.列WEIGHT.Width = 118;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // 列USED
            // 
            this.列USED.Caption = "启用";
            repositoryItemCheckEdit1.AutoHeight = false;
            repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.列USED.ColumnEdit = repositoryItemCheckEdit1;
            this.列USED.FieldName = "USED";
            this.列USED.Name = "列USED";
            this.列USED.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列USED.OptionsColumn.ShowInCustomizationForm = false;
            this.列USED.Visible = true;
            this.列USED.VisibleIndex = 3;
            this.列USED.Width = 134;
            // 
            // 列FIT_POSITION_ID
            // 
            this.列FIT_POSITION_ID.Caption = "适用岗位";
            this.列FIT_POSITION_ID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.列FIT_POSITION_ID.FieldName = "FIT_POSITION_ID";
            this.列FIT_POSITION_ID.Name = "列FIT_POSITION_ID";
            this.列FIT_POSITION_ID.OptionsColumn.AllowEdit = false;
            this.列FIT_POSITION_ID.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列FIT_POSITION_ID.OptionsColumn.ShowInCustomizationForm = false;
            this.列FIT_POSITION_ID.Visible = true;
            this.列FIT_POSITION_ID.VisibleIndex = 4;
            this.列FIT_POSITION_ID.Width = 119;
            // 
            // 列DEFINE_DESC
            // 
            this.列DEFINE_DESC.Caption = "任务说明";
            this.列DEFINE_DESC.FieldName = "DEFINE_DESC";
            this.列DEFINE_DESC.Name = "列DEFINE_DESC";
            this.列DEFINE_DESC.OptionsColumn.AllowEdit = false;
            this.列DEFINE_DESC.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列DEFINE_DESC.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // 列DEFINE_ID
            // 
            this.列DEFINE_ID.FieldName = "DEFINE_ID";
            this.列DEFINE_ID.Name = "列DEFINE_ID";
            this.列DEFINE_ID.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列DEFINE_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // 列DEFINE_TYPE
            // 
            this.列DEFINE_TYPE.FieldName = "DEFINE_TYPE";
            this.列DEFINE_TYPE.Name = "列DEFINE_TYPE";
            this.列DEFINE_TYPE.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列DEFINE_TYPE.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // 列UNIT_ID
            // 
            this.列UNIT_ID.FieldName = "UNIT_ID";
            this.列UNIT_ID.Name = "列UNIT_ID";
            this.列UNIT_ID.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列UNIT_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // 列IS_NEW
            // 
            this.列IS_NEW.FieldName = "IS_NEW";
            this.列IS_NEW.Name = "列IS_NEW";
            this.列IS_NEW.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列IS_NEW.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // 列VERSION_ID
            // 
            this.列VERSION_ID.FieldName = "VERSION_ID";
            this.列VERSION_ID.Name = "列VERSION_ID";
            this.列VERSION_ID.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列VERSION_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // vteamassignmentdetailBindingSource
            // 
            this.vteamassignmentdetailBindingSource.DataMember = "v_team_assignment_detail";
            this.vteamassignmentdetailBindingSource.DataSource = this.dataSetSalary;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlAssignmentDefine);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.treeList1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(814, 462);
            this.splitContainerControl1.SplitterPosition = 213;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlAssignmentDefine
            // 
            this.gridControlAssignmentDefine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAssignmentDefine.Location = new System.Drawing.Point(0, 0);
            this.gridControlAssignmentDefine.MainView = this.gridViewAssignmentDefine;
            this.gridControlAssignmentDefine.Name = "gridControlAssignmentDefine";
            this.gridControlAssignmentDefine.Size = new System.Drawing.Size(213, 462);
            this.gridControlAssignmentDefine.TabIndex = 0;
            this.gridControlAssignmentDefine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAssignmentDefine});
            // 
            // gridViewAssignmentDefine
            // 
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewAssignmentDefine.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridViewAssignmentDefine.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewAssignmentDefine.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewAssignmentDefine.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewAssignmentDefine.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewAssignmentDefine.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewAssignmentDefine.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewAssignmentDefine.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewAssignmentDefine.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewAssignmentDefine.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewAssignmentDefine.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridViewAssignmentDefine.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridViewAssignmentDefine.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewAssignmentDefine.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewAssignmentDefine.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewAssignmentDefine.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewAssignmentDefine.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewAssignmentDefine.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewAssignmentDefine.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewAssignmentDefine.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewAssignmentDefine.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewAssignmentDefine.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewAssignmentDefine.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewAssignmentDefine.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewAssignmentDefine.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewAssignmentDefine.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewAssignmentDefine.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewAssignmentDefine.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewAssignmentDefine.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewAssignmentDefine.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewAssignmentDefine.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewAssignmentDefine.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewAssignmentDefine.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridViewAssignmentDefine.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewAssignmentDefine.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewAssignmentDefine.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewAssignmentDefine.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewAssignmentDefine.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewAssignmentDefine.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewAssignmentDefine.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewAssignmentDefine.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridViewAssignmentDefine.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewAssignmentDefine.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridViewAssignmentDefine.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewAssignmentDefine.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewAssignmentDefine.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridViewAssignmentDefine.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridViewAssignmentDefine.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewAssignmentDefine.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewAssignmentDefine.Appearance.Row.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.Row.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewAssignmentDefine.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridViewAssignmentDefine.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewAssignmentDefine.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewAssignmentDefine.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridViewAssignmentDefine.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewAssignmentDefine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNAME,
            this.colID,
            this.colDESCRIPTION,
            this.colENABLED,
            this.colTYPE,
            this.colDEFAULT_VALUE,
            this.colVERSION_ID,
            this.colUNIT_ID,
            this.colPOSITION_ID});
            this.gridViewAssignmentDefine.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewAssignmentDefine.GridControl = this.gridControlAssignmentDefine;
            this.gridViewAssignmentDefine.Name = "gridViewAssignmentDefine";
            this.gridViewAssignmentDefine.OptionsBehavior.Editable = false;
            this.gridViewAssignmentDefine.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewAssignmentDefine.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewAssignmentDefine.OptionsView.ShowGroupPanel = false;
            this.gridViewAssignmentDefine.OptionsView.ShowIndicator = false;
            this.gridViewAssignmentDefine.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.focusedAssignmentDefinChanged);
            // 
            // colNAME
            // 
            this.colNAME.Caption = "任务名称";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 0;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            // 
            // colENABLED
            // 
            this.colENABLED.FieldName = "ENABLED";
            this.colENABLED.Name = "colENABLED";
            // 
            // colTYPE
            // 
            this.colTYPE.FieldName = "TYPE";
            this.colTYPE.Name = "colTYPE";
            // 
            // colDEFAULT_VALUE
            // 
            this.colDEFAULT_VALUE.FieldName = "DEFAULT_VALUE";
            this.colDEFAULT_VALUE.Name = "colDEFAULT_VALUE";
            // 
            // colVERSION_ID
            // 
            this.colVERSION_ID.FieldName = "VERSION_ID";
            this.colVERSION_ID.Name = "colVERSION_ID";
            // 
            // colUNIT_ID
            // 
            this.colUNIT_ID.FieldName = "UNIT_ID";
            this.colUNIT_ID.Name = "colUNIT_ID";
            // 
            // colPOSITION_ID
            // 
            this.colPOSITION_ID.FieldName = "POSITION_ID";
            this.colPOSITION_ID.Name = "colPOSITION_ID";
            // 
            // v_team_assignment_detailTableAdapter
            // 
            this.v_team_assignment_detailTableAdapter.ClearBeforeFill = true;
            // 
            // AutoAssignmentRateDefineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AutoAssignmentRateDefineControl";
            this.Size = new System.Drawing.Size(818, 506);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vteamassignmentdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAssignmentDefine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAssignmentDefine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列DEFINE_NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列DEFINE_TYPE;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列FIT_POSITION_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列DEFINE_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列USED;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列WEIGHT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列DEFINE_DESC;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlAssignmentDefine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAssignmentDefine;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFAULT_VALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colVERSION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSITION_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列UNIT_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列IS_NEW;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列VERSION_ID;
        private System.Windows.Forms.BindingSource vteamassignmentdetailBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private Data.DataSetSalaryTableAdapters.v_team_assignment_detailTableAdapter v_team_assignment_detailTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}
