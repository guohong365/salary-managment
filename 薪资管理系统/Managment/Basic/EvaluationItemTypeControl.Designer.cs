﻿namespace SalarySystem.Managment.Basic
{
    partial class EvaluationItemTypeControl
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colENABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlEvaluationType = new DevExpress.XtraGrid.GridControl();
            this.gridViewEvaluationType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvaluationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvaluationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // colENABLED
            // 
            this.colENABLED.AppearanceHeader.Options.UseTextOptions = true;
            this.colENABLED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colENABLED.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.colENABLED.Caption = "有效";
            this.colENABLED.FieldName = "ENABLED";
            this.colENABLED.MaxWidth = 35;
            this.colENABLED.MinWidth = 35;
            this.colENABLED.Name = "colENABLED";
            this.colENABLED.Visible = true;
            this.colENABLED.VisibleIndex = 0;
            this.colENABLED.Width = 35;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton1.Location = new System.Drawing.Point(358, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "保存";
            this.simpleButton1.Click += new System.EventHandler(this.save_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 371);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(519, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton2.Location = new System.Drawing.Point(439, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "放弃";
            this.simpleButton2.Click += new System.EventHandler(this.abandon_Click);
            // 
            // gridControlEvaluationType
            // 
            this.gridControlEvaluationType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEvaluationType.Location = new System.Drawing.Point(0, 0);
            this.gridControlEvaluationType.MainView = this.gridViewEvaluationType;
            this.gridControlEvaluationType.Name = "gridControlEvaluationType";
            this.gridControlEvaluationType.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControlEvaluationType.Size = new System.Drawing.Size(519, 371);
            this.gridControlEvaluationType.TabIndex = 0;
            this.gridControlEvaluationType.UseEmbeddedNavigator = true;
            this.gridControlEvaluationType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEvaluationType});
            // 
            // gridViewEvaluationType
            // 
            this.gridViewEvaluationType.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvaluationType.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewEvaluationType.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvaluationType.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvaluationType.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewEvaluationType.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewEvaluationType.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridViewEvaluationType.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridViewEvaluationType.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridViewEvaluationType.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvaluationType.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewEvaluationType.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewEvaluationType.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridViewEvaluationType.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvaluationType.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvaluationType.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvaluationType.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewEvaluationType.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvaluationType.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewEvaluationType.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewEvaluationType.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewEvaluationType.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewEvaluationType.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridViewEvaluationType.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridViewEvaluationType.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvaluationType.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvaluationType.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewEvaluationType.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvaluationType.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewEvaluationType.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewEvaluationType.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewEvaluationType.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewEvaluationType.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvaluationType.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewEvaluationType.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewEvaluationType.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewEvaluationType.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvaluationType.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewEvaluationType.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewEvaluationType.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvaluationType.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewEvaluationType.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewEvaluationType.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewEvaluationType.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvaluationType.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridViewEvaluationType.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewEvaluationType.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvaluationType.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewEvaluationType.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvaluationType.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvaluationType.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewEvaluationType.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewEvaluationType.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridViewEvaluationType.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewEvaluationType.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridViewEvaluationType.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewEvaluationType.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvaluationType.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridViewEvaluationType.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridViewEvaluationType.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewEvaluationType.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvaluationType.Appearance.Row.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.Row.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewEvaluationType.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridViewEvaluationType.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvaluationType.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewEvaluationType.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewEvaluationType.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridViewEvaluationType.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewEvaluationType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colENABLED,
            this.colID,
            this.colNAME,
            this.colDESCRIPTION});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.LightCoral;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colENABLED;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual;
            styleFormatCondition1.Expression = "[ENABLED]";
            styleFormatCondition1.Value1 = true;
            this.gridViewEvaluationType.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewEvaluationType.GridControl = this.gridControlEvaluationType;
            this.gridViewEvaluationType.Name = "gridViewEvaluationType";
            this.gridViewEvaluationType.NewItemRowText = "点击新增";
            this.gridViewEvaluationType.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewEvaluationType.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewEvaluationType.OptionsBehavior.AutoPopulateColumns = false;
            this.gridViewEvaluationType.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewEvaluationType.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewEvaluationType.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewEvaluationType.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewEvaluationType.OptionsView.ShowViewCaption = true;
            this.gridViewEvaluationType.ViewCaption = "考核项目类型定义";
            this.gridViewEvaluationType.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.initNewRow);
            // 
            // colID
            // 
            this.colID.Caption = "类型编号";
            this.colID.FieldName = "ID";
            this.colID.MaxWidth = 100;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            this.colID.Width = 100;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "类型名称";
            this.colNAME.FieldName = "NAME";
            this.colNAME.MaxWidth = 200;
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 2;
            this.colNAME.Width = 200;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "类型说明";
            this.colDESCRIPTION.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 3;
            this.colDESCRIPTION.Width = 166;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // EvaluationItemTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlEvaluationType);
            this.Controls.Add(this.panelControl1);
            this.Name = "EvaluationItemTypeControl";
            this.Size = new System.Drawing.Size(519, 411);
            this.VisibleChanged += new System.EventHandler(this.close_Click);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvaluationType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvaluationType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControlEvaluationType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEvaluationType;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colENABLED;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}
