using DevExpress.XtraEditors;

namespace SalarySystem.Managment.Employee
{
    partial class EmployeeManagerControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControlEmployee = new DevExpress.XtraGrid.GridControl();
            this.temployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.gridViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnLeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditLeader = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGENDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEntryTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditEntryTime = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumnSeniority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDismissionTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditLeaveTime = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.t_employeeTableAdapter = new SalarySystem.Data.DataSetSalaryTableAdapters.t_employeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).BeginInit();
            this.panelControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditEntryTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditEntryTime.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditLeaveTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditLeaveTime.VistaTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControlButtons.Location = new System.Drawing.Point(0, 595);
            this.panelControlButtons.Size = new System.Drawing.Size(779, 35);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(699, 6);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(618, 6);
            // 
            // panelControl2
            // 
            this.panelControlMain.Controls.Add(this.gridControlEmployee);
            this.panelControlMain.Size = new System.Drawing.Size(779, 595);
            // 
            // gridControlEmployee
            // 
            this.gridControlEmployee.DataSource = this.temployeeBindingSource;
            this.gridControlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmployee.Location = new System.Drawing.Point(2, 2);
            this.gridControlEmployee.MainView = this.gridViewEmployee;
            this.gridControlEmployee.Name = "gridControlEmployee";
            this.gridControlEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditPosition,
            this.repositoryItemLookUpEditLeader,
            this.repositoryItemDateEditEntryTime,
            this.repositoryItemDateEditLeaveTime});
            this.gridControlEmployee.Size = new System.Drawing.Size(775, 591);
            this.gridControlEmployee.TabIndex = 2;
            this.gridControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmployee});
            // 
            // temployeeBindingSource
            // 
            this.temployeeBindingSource.DataMember = "t_employee";
            this.temployeeBindingSource.DataSource = this.dataSetSalary;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewEmployee
            // 
            this.gridViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPosition,
            this.gridColumnLeader,
            this.gridColumnId,
            this.gridColumnName,
            this.colGENDER,
            this.gridColumnEntryTime,
            this.gridColumnSeniority,
            this.gridColumnDismissionTime,
            this.gridColumnDesc,
            this.gridColumnEnabled});
            this.gridViewEmployee.GridControl = this.gridControlEmployee;
            this.gridViewEmployee.Name = "gridViewEmployee";
            // 
            // gridColumnPosition
            // 
            this.gridColumnPosition.Caption = "岗位";
            this.gridColumnPosition.ColumnEdit = this.repositoryItemLookUpEditPosition;
            this.gridColumnPosition.FieldName = "POSITION_ID";
            this.gridColumnPosition.Name = "gridColumnPosition";
            this.gridColumnPosition.Visible = true;
            this.gridColumnPosition.VisibleIndex = 1;
            this.gridColumnPosition.Width = 89;
            // 
            // repositoryItemLookUpEditPosition
            // 
            this.repositoryItemLookUpEditPosition.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemLookUpEditPosition.AutoHeight = false;
            this.repositoryItemLookUpEditPosition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPosition.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "岗位名称")});
            this.repositoryItemLookUpEditPosition.DisplayMember = "NAME";
            this.repositoryItemLookUpEditPosition.Name = "repositoryItemLookUpEditPosition";
            this.repositoryItemLookUpEditPosition.NullText = "";
            this.repositoryItemLookUpEditPosition.ValueMember = "ID";
            // 
            // gridColumnLeader
            // 
            this.gridColumnLeader.Caption = "上级主管";
            this.gridColumnLeader.ColumnEdit = this.repositoryItemLookUpEditLeader;
            this.gridColumnLeader.FieldName = "LEADER_ID";
            this.gridColumnLeader.Name = "gridColumnLeader";
            this.gridColumnLeader.Visible = true;
            this.gridColumnLeader.VisibleIndex = 2;
            this.gridColumnLeader.Width = 89;
            // 
            // repositoryItemLookUpEditLeader
            // 
            this.repositoryItemLookUpEditLeader.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemLookUpEditLeader.AutoHeight = false;
            this.repositoryItemLookUpEditLeader.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditLeader.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "主管")});
            this.repositoryItemLookUpEditLeader.DisplayMember = "NAME";
            this.repositoryItemLookUpEditLeader.Name = "repositoryItemLookUpEditLeader";
            this.repositoryItemLookUpEditLeader.NullText = "无";
            this.repositoryItemLookUpEditLeader.ValueMember = "ID";
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "员工编号";
            this.gridColumnId.FieldName = "ID";
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Visible = true;
            this.gridColumnId.VisibleIndex = 3;
            this.gridColumnId.Width = 89;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "姓名";
            this.gridColumnName.FieldName = "NAME";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 4;
            this.gridColumnName.Width = 89;
            // 
            // colGENDER
            // 
            this.colGENDER.Caption = "性别";
            this.colGENDER.FieldName = "GENDER";
            this.colGENDER.Name = "colGENDER";
            this.colGENDER.Visible = true;
            this.colGENDER.VisibleIndex = 5;
            // 
            // gridColumnEntryTime
            // 
            this.gridColumnEntryTime.Caption = "入职时间";
            this.gridColumnEntryTime.ColumnEdit = this.repositoryItemDateEditEntryTime;
            this.gridColumnEntryTime.DisplayFormat.FormatString = "yyyy年MM月dd日";
            this.gridColumnEntryTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnEntryTime.FieldName = "ENTRY_TIME";
            this.gridColumnEntryTime.Name = "gridColumnEntryTime";
            this.gridColumnEntryTime.Visible = true;
            this.gridColumnEntryTime.VisibleIndex = 6;
            this.gridColumnEntryTime.Width = 89;
            // 
            // repositoryItemDateEditEntryTime
            // 
            this.repositoryItemDateEditEntryTime.AutoHeight = false;
            this.repositoryItemDateEditEntryTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditEntryTime.Name = "repositoryItemDateEditEntryTime";
            this.repositoryItemDateEditEntryTime.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridColumnSeniority
            // 
            this.gridColumnSeniority.Caption = "工龄";
            this.gridColumnSeniority.FieldName = "gridColumnSeniority";
            this.gridColumnSeniority.Name = "gridColumnSeniority";
            this.gridColumnSeniority.OptionsColumn.ReadOnly = true;
            this.gridColumnSeniority.UnboundExpression = "DateDiffYear([ENTRY_TIME],Today())";
            this.gridColumnSeniority.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumnSeniority.Visible = true;
            this.gridColumnSeniority.VisibleIndex = 7;
            this.gridColumnSeniority.Width = 89;
            // 
            // gridColumnDismissionTime
            // 
            this.gridColumnDismissionTime.Caption = "离职时间";
            this.gridColumnDismissionTime.DisplayFormat.FormatString = "yyyy年MM月dd日";
            this.gridColumnDismissionTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDismissionTime.FieldName = "DISMISSION_TIME";
            this.gridColumnDismissionTime.Name = "gridColumnDismissionTime";
            this.gridColumnDismissionTime.Visible = true;
            this.gridColumnDismissionTime.VisibleIndex = 8;
            this.gridColumnDismissionTime.Width = 89;
            // 
            // gridColumnDesc
            // 
            this.gridColumnDesc.Caption = "描述";
            this.gridColumnDesc.FieldName = "DESCRIPTION";
            this.gridColumnDesc.Name = "gridColumnDesc";
            this.gridColumnDesc.Visible = true;
            this.gridColumnDesc.VisibleIndex = 9;
            this.gridColumnDesc.Width = 95;
            // 
            // gridColumnEnabled
            // 
            this.gridColumnEnabled.Caption = "有效";
            this.gridColumnEnabled.FieldName = "ENABLED";
            this.gridColumnEnabled.Name = "gridColumnEnabled";
            this.gridColumnEnabled.Visible = true;
            this.gridColumnEnabled.VisibleIndex = 0;
            this.gridColumnEnabled.Width = 43;
            // 
            // repositoryItemDateEditLeaveTime
            // 
            this.repositoryItemDateEditLeaveTime.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemDateEditLeaveTime.AutoHeight = false;
            this.repositoryItemDateEditLeaveTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditLeaveTime.Name = "repositoryItemDateEditLeaveTime";
            this.repositoryItemDateEditLeaveTime.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // t_employeeTableAdapter
            // 
            this.t_employeeTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "EmployeeManagerControl";
            this.Size = new System.Drawing.Size(779, 630);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).EndInit();
            this.panelControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditEntryTime.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditEntryTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditLeaveTime.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditLeaveTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPosition;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLeader;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDesc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDismissionTime;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEntryTime;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSeniority;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPosition;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditLeader;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditEntryTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditLeaveTime;
        private System.Windows.Forms.BindingSource temployeeBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colGENDER;
        private Data.DataSetSalaryTableAdapters.t_employeeTableAdapter t_employeeTableAdapter;

    }
}
