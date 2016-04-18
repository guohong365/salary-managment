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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControlUnit = new DevExpress.XtraEditors.LabelControl();
            this.textEditAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.vGridControl2 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.rowMonth = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowValue = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonGen = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage8 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage9 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage10 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage11 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage12 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControlUnit);
            this.panelControl2.Controls.Add(this.textEditAmount);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(614, 54);
            this.panelControl2.TabIndex = 5;
            // 
            // labelControlUnit
            // 
            this.labelControlUnit.Location = new System.Drawing.Point(285, 20);
            this.labelControlUnit.Name = "labelControlUnit";
            this.labelControlUnit.Size = new System.Drawing.Size(24, 14);
            this.labelControlUnit.TabIndex = 2;
            this.labelControlUnit.Text = "万元";
            // 
            // textEditAmount
            // 
            this.textEditAmount.Location = new System.Drawing.Point(109, 17);
            this.textEditAmount.Name = "textEditAmount";
            this.textEditAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditAmount.Size = new System.Drawing.Size(170, 21);
            this.textEditAmount.TabIndex = 1;
            this.textEditAmount.FormatEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.amountEditValueChanged);
            this.textEditAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onAmountKeyDownEnter);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "年度任务额度：";
            // 
            // vGridControl2
            // 
            this.vGridControl2.Appearance.ModifiedRecordValue.BackColor = System.Drawing.Color.Yellow;
            this.vGridControl2.Appearance.ModifiedRecordValue.Options.UseBackColor = true;
            this.vGridControl2.Appearance.ReadOnlyRecordValue.ForeColor = System.Drawing.Color.Black;
            this.vGridControl2.Appearance.ReadOnlyRecordValue.Options.UseForeColor = true;
            this.vGridControl2.Appearance.ReadOnlyRow.ForeColor = System.Drawing.Color.Black;
            this.vGridControl2.Appearance.ReadOnlyRow.Options.UseForeColor = true;
            this.vGridControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.vGridControl2.Location = new System.Drawing.Point(0, 54);
            this.vGridControl2.Name = "vGridControl2";
            this.vGridControl2.OptionsBehavior.UseEnterAsTab = true;
            this.vGridControl2.OptionsView.FixRowHeaderPanelWidth = true;
            this.vGridControl2.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowMonth,
            this.rowRate,
            this.rowValue});
            this.vGridControl2.Size = new System.Drawing.Size(614, 80);
            this.vGridControl2.TabIndex = 6;
            this.vGridControl2.CustomDrawRowValueCell += new DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventHandler(this.customDrawRowValueCell);
            this.vGridControl2.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.onScheduleShowingEditor);
            this.vGridControl2.CellValueChanged += new DevExpress.XtraVerticalGrid.Events.CellValueChangedEventHandler(this.onScheduleValueChanged);
            this.vGridControl2.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.onShecduleValidatingEditor);
            this.vGridControl2.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.onInvalidValueException);
            // 
            // rowMonth
            // 
            this.rowMonth.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rowMonth.Appearance.Options.UseBackColor = true;
            this.rowMonth.Appearance.Options.UseTextOptions = true;
            this.rowMonth.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rowMonth.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rowMonth.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.rowMonth.Name = "rowMonth";
            this.rowMonth.OptionsRow.AllowFocus = false;
            this.rowMonth.Properties.Caption = "月份";
            this.rowMonth.Properties.FieldName = "MONTH";
            this.rowMonth.Properties.Format.FormatString = "{0}月";
            this.rowMonth.Properties.Format.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rowMonth.Properties.ReadOnly = true;
            // 
            // rowRate
            // 
            this.rowRate.Height = 17;
            this.rowRate.Name = "rowRate";
            this.rowRate.Properties.Caption = "占比";
            this.rowRate.Properties.FieldName = "RATE";
            this.rowRate.Properties.Format.FormatString = "{0}%";
            this.rowRate.Properties.Format.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // rowValue
            // 
            this.rowValue.Height = 17;
            this.rowValue.Name = "rowValue";
            this.rowValue.Properties.Caption = "分配值";
            this.rowValue.Properties.FieldName = "TARGET";
            this.rowValue.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonGen);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 134);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(614, 40);
            this.panelControl1.TabIndex = 7;
            // 
            // simpleButtonGen
            // 
            this.simpleButtonGen.Enabled = false;
            this.simpleButtonGen.Location = new System.Drawing.Point(14, 9);
            this.simpleButtonGen.Name = "simpleButtonGen";
            this.simpleButtonGen.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonGen.TabIndex = 0;
            this.simpleButtonGen.Text = "分配任务";
            this.simpleButtonGen.Click += new System.EventHandler(this.generateAssignment);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 174);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Size = new System.Drawing.Size(614, 308);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5,
            this.xtraTabPage6,
            this.xtraTabPage7,
            this.xtraTabPage8,
            this.xtraTabPage9,
            this.xtraTabPage10,
            this.xtraTabPage11,
            this.xtraTabPage12});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.onMontlySchedulePageChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(608, 280);
            this.xtraTabPage1.Text = "1月";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(608, 280);
            this.xtraTabPage2.Text = "2月";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(608, 280);
            this.xtraTabPage3.Text = "3月";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(608, 280);
            this.xtraTabPage4.Text = "4月";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(608, 280);
            this.xtraTabPage5.Text = "5月";
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(608, 280);
            this.xtraTabPage6.Text = "6月";
            // 
            // xtraTabPage7
            // 
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.Size = new System.Drawing.Size(608, 280);
            this.xtraTabPage7.Text = "7月";
            // 
            // xtraTabPage8
            // 
            this.xtraTabPage8.Name = "xtraTabPage8";
            this.xtraTabPage8.Size = new System.Drawing.Size(608, 280);
            this.xtraTabPage8.Text = "8月";
            // 
            // xtraTabPage9
            // 
            this.xtraTabPage9.Name = "xtraTabPage9";
            this.xtraTabPage9.Size = new System.Drawing.Size(608, 280);
            this.xtraTabPage9.Text = "9月";
            // 
            // xtraTabPage10
            // 
            this.xtraTabPage10.Name = "xtraTabPage10";
            this.xtraTabPage10.Size = new System.Drawing.Size(608, 280);
            this.xtraTabPage10.Text = "10月";
            // 
            // xtraTabPage11
            // 
            this.xtraTabPage11.Name = "xtraTabPage11";
            this.xtraTabPage11.Size = new System.Drawing.Size(608, 280);
            this.xtraTabPage11.Text = "11月";
            // 
            // xtraTabPage12
            // 
            this.xtraTabPage12.Name = "xtraTabPage12";
            this.xtraTabPage12.Size = new System.Drawing.Size(608, 280);
            this.xtraTabPage12.Text = "12月";
            // 
            // ScheduleItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.vGridControl2);
            this.Controls.Add(this.panelControl2);
            this.Name = "ScheduleItemControl";
            this.Size = new System.Drawing.Size(614, 482);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControlUnit;
        private DevExpress.XtraEditors.TextEdit textEditAmount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMonth;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowValue;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGen;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage8;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage9;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage10;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage11;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage12;

    }
}
