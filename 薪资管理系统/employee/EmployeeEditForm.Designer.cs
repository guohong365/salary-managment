using DevExpress.XtraEditors;

namespace salary.main.employee
{
    partial class EmployeeEditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.button2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.employeePropertyControl1 = new salary.main.employee.EmployeePropertyControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 51);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(196, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(68, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // employeePropertyControl1
            // 
            this.employeePropertyControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeePropertyControl1.Location = new System.Drawing.Point(0, 0);
            this.employeePropertyControl1.Name = "employeePropertyControl1";
            this.employeePropertyControl1.Purpose = salary.utilities.EditPurpose.FOR_NEW;
            this.employeePropertyControl1.Size = new System.Drawing.Size(350, 254);
            this.employeePropertyControl1.TabIndex = 1;
            // 
            // EmployeeEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(350, 305);
            this.Controls.Add(this.employeePropertyControl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeEditForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "员工录入";
            this.Load += new System.EventHandler(this.EmployeeEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PanelControl panel1;
        private SimpleButton button2;
        private SimpleButton btnSave;
        private EmployeePropertyControl employeePropertyControl1;
    }
}