namespace SalarySystem.Managment.Assignment
{
    partial class TeamAssignmentControl
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.列NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列DEFINE_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列WEIGHT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.列FIT_POSITION_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.列DEFINE_DESC = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列DEFINE_UNIT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列DEFINE_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列DEFINE_TYPE = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列USED = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.vteamassignmentdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.v_team_assignment_detailTableAdapter = new SalarySystem.Data.DataSetSalaryTableAdapters.v_team_assignment_detailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vteamassignmentdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 466);
            this.panelControl1.Size = new System.Drawing.Size(818, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(2631, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(2550, 9);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.treeList1);
            this.panelControl2.Size = new System.Drawing.Size(818, 466);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.列NAME,
            this.列DEFINE_NAME,
            this.列WEIGHT,
            this.列FIT_POSITION_ID,
            this.列DEFINE_DESC,
            this.列DEFINE_UNIT,
            this.列DEFINE_ID,
            this.列DEFINE_TYPE,
            this.列USED});
            this.treeList1.DataSource = this.vteamassignmentdetailBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(2, 2);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowCheckBoxes = true;
            this.treeList1.OptionsView.ShowRowFooterSummary = true;
            this.treeList1.ParentFieldName = "LEADER_ID";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemLookUpEdit1});
            this.treeList1.RootValue = "";
            this.treeList1.Size = new System.Drawing.Size(814, 462);
            this.treeList1.TabIndex = 0;
            // 
            // 列NAME
            // 
            this.列NAME.Caption = "岗位名称";
            this.列NAME.FieldName = "NAME";
            this.列NAME.Name = "列NAME";
            this.列NAME.OptionsColumn.AllowEdit = false;
            this.列NAME.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列NAME.OptionsColumn.ShowInCustomizationForm = false;
            this.列NAME.Visible = true;
            this.列NAME.VisibleIndex = 0;
            this.列NAME.Width = 137;
            // 
            // 列DEFINE_NAME
            // 
            this.列DEFINE_NAME.Caption = "任务名称";
            this.列DEFINE_NAME.FieldName = "DEFINE_NAME";
            this.列DEFINE_NAME.Name = "列DEFINE_NAME";
            this.列DEFINE_NAME.OptionsColumn.AllowEdit = false;
            this.列DEFINE_NAME.OptionsColumn.ShowInCustomizationForm = false;
            this.列DEFINE_NAME.Visible = true;
            this.列DEFINE_NAME.VisibleIndex = 1;
            this.列DEFINE_NAME.Width = 136;
            // 
            // 列WEIGHT
            // 
            this.列WEIGHT.Caption = "占比";
            this.列WEIGHT.ColumnEdit = this.repositoryItemSpinEdit1;
            this.列WEIGHT.FieldName = "WEIGHT";
            this.列WEIGHT.Name = "列WEIGHT";
            this.列WEIGHT.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列WEIGHT.OptionsColumn.ShowInCustomizationForm = false;
            this.列WEIGHT.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum;
            this.列WEIGHT.RowFooterSummaryStrFormat = "{0:p}";
            this.列WEIGHT.Visible = true;
            this.列WEIGHT.VisibleIndex = 2;
            this.列WEIGHT.Width = 135;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.DisplayFormat.FormatString = "p";
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // 列FIT_POSITION_ID
            // 
            this.列FIT_POSITION_ID.Caption = "适用岗位";
            this.列FIT_POSITION_ID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.列FIT_POSITION_ID.FieldName = "FIT_POSITION_ID";
            this.列FIT_POSITION_ID.Name = "列FIT_POSITION_ID";
            this.列FIT_POSITION_ID.OptionsColumn.AllowEdit = false;
            this.列FIT_POSITION_ID.Visible = true;
            this.列FIT_POSITION_ID.VisibleIndex = 3;
            this.列FIT_POSITION_ID.Width = 136;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "名称1")});
            this.repositoryItemLookUpEdit1.DisplayMember = "NAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // 列DEFINE_DESC
            // 
            this.列DEFINE_DESC.Caption = "任务说明";
            this.列DEFINE_DESC.FieldName = "DEFINE_DESC";
            this.列DEFINE_DESC.Name = "列DEFINE_DESC";
            this.列DEFINE_DESC.OptionsColumn.AllowEdit = false;
            this.列DEFINE_DESC.Visible = true;
            this.列DEFINE_DESC.VisibleIndex = 4;
            // 
            // 列DEFINE_UNIT
            // 
            this.列DEFINE_UNIT.Caption = "任务单位";
            this.列DEFINE_UNIT.FieldName = "DEFINE_UNIT";
            this.列DEFINE_UNIT.Name = "列DEFINE_UNIT";
            // 
            // 列DEFINE_ID
            // 
            this.列DEFINE_ID.FieldName = "DEFINE_ID";
            this.列DEFINE_ID.Name = "列DEFINE_ID";
            // 
            // 列DEFINE_TYPE
            // 
            this.列DEFINE_TYPE.FieldName = "DEFINE_TYPE";
            this.列DEFINE_TYPE.Name = "列DEFINE_TYPE";
            // 
            // 列USED
            // 
            this.列USED.Caption = "启用";
            this.列USED.FieldName = "USED";
            this.列USED.Name = "列USED";
            this.列USED.Width = 135;
            // 
            // vteamassignmentdetailBindingSource
            // 
            this.vteamassignmentdetailBindingSource.DataMember = "v_team_assignment_detail";
            this.vteamassignmentdetailBindingSource.DataSource = this.dataSetSalary;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_team_assignment_detailTableAdapter
            // 
            this.v_team_assignment_detailTableAdapter.ClearBeforeFill = true;
            // 
            // TeamAssignmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TeamAssignmentControl";
            this.Size = new System.Drawing.Size(818, 506);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vteamassignmentdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列DEFINE_NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列DEFINE_TYPE;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列DEFINE_UNIT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列FIT_POSITION_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列DEFINE_ID;
        private System.Windows.Forms.BindingSource vteamassignmentdetailBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private Data.DataSetSalaryTableAdapters.v_team_assignment_detailTableAdapter v_team_assignment_detailTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列USED;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列WEIGHT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列DEFINE_DESC;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}
