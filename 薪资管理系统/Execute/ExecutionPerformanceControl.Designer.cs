namespace SalarySystem.Execute
{
    partial class ExecutionPerformanceControl
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
      this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
      this.gridControlEmployee = new DevExpress.XtraGrid.GridControl();
      this.gridViewEmploye = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPOSITION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repositoryItemLookUpEditPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.colLEADER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colENTRY_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDISMISSION_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colENABLED = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
      this.xtraTabPageEval = new DevExpress.XtraTab.XtraTabPage();
      this.evalFormsControl1 = new SalarySystem.Execute.EvalFormsControl();
      this.xtraTabPagePerf = new DevExpress.XtraTab.XtraTabPage();
      this.assignmentPerformanceControl1 = new SalarySystem.Execute.AssignmentPerformanceControl();
      this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
      this.lookUpEditEvaluator = new DevExpress.XtraEditors.LookUpEdit();
      this.dateEditEvalTIme = new DevExpress.XtraEditors.DateEdit();
      this.textEditEvalMonth = new DevExpress.XtraEditors.TextEdit();
      this.labelControlEmployee = new DevExpress.XtraEditors.LabelControl();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.textEditEvalYear = new DevExpress.XtraEditors.TextEdit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).BeginInit();
      this.panelControlButtons.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
      this.panelControlMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
      this.splitContainerControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewEmploye)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
      this.xtraTabControl1.SuspendLayout();
      this.xtraTabPageEval.SuspendLayout();
      this.xtraTabPagePerf.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
      this.panelControl3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEvaluator.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateEditEvalTIme.Properties.VistaTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateEditEvalTIme.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditEvalMonth.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditEvalYear.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // panelControlButtons
      // 
      this.panelControlButtons.Location = new System.Drawing.Point(0, 555);
      this.panelControlButtons.Size = new System.Drawing.Size(823, 40);
      // 
      // simpleButtonRevert
      // 
      this.simpleButtonRevert.Location = new System.Drawing.Point(743, 6);
      // 
      // simpleButtonSave
      // 
      this.simpleButtonSave.Location = new System.Drawing.Point(662, 6);
      // 
      // panelControlMain
      // 
      this.panelControlMain.Controls.Add(this.splitContainerControl1);
      this.panelControlMain.Size = new System.Drawing.Size(823, 555);
      // 
      // splitContainerControl1
      // 
      this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
      this.splitContainerControl1.Name = "splitContainerControl1";
      this.splitContainerControl1.Panel1.Controls.Add(this.gridControlEmployee);
      this.splitContainerControl1.Panel1.Text = "Panel1";
      this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
      this.splitContainerControl1.Panel2.Controls.Add(this.panelControl3);
      this.splitContainerControl1.Panel2.Text = "Panel2";
      this.splitContainerControl1.Size = new System.Drawing.Size(823, 555);
      this.splitContainerControl1.SplitterPosition = 200;
      this.splitContainerControl1.TabIndex = 1;
      this.splitContainerControl1.Text = "splitContainerControl1";
      // 
      // gridControlEmployee
      // 
      this.gridControlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridControlEmployee.Location = new System.Drawing.Point(0, 0);
      this.gridControlEmployee.MainView = this.gridViewEmploye;
      this.gridControlEmployee.Name = "gridControlEmployee";
      this.gridControlEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditPosition});
      this.gridControlEmployee.Size = new System.Drawing.Size(200, 555);
      this.gridControlEmployee.TabIndex = 0;
      this.gridControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmploye});
      // 
      // gridViewEmploye
      // 
      this.gridViewEmploye.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNAME,
            this.colPOSITION_ID,
            this.colLEADER_ID,
            this.colDESCRIPTION,
            this.colENTRY_TIME,
            this.colDISMISSION_TIME,
            this.colENABLED,
            this.colID});
      this.gridViewEmploye.GridControl = this.gridControlEmployee;
      this.gridViewEmploye.GroupCount = 1;
      this.gridViewEmploye.Name = "gridViewEmploye";
      this.gridViewEmploye.OptionsBehavior.Editable = false;
      this.gridViewEmploye.OptionsBehavior.ReadOnly = true;
      this.gridViewEmploye.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPOSITION_ID, DevExpress.Data.ColumnSortOrder.Ascending)});
      this.gridViewEmploye.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.focusedEmployeeChanged);
      // 
      // colNAME
      // 
      this.colNAME.Caption = "姓名";
      this.colNAME.FieldName = "NAME";
      this.colNAME.Name = "colNAME";
      this.colNAME.Visible = true;
      this.colNAME.VisibleIndex = 0;
      // 
      // colPOSITION_ID
      // 
      this.colPOSITION_ID.Caption = "岗位";
      this.colPOSITION_ID.ColumnEdit = this.repositoryItemLookUpEditPosition;
      this.colPOSITION_ID.FieldName = "POSITION_ID";
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "名称1")});
      this.repositoryItemLookUpEditPosition.DisplayMember = "NAME";
      this.repositoryItemLookUpEditPosition.Name = "repositoryItemLookUpEditPosition";
      this.repositoryItemLookUpEditPosition.NullText = "";
      this.repositoryItemLookUpEditPosition.ValueMember = "ID";
      // 
      // colLEADER_ID
      // 
      this.colLEADER_ID.FieldName = "LEADER_ID";
      this.colLEADER_ID.Name = "colLEADER_ID";
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
      // colID
      // 
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      // 
      // xtraTabControl1
      // 
      this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.xtraTabControl1.Location = new System.Drawing.Point(0, 140);
      this.xtraTabControl1.Name = "xtraTabControl1";
      this.xtraTabControl1.SelectedTabPage = this.xtraTabPageEval;
      this.xtraTabControl1.Size = new System.Drawing.Size(617, 415);
      this.xtraTabControl1.TabIndex = 1;
      this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageEval,
            this.xtraTabPagePerf});
      // 
      // xtraTabPageEval
      // 
      this.xtraTabPageEval.Controls.Add(this.evalFormsControl1);
      this.xtraTabPageEval.Name = "xtraTabPageEval";
      this.xtraTabPageEval.Size = new System.Drawing.Size(612, 388);
      this.xtraTabPageEval.Text = "考核";
      // 
      // evalFormsControl1
      // 
      this.evalFormsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.evalFormsControl1.EmployeePerformance = null;
      this.evalFormsControl1.Location = new System.Drawing.Point(0, 0);
      this.evalFormsControl1.Margin = new System.Windows.Forms.Padding(0);
      this.evalFormsControl1.Name = "evalFormsControl1";
      this.evalFormsControl1.Size = new System.Drawing.Size(612, 388);
      this.evalFormsControl1.TabIndex = 0;
      // 
      // xtraTabPagePerf
      // 
      this.xtraTabPagePerf.Controls.Add(this.assignmentPerformanceControl1);
      this.xtraTabPagePerf.Name = "xtraTabPagePerf";
      this.xtraTabPagePerf.Size = new System.Drawing.Size(406, 252);
      this.xtraTabPagePerf.Text = "业绩";
      // 
      // assignmentPerformanceControl1
      // 
      this.assignmentPerformanceControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.assignmentPerformanceControl1.EmployeePerformance = null;
      this.assignmentPerformanceControl1.Location = new System.Drawing.Point(0, 0);
      this.assignmentPerformanceControl1.Name = "assignmentPerformanceControl1";
      this.assignmentPerformanceControl1.Size = new System.Drawing.Size(406, 252);
      this.assignmentPerformanceControl1.TabIndex = 0;
      // 
      // panelControl3
      // 
      this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelControl3.Controls.Add(this.lookUpEditEvaluator);
      this.panelControl3.Controls.Add(this.dateEditEvalTIme);
      this.panelControl3.Controls.Add(this.textEditEvalMonth);
      this.panelControl3.Controls.Add(this.labelControlEmployee);
      this.panelControl3.Controls.Add(this.labelControl5);
      this.panelControl3.Controls.Add(this.labelControl4);
      this.panelControl3.Controls.Add(this.labelControl3);
      this.panelControl3.Controls.Add(this.labelControl2);
      this.panelControl3.Controls.Add(this.labelControl1);
      this.panelControl3.Controls.Add(this.textEditEvalYear);
      this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelControl3.Location = new System.Drawing.Point(0, 0);
      this.panelControl3.Name = "panelControl3";
      this.panelControl3.Size = new System.Drawing.Size(617, 140);
      this.panelControl3.TabIndex = 0;
      // 
      // lookUpEditEvaluator
      // 
      this.lookUpEditEvaluator.Location = new System.Drawing.Point(314, 100);
      this.lookUpEditEvaluator.Name = "lookUpEditEvaluator";
      this.lookUpEditEvaluator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpEditEvaluator.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "考评人")});
      this.lookUpEditEvaluator.Properties.DisplayMember = "NAME";
      this.lookUpEditEvaluator.Properties.NullText = "";
      this.lookUpEditEvaluator.Properties.ValueMember = "ID";
      this.lookUpEditEvaluator.Size = new System.Drawing.Size(140, 21);
      this.lookUpEditEvaluator.TabIndex = 3;
      // 
      // dateEditEvalTIme
      // 
      this.dateEditEvalTIme.EditValue = null;
      this.dateEditEvalTIme.Location = new System.Drawing.Point(87, 100);
      this.dateEditEvalTIme.Name = "dateEditEvalTIme";
      this.dateEditEvalTIme.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dateEditEvalTIme.Properties.DisplayFormat.FormatString = "yyyy年MM月dd日";
      this.dateEditEvalTIme.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.dateEditEvalTIme.Properties.EditFormat.FormatString = "yyyy-MM-dd";
      this.dateEditEvalTIme.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.dateEditEvalTIme.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.dateEditEvalTIme.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.dateEditEvalTIme.Size = new System.Drawing.Size(140, 21);
      this.dateEditEvalTIme.TabIndex = 2;
      // 
      // textEditEvalMonth
      // 
      this.textEditEvalMonth.Location = new System.Drawing.Point(314, 63);
      this.textEditEvalMonth.Name = "textEditEvalMonth";
      this.textEditEvalMonth.Properties.DisplayFormat.FormatString = "D2";
      this.textEditEvalMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.textEditEvalMonth.Properties.EditFormat.FormatString = "D2";
      this.textEditEvalMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.textEditEvalMonth.Size = new System.Drawing.Size(140, 21);
      this.textEditEvalMonth.TabIndex = 1;
      // 
      // labelControlEmployee
      // 
      this.labelControlEmployee.Appearance.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.labelControlEmployee.Location = new System.Drawing.Point(85, 18);
      this.labelControlEmployee.Name = "labelControlEmployee";
      this.labelControlEmployee.Size = new System.Drawing.Size(48, 24);
      this.labelControlEmployee.TabIndex = 1;
      this.labelControlEmployee.Text = "张三";
      // 
      // labelControl5
      // 
      this.labelControl5.Location = new System.Drawing.Point(19, 18);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(60, 14);
      this.labelControl5.TabIndex = 0;
      this.labelControl5.Text = "被考核人：";
      // 
      // labelControl4
      // 
      this.labelControl4.Location = new System.Drawing.Point(19, 101);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(60, 14);
      this.labelControl4.TabIndex = 6;
      this.labelControl4.Text = "考核时间：";
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(258, 101);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(48, 14);
      this.labelControl3.TabIndex = 8;
      this.labelControl3.Text = "考核人：";
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(19, 64);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(60, 14);
      this.labelControl2.TabIndex = 2;
      this.labelControl2.Text = "考核年份：";
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(246, 64);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(60, 14);
      this.labelControl1.TabIndex = 4;
      this.labelControl1.Text = "考核月份：";
      // 
      // textEditEvalYear
      // 
      this.textEditEvalYear.Location = new System.Drawing.Point(87, 63);
      this.textEditEvalYear.Name = "textEditEvalYear";
      this.textEditEvalYear.Properties.DisplayFormat.FormatString = "D4";
      this.textEditEvalYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.textEditEvalYear.Properties.EditFormat.FormatString = "D4";
      this.textEditEvalYear.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.textEditEvalYear.Size = new System.Drawing.Size(140, 21);
      this.textEditEvalYear.TabIndex = 0;
      // 
      // ExecutionPerformanceControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Name = "ExecutionPerformanceControl";
      this.Size = new System.Drawing.Size(823, 595);
      ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).EndInit();
      this.panelControlButtons.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
      this.panelControlMain.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
      this.splitContainerControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewEmploye)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
      this.xtraTabControl1.ResumeLayout(false);
      this.xtraTabPageEval.ResumeLayout(false);
      this.xtraTabPagePerf.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
      this.panelControl3.ResumeLayout(false);
      this.panelControl3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEvaluator.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateEditEvalTIme.Properties.VistaTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateEditEvalTIme.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditEvalMonth.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditEvalYear.Properties)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmploye;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSITION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLEADER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colENTRY_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colDISMISSION_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditEvaluator;
        private DevExpress.XtraEditors.DateEdit dateEditEvalTIme;
        private DevExpress.XtraEditors.TextEdit textEditEvalMonth;
        private DevExpress.XtraEditors.LabelControl labelControlEmployee;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditEvalYear;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPosition;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageEval;
        private EvalFormsControl evalFormsControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagePerf;
        private AssignmentPerformanceControl assignmentPerformanceControl1;
    }
}
