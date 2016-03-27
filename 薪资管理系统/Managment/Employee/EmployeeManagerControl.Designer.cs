using DevExpress.XtraEditors;

namespace SalarySystem.Management.Employee
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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLeave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumnName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnPosition = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnEntryTime = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnSalaryLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLeave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 579);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 51);
            this.panel1.TabIndex = 1;
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(122, 13);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(87, 27);
            this.btnLeave.TabIndex = 1;
            this.btnLeave.Text = "离职";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 27);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumnName,
            this.treeListColumnPosition,
            this.treeListColumnEntryTime,
            this.treeListColumnSalaryLevel});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "Id";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.ParentFieldName = "LeaderId";
            this.treeList1.RootValue = "";
            this.treeList1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow;
            this.treeList1.Size = new System.Drawing.Size(779, 579);
            this.treeList1.TabIndex = 3;
            // 
            // treeListColumnName
            // 
            this.treeListColumnName.Caption = "姓名";
            this.treeListColumnName.FieldName = "Name";
            this.treeListColumnName.Name = "treeListColumnName";
            this.treeListColumnName.Visible = true;
            this.treeListColumnName.VisibleIndex = 0;
            // 
            // treeListColumnPosition
            // 
            this.treeListColumnPosition.Caption = "岗位";
            this.treeListColumnPosition.FieldName = "Position";
            this.treeListColumnPosition.Name = "treeListColumnPosition";
            this.treeListColumnPosition.Visible = true;
            this.treeListColumnPosition.VisibleIndex = 1;
            // 
            // treeListColumnEntryTime
            // 
            this.treeListColumnEntryTime.Caption = "入职时间";
            this.treeListColumnEntryTime.FieldName = "EntryTime";
            this.treeListColumnEntryTime.Format.FormatString = "yyyy年MM月dd日";
            this.treeListColumnEntryTime.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.treeListColumnEntryTime.Name = "treeListColumnEntryTime";
            this.treeListColumnEntryTime.Visible = true;
            this.treeListColumnEntryTime.VisibleIndex = 2;
            // 
            // treeListColumnSalaryLevel
            // 
            this.treeListColumnSalaryLevel.Caption = "工资级别";
            this.treeListColumnSalaryLevel.FieldName = "SalaryLevel";
            this.treeListColumnSalaryLevel.Name = "treeListColumnSalaryLevel";
            this.treeListColumnSalaryLevel.Visible = true;
            this.treeListColumnSalaryLevel.VisibleIndex = 3;
            // 
            // EmployeeManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeManagerControl";
            this.Size = new System.Drawing.Size(779, 630);
            this.Load += new System.EventHandler(this.EmployeeManagerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton btnLeave;
        private SimpleButton btnAdd;
        private PanelControl panel1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnPosition;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnEntryTime;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnSalaryLevel;

    }
}
