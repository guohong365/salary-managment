namespace SalarySystem.Schedule
{
    partial class AutoAssignmentWeightControl
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).BeginInit();
            this.panelControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControlButtons.Location = new System.Drawing.Point(0, 544);
            this.panelControlButtons.Size = new System.Drawing.Size(727, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(647, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(566, 9);
            // 
            // panelControl2
            // 
            this.panelControlMain.Controls.Add(this.gridControl1);
            this.panelControlMain.Size = new System.Drawing.Size(727, 544);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(723, 540);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNAME,
            this.colVALUE,
            this.colDESCRIPTION,
            this.colTYPE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.onCustomDrawCell);
            this.gridView1.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.onCustomDrawFooterCell);
            // 
            // colNAME
            // 
            this.colNAME.Caption = "月份";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.OptionsColumn.AllowEdit = false;
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 0;
            // 
            // colVALUE
            // 
            this.colVALUE.Caption = "占比";
            this.colVALUE.DisplayFormat.FormatString = "{0}%";
            this.colVALUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colVALUE.FieldName = "VALUE";
            this.colVALUE.Name = "colVALUE";
            this.colVALUE.SummaryItem.DisplayFormat = "{0}%";
            this.colVALUE.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colVALUE.Visible = true;
            this.colVALUE.VisibleIndex = 1;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "说明";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 2;
            // 
            // colTYPE
            // 
            this.colTYPE.FieldName = "TYPE";
            this.colTYPE.Name = "colTYPE";
            // 
            // AutoAssignmentWeightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AutoAssignmentWeightControl";
            this.Size = new System.Drawing.Size(727, 584);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtons)).EndInit();
            this.panelControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE;
    }
}
