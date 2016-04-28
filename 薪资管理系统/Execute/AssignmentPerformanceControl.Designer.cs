namespace SalarySystem.Execute
{
    partial class AssignmentPerformanceControl
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tassignmentperformanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDEFINE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFINE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTARGET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPLETED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFINE_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_assignment_performanceTableAdapter = new SalarySystem.Data.DataSetSalaryTableAdapters.t_assignment_performanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tassignmentperformanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tassignmentperformanceBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(594, 499);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tassignmentperformanceBindingSource
            // 
            this.tassignmentperformanceBindingSource.DataMember = "t_assignment_performance";
            this.tassignmentperformanceBindingSource.DataSource = this.dataSetSalary;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDEFINE_ID,
            this.colDEFINE_TYPE,
            this.colTARGET,
            this.colCOMPLETED,
            this.colDEFINE_UNIT,
            this.colDESCRIPTION});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colDEFINE_ID
            // 
            this.colDEFINE_ID.Caption = "任务";
            this.colDEFINE_ID.FieldName = "DEFINE_ID";
            this.colDEFINE_ID.Name = "colDEFINE_ID";
            this.colDEFINE_ID.OptionsColumn.AllowEdit = false;
            this.colDEFINE_ID.Visible = true;
            this.colDEFINE_ID.VisibleIndex = 4;
            // 
            // colDEFINE_TYPE
            // 
            this.colDEFINE_TYPE.Caption = "类型";
            this.colDEFINE_TYPE.FieldName = "DEFINE_TYPE";
            this.colDEFINE_TYPE.Name = "colDEFINE_TYPE";
            this.colDEFINE_TYPE.OptionsColumn.AllowEdit = false;
            this.colDEFINE_TYPE.Visible = true;
            this.colDEFINE_TYPE.VisibleIndex = 5;
            // 
            // colTARGET
            // 
            this.colTARGET.Caption = "任务额度";
            this.colTARGET.FieldName = "TARGET";
            this.colTARGET.Name = "colTARGET";
            this.colTARGET.OptionsColumn.AllowEdit = false;
            this.colTARGET.Visible = true;
            this.colTARGET.VisibleIndex = 1;
            // 
            // colCOMPLETED
            // 
            this.colCOMPLETED.Caption = "完成额度";
            this.colCOMPLETED.FieldName = "COMPLETED";
            this.colCOMPLETED.Name = "colCOMPLETED";
            this.colCOMPLETED.Visible = true;
            this.colCOMPLETED.VisibleIndex = 0;
            // 
            // colDEFINE_UNIT
            // 
            this.colDEFINE_UNIT.Caption = "单位";
            this.colDEFINE_UNIT.FieldName = "DEFINE_UNIT";
            this.colDEFINE_UNIT.Name = "colDEFINE_UNIT";
            this.colDEFINE_UNIT.OptionsColumn.AllowEdit = false;
            this.colDEFINE_UNIT.Visible = true;
            this.colDEFINE_UNIT.VisibleIndex = 3;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "备注";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 2;
            // 
            // t_assignment_performanceTableAdapter
            // 
            this.t_assignment_performanceTableAdapter.ClearBeforeFill = true;
            // 
            // AssignmentPerformanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "AssignmentPerformanceControl";
            this.Size = new System.Drawing.Size(594, 499);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tassignmentperformanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tassignmentperformanceBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPLETED;
        private DevExpress.XtraGrid.Columns.GridColumn colTARGET;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private Data.DataSetSalaryTableAdapters.t_assignment_performanceTableAdapter t_assignment_performanceTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFINE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFINE_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFINE_UNIT;
    }
}
