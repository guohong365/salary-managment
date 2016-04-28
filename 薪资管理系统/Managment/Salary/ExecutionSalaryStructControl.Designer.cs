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
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeListPosition = new DevExpress.XtraTreeList.TreeList();
            this.colNAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gridControlExecSalaryDetai = new DevExpress.XtraGrid.GridControl();
            this.vsalarystructdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.gridViewExecSalaryDetai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colENABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFUNC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditItemType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEditFormular = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.v_salary_struct_detailTableAdapter = new SalarySystem.Data.DataSetSalaryTableAdapters.v_salary_struct_detailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlExecSalaryDetai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsalarystructdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExecSalaryDetai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditFormular)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 443);
            this.panelControl1.Size = new System.Drawing.Size(760, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(1048, 5);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(967, 5);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.splitContainerControl1);
            this.panelControl2.Size = new System.Drawing.Size(760, 443);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeListPosition);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlExecSalaryDetai);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(756, 439);
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
            this.treeListPosition.Size = new System.Drawing.Size(220, 439);
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
            this.gridControlExecSalaryDetai.DataSource = this.vsalarystructdetailBindingSource;
            this.gridControlExecSalaryDetai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlExecSalaryDetai.Location = new System.Drawing.Point(0, 0);
            this.gridControlExecSalaryDetai.MainView = this.gridViewExecSalaryDetai;
            this.gridControlExecSalaryDetai.Name = "gridControlExecSalaryDetai";
            this.gridControlExecSalaryDetai.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditItemType,
            this.repositoryItemLookUpEditFormular});
            this.gridControlExecSalaryDetai.Size = new System.Drawing.Size(531, 439);
            this.gridControlExecSalaryDetai.TabIndex = 0;
            this.gridControlExecSalaryDetai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewExecSalaryDetai});
            // 
            // vsalarystructdetailBindingSource
            // 
            this.vsalarystructdetailBindingSource.DataMember = "v_salary_struct_detail";
            this.vsalarystructdetailBindingSource.DataSource = this.dataSetSalary;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colENABLED.Caption = "启用";
            this.colENABLED.FieldName = "ENABLED";
            this.colENABLED.Name = "colENABLED";
            this.colENABLED.Visible = true;
            this.colENABLED.VisibleIndex = 0;
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
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "说明";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.OptionsColumn.AllowEdit = false;
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 5;
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
            // v_salary_struct_detailTableAdapter
            // 
            this.v_salary_struct_detailTableAdapter.ClearBeforeFill = true;
            // 
            // ExecutionSalaryStructControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ExecutionSalaryStructControl";
            this.Size = new System.Drawing.Size(760, 483);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlExecSalaryDetai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsalarystructdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExecSalaryDetai)).EndInit();
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
        private System.Windows.Forms.BindingSource vsalarystructdetailBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private Data.DataSetSalaryTableAdapters.v_salary_struct_detailTableAdapter v_salary_struct_detailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colFUNC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
    }
}
