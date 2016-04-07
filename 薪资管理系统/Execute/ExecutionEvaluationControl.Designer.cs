namespace SalarySystem.Execute
{
    partial class ExecutionEvaluationControl
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
            this.gridControlEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmploye = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.temployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_employeeTableAdapter = new SalarySystem.Data.DataSetSalaryTableAdapters.t_employeeTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLEADER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOSITION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENTRY_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISMISSION_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageEvaluation = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageAssignment = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageSalary = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmploye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 406);
            this.panelControl1.Size = new System.Drawing.Size(650, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(570, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(489, 9);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.splitContainerControl1);
            this.panelControl2.Size = new System.Drawing.Size(650, 406);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlEmployee);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(646, 402);
            this.splitContainerControl1.SplitterPosition = 280;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlEmployee
            // 
            this.gridControlEmployee.DataSource = this.temployeeBindingSource;
            this.gridControlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmployee.Location = new System.Drawing.Point(0, 0);
            this.gridControlEmployee.MainView = this.gridViewEmploye;
            this.gridControlEmployee.Name = "gridControlEmployee";
            this.gridControlEmployee.Size = new System.Drawing.Size(280, 402);
            this.gridControlEmployee.TabIndex = 0;
            this.gridControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmploye});
            // 
            // gridViewEmploye
            // 
            this.gridViewEmploye.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPOSITION_ID,
            this.colNAME,
            this.colLEADER_ID,
            this.colDESCRIPTION,
            this.colENTRY_TIME,
            this.colDISMISSION_TIME,
            this.colENABLED,
            this.colID});
            this.gridViewEmploye.GridControl = this.gridControlEmployee;
            this.gridViewEmploye.Name = "gridViewEmploye";
            this.gridViewEmploye.OptionsBehavior.Editable = false;
            this.gridViewEmploye.OptionsBehavior.ReadOnly = true;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temployeeBindingSource
            // 
            this.temployeeBindingSource.DataMember = "t_employee";
            this.temployeeBindingSource.DataSource = this.dataSetSalary;
            // 
            // t_employeeTableAdapter
            // 
            this.t_employeeTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colLEADER_ID
            // 
            this.colLEADER_ID.FieldName = "LEADER_ID";
            this.colLEADER_ID.Name = "colLEADER_ID";
            // 
            // colPOSITION_ID
            // 
            this.colPOSITION_ID.Caption = "岗位";
            this.colPOSITION_ID.FieldName = "POSITION_ID";
            this.colPOSITION_ID.Name = "colPOSITION_ID";
            this.colPOSITION_ID.Visible = true;
            this.colPOSITION_ID.VisibleIndex = 0;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "姓名";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 1;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            // 
            // colENTRY_TIME
            // 
            this.colENTRY_TIME.FieldName = "ENTRY_TIME";
            this.colENTRY_TIME.Name = "colENTRY_TIME";
            // 
            // colDISMISSION_TIME
            // 
            this.colDISMISSION_TIME.FieldName = "DISMISSION_TIME";
            this.colDISMISSION_TIME.Name = "colDISMISSION_TIME";
            // 
            // colENABLED
            // 
            this.colENABLED.FieldName = "ENABLED";
            this.colENABLED.Name = "colENABLED";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageEvaluation;
            this.xtraTabControl1.Size = new System.Drawing.Size(361, 402);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageEvaluation,
            this.xtraTabPageAssignment,
            this.xtraTabPageSalary});
            // 
            // xtraTabPageEvaluation
            // 
            this.xtraTabPageEvaluation.Name = "xtraTabPageEvaluation";
            this.xtraTabPageEvaluation.Size = new System.Drawing.Size(355, 374);
            this.xtraTabPageEvaluation.Text = "绩效考核成绩";
            // 
            // xtraTabPageAssignment
            // 
            this.xtraTabPageAssignment.Name = "xtraTabPageAssignment";
            this.xtraTabPageAssignment.Size = new System.Drawing.Size(355, 374);
            this.xtraTabPageAssignment.Text = "任务完成情况";
            // 
            // xtraTabPageSalary
            // 
            this.xtraTabPageSalary.Name = "xtraTabPageSalary";
            this.xtraTabPageSalary.Size = new System.Drawing.Size(355, 374);
            this.xtraTabPageSalary.Text = "工资明细";
            // 
            // ExecutionEvaluationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ExecutionEvaluationControl";
            this.Size = new System.Drawing.Size(650, 446);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmploye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlEmployee;
        private System.Windows.Forms.BindingSource temployeeBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmploye;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colLEADER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSITION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colENTRY_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colDISMISSION_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED;
        private Data.DataSetSalaryTableAdapters.t_employeeTableAdapter t_employeeTableAdapter;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageEvaluation;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageAssignment;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageSalary;

    }
}
