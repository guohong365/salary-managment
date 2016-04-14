namespace SalarySystem.Schedule
{
    partial class AssignmentScheduleControl
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
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditYear = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControlScheduleItems = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlScheduleItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 512);
            this.panelControl1.Size = new System.Drawing.Size(604, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(432, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(351, 9);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.xtraTabControlScheduleItems);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Size = new System.Drawing.Size(604, 512);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.textEditYear);
            this.panelControl3.Controls.Add(this.simpleButton1);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(600, 51);
            this.panelControl3.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(186, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(12, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "年";
            // 
            // textEditYear
            // 
            this.textEditYear.Location = new System.Drawing.Point(80, 16);
            this.textEditYear.Name = "textEditYear";
            this.textEditYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditYear.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditYear.Properties.Mask.EditMask = "0000";
            this.textEditYear.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditYear.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditYear.Size = new System.Drawing.Size(100, 21);
            this.textEditYear.TabIndex = 0;
            this.textEditYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onYearEditEnterKeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(227, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "加载";
            this.simpleButton1.Click += new System.EventHandler(this.onLoadData);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "计划年度：";
            // 
            // xtraTabControlScheduleItems
            // 
            this.xtraTabControlScheduleItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlScheduleItems.Location = new System.Drawing.Point(2, 53);
            this.xtraTabControlScheduleItems.Margin = new System.Windows.Forms.Padding(0);
            this.xtraTabControlScheduleItems.Name = "xtraTabControlScheduleItems";
            this.xtraTabControlScheduleItems.Size = new System.Drawing.Size(600, 457);
            this.xtraTabControlScheduleItems.TabIndex = 0;
            // 
            // AssignmentScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AssignmentScheduleControl";
            this.Size = new System.Drawing.Size(604, 552);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlScheduleItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlScheduleItems;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditYear;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
