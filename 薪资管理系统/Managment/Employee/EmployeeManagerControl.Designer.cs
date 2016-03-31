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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLeave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEntryTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSeniority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDismissionTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.salaryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btnLeave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 40);
            this.panel1.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(248, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "停用";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(86, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "修改";
            this.simpleButton1.Click += new System.EventHandler(this.modifyEmployee_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(167, 9);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(75, 23);
            this.btnLeave.TabIndex = 1;
            this.btnLeave.Text = "离职";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(5, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridControlEmployee
            // 
            this.gridControlEmployee.DataMember = "t_employee";
            this.gridControlEmployee.DataSource = this.salaryDataSetBindingSource;
            this.gridControlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmployee.Location = new System.Drawing.Point(0, 0);
            this.gridControlEmployee.MainView = this.gridViewEmployee;
            this.gridControlEmployee.Name = "gridControlEmployee";
            this.gridControlEmployee.Size = new System.Drawing.Size(779, 590);
            this.gridControlEmployee.TabIndex = 2;
            this.gridControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmployee});
            // 
            // gridViewEmployee
            // 
            this.gridViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPosition,
            this.gridColumnLeader,
            this.gridColumnId,
            this.gridColumnName,
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
            this.gridColumnPosition.FieldName = "POSITION_ID";
            this.gridColumnPosition.Name = "gridColumnPosition";
            this.gridColumnPosition.Visible = true;
            this.gridColumnPosition.VisibleIndex = 1;
            this.gridColumnPosition.Width = 89;
            // 
            // gridColumnLeader
            // 
            this.gridColumnLeader.Caption = "上级主管";
            this.gridColumnLeader.FieldName = "LEADER_ID";
            this.gridColumnLeader.Name = "gridColumnLeader";
            this.gridColumnLeader.Visible = true;
            this.gridColumnLeader.VisibleIndex = 2;
            this.gridColumnLeader.Width = 89;
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
            // gridColumnEntryTime
            // 
            this.gridColumnEntryTime.Caption = "入职时间";
            this.gridColumnEntryTime.DisplayFormat.FormatString = "yyyy年MM月dd日";
            this.gridColumnEntryTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnEntryTime.FieldName = "ENTRY_TIME";
            this.gridColumnEntryTime.Name = "gridColumnEntryTime";
            this.gridColumnEntryTime.Visible = true;
            this.gridColumnEntryTime.VisibleIndex = 5;
            this.gridColumnEntryTime.Width = 89;
            // 
            // gridColumnSeniority
            // 
            this.gridColumnSeniority.Caption = "工龄";
            this.gridColumnSeniority.Name = "gridColumnSeniority";
            this.gridColumnSeniority.OptionsColumn.ReadOnly = true;
            this.gridColumnSeniority.Visible = true;
            this.gridColumnSeniority.VisibleIndex = 6;
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
            this.gridColumnDismissionTime.VisibleIndex = 7;
            this.gridColumnDismissionTime.Width = 89;
            // 
            // gridColumnDesc
            // 
            this.gridColumnDesc.Caption = "描述";
            this.gridColumnDesc.FieldName = "DESCRIPTION";
            this.gridColumnDesc.Name = "gridColumnDesc";
            this.gridColumnDesc.Visible = true;
            this.gridColumnDesc.VisibleIndex = 8;
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
            // salaryDataSetBindingSource
            // 
            this.salaryDataSetBindingSource.DataSource = typeof(SalarySystem.Data.SalaryDataSet);
            this.salaryDataSetBindingSource.Position = 0;
            // 
            // EmployeeManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlEmployee);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeManagerControl";
            this.Size = new System.Drawing.Size(779, 630);
            this.Load += new System.EventHandler(this.EmployeeManagerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton btnLeave;
        private SimpleButton btnAdd;
        private PanelControl panel1;
        private SimpleButton simpleButton1;
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
        private SimpleButton simpleButton2;
        private System.Windows.Forms.BindingSource salaryDataSetBindingSource;

    }
}
