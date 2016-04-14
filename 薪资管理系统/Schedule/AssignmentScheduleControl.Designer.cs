﻿namespace SalarySystem.Schedule
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
            this.components = new System.ComponentModel.Container();
            this.annualScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.annualScheduleItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditYear = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControlScheduleItems = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.annualScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualScheduleItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlScheduleItems)).BeginInit();
            this.xtraTabControlScheduleItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 512);
            this.panelControl1.Size = new System.Drawing.Size(604, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(139, 5);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(58, 5);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.xtraTabControlScheduleItems);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Size = new System.Drawing.Size(604, 512);
            // 
            // annualScheduleBindingSource
            // 
            this.annualScheduleBindingSource.DataSource = typeof(SalarySystem.Schedule.AnnualSchedule);
            // 
            // annualScheduleItemBindingSource
            // 
            this.annualScheduleItemBindingSource.DataSource = typeof(SalarySystem.Schedule.AnnualScheduleItem);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.textEditYear);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(600, 51);
            this.panelControl3.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "计划年度：";
            // 
            // textEditYear
            // 
            this.textEditYear.Location = new System.Drawing.Point(80, 13);
            this.textEditYear.Name = "textEditYear";
            this.textEditYear.Size = new System.Drawing.Size(102, 21);
            this.textEditYear.TabIndex = 1;
            // 
            // xtraTabControlScheduleItems
            // 
            this.xtraTabControlScheduleItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlScheduleItems.Location = new System.Drawing.Point(2, 53);
            this.xtraTabControlScheduleItems.Name = "xtraTabControlScheduleItems";
            this.xtraTabControlScheduleItems.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControlScheduleItems.Size = new System.Drawing.Size(600, 457);
            this.xtraTabControlScheduleItems.TabIndex = 1;
            this.xtraTabControlScheduleItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(594, 429);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(0, 0);
            this.xtraTabPage2.Text = "xtraTabPage2";
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
            ((System.ComponentModel.ISupportInitialize)(this.annualScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualScheduleItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlScheduleItems)).EndInit();
            this.xtraTabControlScheduleItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource annualScheduleItemBindingSource;
        private System.Windows.Forms.BindingSource annualScheduleBindingSource;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlScheduleItems;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit textEditYear;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
