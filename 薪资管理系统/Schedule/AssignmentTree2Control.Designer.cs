namespace SalarySystem.Schedule
{
    partial class AssignmentTree2Control
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colEMPLOYEE_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPOSITION_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPOSITION_WEIGHT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDEF_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTARGET = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCOMPLETED = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUNIT_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPERF_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUNIT_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colASSIGNMENT_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colVERSION_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colASSIGNMENT_MONTH = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colASSIGNMENT_YEAR = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPOSITION_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colEMPLOYEE_NAME,
            this.colPOSITION_NAME,
            this.colPOSITION_WEIGHT,
            this.colDEF_NAME,
            this.colTARGET,
            this.colCOMPLETED,
            this.colUNIT_NAME,
            this.colPERF_ID,
            this.colUNIT_ID,
            this.colASSIGNMENT_ID,
            this.colVERSION_ID,
            this.colASSIGNMENT_MONTH,
            this.colASSIGNMENT_YEAR,
            this.colPOSITION_ID});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "EMPLOYEE_ID";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeList1.LookAndFeel.UseWindowsXPTheme = true;
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.ParentFieldName = "EMPLOYEE_LEADER";
            this.treeList1.RootValue = null;
            this.treeList1.Size = new System.Drawing.Size(644, 546);
            this.treeList1.TabIndex = 0;
            // 
            // colEMPLOYEE_NAME
            // 
            this.colEMPLOYEE_NAME.Caption = "员工";
            this.colEMPLOYEE_NAME.FieldName = "EMPLOYEE_NAME";
            this.colEMPLOYEE_NAME.Name = "colEMPLOYEE_NAME";
            this.colEMPLOYEE_NAME.OptionsColumn.AllowEdit = false;
            this.colEMPLOYEE_NAME.Visible = true;
            this.colEMPLOYEE_NAME.VisibleIndex = 0;
            this.colEMPLOYEE_NAME.Width = 39;
            // 
            // colPOSITION_NAME
            // 
            this.colPOSITION_NAME.Caption = "职位 ";
            this.colPOSITION_NAME.FieldName = "POSITION_NAME";
            this.colPOSITION_NAME.Name = "colPOSITION_NAME";
            this.colPOSITION_NAME.Visible = true;
            this.colPOSITION_NAME.VisibleIndex = 1;
            this.colPOSITION_NAME.Width = 39;
            // 
            // colPOSITION_WEIGHT
            // 
            this.colPOSITION_WEIGHT.Caption = "职位权重";
            this.colPOSITION_WEIGHT.FieldName = "POSITION_WEIGHT";
            this.colPOSITION_WEIGHT.Name = "colPOSITION_WEIGHT";
            this.colPOSITION_WEIGHT.Visible = true;
            this.colPOSITION_WEIGHT.VisibleIndex = 2;
            this.colPOSITION_WEIGHT.Width = 39;
            // 
            // colDEF_NAME
            // 
            this.colDEF_NAME.Caption = "任务名称";
            this.colDEF_NAME.FieldName = "DEF_NAME";
            this.colDEF_NAME.Name = "colDEF_NAME";
            this.colDEF_NAME.Visible = true;
            this.colDEF_NAME.VisibleIndex = 3;
            this.colDEF_NAME.Width = 39;
            // 
            // colTARGET
            // 
            this.colTARGET.Caption = "任务额度";
            this.colTARGET.FieldName = "TARGET";
            this.colTARGET.Name = "colTARGET";
            this.colTARGET.Visible = true;
            this.colTARGET.VisibleIndex = 4;
            this.colTARGET.Width = 39;
            // 
            // colCOMPLETED
            // 
            this.colCOMPLETED.Caption = "完成额度";
            this.colCOMPLETED.FieldName = "COMPLETED";
            this.colCOMPLETED.Name = "colCOMPLETED";
            this.colCOMPLETED.Visible = true;
            this.colCOMPLETED.VisibleIndex = 5;
            this.colCOMPLETED.Width = 39;
            // 
            // colUNIT_NAME
            // 
            this.colUNIT_NAME.Caption = "单位";
            this.colUNIT_NAME.FieldName = "UNIT_NAME";
            this.colUNIT_NAME.Name = "colUNIT_NAME";
            this.colUNIT_NAME.Visible = true;
            this.colUNIT_NAME.VisibleIndex = 6;
            this.colUNIT_NAME.Width = 39;
            // 
            // colPERF_ID
            // 
            this.colPERF_ID.FieldName = "PERF_ID";
            this.colPERF_ID.Name = "colPERF_ID";
            this.colPERF_ID.Width = 39;
            // 
            // colUNIT_ID
            // 
            this.colUNIT_ID.FieldName = "UNIT_ID";
            this.colUNIT_ID.Name = "colUNIT_ID";
            this.colUNIT_ID.Width = 39;
            // 
            // colASSIGNMENT_ID
            // 
            this.colASSIGNMENT_ID.FieldName = "ASSIGNMENT_ID";
            this.colASSIGNMENT_ID.Name = "colASSIGNMENT_ID";
            this.colASSIGNMENT_ID.Width = 39;
            // 
            // colVERSION_ID
            // 
            this.colVERSION_ID.FieldName = "VERSION_ID";
            this.colVERSION_ID.Name = "colVERSION_ID";
            this.colVERSION_ID.Width = 39;
            // 
            // colASSIGNMENT_MONTH
            // 
            this.colASSIGNMENT_MONTH.FieldName = "ASSIGNMENT_MONTH";
            this.colASSIGNMENT_MONTH.Name = "colASSIGNMENT_MONTH";
            this.colASSIGNMENT_MONTH.Width = 40;
            // 
            // colASSIGNMENT_YEAR
            // 
            this.colASSIGNMENT_YEAR.FieldName = "ASSIGNMENT_YEAR";
            this.colASSIGNMENT_YEAR.Name = "colASSIGNMENT_YEAR";
            this.colASSIGNMENT_YEAR.Width = 40;
            // 
            // colPOSITION_ID
            // 
            this.colPOSITION_ID.FieldName = "POSITION_ID";
            this.colPOSITION_ID.Name = "colPOSITION_ID";
            this.colPOSITION_ID.Width = 39;
            // 
            // AssignmentTree2Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Name = "AssignmentTree2Control";
            this.Size = new System.Drawing.Size(644, 546);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEMPLOYEE_NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPOSITION_NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPOSITION_WEIGHT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDEF_NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTARGET;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCOMPLETED;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUNIT_NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPERF_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUNIT_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colASSIGNMENT_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colVERSION_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colASSIGNMENT_MONTH;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colASSIGNMENT_YEAR;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPOSITION_ID;
    }
}
