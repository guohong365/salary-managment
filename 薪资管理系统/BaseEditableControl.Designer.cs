namespace SalarySystem
{
    partial class BaseEditableControl
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonRevert = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonRevert);
            this.panelControl1.Controls.Add(this.simpleButtonSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 420);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(617, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButtonRevert.Enabled = false;
            this.simpleButtonRevert.Location = new System.Drawing.Point(537, 9);
            this.simpleButtonRevert.Name = "simpleButtonRevert";
            this.simpleButtonRevert.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonRevert.TabIndex = 1;
            this.simpleButtonRevert.Text = "放弃";
            this.simpleButtonRevert.Click += new System.EventHandler(this.btn_revertChanges);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButtonSave.Enabled = false;
            this.simpleButtonSave.Location = new System.Drawing.Point(456, 9);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSave.TabIndex = 0;
            this.simpleButtonSave.Text = "保存";
            this.simpleButtonSave.Click += new System.EventHandler(this.btn_SaveModified);
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(617, 420);
            this.panelControl2.TabIndex = 0;
            // 
            // DefineBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "DefineBaseControl";
            this.Size = new System.Drawing.Size(617, 460);
            this.Load += new System.EventHandler(this.onLoad);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.PanelControl panelControl1;
        protected DevExpress.XtraEditors.SimpleButton simpleButtonRevert;
        protected DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        protected DevExpress.XtraEditors.PanelControl panelControl2;

    }
}
