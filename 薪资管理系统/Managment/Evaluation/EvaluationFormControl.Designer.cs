namespace SalarySystem.Managment.Evaluation
{
    partial class EvaluationFormControl
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridViewFormDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHOW_ORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFULL_MARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlEvaluationForm = new DevExpress.XtraGrid.GridControl();
            this.gridViewForm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colENABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOSITION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPositoin = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlEvaluationItems = new DevExpress.XtraGrid.GridControl();
            this.gridViewItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPOSITION_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditItemPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTYPE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditItemType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNAME2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFULL_MARK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.simpleButtonRemoveItems = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAddItems = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).BeginInit();
            this.panelControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFormDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvaluationForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPositoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvaluationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControlButtons.Location = new System.Drawing.Point(0, 447);
            this.panelControlButtons.Size = new System.Drawing.Size(929, 40);
            this.panelControlButtons.TabIndex = 0;
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(849, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(768, 9);
            // 
            // panelControl2
            // 
            this.panelControlMain.Controls.Add(this.simpleButtonRemoveItems);
            this.panelControlMain.Controls.Add(this.simpleButtonAddItems);
            this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControlMain.Size = new System.Drawing.Size(40, 447);
            // 
            // gridViewFormDetail
            // 
            this.gridViewFormDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSED,
            this.colSHOW_ORDER,
            this.colTYPE,
            this.colNAME1,
            this.colFULL_MARK,
            this.colDESCRIPTION1});
            this.gridViewFormDetail.GridControl = this.gridControlEvaluationForm;
            this.gridViewFormDetail.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FULL_MARK", null, "满分：{0}")});
            this.gridViewFormDetail.Name = "gridViewFormDetail";
            this.gridViewFormDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewFormDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewFormDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewFormDetail.OptionsCustomization.AllowColumnResizing = false;
            this.gridViewFormDetail.OptionsCustomization.AllowFilter = false;
            this.gridViewFormDetail.OptionsCustomization.AllowGroup = false;
            this.gridViewFormDetail.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewFormDetail.OptionsCustomization.AllowSort = false;
            this.gridViewFormDetail.OptionsSelection.MultiSelect = true;
            this.gridViewFormDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewFormDetail.ViewCaption = "考核表项目明细";
            this.gridViewFormDetail.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.detail_selectionChanged);
            this.gridViewFormDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.detailCellValueChanged);
            // 
            // colUSED
            // 
            this.colUSED.Caption = "启用";
            this.colUSED.FieldName = "USED";
            this.colUSED.MaxWidth = 35;
            this.colUSED.Name = "colUSED";
            this.colUSED.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUSED.Visible = true;
            this.colUSED.VisibleIndex = 0;
            this.colUSED.Width = 35;
            // 
            // colSHOW_ORDER
            // 
            this.colSHOW_ORDER.Caption = "显示顺序";
            this.colSHOW_ORDER.FieldName = "SHOW_ORDER";
            this.colSHOW_ORDER.MaxWidth = 80;
            this.colSHOW_ORDER.Name = "colSHOW_ORDER";
            this.colSHOW_ORDER.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSHOW_ORDER.Visible = true;
            this.colSHOW_ORDER.VisibleIndex = 1;
            this.colSHOW_ORDER.Width = 80;
            // 
            // colTYPE
            // 
            this.colTYPE.Caption = "考核类型";
            this.colTYPE.ColumnEdit = this.repositoryItemLookUpEditType;
            this.colTYPE.FieldName = "TYPE";
            this.colTYPE.MaxWidth = 100;
            this.colTYPE.Name = "colTYPE";
            this.colTYPE.OptionsColumn.AllowEdit = false;
            this.colTYPE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colTYPE.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colTYPE.Visible = true;
            this.colTYPE.VisibleIndex = 3;
            this.colTYPE.Width = 96;
            // 
            // repositoryItemLookUpEditType
            // 
            this.repositoryItemLookUpEditType.AutoHeight = false;
            this.repositoryItemLookUpEditType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "类型")});
            this.repositoryItemLookUpEditType.DisplayMember = "NAME";
            this.repositoryItemLookUpEditType.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.repositoryItemLookUpEditType.Name = "repositoryItemLookUpEditType";
            this.repositoryItemLookUpEditType.NullText = "";
            this.repositoryItemLookUpEditType.ShowFooter = false;
            this.repositoryItemLookUpEditType.ShowHeader = false;
            this.repositoryItemLookUpEditType.ValueMember = "ID";
            // 
            // colNAME1
            // 
            this.colNAME1.Caption = "基本项名称";
            this.colNAME1.FieldName = "NAME";
            this.colNAME1.MaxWidth = 100;
            this.colNAME1.Name = "colNAME1";
            this.colNAME1.OptionsColumn.AllowEdit = false;
            this.colNAME1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colNAME1.Visible = true;
            this.colNAME1.VisibleIndex = 2;
            this.colNAME1.Width = 100;
            // 
            // colFULL_MARK
            // 
            this.colFULL_MARK.Caption = "满分";
            this.colFULL_MARK.FieldName = "FULL_MARK";
            this.colFULL_MARK.MaxWidth = 80;
            this.colFULL_MARK.Name = "colFULL_MARK";
            this.colFULL_MARK.OptionsColumn.AllowEdit = false;
            this.colFULL_MARK.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colFULL_MARK.Visible = true;
            this.colFULL_MARK.VisibleIndex = 4;
            this.colFULL_MARK.Width = 80;
            // 
            // colDESCRIPTION1
            // 
            this.colDESCRIPTION1.Caption = "说明";
            this.colDESCRIPTION1.FieldName = "DESCRIPTION";
            this.colDESCRIPTION1.Name = "colDESCRIPTION1";
            this.colDESCRIPTION1.OptionsColumn.AllowEdit = false;
            this.colDESCRIPTION1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDESCRIPTION1.Visible = true;
            this.colDESCRIPTION1.VisibleIndex = 5;
            this.colDESCRIPTION1.Width = 96;
            // 
            // gridControlEvaluationForm
            // 
            this.gridControlEvaluationForm.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridViewFormDetail;
            gridLevelNode1.RelationName = "evaluation_form_detail";
            this.gridControlEvaluationForm.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlEvaluationForm.Location = new System.Drawing.Point(0, 0);
            this.gridControlEvaluationForm.MainView = this.gridViewForm;
            this.gridControlEvaluationForm.Name = "gridControlEvaluationForm";
            this.gridControlEvaluationForm.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditPositoin,
            this.repositoryItemLookUpEditType,
            this.repositoryItemMemoEdit1});
            this.gridControlEvaluationForm.ShowOnlyPredefinedDetails = true;
            this.gridControlEvaluationForm.Size = new System.Drawing.Size(529, 447);
            this.gridControlEvaluationForm.TabIndex = 0;
            this.gridControlEvaluationForm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewForm,
            this.gridViewFormDetail});
            // 
            // gridViewForm
            // 
            this.gridViewForm.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colENABLED,
            this.colPOSITION_ID,
            this.colNAME,
            this.colDESCRIPTION});
            this.gridViewForm.GridControl = this.gridControlEvaluationForm;
            this.gridViewForm.GroupCount = 1;
            this.gridViewForm.Name = "gridViewForm";
            this.gridViewForm.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewForm.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewForm.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewForm.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewForm.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridViewForm.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gridViewForm.OptionsDetail.SmartDetailHeight = true;
            this.gridViewForm.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewForm.OptionsView.RowAutoHeight = true;
            this.gridViewForm.OptionsView.ShowGroupedColumns = true;
            this.gridViewForm.OptionsView.ShowViewCaption = true;
            this.gridViewForm.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.gridViewForm.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPOSITION_ID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewForm.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.initNewRow);
            this.gridViewForm.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.form_FocusedRowChanged);
            // 
            // colENABLED
            // 
            this.colENABLED.AppearanceHeader.Options.UseTextOptions = true;
            this.colENABLED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colENABLED.Caption = "有效";
            this.colENABLED.FieldName = "ENABLED";
            this.colENABLED.MaxWidth = 35;
            this.colENABLED.Name = "colENABLED";
            this.colENABLED.Visible = true;
            this.colENABLED.VisibleIndex = 0;
            this.colENABLED.Width = 41;
            // 
            // colPOSITION_ID
            // 
            this.colPOSITION_ID.Caption = "适用岗位";
            this.colPOSITION_ID.ColumnEdit = this.repositoryItemLookUpEditPositoin;
            this.colPOSITION_ID.FieldName = "POSITION_ID";
            this.colPOSITION_ID.MaxWidth = 100;
            this.colPOSITION_ID.Name = "colPOSITION_ID";
            this.colPOSITION_ID.Visible = true;
            this.colPOSITION_ID.VisibleIndex = 1;
            this.colPOSITION_ID.Width = 100;
            // 
            // repositoryItemLookUpEditPositoin
            // 
            this.repositoryItemLookUpEditPositoin.AutoHeight = false;
            this.repositoryItemLookUpEditPositoin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPositoin.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "岗位名称")});
            this.repositoryItemLookUpEditPositoin.DisplayMember = "NAME";
            this.repositoryItemLookUpEditPositoin.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.repositoryItemLookUpEditPositoin.Name = "repositoryItemLookUpEditPositoin";
            this.repositoryItemLookUpEditPositoin.NullText = "";
            this.repositoryItemLookUpEditPositoin.ShowFooter = false;
            this.repositoryItemLookUpEditPositoin.ShowHeader = false;
            this.repositoryItemLookUpEditPositoin.ValueMember = "ID";
            // 
            // colNAME
            // 
            this.colNAME.Caption = "名称";
            this.colNAME.FieldName = "NAME";
            this.colNAME.MaxWidth = 150;
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 2;
            this.colNAME.Width = 150;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "说明";
            this.colDESCRIPTION.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 3;
            this.colDESCRIPTION.Width = 200;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlEvaluationForm);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlEvaluationItems);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControlMain);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(929, 447);
            this.splitContainerControl1.SplitterPosition = 529;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlEvaluationItems
            // 
            this.gridControlEvaluationItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEvaluationItems.Location = new System.Drawing.Point(40, 0);
            this.gridControlEvaluationItems.MainView = this.gridViewItem;
            this.gridControlEvaluationItems.Name = "gridControlEvaluationItems";
            this.gridControlEvaluationItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditItemType,
            this.repositoryItemLookUpEditItemPosition,
            this.repositoryItemMemoEdit2});
            this.gridControlEvaluationItems.Size = new System.Drawing.Size(355, 447);
            this.gridControlEvaluationItems.TabIndex = 1;
            this.gridControlEvaluationItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItem});
            // 
            // gridViewItem
            // 
            this.gridViewItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPOSITION_ID2,
            this.colTYPE1,
            this.colNAME2,
            this.colFULL_MARK1,
            this.colDESCRIPTION2});
            this.gridViewItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewItem.GridControl = this.gridControlEvaluationItems;
            this.gridViewItem.Name = "gridViewItem";
            this.gridViewItem.OptionsBehavior.Editable = false;
            this.gridViewItem.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridViewItem.OptionsSelection.MultiSelect = true;
            this.gridViewItem.OptionsView.RowAutoHeight = true;
            this.gridViewItem.OptionsView.ShowViewCaption = true;
            this.gridViewItem.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.gridViewItem.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.items_selectionChanged);
            // 
            // colPOSITION_ID2
            // 
            this.colPOSITION_ID2.Caption = "适用岗位";
            this.colPOSITION_ID2.ColumnEdit = this.repositoryItemLookUpEditItemPosition;
            this.colPOSITION_ID2.FieldName = "POSITION_ID";
            this.colPOSITION_ID2.MaxWidth = 100;
            this.colPOSITION_ID2.Name = "colPOSITION_ID2";
            this.colPOSITION_ID2.Visible = true;
            this.colPOSITION_ID2.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEditItemPosition
            // 
            this.repositoryItemLookUpEditItemPosition.AutoHeight = false;
            this.repositoryItemLookUpEditItemPosition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditItemPosition.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Name2")});
            this.repositoryItemLookUpEditItemPosition.DisplayMember = "NAME";
            this.repositoryItemLookUpEditItemPosition.Name = "repositoryItemLookUpEditItemPosition";
            this.repositoryItemLookUpEditItemPosition.ValueMember = "ID";
            // 
            // colTYPE1
            // 
            this.colTYPE1.Caption = "考核类型";
            this.colTYPE1.ColumnEdit = this.repositoryItemLookUpEditItemType;
            this.colTYPE1.FieldName = "TYPE";
            this.colTYPE1.MaxWidth = 100;
            this.colTYPE1.Name = "colTYPE1";
            this.colTYPE1.Visible = true;
            this.colTYPE1.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEditItemType
            // 
            this.repositoryItemLookUpEditItemType.AutoHeight = false;
            this.repositoryItemLookUpEditItemType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditItemType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Name12")});
            this.repositoryItemLookUpEditItemType.DisplayMember = "NAME";
            this.repositoryItemLookUpEditItemType.Name = "repositoryItemLookUpEditItemType";
            this.repositoryItemLookUpEditItemType.NullText = "";
            this.repositoryItemLookUpEditItemType.ValueMember = "ID";
            // 
            // colNAME2
            // 
            this.colNAME2.Caption = "项目名称";
            this.colNAME2.FieldName = "NAME";
            this.colNAME2.MaxWidth = 120;
            this.colNAME2.Name = "colNAME2";
            this.colNAME2.Visible = true;
            this.colNAME2.VisibleIndex = 2;
            // 
            // colFULL_MARK1
            // 
            this.colFULL_MARK1.Caption = "满分";
            this.colFULL_MARK1.FieldName = "FULL_MARK";
            this.colFULL_MARK1.MaxWidth = 80;
            this.colFULL_MARK1.Name = "colFULL_MARK1";
            this.colFULL_MARK1.Visible = true;
            this.colFULL_MARK1.VisibleIndex = 4;
            // 
            // colDESCRIPTION2
            // 
            this.colDESCRIPTION2.Caption = "说明";
            this.colDESCRIPTION2.ColumnEdit = this.repositoryItemMemoEdit2;
            this.colDESCRIPTION2.FieldName = "DESCRIPTION";
            this.colDESCRIPTION2.Name = "colDESCRIPTION2";
            this.colDESCRIPTION2.Visible = true;
            this.colDESCRIPTION2.VisibleIndex = 3;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // simpleButtonRemoveItems
            // 
            this.simpleButtonRemoveItems.Enabled = false;
            this.simpleButtonRemoveItems.Location = new System.Drawing.Point(5, 157);
            this.simpleButtonRemoveItems.Name = "simpleButtonRemoveItems";
            this.simpleButtonRemoveItems.Size = new System.Drawing.Size(30, 23);
            this.simpleButtonRemoveItems.TabIndex = 1;
            this.simpleButtonRemoveItems.Text = ">>";
            this.simpleButtonRemoveItems.Click += new System.EventHandler(this.remove_items);
            // 
            // simpleButtonAddItems
            // 
            this.simpleButtonAddItems.Enabled = false;
            this.simpleButtonAddItems.Location = new System.Drawing.Point(5, 128);
            this.simpleButtonAddItems.Name = "simpleButtonAddItems";
            this.simpleButtonAddItems.Size = new System.Drawing.Size(30, 23);
            this.simpleButtonAddItems.TabIndex = 0;
            this.simpleButtonAddItems.Text = "<<";
            this.simpleButtonAddItems.Click += new System.EventHandler(this.add_items);
            // 
            // EvaluationFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "EvaluationFormControl";
            this.Size = new System.Drawing.Size(929, 487);
            this.Controls.SetChildIndex(this.panelControlButtons, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).EndInit();
            this.panelControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFormDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvaluationForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPositoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvaluationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEvaluationForm;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewForm;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSITION_ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFormDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colUSED;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION1;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_MARK;
        private DevExpress.XtraGrid.Columns.GridColumn colSHOW_ORDER;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPositoin;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlEvaluationItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME2;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_MARK1;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION2;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSITION_ID2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRemoveItems;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddItems;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditItemPosition;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;

    }
}
