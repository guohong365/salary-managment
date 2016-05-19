namespace SalarySystem.Definition.Salary
{
    partial class SalaryItemGroupControl
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
            this.gridControlItemGroup = new DevExpress.XtraGrid.GridControl();
            this.gridViewItemGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colENABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditItem = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tsalaryitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.gridViewLookupItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHOW_ORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).BeginInit();
            this.panelControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsalaryitemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLookupItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControlButtons.Location = new System.Drawing.Point(0, 391);
            this.panelControlButtons.Size = new System.Drawing.Size(691, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(611, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(530, 9);
            // 
            // panelControl2
            // 
            this.panelControlMain.Controls.Add(this.gridControlItemGroup);
            this.panelControlMain.Size = new System.Drawing.Size(691, 391);
            // 
            // gridControlItemGroup
            // 
            this.gridControlItemGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlItemGroup.Location = new System.Drawing.Point(2, 2);
            this.gridControlItemGroup.MainView = this.gridViewItemGroup;
            this.gridControlItemGroup.Name = "gridControlItemGroup";
            this.gridControlItemGroup.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditItem});
            this.gridControlItemGroup.Size = new System.Drawing.Size(687, 387);
            this.gridControlItemGroup.TabIndex = 0;
            this.gridControlItemGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItemGroup});
            // 
            // gridViewItemGroup
            // 
            this.gridViewItemGroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colENABLED,
            this.colNAME,
            this.colITEM_ID,
            this.colSHOW_ORDER,
            this.colDESCRIPTION});
            this.gridViewItemGroup.GridControl = this.gridControlItemGroup;
            this.gridViewItemGroup.GroupCount = 1;
            this.gridViewItemGroup.Name = "gridViewItemGroup";
            this.gridViewItemGroup.OptionsView.ShowGroupedColumns = true;
            this.gridViewItemGroup.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNAME, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colENABLED
            // 
            this.colENABLED.Caption = "启用";
            this.colENABLED.FieldName = "ENABLED";
            this.colENABLED.Name = "colENABLED";
            this.colENABLED.Visible = true;
            this.colENABLED.VisibleIndex = 0;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "组名";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 1;
            // 
            // colITEM_ID
            // 
            this.colITEM_ID.Caption = "薪资项目";
            this.colITEM_ID.ColumnEdit = this.repositoryItemGridLookUpEditItem;
            this.colITEM_ID.FieldName = "ITEM_ID";
            this.colITEM_ID.Name = "colITEM_ID";
            this.colITEM_ID.Visible = true;
            this.colITEM_ID.VisibleIndex = 3;
            // 
            // repositoryItemGridLookUpEditItem
            // 
            this.repositoryItemGridLookUpEditItem.AutoHeight = false;
            this.repositoryItemGridLookUpEditItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditItem.DataSource = this.tsalaryitemBindingSource;
            this.repositoryItemGridLookUpEditItem.DisplayMember = "NAME";
            this.repositoryItemGridLookUpEditItem.Name = "repositoryItemGridLookUpEditItem";
            this.repositoryItemGridLookUpEditItem.ValueMember = "ID";
            this.repositoryItemGridLookUpEditItem.View = this.gridViewLookupItem;
            this.repositoryItemGridLookUpEditItem.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            this.repositoryItemGridLookUpEditItem.Popup += new System.EventHandler(this.onPopup);
            // 
            // tsalaryitemBindingSource
            // 
            this.tsalaryitemBindingSource.DataMember = "t_salary_item";
            this.tsalaryitemBindingSource.DataSource = this.dataSetSalary;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewLookupItem
            // 
            this.gridViewLookupItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNAME1,
            this.colID1});
            this.gridViewLookupItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewLookupItem.Name = "gridViewLookupItem";
            this.gridViewLookupItem.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewLookupItem.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewLookupItem.OptionsView.ShowGroupPanel = false;
            this.gridViewLookupItem.OptionsView.ShowIndicator = false;
            // 
            // colNAME1
            // 
            this.colNAME1.Caption = "薪资项目";
            this.colNAME1.FieldName = "NAME";
            this.colNAME1.Name = "colNAME1";
            this.colNAME1.Visible = true;
            this.colNAME1.VisibleIndex = 0;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            // 
            // colSHOW_ORDER
            // 
            this.colSHOW_ORDER.Caption = "顺序";
            this.colSHOW_ORDER.FieldName = "SHOW_ORDER";
            this.colSHOW_ORDER.Name = "colSHOW_ORDER";
            this.colSHOW_ORDER.Visible = true;
            this.colSHOW_ORDER.VisibleIndex = 4;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "说明";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 2;
            // 
            // t_salary_itemTableAdapter
            // 
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // SalaryItemGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SalaryItemGroupControl";
            this.Size = new System.Drawing.Size(691, 431);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).EndInit();
            this.panelControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsalaryitemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLookupItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlItemGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItemGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHOW_ORDER;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditItem;
        private System.Windows.Forms.BindingSource tsalaryitemBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLookupItem;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
    }
}
