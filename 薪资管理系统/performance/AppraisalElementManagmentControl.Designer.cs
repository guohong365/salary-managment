namespace salary.main.performance
{
    partial class AppraisalElementManagmentControl
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlAppraisals = new DevExpress.XtraGrid.GridControl();
            this.gridViewAppraisals = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewParameters = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridViewSettings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnParamName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnParamType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnParamDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFormula = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAppraisals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAppraisals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 541);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(732, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // gridControlAppraisals
            // 
            this.gridControlAppraisals.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridViewParameters;
            gridLevelNode1.RelationName = "Parameters";
            gridLevelNode2.LevelTemplate = this.gridViewSettings;
            gridLevelNode2.RelationName = "Settings";
            this.gridControlAppraisals.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridControlAppraisals.Location = new System.Drawing.Point(0, 0);
            this.gridControlAppraisals.MainView = this.gridViewAppraisals;
            this.gridControlAppraisals.Name = "gridControlAppraisals";
            this.gridControlAppraisals.Size = new System.Drawing.Size(732, 541);
            this.gridControlAppraisals.TabIndex = 0;
            this.gridControlAppraisals.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAppraisals,
            this.gridViewParameters,
            this.gridViewSettings});
            // 
            // gridViewAppraisals
            // 
            this.gridViewAppraisals.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnName,
            this.gridColumnWeight,
            this.gridColumnFormula,
            this.gridColumnDesc});
            this.gridViewAppraisals.GridControl = this.gridControlAppraisals;
            this.gridViewAppraisals.Name = "gridViewAppraisals";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "新增";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(86, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "修改";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(167, 9);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "停用";
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "编号";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Visible = true;
            this.gridColumnId.VisibleIndex = 0;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "名称";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            // 
            // gridColumnWeight
            // 
            this.gridColumnWeight.Caption = "权重";
            this.gridColumnWeight.FieldName = "Weight";
            this.gridColumnWeight.Name = "gridColumnWeight";
            this.gridColumnWeight.Visible = true;
            this.gridColumnWeight.VisibleIndex = 2;
            // 
            // gridColumnDesc
            // 
            this.gridColumnDesc.Caption = "说明";
            this.gridColumnDesc.FieldName = "Description";
            this.gridColumnDesc.Name = "gridColumnDesc";
            this.gridColumnDesc.Visible = true;
            this.gridColumnDesc.VisibleIndex = 4;
            // 
            // gridViewParameters
            // 
            this.gridViewParameters.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnParamName,
            this.gridColumnParamType,
            this.gridColumnParamDesc});
            this.gridViewParameters.GridControl = this.gridControlAppraisals;
            this.gridViewParameters.Name = "gridViewParameters";
            // 
            // gridViewSettings
            // 
            this.gridViewSettings.GridControl = this.gridControlAppraisals;
            this.gridViewSettings.Name = "gridViewSettings";
            // 
            // gridColumnParamName
            // 
            this.gridColumnParamName.Caption = "名称";
            this.gridColumnParamName.FieldName = "Name";
            this.gridColumnParamName.Name = "gridColumnParamName";
            this.gridColumnParamName.Visible = true;
            this.gridColumnParamName.VisibleIndex = 0;
            // 
            // gridColumnParamType
            // 
            this.gridColumnParamType.Caption = "类型";
            this.gridColumnParamType.FieldName = "Type";
            this.gridColumnParamType.Name = "gridColumnParamType";
            this.gridColumnParamType.Visible = true;
            this.gridColumnParamType.VisibleIndex = 1;
            // 
            // gridColumnParamDesc
            // 
            this.gridColumnParamDesc.Caption = "说明";
            this.gridColumnParamDesc.FieldName = "Description";
            this.gridColumnParamDesc.Name = "gridColumnParamDesc";
            this.gridColumnParamDesc.Visible = true;
            this.gridColumnParamDesc.VisibleIndex = 2;
            // 
            // gridColumnFormula
            // 
            this.gridColumnFormula.Caption = "公式";
            this.gridColumnFormula.Name = "gridColumnFormula";
            this.gridColumnFormula.Visible = true;
            this.gridColumnFormula.VisibleIndex = 3;
            // 
            // AppraisalElementManagmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlAppraisals);
            this.Controls.Add(this.panelControl1);
            this.Name = "AppraisalElementManagmentControl";
            this.Size = new System.Drawing.Size(732, 581);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAppraisals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAppraisals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControlAppraisals;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAppraisals;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnWeight;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDesc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParameters;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnParamName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnParamType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnParamDesc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSettings;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFormula;
    }
}
