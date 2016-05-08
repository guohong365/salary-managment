namespace SalarySystem.Schedule
{
    partial class PersonalAssignmentScheduleControl
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
            this.simpleButtonLoad = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spinEditMonthTo = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditMonthFrom = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spinEditYear = new DevExpress.XtraEditors.SpinEdit();
            this.xtraTabControlAssignments = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).BeginInit();
            this.panelControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonthTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonthFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControlButtons.Location = new System.Drawing.Point(0, 498);
            this.panelControlButtons.Size = new System.Drawing.Size(689, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(601, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(520, 9);
            // 
            // panelControl2
            // 
            this.panelControlMain.Controls.Add(this.xtraTabControlAssignments);
            this.panelControlMain.Controls.Add(this.panelControl3);
            this.panelControlMain.Size = new System.Drawing.Size(689, 498);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.simpleButtonLoad);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.spinEditMonthTo);
            this.panelControl3.Controls.Add(this.spinEditMonthFrom);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.spinEditYear);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(685, 40);
            this.panelControl3.TabIndex = 0;
            // 
            // simpleButtonLoad
            // 
            this.simpleButtonLoad.Location = new System.Drawing.Point(542, 9);
            this.simpleButtonLoad.Name = "simpleButtonLoad";
            this.simpleButtonLoad.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonLoad.TabIndex = 3;
            this.simpleButtonLoad.Text = "加载";
            this.simpleButtonLoad.Click += new System.EventHandler(this.loadSchedule);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(479, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(12, 14);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "月";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(366, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "月 — ";
            // 
            // spinEditMonthTo
            // 
            this.spinEditMonthTo.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditMonthTo.Location = new System.Drawing.Point(403, 10);
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
            this.spinEditMonthTo.Size = new System.Drawing.Size(70, 21);
            this.spinEditMonthTo.TabIndex = 2;
            // 
            // spinEditMonthFrom
            // 
            this.spinEditMonthFrom.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditMonthFrom.Location = new System.Drawing.Point(290, 10);
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
            this.spinEditMonthFrom.Size = new System.Drawing.Size(70, 21);
            this.spinEditMonthFrom.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(224, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "计划月份：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(171, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(12, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "年";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "计划年度：";
            // 
            // spinEditYear
            // 
            this.spinEditYear.EditValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.spinEditYear.Location = new System.Drawing.Point(79, 10);
            this.spinEditYear.Name = "spinEditYear";
            this.spinEditYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditYear.Properties.IsFloatValue = false;
            this.spinEditYear.Properties.Mask.EditMask = "N0000";
            this.spinEditYear.Properties.MaxValue = new decimal(new int[] {
            2380,
            0,
            0,
            0});
            this.spinEditYear.Properties.MinValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.spinEditYear.Size = new System.Drawing.Size(86, 21);
            this.spinEditYear.TabIndex = 0;
            // 
            // xtraTabControlAssignments
            // 
            this.xtraTabControlAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlAssignments.Location = new System.Drawing.Point(2, 42);
            this.xtraTabControlAssignments.Name = "xtraTabControlAssignments";
            this.xtraTabControlAssignments.Size = new System.Drawing.Size(685, 454);
            this.xtraTabControlAssignments.TabIndex = 1;
            // 
            // PersonalAssignmentScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PersonalAssignmentScheduleControl";
            this.Size = new System.Drawing.Size(689, 538);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).EndInit();
            this.panelControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonthTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonthFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLoad;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit spinEditMonthTo;
        private DevExpress.XtraEditors.SpinEdit spinEditMonthFrom;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spinEditYear;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlAssignments;
    }
}
