namespace SalarySystem.Managment.Performance
{
    partial class EvaluationManagmentControl
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
            this.gridViewParameters = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnParamName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnParamType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnParamDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlEvaluationForm = new DevExpress.XtraGrid.GridControl();
            this.gridViewSettings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridViewEvaluationForm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFormula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlEvaluationItem = new DevExpress.XtraGrid.GridControl();
            this.gridViewEvaluationItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvaluationForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvaluationForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvaluationItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvaluationItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewParameters
            // 
            this.gridViewParameters.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnParamName,
            this.gridColumnParamType,
            this.gridColumnParamDesc});
            this.gridViewParameters.GridControl = this.gridControlEvaluationForm;
            this.gridViewParameters.Name = "gridViewParameters";
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
            // gridControlEvaluationForm
            // 
            this.gridControlEvaluationForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEvaluationForm.Location = new System.Drawing.Point(0, 0);
            this.gridControlEvaluationForm.MainView = this.gridViewEvaluationForm;
            this.gridControlEvaluationForm.Name = "gridControlEvaluationForm";
            this.gridControlEvaluationForm.Size = new System.Drawing.Size(271, 581);
            this.gridControlEvaluationForm.TabIndex = 0;
            this.gridControlEvaluationForm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSettings,
            this.gridViewEvaluationForm,
            this.gridViewParameters});
            // 
            // gridViewSettings
            // 
            this.gridViewSettings.GridControl = this.gridControlEvaluationForm;
            this.gridViewSettings.Name = "gridViewSettings";
            // 
            // gridViewEvaluationForm
            // 
            this.gridViewEvaluationForm.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnName,
            this.gridColumnWeight,
            this.gridColumnFormula,
            this.gridColumnDesc});
            this.gridViewEvaluationForm.GridControl = this.gridControlEvaluationForm;
            this.gridViewEvaluationForm.Name = "gridViewEvaluationForm";
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
            // gridColumnFormula
            // 
            this.gridColumnFormula.Caption = "公式";
            this.gridColumnFormula.Name = "gridColumnFormula";
            this.gridColumnFormula.Visible = true;
            this.gridColumnFormula.VisibleIndex = 3;
            // 
            // gridColumnDesc
            // 
            this.gridColumnDesc.Caption = "说明";
            this.gridColumnDesc.FieldName = "Description";
            this.gridColumnDesc.Name = "gridColumnDesc";
            this.gridColumnDesc.Visible = true;
            this.gridColumnDesc.VisibleIndex = 4;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlEvaluationForm);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlEvaluationItem);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(732, 581);
            this.splitContainerControl1.SplitterPosition = 271;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlEvaluationItem
            // 
            this.gridControlEvaluationItem.Location = new System.Drawing.Point(32, 86);
            this.gridControlEvaluationItem.MainView = this.gridViewEvaluationItem;
            this.gridControlEvaluationItem.Name = "gridControlEvaluationItem";
            this.gridControlEvaluationItem.Size = new System.Drawing.Size(400, 200);
            this.gridControlEvaluationItem.TabIndex = 0;
            this.gridControlEvaluationItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEvaluationItem});
            // 
            // gridViewEvaluationItem
            // 
            this.gridViewEvaluationItem.GridControl = this.gridControlEvaluationItem;
            this.gridViewEvaluationItem.Name = "gridViewEvaluationItem";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 541);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(456, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // EvaluationManagmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "EvaluationManagmentControl";
            this.Size = new System.Drawing.Size(732, 581);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvaluationForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvaluationForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvaluationItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvaluationItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEvaluationForm;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEvaluationForm;
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
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControlEvaluationItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEvaluationItem;
    }
}
