namespace SalarySystem.Managment.Assignment
{
    partial class PositionAssignmentDefineControl
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
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.tpositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_positionTableAdapter = new SalarySystem.Data.DataSetSalaryTableAdapters.t_positionTableAdapter();
            this.列NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列DESCRIPTION = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列ENABLED = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gridControlDefineDetail = new DevExpress.XtraGrid.GridControl();
            this.gridViewDefineDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDefineDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDefineDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 444);
            this.panelControl1.Size = new System.Drawing.Size(723, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(643, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(562, 9);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.splitContainerControl1);
            this.panelControl2.Size = new System.Drawing.Size(723, 444);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeListPosition);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlDefineDetail);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(719, 440);
            this.splitContainerControl1.SplitterPosition = 223;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeListPosition
            // 
            this.treeListPosition.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.列NAME,
            this.列DESCRIPTION,
            this.列ENABLED});
            this.treeListPosition.DataSource = this.tpositionBindingSource;
            this.treeListPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListPosition.Location = new System.Drawing.Point(0, 0);
            this.treeListPosition.Name = "treeListPosition";
            this.treeListPosition.OptionsBehavior.AutoPopulateColumns = false;
            this.treeListPosition.OptionsBehavior.Editable = false;
            this.treeListPosition.OptionsView.ShowFocusedFrame = false;
            this.treeListPosition.OptionsView.ShowIndicator = false;
            this.treeListPosition.ParentFieldName = "LEADER_ID";
            this.treeListPosition.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor;
            this.treeListPosition.Size = new System.Drawing.Size(223, 440);
            this.treeListPosition.TabIndex = 0;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpositionBindingSource
            // 
            this.tpositionBindingSource.DataMember = "t_position";
            this.tpositionBindingSource.DataSource = this.dataSetSalary;
            // 
            // t_positionTableAdapter
            // 
            this.t_positionTableAdapter.ClearBeforeFill = true;
            // 
            // 列NAME
            // 
            this.列NAME.FieldName = "NAME";
            this.列NAME.Name = "列NAME";
            this.列NAME.OptionsColumn.AllowEdit = false;
            this.列NAME.OptionsColumn.AllowFocus = false;
            this.列NAME.OptionsColumn.AllowMove = false;
            this.列NAME.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列NAME.OptionsColumn.AllowSize = false;
            this.列NAME.OptionsColumn.AllowSort = false;
            this.列NAME.OptionsColumn.FixedWidth = true;
            this.列NAME.OptionsColumn.ReadOnly = true;
            this.列NAME.OptionsColumn.ShowInCustomizationForm = false;
            this.列NAME.Visible = true;
            this.列NAME.VisibleIndex = 0;
            this.列NAME.Width = 51;
            // 
            // 列DESCRIPTION
            // 
            this.列DESCRIPTION.FieldName = "DESCRIPTION";
            this.列DESCRIPTION.Name = "列DESCRIPTION";
            this.列DESCRIPTION.OptionsColumn.ShowInCustomizationForm = false;
            this.列DESCRIPTION.Width = 51;
            // 
            // 列ENABLED
            // 
            this.列ENABLED.FieldName = "ENABLED";
            this.列ENABLED.Name = "列ENABLED";
            this.列ENABLED.OptionsColumn.AllowEdit = false;
            this.列ENABLED.OptionsColumn.AllowFocus = false;
            this.列ENABLED.OptionsColumn.AllowMove = false;
            this.列ENABLED.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.列ENABLED.OptionsColumn.AllowSize = false;
            this.列ENABLED.OptionsColumn.AllowSort = false;
            this.列ENABLED.OptionsColumn.ReadOnly = true;
            this.列ENABLED.OptionsColumn.ShowInCustomizationForm = false;
            this.列ENABLED.Width = 52;
            // 
            // gridControlDefineDetail
            // 
            this.gridControlDefineDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDefineDetail.Location = new System.Drawing.Point(0, 0);
            this.gridControlDefineDetail.MainView = this.gridViewDefineDetail;
            this.gridControlDefineDetail.Name = "gridControlDefineDetail";
            this.gridControlDefineDetail.Size = new System.Drawing.Size(491, 440);
            this.gridControlDefineDetail.TabIndex = 0;
            this.gridControlDefineDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDefineDetail});
            // 
            // gridViewDefineDetail
            // 
            this.gridViewDefineDetail.GridControl = this.gridControlDefineDetail;
            this.gridViewDefineDetail.Name = "gridViewDefineDetail";
            // 
            // PositionAssignmentDefineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PositionAssignmentDefineControl";
            this.Size = new System.Drawing.Size(723, 484);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDefineDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDefineDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList treeListPosition;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列DESCRIPTION;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列ENABLED;
        private System.Windows.Forms.BindingSource tpositionBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private DevExpress.XtraGrid.GridControl gridControlDefineDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDefineDetail;
        private Data.DataSetSalaryTableAdapters.t_positionTableAdapter t_positionTableAdapter;
    }
}
