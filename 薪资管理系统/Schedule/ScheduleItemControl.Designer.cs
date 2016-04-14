namespace SalarySystem.Schedule
{
    partial class ScheduleItemControl
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
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.annualScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rowYear = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowId = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowAnnualValue = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMonthValues = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.annualScheduleItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vGridControl2 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.rowDispalyText = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMonth = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowValue = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualScheduleItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vGridControl1
            // 
            this.vGridControl1.DataSource = this.annualScheduleBindingSource;
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(0, 0);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 138;
            this.vGridControl1.RowHeaderWidth = 62;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowYear,
            this.rowId,
            this.rowName,
            this.rowAnnualValue,
            this.rowMonthValues});
            this.vGridControl1.Size = new System.Drawing.Size(614, 112);
            this.vGridControl1.TabIndex = 0;
            // 
            // annualScheduleBindingSource
            // 
            this.annualScheduleBindingSource.DataSource = typeof(SalarySystem.Schedule.AnnualSchedule);
            // 
            // rowYear
            // 
            this.rowYear.Name = "rowYear";
            this.rowYear.Properties.Caption = "年度";
            this.rowYear.Properties.FieldName = "Year";
            // 
            // rowId
            // 
            this.rowId.Name = "rowId";
            this.rowId.Properties.Caption = "任务编号";
            this.rowId.Properties.FieldName = "Id";
            // 
            // rowName
            // 
            this.rowName.Name = "rowName";
            this.rowName.Properties.Caption = "任务名称";
            this.rowName.Properties.FieldName = "Name";
            // 
            // rowAnnualValue
            // 
            this.rowAnnualValue.Name = "rowAnnualValue";
            this.rowAnnualValue.Properties.Caption = "任务额度";
            this.rowAnnualValue.Properties.FieldName = "AnnualValue";
            // 
            // rowMonthValues
            // 
            this.rowMonthValues.Name = "rowMonthValues";
            this.rowMonthValues.Properties.Caption = "Month Values";
            this.rowMonthValues.Properties.FieldName = "MonthValues";
            this.rowMonthValues.Properties.ReadOnly = true;
            // 
            // annualScheduleItemBindingSource
            // 
            this.annualScheduleItemBindingSource.DataSource = typeof(SalarySystem.Schedule.AnnualScheduleItem);
            // 
            // vGridControl2
            // 
            this.vGridControl2.DataSource = this.annualScheduleItemBindingSource;
            this.vGridControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.vGridControl2.Location = new System.Drawing.Point(0, 112);
            this.vGridControl2.Name = "vGridControl2";
            this.vGridControl2.OptionsView.FixRowHeaderPanelWidth = true;
            this.vGridControl2.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowDispalyText,
            this.rowMonth,
            this.rowRate,
            this.rowValue});
            this.vGridControl2.Size = new System.Drawing.Size(614, 98);
            this.vGridControl2.TabIndex = 2;
            // 
            // rowDispalyText
            // 
            this.rowDispalyText.Name = "rowDispalyText";
            this.rowDispalyText.Properties.Caption = "月份名称";
            this.rowDispalyText.Properties.FieldName = "DispalyText";
            // 
            // rowMonth
            // 
            this.rowMonth.Name = "rowMonth";
            this.rowMonth.Properties.Caption = "月份";
            this.rowMonth.Properties.FieldName = "Month";
            // 
            // rowRate
            // 
            this.rowRate.Name = "rowRate";
            this.rowRate.Properties.Caption = "占比";
            this.rowRate.Properties.FieldName = "Rate";
            // 
            // rowValue
            // 
            this.rowValue.Name = "rowValue";
            this.rowValue.Properties.Caption = "分配值";
            this.rowValue.Properties.FieldName = "Value";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 210);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(614, 40);
            this.panelControl1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(14, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "生成任务";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 250);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(614, 232);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(608, 204);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(608, 204);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // ScheduleItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.vGridControl2);
            this.Controls.Add(this.vGridControl1);
            this.Name = "ScheduleItemControl";
            this.Size = new System.Drawing.Size(614, 482);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualScheduleItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private System.Windows.Forms.BindingSource annualScheduleBindingSource;
        private System.Windows.Forms.BindingSource annualScheduleItemBindingSource;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowYear;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowId;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAnnualValue;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMonthValues;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDispalyText;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMonth;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowValue;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
    }
}
