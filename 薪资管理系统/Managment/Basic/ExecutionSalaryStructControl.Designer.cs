namespace SalarySystem.Managment.Basic
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonRevert = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeListPosition = new DevExpress.XtraTreeList.TreeList();
            this.colNAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colENABLED = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDESCRIPTION = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gridControlExecSalaryDetai = new DevExpress.XtraGrid.GridControl();
            this.gridViewExecSalaryDetai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colENABLED1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALARY_ITEM_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditItem = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemLookUpEditLookUpPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNAME2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATA_SOURCE_TYPE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOSITION_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERSION_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENABLED2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditItemType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDESCRIPTION1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATA_SOURCE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditItemDataSource = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIT_POSITION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOSITION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERSION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlExecSalaryDetai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExecSalaryDetai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLookUpPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonRevert);
            this.panelControl1.Controls.Add(this.simpleButtonSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 443);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(760, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButtonRevert.Enabled = false;
            this.simpleButtonRevert.Location = new System.Drawing.Point(680, 9);
            this.simpleButtonRevert.Name = "simpleButtonRevert";
            this.simpleButtonRevert.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonRevert.TabIndex = 1;
            this.simpleButtonRevert.Text = "放弃";
            this.simpleButtonRevert.Click += new System.EventHandler(this.abandon_items);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButtonSave.Enabled = false;
            this.simpleButtonSave.Location = new System.Drawing.Point(599, 9);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSave.TabIndex = 0;
            this.simpleButtonSave.Text = "保存";
            this.simpleButtonSave.Click += new System.EventHandler(this.save_items);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(760, 443);
            this.splitContainerControl1.SplitterPosition = 220;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeListPosition
            // 
            this.treeListPosition.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colNAME,
            this.colENABLED,
            this.colDESCRIPTION});
            this.treeListPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListPosition.Location = new System.Drawing.Point(0, 0);
            this.treeListPosition.Name = "treeListPosition";
            this.treeListPosition.OptionsBehavior.AutoPopulateColumns = false;
            this.treeListPosition.OptionsBehavior.Editable = false;
            this.treeListPosition.ParentFieldName = "LEADER_ID";
            this.treeListPosition.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow;
            this.treeListPosition.Size = new System.Drawing.Size(220, 443);
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
            // colENABLED
            // 
            this.colENABLED.FieldName = "ENABLED";
            this.colENABLED.Name = "colENABLED";
            this.colENABLED.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colENABLED.Width = 50;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colDESCRIPTION.Width = 50;
            // 
            // gridControlExecSalaryDetai
            // 
            this.gridControlExecSalaryDetai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlExecSalaryDetai.Location = new System.Drawing.Point(0, 0);
            this.gridControlExecSalaryDetai.MainView = this.gridViewExecSalaryDetai;
            this.gridControlExecSalaryDetai.Name = "gridControlExecSalaryDetai";
            this.gridControlExecSalaryDetai.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditItemType,
            this.repositoryItemLookUpEditItemDataSource,
            this.repositoryItemLookUpEditPosition,
            this.repositoryItemGridLookUpEditItem});
            this.gridControlExecSalaryDetai.Size = new System.Drawing.Size(535, 443);
            this.gridControlExecSalaryDetai.TabIndex = 0;
            this.gridControlExecSalaryDetai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewExecSalaryDetai});
            // 
            // gridViewExecSalaryDetai
            // 
            this.gridViewExecSalaryDetai.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colENABLED1,
            this.colSALARY_ITEM_ID,
            this.colTYPE,
            this.colDESCRIPTION1,
            this.colDATA_SOURCE_TYPE,
            this.colVALUE,
            this.colFIT_POSITION_ID,
            this.colNAME1,
            this.colPOSITION_ID,
            this.colVERSION_ID});
            this.gridViewExecSalaryDetai.GridControl = this.gridControlExecSalaryDetai;
            this.gridViewExecSalaryDetai.Name = "gridViewExecSalaryDetai";
            this.gridViewExecSalaryDetai.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridViewExecSalaryDetai_ShowingEditor);
            this.gridViewExecSalaryDetai.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.initNewRow);
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
            // colSALARY_ITEM_ID
            // 
            this.colSALARY_ITEM_ID.Caption = "项目名称";
            this.colSALARY_ITEM_ID.ColumnEdit = this.repositoryItemGridLookUpEditItem;
            this.colSALARY_ITEM_ID.FieldName = "SALARY_ITEM_ID";
            this.colSALARY_ITEM_ID.Name = "colSALARY_ITEM_ID";
            this.colSALARY_ITEM_ID.Visible = true;
            this.colSALARY_ITEM_ID.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEditItem
            // 
            this.repositoryItemGridLookUpEditItem.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemGridLookUpEditItem.AutoHeight = false;
            this.repositoryItemGridLookUpEditItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditItem.DisplayMember = "NAME";
            this.repositoryItemGridLookUpEditItem.Name = "repositoryItemGridLookUpEditItem";
            this.repositoryItemGridLookUpEditItem.NullText = "";
            this.repositoryItemGridLookUpEditItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditLookUpPosition});
            this.repositoryItemGridLookUpEditItem.ValueMember = "ID";
            this.repositoryItemGridLookUpEditItem.View = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEditItem.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.repositoryItemGridLookUpEditItem_ParseEditValue);
            // 
            // repositoryItemLookUpEditLookUpPosition
            // 
            this.repositoryItemLookUpEditLookUpPosition.AutoHeight = false;
            this.repositoryItemLookUpEditLookUpPosition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditLookUpPosition.DisplayMember = "NAME";
            this.repositoryItemLookUpEditLookUpPosition.Name = "repositoryItemLookUpEditLookUpPosition";
            this.repositoryItemLookUpEditLookUpPosition.NullText = "";
            this.repositoryItemLookUpEditLookUpPosition.ValueMember = "ID";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNAME2,
            this.colTYPE1,
            this.colVALUE1,
            this.colDATA_SOURCE_TYPE1,
            this.colDESCRIPTION2,
            this.colPOSITION_ID1,
            this.colVERSION_ID1,
            this.colENABLED2,
            this.colID});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsBehavior.AutoExpandAllGroups = true;
            this.repositoryItemGridLookUpEdit1View.OptionsBehavior.AutoPopulateColumns = false;
            this.repositoryItemGridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.repositoryItemGridLookUpEdit1View.OptionsBehavior.ReadOnly = true;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemGridLookUpEdit1View.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            // 
            // colNAME2
            // 
            this.colNAME2.Caption = "项目名称";
            this.colNAME2.FieldName = "NAME";
            this.colNAME2.MaxWidth = 120;
            this.colNAME2.MinWidth = 120;
            this.colNAME2.Name = "colNAME2";
            this.colNAME2.Visible = true;
            this.colNAME2.VisibleIndex = 0;
            this.colNAME2.Width = 120;
            // 
            // colTYPE1
            // 
            this.colTYPE1.Caption = "类型";
            this.colTYPE1.FieldName = "TYPE";
            this.colTYPE1.MaxWidth = 50;
            this.colTYPE1.MinWidth = 50;
            this.colTYPE1.Name = "colTYPE1";
            this.colTYPE1.OptionsColumn.AllowFocus = false;
            this.colTYPE1.Visible = true;
            this.colTYPE1.VisibleIndex = 1;
            this.colTYPE1.Width = 50;
            // 
            // colVALUE1
            // 
            this.colVALUE1.Caption = "取值";
            this.colVALUE1.FieldName = "VALUE";
            this.colVALUE1.MaxWidth = 100;
            this.colVALUE1.MinWidth = 100;
            this.colVALUE1.Name = "colVALUE1";
            this.colVALUE1.OptionsColumn.AllowFocus = false;
            this.colVALUE1.Visible = true;
            this.colVALUE1.VisibleIndex = 2;
            this.colVALUE1.Width = 100;
            // 
            // colDATA_SOURCE_TYPE1
            // 
            this.colDATA_SOURCE_TYPE1.Caption = "数据来源";
            this.colDATA_SOURCE_TYPE1.FieldName = "DATA_SOURCE_TYPE";
            this.colDATA_SOURCE_TYPE1.MaxWidth = 50;
            this.colDATA_SOURCE_TYPE1.MinWidth = 50;
            this.colDATA_SOURCE_TYPE1.Name = "colDATA_SOURCE_TYPE1";
            this.colDATA_SOURCE_TYPE1.OptionsColumn.AllowFocus = false;
            this.colDATA_SOURCE_TYPE1.Visible = true;
            this.colDATA_SOURCE_TYPE1.VisibleIndex = 3;
            this.colDATA_SOURCE_TYPE1.Width = 50;
            // 
            // colDESCRIPTION2
            // 
            this.colDESCRIPTION2.Caption = "说明";
            this.colDESCRIPTION2.FieldName = "DESCRIPTION";
            this.colDESCRIPTION2.Name = "colDESCRIPTION2";
            this.colDESCRIPTION2.OptionsColumn.ShowInCustomizationForm = false;
            this.colDESCRIPTION2.Width = 22;
            // 
            // colPOSITION_ID1
            // 
            this.colPOSITION_ID1.Caption = "适用岗位";
            this.colPOSITION_ID1.ColumnEdit = this.repositoryItemLookUpEditLookUpPosition;
            this.colPOSITION_ID1.FieldName = "POSITION_ID";
            this.colPOSITION_ID1.MaxWidth = 100;
            this.colPOSITION_ID1.MinWidth = 100;
            this.colPOSITION_ID1.Name = "colPOSITION_ID1";
            this.colPOSITION_ID1.Visible = true;
            this.colPOSITION_ID1.VisibleIndex = 4;
            this.colPOSITION_ID1.Width = 100;
            // 
            // colVERSION_ID1
            // 
            this.colVERSION_ID1.FieldName = "VERSION_ID";
            this.colVERSION_ID1.Name = "colVERSION_ID1";
            // 
            // colENABLED2
            // 
            this.colENABLED2.FieldName = "ENABLED";
            this.colENABLED2.Name = "colENABLED2";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colTYPE
            // 
            this.colTYPE.Caption = "类型";
            this.colTYPE.ColumnEdit = this.repositoryItemLookUpEditItemType;
            this.colTYPE.FieldName = "TYPE";
            this.colTYPE.MaxWidth = 100;
            this.colTYPE.Name = "colTYPE";
            this.colTYPE.OptionsColumn.ReadOnly = true;
            this.colTYPE.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
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
            // colDESCRIPTION1
            // 
            this.colDESCRIPTION1.Caption = "描述";
            this.colDESCRIPTION1.FieldName = "DESCRIPTION";
            this.colDESCRIPTION1.Name = "colDESCRIPTION1";
            this.colDESCRIPTION1.OptionsColumn.ReadOnly = true;
            this.colDESCRIPTION1.Visible = true;
            this.colDESCRIPTION1.VisibleIndex = 3;
            // 
            // colDATA_SOURCE_TYPE
            // 
            this.colDATA_SOURCE_TYPE.Caption = "数据来源";
            this.colDATA_SOURCE_TYPE.ColumnEdit = this.repositoryItemLookUpEditItemDataSource;
            this.colDATA_SOURCE_TYPE.FieldName = "DATA_SOURCE_TYPE";
            this.colDATA_SOURCE_TYPE.Name = "colDATA_SOURCE_TYPE";
            this.colDATA_SOURCE_TYPE.OptionsColumn.ReadOnly = true;
            this.colDATA_SOURCE_TYPE.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.colDATA_SOURCE_TYPE.Visible = true;
            this.colDATA_SOURCE_TYPE.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEditItemDataSource
            // 
            this.repositoryItemLookUpEditItemDataSource.AutoHeight = false;
            this.repositoryItemLookUpEditItemDataSource.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditItemDataSource.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Name3")});
            this.repositoryItemLookUpEditItemDataSource.DisplayMember = "NAME";
            this.repositoryItemLookUpEditItemDataSource.Name = "repositoryItemLookUpEditItemDataSource";
            this.repositoryItemLookUpEditItemDataSource.NullText = "";
            this.repositoryItemLookUpEditItemDataSource.ValueMember = "ID";
            // 
            // colVALUE
            // 
            this.colVALUE.Caption = "取值";
            this.colVALUE.FieldName = "VALUE";
            this.colVALUE.Name = "colVALUE";
            this.colVALUE.OptionsColumn.ReadOnly = true;
            this.colVALUE.Visible = true;
            this.colVALUE.VisibleIndex = 4;
            // 
            // colFIT_POSITION_ID
            // 
            this.colFIT_POSITION_ID.Caption = "适用岗位";
            this.colFIT_POSITION_ID.ColumnEdit = this.repositoryItemLookUpEditPosition;
            this.colFIT_POSITION_ID.FieldName = "FIT_POSITION_ID";
            this.colFIT_POSITION_ID.Name = "colFIT_POSITION_ID";
            this.colFIT_POSITION_ID.OptionsColumn.ReadOnly = true;
            this.colFIT_POSITION_ID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.colFIT_POSITION_ID.Visible = true;
            this.colFIT_POSITION_ID.VisibleIndex = 6;
            // 
            // repositoryItemLookUpEditPosition
            // 
            this.repositoryItemLookUpEditPosition.AutoHeight = false;
            this.repositoryItemLookUpEditPosition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPosition.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Name2")});
            this.repositoryItemLookUpEditPosition.DisplayMember = "NAME";
            this.repositoryItemLookUpEditPosition.Name = "repositoryItemLookUpEditPosition";
            this.repositoryItemLookUpEditPosition.NullText = "";
            this.repositoryItemLookUpEditPosition.ShowFooter = false;
            this.repositoryItemLookUpEditPosition.ShowHeader = false;
            this.repositoryItemLookUpEditPosition.ValueMember = "ID";
            // 
            // colNAME1
            // 
            this.colNAME1.Caption = "项目名称";
            this.colNAME1.FieldName = "NAME";
            this.colNAME1.Name = "colNAME1";
            // 
            // colPOSITION_ID
            // 
            this.colPOSITION_ID.FieldName = "POSITION_ID";
            this.colPOSITION_ID.Name = "colPOSITION_ID";
            // 
            // colVERSION_ID
            // 
            this.colVERSION_ID.FieldName = "VERSION_ID";
            this.colVERSION_ID.Name = "colVERSION_ID";
            // 
            // ExecutionSalaryStructControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "ExecutionSalaryStructControl";
            this.Size = new System.Drawing.Size(760, 483);
            this.Load += new System.EventHandler(this.control_load);
            this.VisibleChanged += new System.EventHandler(this.visibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlExecSalaryDetai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExecSalaryDetai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLookUpPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRevert;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList treeListPosition;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colENABLED;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDESCRIPTION;
        private DevExpress.XtraGrid.GridControl gridControlExecSalaryDetai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewExecSalaryDetai;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION1;
        private DevExpress.XtraGrid.Columns.GridColumn colDATA_SOURCE_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSITION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED1;
        private DevExpress.XtraGrid.Columns.GridColumn colVERSION_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditItemType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditItemDataSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colFIT_POSITION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSALARY_ITEM_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditItem;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME2;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE1;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE1;
        private DevExpress.XtraGrid.Columns.GridColumn colDATA_SOURCE_TYPE1;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION2;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSITION_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colVERSION_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED2;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditLookUpPosition;
    }
}
