namespace SalarySystem.Managment.Position
{
    partial class PositionManagerControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.列ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.列DESCRIPTION = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tpositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalary = new SalarySystem.Data.DataSetSalary();
            this.t_positionTableAdapter = new SalarySystem.Data.DataSetSalaryTableAdapters.t_positionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).BeginInit();
            this.panelControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControlButtons.Location = new System.Drawing.Point(0, 567);
            this.panelControlButtons.Size = new System.Drawing.Size(968, 35);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(888, 6);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(807, 6);
            // 
            // panelControl2
            // 
            this.panelControlMain.Controls.Add(this.treeList1);
            this.panelControlMain.Size = new System.Drawing.Size(968, 567);
            // 
            // treeList1
            // 
            this.treeList1.AllowDrop = true;
            this.treeList1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.treeList1.Appearance.Empty.Options.UseBackColor = true;
            this.treeList1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.treeList1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.EvenRow.Options.UseBackColor = true;
            this.treeList1.Appearance.EvenRow.Options.UseForeColor = true;
            this.treeList1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Cyan;
            this.treeList1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeList1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeList1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.treeList1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.treeList1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.treeList1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.treeList1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.treeList1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.treeList1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.treeList1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.treeList1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.GroupButton.Options.UseBackColor = true;
            this.treeList1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.treeList1.Appearance.GroupButton.Options.UseForeColor = true;
            this.treeList1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.treeList1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.treeList1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.treeList1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.treeList1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.treeList1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.treeList1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.treeList1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.treeList1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.treeList1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.treeList1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.treeList1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.treeList1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.treeList1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.treeList1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeList1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.treeList1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.treeList1.Appearance.HorzLine.Options.UseBackColor = true;
            this.treeList1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.treeList1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.OddRow.Options.UseBackColor = true;
            this.treeList1.Appearance.OddRow.Options.UseForeColor = true;
            this.treeList1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.treeList1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.treeList1.Appearance.Preview.Options.UseBackColor = true;
            this.treeList1.Appearance.Preview.Options.UseForeColor = true;
            this.treeList1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.treeList1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.Row.Options.UseBackColor = true;
            this.treeList1.Appearance.Row.Options.UseForeColor = true;
            this.treeList1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.treeList1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeList1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.treeList1.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.treeList1.Appearance.TreeLine.Options.UseBackColor = true;
            this.treeList1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.treeList1.Appearance.VertLine.Options.UseBackColor = true;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.列ID,
            this.列NAME,
            this.列DESCRIPTION});
            this.treeList1.DataSource = this.tpositionBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(2, 2);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.AutoFocusNewNode = true;
            this.treeList1.OptionsBehavior.DragNodes = true;
            this.treeList1.OptionsBehavior.EnterMovesNextColumn = true;
            this.treeList1.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList1.OptionsView.EnableAppearanceOddRow = true;
            this.treeList1.OptionsView.ShowCheckBoxes = true;
            this.treeList1.ParentFieldName = "LEADER_ID";
            this.treeList1.PreviewFieldName = "DESCRIPTION";
            this.treeList1.RootValue = "0000000000";
            this.treeList1.Size = new System.Drawing.Size(964, 563);
            this.treeList1.TabIndex = 0;
            this.treeList1.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.onAfterCheckNode);
            this.treeList1.InvalidNodeException += new DevExpress.XtraTreeList.InvalidNodeExceptionEventHandler(this.invalidNodeException);
            this.treeList1.ValidateNode += new DevExpress.XtraTreeList.ValidateNodeEventHandler(this.validateNode);
            this.treeList1.CustomDrawNodeCheckBox += new DevExpress.XtraTreeList.CustomDrawNodeCheckBoxEventHandler(this.customDrawNodeCheckBox);
            this.treeList1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            // 
            // 列ID
            // 
            this.列ID.Caption = "岗位编号";
            this.列ID.FieldName = "ID";
            this.列ID.Name = "列ID";
            this.列ID.Visible = true;
            this.列ID.VisibleIndex = 0;
            this.列ID.Width = 57;
            // 
            // 列NAME
            // 
            this.列NAME.Caption = "岗位名称";
            this.列NAME.FieldName = "NAME";
            this.列NAME.Name = "列NAME";
            this.列NAME.Visible = true;
            this.列NAME.VisibleIndex = 1;
            this.列NAME.Width = 154;
            // 
            // 列DESCRIPTION
            // 
            this.列DESCRIPTION.Caption = "岗位说明";
            this.列DESCRIPTION.FieldName = "DESCRIPTION";
            this.列DESCRIPTION.Name = "列DESCRIPTION";
            this.列DESCRIPTION.Visible = true;
            this.列DESCRIPTION.VisibleIndex = 2;
            this.列DESCRIPTION.Width = 154;
            // 
            // tpositionBindingSource
            // 
            this.tpositionBindingSource.DataMember = "t_position";
            this.tpositionBindingSource.DataSource = this.dataSetSalary;
            // 
            // dataSetSalary
            // 
            this.dataSetSalary.DataSetName = "DataSetSalary";
            this.dataSetSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_positionTableAdapter
            // 
            this.t_positionTableAdapter.ClearBeforeFill = true;
            // 
            // PositionManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PositionManagerControl";
            this.Size = new System.Drawing.Size(968, 602);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).EndInit();
            this.panelControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn 列DESCRIPTION;
        private System.Windows.Forms.BindingSource tpositionBindingSource;
        private Data.DataSetSalary dataSetSalary;
        private Data.DataSetSalaryTableAdapters.t_positionTableAdapter t_positionTableAdapter;


    }
}
