namespace SalarySystem.Managment.Position
{
    partial class EmployeeListControl
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.salaryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntryTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDimissionTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemLookUpEditPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEditLeader = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.temployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton4);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 556);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(686, 40);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(248, 8);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "禁用";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(167, 8);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "待岗";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(86, 10);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "修改";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "添加";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "t_employee";
            this.gridControl1.DataSource = this.salaryDataSetBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditPosition,
            this.repositoryItemLookUpEditLeader});
            this.gridControl1.Size = new System.Drawing.Size(686, 556);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // salaryDataSetBindingSource
            // 
            this.salaryDataSetBindingSource.DataSource = typeof(SalarySystem.Data.SalaryDataSet);
            this.salaryDataSetBindingSource.Position = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEnabled,
            this.colId,
            this.colName,
            this.colPosition,
            this.colLeader,
            this.colEntryTime,
            this.colDimissionTime,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colEnabled
            // 
            this.colEnabled.Caption = "有效";
            this.colEnabled.FieldName = "ENABLED";
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.Visible = true;
            this.colEnabled.VisibleIndex = 0;
            this.colEnabled.Width = 38;
            // 
            // colId
            // 
            this.colId.Caption = "员工编号";
            this.colId.FieldName = "ID";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 78;
            // 
            // colName
            // 
            this.colName.Caption = "姓名";
            this.colName.FieldName = "NAME";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 78;
            // 
            // colPosition
            // 
            this.colPosition.Caption = "岗位";
            this.colPosition.FieldName = "POSITION_ID";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 3;
            // 
            // colLeader
            // 
            this.colLeader.Caption = "主管";
            this.colLeader.FieldName = "LEADER_ID";
            this.colLeader.Name = "colLeader";
            this.colLeader.Visible = true;
            this.colLeader.VisibleIndex = 3;
            this.colLeader.Width = 78;
            // 
            // colEntryTime
            // 
            this.colEntryTime.Caption = "入职时间";
            this.colEntryTime.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colEntryTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEntryTime.FieldName = "ENTRY_TIME";
            this.colEntryTime.Name = "colEntryTime";
            this.colEntryTime.Visible = true;
            this.colEntryTime.VisibleIndex = 4;
            this.colEntryTime.Width = 78;
            // 
            // colDimissionTime
            // 
            this.colDimissionTime.Caption = "离职时间";
            this.colDimissionTime.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colDimissionTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDimissionTime.FieldName = "DISMISSION_TIME";
            this.colDimissionTime.Name = "colDimissionTime";
            this.colDimissionTime.Visible = true;
            this.colDimissionTime.VisibleIndex = 5;
            this.colDimissionTime.Width = 78;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "备注";
            this.colDescription.FieldName = "DESCRIPTION";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 84;
            // 
            // tpositionBindingSource
            // 
            this.tpositionBindingSource.DataMember = "t_position";
            this.tpositionBindingSource.DataSource = this.salaryDataSetBindingSource;
            // 
            // repositoryItemLookUpEditPosition
            // 
            this.repositoryItemLookUpEditPosition.AutoHeight = false;
            this.repositoryItemLookUpEditPosition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPosition.DataSource = this.tpositionBindingSource;
            this.repositoryItemLookUpEditPosition.DisplayMember = "NAME";
            this.repositoryItemLookUpEditPosition.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.repositoryItemLookUpEditPosition.Name = "repositoryItemLookUpEditPosition";
            this.repositoryItemLookUpEditPosition.ValueMember = "ID";
            // 
            // repositoryItemLookUpEditLeader
            // 
            this.repositoryItemLookUpEditLeader.AutoHeight = false;
            this.repositoryItemLookUpEditLeader.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditLeader.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "员工编号", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("POSITION_ID", "POSITION_ID", 85, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "员工姓名", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPTION", "备注", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ENABLED", "ENABLED", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditLeader.DataSource = this.temployeeBindingSource;
            this.repositoryItemLookUpEditLeader.DisplayMember = "NAME";
            this.repositoryItemLookUpEditLeader.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.repositoryItemLookUpEditLeader.Name = "repositoryItemLookUpEditLeader";
            this.repositoryItemLookUpEditLeader.ValueMember = "ID";
            // 
            // temployeeBindingSource
            // 
            this.temployeeBindingSource.DataMember = "t_employee";
            this.temployeeBindingSource.DataSource = this.salaryDataSetBindingSource;
            // 
            // EmployeeListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "EmployeeListControl";
            this.Size = new System.Drawing.Size(686, 596);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLeader;
        private DevExpress.XtraGrid.Columns.GridColumn colEntryTime;
        private DevExpress.XtraGrid.Columns.GridColumn colEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn colDimissionTime;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.Windows.Forms.BindingSource salaryDataSetBindingSource;
        private System.Windows.Forms.BindingSource tpositionBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPosition;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditLeader;
        private System.Windows.Forms.BindingSource temployeeBindingSource;
    }
}
