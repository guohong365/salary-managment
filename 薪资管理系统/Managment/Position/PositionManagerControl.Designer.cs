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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridViewEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntryTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colSeniority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalaryLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDimissionTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridControlPosition = new DevExpress.XtraGrid.GridControl();
            this.dataHolderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewEvaluationForms = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEnabled1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullMark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewEvaluationDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEnabled2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullMark1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewPosition = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHolderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvaluationForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvaluationDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewEmployees
            // 
            this.gridViewEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colLeader,
            this.colEntryTime,
            this.colSeniority,
            this.colSalaryLevel,
            this.colDimissionTime,
            this.colEnabled,
            this.colDescription});
            this.gridViewEmployees.GridControl = this.gridControlPosition;
            this.gridViewEmployees.Name = "gridViewEmployees";
            this.gridViewEmployees.ViewCaption = "员工";
            // 
            // colId
            // 
            this.colId.Caption = "员工编号";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "姓名";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colLeader
            // 
            this.colLeader.Caption = "上级主管";
            this.colLeader.FieldName = "Leader";
            this.colLeader.Name = "colLeader";
            this.colLeader.Visible = true;
            this.colLeader.VisibleIndex = 2;
            // 
            // colEntryTime
            // 
            this.colEntryTime.Caption = "入职时间";
            this.colEntryTime.ColumnEdit = this.repositoryItemDateEdit1;
            this.colEntryTime.DisplayFormat.FormatString = "yyyy年MM月dd日";
            this.colEntryTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEntryTime.FieldName = "EntryTime";
            this.colEntryTime.Name = "colEntryTime";
            this.colEntryTime.Visible = true;
            this.colEntryTime.VisibleIndex = 3;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colSeniority
            // 
            this.colSeniority.Caption = "工龄";
            this.colSeniority.DisplayFormat.FormatString = "{0}年";
            this.colSeniority.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSeniority.FieldName = "Seniority";
            this.colSeniority.Name = "colSeniority";
            this.colSeniority.OptionsColumn.ReadOnly = true;
            this.colSeniority.Visible = true;
            this.colSeniority.VisibleIndex = 4;
            // 
            // colSalaryLevel
            // 
            this.colSalaryLevel.Caption = "工资级别";
            this.colSalaryLevel.FieldName = "SalaryLevel";
            this.colSalaryLevel.Name = "colSalaryLevel";
            this.colSalaryLevel.Visible = true;
            this.colSalaryLevel.VisibleIndex = 5;
            // 
            // colDimissionTime
            // 
            this.colDimissionTime.Caption = "离职时间";
            this.colDimissionTime.ColumnEdit = this.repositoryItemDateEdit1;
            this.colDimissionTime.DisplayFormat.FormatString = "yyyy年MM月dd日";
            this.colDimissionTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDimissionTime.FieldName = "DimissionTime";
            this.colDimissionTime.Name = "colDimissionTime";
            this.colDimissionTime.Visible = true;
            this.colDimissionTime.VisibleIndex = 6;
            // 
            // colEnabled
            // 
            this.colEnabled.Caption = "有效";
            this.colEnabled.FieldName = "Enabled";
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.Visible = true;
            this.colEnabled.VisibleIndex = 7;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "描述";
            this.colDescription.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 8;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // gridControlPosition
            // 
            this.gridControlPosition.DataSource = this.dataHolderBindingSource;
            this.gridControlPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridViewEmployees;
            gridLevelNode1.RelationName = "Employees";
            gridLevelNode2.LevelTemplate = this.gridViewEvaluationForms;
            gridLevelNode3.LevelTemplate = this.gridViewEvaluationDetails;
            gridLevelNode3.RelationName = "Items";
            gridLevelNode2.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            gridLevelNode2.RelationName = "EvaluationForms";
            this.gridControlPosition.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridControlPosition.Location = new System.Drawing.Point(2, 2);
            this.gridControlPosition.MainView = this.gridViewPosition;
            this.gridControlPosition.Name = "gridControlPosition";
            this.gridControlPosition.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemDateEdit1});
            this.gridControlPosition.Size = new System.Drawing.Size(964, 558);
            this.gridControlPosition.TabIndex = 0;
            this.gridControlPosition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEvaluationForms,
            this.gridViewEvaluationDetails,
            this.gridViewPosition,
            this.gridViewEmployees});
            // 
            // dataHolderBindingSource
            // 
            this.dataHolderBindingSource.DataSource = typeof(SalarySystem.Position);
            // 
            // gridViewEvaluationForms
            // 
            this.gridViewEvaluationForms.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEnabled1,
            this.colId1,
            this.colName1,
            this.colDescription1,
            this.colFullMark,
            this.colWeight});
            this.gridViewEvaluationForms.GridControl = this.gridControlPosition;
            this.gridViewEvaluationForms.Name = "gridViewEvaluationForms";
            this.gridViewEvaluationForms.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewEvaluationForms.ViewCaption = "考核项目";
            // 
            // colEnabled1
            // 
            this.colEnabled1.Caption = "启用";
            this.colEnabled1.FieldName = "Enabled";
            this.colEnabled1.Name = "colEnabled1";
            this.colEnabled1.Visible = true;
            this.colEnabled1.VisibleIndex = 0;
            // 
            // colId1
            // 
            this.colId1.Caption = "项目编号";
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 1;
            // 
            // colName1
            // 
            this.colName1.Caption = "项目名称";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 2;
            // 
            // colDescription1
            // 
            this.colDescription1.Caption = "详细说明";
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 3;
            // 
            // colFullMark
            // 
            this.colFullMark.Caption = "总分";
            this.colFullMark.FieldName = "FullMark";
            this.colFullMark.Name = "colFullMark";
            this.colFullMark.Visible = true;
            this.colFullMark.VisibleIndex = 4;
            // 
            // colWeight
            // 
            this.colWeight.Caption = "权重";
            this.colWeight.DisplayFormat.FormatString = "p";
            this.colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 5;
            // 
            // gridViewEvaluationDetails
            // 
            this.gridViewEvaluationDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEnabled2,
            this.colId2,
            this.colName2,
            this.colDescription2,
            this.colFullMark1,
            this.colWeight1});
            this.gridViewEvaluationDetails.GridControl = this.gridControlPosition;
            this.gridViewEvaluationDetails.Name = "gridViewEvaluationDetails";
            this.gridViewEvaluationDetails.ViewCaption = "考核表";
            // 
            // colEnabled2
            // 
            this.colEnabled2.Caption = "启用";
            this.colEnabled2.FieldName = "Enabled";
            this.colEnabled2.Name = "colEnabled2";
            this.colEnabled2.Visible = true;
            this.colEnabled2.VisibleIndex = 0;
            // 
            // colId2
            // 
            this.colId2.Caption = "编号";
            this.colId2.FieldName = "Id";
            this.colId2.Name = "colId2";
            this.colId2.Visible = true;
            this.colId2.VisibleIndex = 1;
            // 
            // colName2
            // 
            this.colName2.Caption = "项目名称";
            this.colName2.FieldName = "Name";
            this.colName2.Name = "colName2";
            this.colName2.Visible = true;
            this.colName2.VisibleIndex = 4;
            // 
            // colDescription2
            // 
            this.colDescription2.Caption = "说明";
            this.colDescription2.FieldName = "Description";
            this.colDescription2.Name = "colDescription2";
            this.colDescription2.Visible = true;
            this.colDescription2.VisibleIndex = 5;
            // 
            // colFullMark1
            // 
            this.colFullMark1.Caption = "满分";
            this.colFullMark1.FieldName = "FullMark";
            this.colFullMark1.Name = "colFullMark1";
            this.colFullMark1.Visible = true;
            this.colFullMark1.VisibleIndex = 2;
            // 
            // colWeight1
            // 
            this.colWeight1.Caption = "权重";
            this.colWeight1.DisplayFormat.FormatString = "p";
            this.colWeight1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWeight1.FieldName = "Weight";
            this.colWeight1.Name = "colWeight1";
            this.colWeight1.Visible = true;
            this.colWeight1.VisibleIndex = 3;
            // 
            // gridViewPosition
            // 
            this.gridViewPosition.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnName,
            this.gridColumnLeader,
            this.gridColumnDesc,
            this.gridColumnEnabled});
            this.gridViewPosition.GridControl = this.gridControlPosition;
            this.gridViewPosition.Name = "gridViewPosition";
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "职位编号";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Visible = true;
            this.gridColumnId.VisibleIndex = 0;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "职位名称";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            // 
            // gridColumnLeader
            // 
            this.gridColumnLeader.Caption = "上级岗位";
            this.gridColumnLeader.FieldName = "LeaderPosition";
            this.gridColumnLeader.Name = "gridColumnLeader";
            this.gridColumnLeader.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnLeader.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnLeader.OptionsColumn.ReadOnly = true;
            this.gridColumnLeader.Visible = true;
            this.gridColumnLeader.VisibleIndex = 2;
            // 
            // gridColumnDesc
            // 
            this.gridColumnDesc.Caption = "职位描述";
            this.gridColumnDesc.FieldName = "Description";
            this.gridColumnDesc.Name = "gridColumnDesc";
            this.gridColumnDesc.Visible = true;
            this.gridColumnDesc.VisibleIndex = 3;
            // 
            // gridColumnEnabled
            // 
            this.gridColumnEnabled.Caption = "有效";
            this.gridColumnEnabled.FieldName = "Enabled";
            this.gridColumnEnabled.Name = "gridColumnEnabled";
            this.gridColumnEnabled.Visible = true;
            this.gridColumnEnabled.VisibleIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 562);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(968, 40);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(167, 9);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "停用";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(86, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "修改";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "新增";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlPosition);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(968, 562);
            this.panelControl2.TabIndex = 1;
            // 
            // PositionManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "PositionManagerControl";
            this.Size = new System.Drawing.Size(968, 602);
            this.Load += new System.EventHandler(this.PostManagerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHolderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvaluationForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvaluationDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControlPosition;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPosition;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDesc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLeader;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEnabled;
        private System.Windows.Forms.BindingSource dataHolderBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLeader;
        private DevExpress.XtraGrid.Columns.GridColumn colEntryTime;
        private DevExpress.XtraGrid.Columns.GridColumn colSeniority;
        private DevExpress.XtraGrid.Columns.GridColumn colSalaryLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colDimissionTime;
        private DevExpress.XtraGrid.Columns.GridColumn colEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEvaluationForms;
        private DevExpress.XtraGrid.Columns.GridColumn colEnabled1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colFullMark;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEvaluationDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colEnabled2;
        private DevExpress.XtraGrid.Columns.GridColumn colId2;
        private DevExpress.XtraGrid.Columns.GridColumn colName2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription2;
        private DevExpress.XtraGrid.Columns.GridColumn colFullMark1;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight1;


    }
}
