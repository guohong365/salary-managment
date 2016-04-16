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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControlScheduleItems = new DevExpress.XtraTab.XtraTabControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spinEditMonthFrom = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditMonthTo = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditYear = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlScheduleItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonthFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonthTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 512);
            this.panelControl1.Size = new System.Drawing.Size(604, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(419, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(338, 9);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.xtraTabControlScheduleItems);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Size = new System.Drawing.Size(604, 512);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.spinEditYear);
            this.panelControl3.Controls.Add(this.spinEditMonthTo);
            this.panelControl3.Controls.Add(this.spinEditMonthFrom);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
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
            this.labelControl2.Location = new System.Drawing.Point(152, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(12, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "年";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(397, 14);
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
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(245, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "月 —";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(327, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(12, 14);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "月";
            // 
            // spinEditMonthFrom
            // 
            this.spinEditMonthFrom.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditMonthFrom.Location = new System.Drawing.Point(196, 16);
            this.spinEditMonthFrom.Name = "spinEditMonthFrom";
            this.spinEditMonthFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditMonthFrom.Properties.IsFloatValue = false;
            this.spinEditMonthFrom.Properties.Mask.EditMask = "N00";
            this.spinEditMonthFrom.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.spinEditMonthFrom.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditMonthFrom.Size = new System.Drawing.Size(43, 21);
            this.spinEditMonthFrom.TabIndex = 2;
            // 
            // spinEditMonthTo
            // 
            this.spinEditMonthTo.EditValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.spinEditMonthTo.Location = new System.Drawing.Point(278, 16);
            this.spinEditMonthTo.Name = "spinEditMonthTo";
            this.spinEditMonthTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditMonthTo.Properties.IsFloatValue = false;
            this.spinEditMonthTo.Properties.Mask.EditMask = "N00";
            this.spinEditMonthTo.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.spinEditMonthTo.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditMonthTo.Size = new System.Drawing.Size(43, 21);
            this.spinEditMonthTo.TabIndex = 3;
            // 
            // spinEditYear
            // 
            this.spinEditYear.EditValue = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.spinEditYear.Location = new System.Drawing.Point(80, 16);
            this.spinEditYear.Name = "spinEditYear";
            this.spinEditYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditYear.Properties.IsFloatValue = false;
            this.spinEditYear.Properties.Mask.EditMask = "N0000";
            this.spinEditYear.Properties.MaxLength = 4;
            this.spinEditYear.Properties.MaxValue = new decimal(new int[] {
            2380,
            0,
            0,
            0});
            this.spinEditYear.Properties.MinValue = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.spinEditYear.Size = new System.Drawing.Size(66, 21);
            this.spinEditYear.TabIndex = 0;
            this.spinEditYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onYearEditEnterKeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlScheduleItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonthFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonthTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlScheduleItems;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit spinEditYear;
        private DevExpress.XtraEditors.SpinEdit spinEditMonthTo;
        private DevExpress.XtraEditors.SpinEdit spinEditMonthFrom;
    }
}
