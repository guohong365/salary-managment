namespace SalarySystem.Schedule
{
    partial class AssignmentTreeControl
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
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentTreeControl));
            this.列ICON = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.列NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列DEFINE_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列WEIGHT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列TARGET = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列COMPLETED = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列UNIT_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.vpositiontreeautoassignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.v_position_tree_auto_assignmentTableAdapter = new SalarySystem.Data.DataSetSalaryTableAdapters.v_position_tree_auto_assignmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpositiontreeautoassignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // 列ICON
            // 
            this.列ICON.FieldName = "ICON";
            this.列ICON.Name = "列ICON";
            this.列ICON.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列ICON.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.列NAME,
            this.列DEFINE_NAME,
            this.列WEIGHT,
            this.列TARGET,
            this.列COMPLETED,
            this.列UNIT_NAME,
            this.列ICON});
            this.treeList1.DataSource = this.vpositiontreeautoassignmentBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.列ICON;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = 1;
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.列ICON;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = 0;
            this.treeList1.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.treeList1.ImageIndexFieldName = "ICON";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Margin = new System.Windows.Forms.Padding(0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.ParentFieldName = "LEADER_ID";
            this.treeList1.SelectImageList = this.imageCollection1;
            this.treeList1.Size = new System.Drawing.Size(719, 578);
            this.treeList1.StateImageList = this.imageCollection1;
            this.treeList1.TabIndex = 0;
            // 
            // 列NAME
            // 
            this.列NAME.Caption = "岗位/人员";
            this.列NAME.FieldName = "NAME";
            this.列NAME.MinWidth = 43;
            this.列NAME.Name = "列NAME";
            this.列NAME.Visible = true;
            this.列NAME.VisibleIndex = 0;
            this.列NAME.Width = 53;
            // 
            // 列DEFINE_NAME
            // 
            this.列DEFINE_NAME.Caption = "任务";
            this.列DEFINE_NAME.FieldName = "DEFINE_NAME";
            this.列DEFINE_NAME.Name = "列DEFINE_NAME";
            this.列DEFINE_NAME.Visible = true;
            this.列DEFINE_NAME.VisibleIndex = 1;
            this.列DEFINE_NAME.Width = 54;
            // 
            // 列WEIGHT
            // 
            this.列WEIGHT.Caption = "占比";
            this.列WEIGHT.FieldName = "WEIGHT";
            this.列WEIGHT.Name = "列WEIGHT";
            this.列WEIGHT.Visible = true;
            this.列WEIGHT.VisibleIndex = 2;
            this.列WEIGHT.Width = 54;
            // 
            // 列TARGET
            // 
            this.列TARGET.Caption = "任务额度";
            this.列TARGET.FieldName = "TARGET";
            this.列TARGET.Name = "列TARGET";
            this.列TARGET.Visible = true;
            this.列TARGET.VisibleIndex = 3;
            this.列TARGET.Width = 54;
            // 
            // 列COMPLETED
            // 
            this.列COMPLETED.Caption = "完成额度";
            this.列COMPLETED.FieldName = "COMPLETED";
            this.列COMPLETED.Name = "列COMPLETED";
            this.列COMPLETED.Visible = true;
            this.列COMPLETED.VisibleIndex = 4;
            this.列COMPLETED.Width = 54;
            // 
            // 列UNIT_NAME
            // 
            this.列UNIT_NAME.Caption = "单位";
            this.列UNIT_NAME.FieldName = "UNIT_NAME";
            this.列UNIT_NAME.Name = "列UNIT_NAME";
            this.列UNIT_NAME.Visible = true;
            this.列UNIT_NAME.VisibleIndex = 5;
            this.列UNIT_NAME.Width = 54;
            // 
            // vpositiontreeautoassignmentBindingSource
            // 
            this.vpositiontreeautoassignmentBindingSource.DataMember = "v_position_tree_auto_assignment";
            this.vpositiontreeautoassignmentBindingSource.DataSource = this.dataSetSalary;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(20, 20);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Customer.png");
            this.imageCollection1.Images.SetKeyName(1, "User.png");
            // 
            // v_position_tree_auto_assignmentTableAdapter
            // 
            this.v_position_tree_auto_assignmentTableAdapter.ClearBeforeFill = true;
            // 
            // AssignmentTreeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AssignmentTreeControl";
            this.Size = new System.Drawing.Size(719, 578);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpositiontreeautoassignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列DEFINE_NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列WEIGHT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列TARGET;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列COMPLETED;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列UNIT_NAME;
        private System.Windows.Forms.BindingSource vpositiontreeautoassignmentBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private Data.DataSetSalaryTableAdapters.v_position_tree_auto_assignmentTableAdapter v_position_tree_auto_assignmentTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列ICON;
    }
}
