namespace salary.main.position
{
    partial class PostManagerControl
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("服务主管");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.tabPageLevel = new System.Windows.Forms.TabPage();
            this.tabPageAppraisal = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "服务主管";
            treeNode1.Text = "服务主管";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(205, 516);
            this.treeView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEmployee);
            this.tabControl1.Controls.Add(this.tabPageAppraisal);
            this.tabControl1.Controls.Add(this.tabPageLevel);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(205, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 516);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(617, 490);
            this.tabPageEmployee.TabIndex = 0;
            this.tabPageEmployee.Text = "员工";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // tabPageLevel
            // 
            this.tabPageLevel.Location = new System.Drawing.Point(4, 22);
            this.tabPageLevel.Name = "tabPageLevel";
            this.tabPageLevel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLevel.Size = new System.Drawing.Size(617, 490);
            this.tabPageLevel.TabIndex = 1;
            this.tabPageLevel.Text = "岗位薪资级别定义";
            this.tabPageLevel.UseVisualStyleBackColor = true;
            // 
            // tabPageAppraisal
            // 
            this.tabPageAppraisal.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppraisal.Name = "tabPageAppraisal";
            this.tabPageAppraisal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppraisal.Size = new System.Drawing.Size(617, 490);
            this.tabPageAppraisal.TabIndex = 2;
            this.tabPageAppraisal.Text = "考核指标";
            this.tabPageAppraisal.ToolTipText = "考核指标";
            this.tabPageAppraisal.UseVisualStyleBackColor = true;
            // 
            // PostManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Name = "PostManagerControl";
            this.Size = new System.Drawing.Size(830, 516);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.TabPage tabPageLevel;
        private System.Windows.Forms.TabPage tabPageAppraisal;
    }
}
