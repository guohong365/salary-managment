namespace SalarySystem.Managment.Salary
{
    partial class FunctionDefineControl
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridViewParameter = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlFunction = new DevExpress.XtraGrid.GridControl();
            this.tsalaryfunctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.gridViewFunction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colENABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISPLAY_FORMULA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSQL_STMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).BeginInit();
            this.panelControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsalaryfunctionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControlButtons.Location = new System.Drawing.Point(0, 483);
            this.panelControlButtons.Size = new System.Drawing.Size(704, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(616, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(535, 9);
            // 
            // panelControl2
            // 
            this.panelControlMain.Controls.Add(this.gridControlFunction);
            this.panelControlMain.Size = new System.Drawing.Size(704, 483);
            // 
            // gridViewParameter
            // 
            this.gridViewParameter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridViewParameter.GridControl = this.gridControlFunction;
            this.gridViewParameter.Name = "gridViewParameter";
            this.gridViewParameter.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "名称";
            this.gridColumn1.FieldName = "NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "类型";
            this.gridColumn2.ColumnEdit = this.repositoryItemLookUpEditType;
            this.gridColumn2.FieldName = "TYPE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEditType
            // 
            this.repositoryItemLookUpEditType.AutoHeight = false;
            this.repositoryItemLookUpEditType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "NAME")});
            this.repositoryItemLookUpEditType.DisplayMember = "NAME";
            this.repositoryItemLookUpEditType.Name = "repositoryItemLookUpEditType";
            this.repositoryItemLookUpEditType.ValueMember = "SYSTEM_TYPE";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "数据长度";
            this.gridColumn3.FieldName = "LENGHTH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "取值范围低限";
            this.gridColumn4.FieldName = "MIN_VALUE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "取值范围高限";
            this.gridColumn5.FieldName = "MAX_VALUE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "参数说明";
            this.gridColumn6.FieldName = "DESCRIPTION";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridControlFunction
            // 
            this.gridControlFunction.DataSource = this.tsalaryfunctionBindingSource;
            this.gridControlFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridViewParameter;
            gridLevelNode1.RelationName = "function_parameter";
            this.gridControlFunction.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlFunction.Location = new System.Drawing.Point(2, 2);
            this.gridControlFunction.MainView = this.gridViewFunction;
            this.gridControlFunction.Name = "gridControlFunction";
            this.gridControlFunction.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemLookUpEditType,
            this.repositoryItemMemoExEdit1});
            this.gridControlFunction.Size = new System.Drawing.Size(700, 479);
            this.gridControlFunction.TabIndex = 0;
            this.gridControlFunction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFunction,
            this.gridViewParameter});
            // 
            // tsalaryfunctionBindingSource
            // 
            this.tsalaryfunctionBindingSource.DataMember = "t_salary_function";
            this.tsalaryfunctionBindingSource.DataSource = this.dataSetSalary;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewFunction
            // 
            this.gridViewFunction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colENABLED,
            this.colNAME,
            this.colDISPLAY_FORMULA,
            this.colDESCRIPTION,
            this.colSQL_STMT});
            this.gridViewFunction.GridControl = this.gridControlFunction;
            this.gridViewFunction.Name = "gridViewFunction";
            this.gridViewFunction.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewFunction.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewFunction.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gridViewFunction.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewFunction.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // colENABLED
            // 
            this.colENABLED.Caption = "有效";
            this.colENABLED.FieldName = "ENABLED";
            this.colENABLED.Name = "colENABLED";
            this.colENABLED.Visible = true;
            this.colENABLED.VisibleIndex = 0;
            this.colENABLED.Width = 35;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "名称";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 1;
            // 
            // colDISPLAY_FORMULA
            // 
            this.colDISPLAY_FORMULA.Caption = "公式";
            this.colDISPLAY_FORMULA.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colDISPLAY_FORMULA.FieldName = "DISPLAY_FORMULA";
            this.colDISPLAY_FORMULA.Name = "colDISPLAY_FORMULA";
            this.colDISPLAY_FORMULA.Visible = true;
            this.colDISPLAY_FORMULA.VisibleIndex = 2;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.ReadOnly = true;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.functionEditorButtonClicked);
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "说明";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 3;
            // 
            // colSQL_STMT
            // 
            this.colSQL_STMT.Caption = "SQL";
            this.colSQL_STMT.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colSQL_STMT.FieldName = "SQL_STMT";
            this.colSQL_STMT.Name = "colSQL_STMT";
            this.colSQL_STMT.Visible = true;
            this.colSQL_STMT.VisibleIndex = 4;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // t_salary_functionTableAdapter
            // 
            // 
            // FunctionDefineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FunctionDefineControl";
            this.Size = new System.Drawing.Size(704, 523);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).EndInit();
            this.panelControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsalaryfunctionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlFunction;
        private System.Windows.Forms.BindingSource tsalaryfunctionBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParameter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFunction;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colSQL_STMT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditType;
        private DevExpress.XtraGrid.Columns.GridColumn colDISPLAY_FORMULA;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}
