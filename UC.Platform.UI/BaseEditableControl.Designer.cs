namespace UC.Platform.UI
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
      this.panelControlButtons = new DevExpress.XtraEditors.PanelControl();
      this.simpleButtonRevert = new DevExpress.XtraEditors.SimpleButton();
      this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
      this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
      ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).BeginInit();
      this.panelControlButtons.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
      this.SuspendLayout();
      // 
      // panelControlButtons
      // 
      this.panelControlButtons.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
      this.panelControlButtons.Controls.Add(this.simpleButtonRevert);
      this.panelControlButtons.Controls.Add(this.simpleButtonSave);
      this.panelControlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelControlButtons.Location = new System.Drawing.Point(0, 425);
      this.panelControlButtons.Name = "panelControlButtons";
      this.panelControlButtons.Size = new System.Drawing.Size(617, 35);
      this.panelControlButtons.TabIndex = 1;
      this.panelControlButtons.SizeChanged += new System.EventHandler(this.buttonPanelSizeChanged);
      // 
      // simpleButtonRevert
      // 
      this.simpleButtonRevert.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.simpleButtonRevert.Enabled = false;
      this.simpleButtonRevert.Location = new System.Drawing.Point(537, 6);
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
      this.simpleButtonSave.Location = new System.Drawing.Point(456, 6);
      this.simpleButtonSave.Name = "simpleButtonSave";
      this.simpleButtonSave.Size = new System.Drawing.Size(75, 23);
      this.simpleButtonSave.TabIndex = 0;
      this.simpleButtonSave.Text = "保存";
      this.simpleButtonSave.Click += new System.EventHandler(this.btn_SaveModified);
      // 
      // panelControlMain
      // 
      this.panelControlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelControlMain.Location = new System.Drawing.Point(0, 0);
      this.panelControlMain.Margin = new System.Windows.Forms.Padding(0);
      this.panelControlMain.Name = "panelControlMain";
      this.panelControlMain.Size = new System.Drawing.Size(617, 425);
      this.panelControlMain.TabIndex = 0;
      // 
      // BaseEditableControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panelControlMain);
      this.Controls.Add(this.panelControlButtons);
      this.Name = "BaseEditableControl";
      this.Size = new System.Drawing.Size(617, 460);
      this.Load += new System.EventHandler(this.onLoad);
      ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).EndInit();
      this.panelControlButtons.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.PanelControl panelControlButtons;
        protected DevExpress.XtraEditors.SimpleButton simpleButtonRevert;
        protected DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        protected DevExpress.XtraEditors.PanelControl panelControlMain;

    }
}
