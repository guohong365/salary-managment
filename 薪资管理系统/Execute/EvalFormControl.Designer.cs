namespace SalarySystem.Execute
{
    partial class EvalFormControl
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
            this.gridControlEvalForm = new DevExpress.XtraGrid.GridControl();
            this.gridViewEvalForm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colITEM_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditItemType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colITEM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colFULL_MARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESULT_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvalForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvalForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlEvalForm
            // 
            this.gridControlEvalForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEvalForm.Location = new System.Drawing.Point(0, 0);
            this.gridControlEvalForm.MainView = this.gridViewEvalForm;
            this.gridControlEvalForm.Margin = new System.Windows.Forms.Padding(0);
            this.gridControlEvalForm.Name = "gridControlEvalForm";
            this.gridControlEvalForm.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditItemType,
            this.repositoryItemMemoEdit1});
            this.gridControlEvalForm.Size = new System.Drawing.Size(673, 545);
            this.gridControlEvalForm.TabIndex = 1;
            this.gridControlEvalForm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEvalForm});
            // 
            // gridViewEvalForm
            // 
            this.gridViewEvalForm.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvalForm.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewEvalForm.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvalForm.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvalForm.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewEvalForm.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewEvalForm.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridViewEvalForm.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridViewEvalForm.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridViewEvalForm.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvalForm.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewEvalForm.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewEvalForm.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridViewEvalForm.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvalForm.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvalForm.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvalForm.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewEvalForm.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvalForm.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewEvalForm.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewEvalForm.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewEvalForm.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewEvalForm.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridViewEvalForm.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridViewEvalForm.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvalForm.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvalForm.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewEvalForm.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvalForm.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewEvalForm.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewEvalForm.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewEvalForm.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewEvalForm.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvalForm.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewEvalForm.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewEvalForm.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewEvalForm.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvalForm.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewEvalForm.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewEvalForm.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvalForm.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewEvalForm.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewEvalForm.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewEvalForm.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvalForm.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridViewEvalForm.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewEvalForm.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvalForm.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewEvalForm.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewEvalForm.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvalForm.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewEvalForm.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewEvalForm.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridViewEvalForm.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewEvalForm.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridViewEvalForm.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewEvalForm.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvalForm.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridViewEvalForm.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridViewEvalForm.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewEvalForm.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvalForm.Appearance.Row.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.Row.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewEvalForm.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridViewEvalForm.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewEvalForm.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewEvalForm.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewEvalForm.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridViewEvalForm.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewEvalForm.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colITEM_TYPE,
            this.colITEM_NAME,
            this.colITEM_DESC,
            this.colFULL_MARK,
            this.colMARK,
            this.colRESULT_DESC});
            this.gridViewEvalForm.GridControl = this.gridControlEvalForm;
            this.gridViewEvalForm.Name = "gridViewEvalForm";
            this.gridViewEvalForm.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewEvalForm.OptionsCustomization.AllowFilter = false;
            this.gridViewEvalForm.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewEvalForm.OptionsCustomization.AllowSort = false;
            this.gridViewEvalForm.OptionsFilter.AllowFilterEditor = false;
            this.gridViewEvalForm.OptionsFind.AllowFindPanel = false;
            this.gridViewEvalForm.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewEvalForm.OptionsView.AllowCellMerge = true;
            this.gridViewEvalForm.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewEvalForm.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewEvalForm.OptionsView.RowAutoHeight = true;
            this.gridViewEvalForm.OptionsView.ShowFooter = true;
            this.gridViewEvalForm.OptionsView.ShowGroupedColumns = true;
            this.gridViewEvalForm.OptionsView.ShowGroupPanel = false;
            this.gridViewEvalForm.OptionsView.ShowIndicator = false;
            // 
            // colITEM_TYPE
            // 
            this.colITEM_TYPE.Caption = "考核项目";
            this.colITEM_TYPE.ColumnEdit = this.repositoryItemLookUpEditItemType;
            this.colITEM_TYPE.FieldName = "ITEM_TYPE";
            this.colITEM_TYPE.Name = "colITEM_TYPE";
            this.colITEM_TYPE.OptionsColumn.AllowEdit = false;
            this.colITEM_TYPE.OptionsColumn.AllowFocus = false;
            this.colITEM_TYPE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colITEM_TYPE.OptionsColumn.AllowMove = false;
            this.colITEM_TYPE.OptionsColumn.AllowShowHide = false;
            this.colITEM_TYPE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colITEM_TYPE.OptionsColumn.ShowInCustomizationForm = false;
            this.colITEM_TYPE.OptionsFilter.AllowFilter = false;
            this.colITEM_TYPE.Visible = true;
            this.colITEM_TYPE.VisibleIndex = 0;
            this.colITEM_TYPE.Width = 100;
            // 
            // repositoryItemLookUpEditItemType
            // 
            this.repositoryItemLookUpEditItemType.AutoHeight = false;
            this.repositoryItemLookUpEditItemType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditItemType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "名称4")});
            this.repositoryItemLookUpEditItemType.DisplayMember = "NAME";
            this.repositoryItemLookUpEditItemType.Name = "repositoryItemLookUpEditItemType";
            this.repositoryItemLookUpEditItemType.ValueMember = "ID";
            // 
            // colITEM_NAME
            // 
            this.colITEM_NAME.Caption = "考核内容";
            this.colITEM_NAME.FieldName = "ITEM_NAME";
            this.colITEM_NAME.Name = "colITEM_NAME";
            this.colITEM_NAME.OptionsColumn.AllowEdit = false;
            this.colITEM_NAME.OptionsColumn.AllowFocus = false;
            this.colITEM_NAME.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colITEM_NAME.OptionsColumn.AllowMove = false;
            this.colITEM_NAME.OptionsColumn.AllowShowHide = false;
            this.colITEM_NAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colITEM_NAME.OptionsFilter.AllowFilter = false;
            this.colITEM_NAME.Visible = true;
            this.colITEM_NAME.VisibleIndex = 1;
            this.colITEM_NAME.Width = 120;
            // 
            // colITEM_DESC
            // 
            this.colITEM_DESC.AppearanceCell.Options.UseTextOptions = true;
            this.colITEM_DESC.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colITEM_DESC.Caption = "考核标准";
            this.colITEM_DESC.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colITEM_DESC.FieldName = "ITEM_DESC";
            this.colITEM_DESC.Name = "colITEM_DESC";
            this.colITEM_DESC.OptionsColumn.AllowEdit = false;
            this.colITEM_DESC.OptionsColumn.AllowFocus = false;
            this.colITEM_DESC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colITEM_DESC.OptionsColumn.AllowShowHide = false;
            this.colITEM_DESC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colITEM_DESC.OptionsColumn.ShowInCustomizationForm = false;
            this.colITEM_DESC.OptionsFilter.AllowFilter = false;
            this.colITEM_DESC.Visible = true;
            this.colITEM_DESC.VisibleIndex = 2;
            this.colITEM_DESC.Width = 91;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colFULL_MARK
            // 
            this.colFULL_MARK.Caption = "满分";
            this.colFULL_MARK.FieldName = "FULL_MARK";
            this.colFULL_MARK.Name = "colFULL_MARK";
            this.colFULL_MARK.OptionsColumn.AllowEdit = false;
            this.colFULL_MARK.OptionsColumn.AllowFocus = false;
            this.colFULL_MARK.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colFULL_MARK.OptionsColumn.AllowMove = false;
            this.colFULL_MARK.OptionsColumn.AllowShowHide = false;
            this.colFULL_MARK.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFULL_MARK.OptionsColumn.ShowInCustomizationForm = false;
            this.colFULL_MARK.OptionsFilter.AllowFilter = false;
            this.colFULL_MARK.SummaryItem.DisplayFormat = "满分：{0}";
            this.colFULL_MARK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFULL_MARK.Visible = true;
            this.colFULL_MARK.VisibleIndex = 3;
            this.colFULL_MARK.Width = 60;
            // 
            // colMARK
            // 
            this.colMARK.Caption = "得分";
            this.colMARK.FieldName = "MARK";
            this.colMARK.Name = "colMARK";
            this.colMARK.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMARK.OptionsFilter.AllowFilter = false;
            this.colMARK.SummaryItem.DisplayFormat = "总分：{0}";
            this.colMARK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colMARK.Visible = true;
            this.colMARK.VisibleIndex = 4;
            this.colMARK.Width = 60;
            // 
            // colRESULT_DESC
            // 
            this.colRESULT_DESC.AppearanceCell.Options.UseTextOptions = true;
            this.colRESULT_DESC.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colRESULT_DESC.Caption = "备注";
            this.colRESULT_DESC.FieldName = "RESULT_DESC";
            this.colRESULT_DESC.Name = "colRESULT_DESC";
            this.colRESULT_DESC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRESULT_DESC.OptionsColumn.AllowMove = false;
            this.colRESULT_DESC.OptionsFilter.AllowFilter = false;
            this.colRESULT_DESC.Visible = true;
            this.colRESULT_DESC.VisibleIndex = 5;
            this.colRESULT_DESC.Width = 224;
            // 
            // EvalFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlEvalForm);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EvalFormControl";
            this.Size = new System.Drawing.Size(673, 545);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvalForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvalForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEvalForm;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEvalForm;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_MARK;
        private DevExpress.XtraGrid.Columns.GridColumn colMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colRESULT_DESC;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditItemType;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}
