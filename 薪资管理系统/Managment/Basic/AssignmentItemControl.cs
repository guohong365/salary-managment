using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace SalarySystem.Managment.Basic
{
    public class AssignmentItemControl : DefineBaseControl
    {
        #region default init by desinger
        private IContainer components;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void initializeComponent()
        {
            components = new Container();
            _gridControlAssignmentItem = new GridControl();
            _gridViewAssignmentItem = new GridView();
            _colEnabled = new GridColumn();
            _colName = new GridColumn();
            _colType = new GridColumn();
            _colTarget = new GridColumn();
            _colUnit = new GridColumn();
            _colDescription = new GridColumn();
            _colVersionID = new GridColumn();
            _colID = new GridColumn();
            _colPositionID = new GridColumn();
            _repositoryItemLookUpEditType = new RepositoryItemLookUpEdit();
            _repositoryItemLookUpEditUnit = new RepositoryItemLookUpEdit();
            _repositoryItemLookUpEditPosition = new RepositoryItemLookUpEdit();
            ((ISupportInitialize)(panelControl1)).BeginInit();
            panelControl1.SuspendLayout();
            ((ISupportInitialize)(panelControl2)).BeginInit();
            panelControl2.SuspendLayout();
            ((ISupportInitialize)(_gridControlAssignmentItem)).BeginInit();
            ((ISupportInitialize)(_gridViewAssignmentItem)).BeginInit();
            ((ISupportInitialize)(_repositoryItemLookUpEditType)).BeginInit();
            ((ISupportInitialize)(_repositoryItemLookUpEditUnit)).BeginInit();
            ((ISupportInitialize)(_repositoryItemLookUpEditPosition)).BeginInit();
            SuspendLayout();
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(_gridControlAssignmentItem);
            // 
            // gridControlAssignmentItem
            // 
            _gridControlAssignmentItem.Dock = DockStyle.Fill;
            _gridControlAssignmentItem.Location = new Point(2, 2);
            _gridControlAssignmentItem.MainView = _gridViewAssignmentItem;
            _gridControlAssignmentItem.Name = "_gridControlAssignmentItem";
            _gridControlAssignmentItem.RepositoryItems.AddRange(new RepositoryItem[] {
            _repositoryItemLookUpEditType,
            _repositoryItemLookUpEditUnit,
            _repositoryItemLookUpEditPosition});
            _gridControlAssignmentItem.Size = new Size(613, 416);
            _gridControlAssignmentItem.TabIndex = 0;
            _gridControlAssignmentItem.ViewCollection.AddRange(new BaseView[] {
            _gridViewAssignmentItem});
            // 
            // gridViewAssignmentItem
            // 
            _gridViewAssignmentItem.Columns.AddRange(new[] {
            _colEnabled,
            _colName,
            _colType,
            _colTarget,
            _colUnit,
            _colDescription,
            _colPositionID,
            _colVersionID,
            _colID});
            _gridViewAssignmentItem.GridControl = _gridControlAssignmentItem;
            _gridViewAssignmentItem.Name = "gridViewAssignmentItem";
            // 
            // colENABLED
            // 
            _colEnabled.Caption = "有效";
            _colEnabled.FieldName = "ENABLED";
            _colEnabled.MaxWidth = 35;
            _colEnabled.Name = "colENABLED";
            _colEnabled.Visible = true;
            _colEnabled.VisibleIndex = 0;
            _colEnabled.Width = 35;
            // 
            // colNAME
            // 
            _colName.Caption = "任务名称";
            _colName.FieldName = "NAME";
            _colName.MaxWidth = 150;
            _colName.Name = "colNAME";
            _colName.Visible = true;
            _colName.VisibleIndex = 1;
            // 
            // colTYPE
            // 
            _colType.Caption = "任务类型";
            _colType.ColumnEdit = _repositoryItemLookUpEditType;
            _colType.FieldName = "TYPE";
            _colType.MaxWidth = 100;
            _colType.Name = "colTYPE";
            _colType.Visible = true;
            _colType.VisibleIndex = 2;
            _colType.Width = 50;
            // 
            // colTARGET
            // 
            _colTarget.Caption = "任务目标";
            _colTarget.FieldName = "TARGET";
            _colTarget.MaxWidth = 60;
            _colTarget.Name = "colTARGET";
            _colTarget.Visible = true;
            _colTarget.VisibleIndex = 3;
            _colTarget.Width = 60;
            // 
            // colUNIT
            // 
            _colUnit.Caption = "计量单位";
            _colUnit.ColumnEdit = _repositoryItemLookUpEditUnit;
            _colUnit.FieldName = "UNIT";
            _colUnit.MaxWidth = 100;
            _colUnit.Name = "colUNIT";
            _colUnit.Visible = true;
            _colUnit.VisibleIndex = 4;
            _colUnit.Width = 50;
            // 
            // colDESCRIPTION
            // 
            _colDescription.Caption = "说明";
            _colDescription.FieldName = "DESCRIPTION";
            _colDescription.Name = "colDESCRIPTION";
            _colDescription.Visible = true;
            _colDescription.VisibleIndex = 5;
            // 
            // colVERSION_ID
            // 
            _colVersionID.FieldName = "VERSION_ID";
            _colVersionID.Name = "colVERSION_ID";
            // 
            // colID
            // 
            _colID.FieldName = "ID";
            _colID.Name = "colID";
            // 
            // colPOSITION_ID
            // 
            _colPositionID.Caption = "使用岗位";
            _colPositionID.ColumnEdit = _repositoryItemLookUpEditPosition;
            _colPositionID.FieldName = "POSITION_ID";
            _colPositionID.MaxWidth = 100;
            _colPositionID.Name = "colPOSITION_ID";
            _colPositionID.Visible = true;
            _colPositionID.VisibleIndex = 6;
            // 
            // repositoryItemLookUpEditType
            // 
            _repositoryItemLookUpEditType.AutoHeight = false;
            _repositoryItemLookUpEditType.Buttons.AddRange(new[] {
            new EditorButton(ButtonPredefines.Combo)});
            _repositoryItemLookUpEditType.Columns.AddRange(new[] {
            new LookUpColumnInfo("NAME", "Name9")});
            _repositoryItemLookUpEditType.DisplayMember = "NAME";
            _repositoryItemLookUpEditType.Name = "repositoryItemLookUpEditType";
            _repositoryItemLookUpEditType.ShowFooter = false;
            _repositoryItemLookUpEditType.ShowHeader = false;
            _repositoryItemLookUpEditType.ValueMember = "ID";
            _repositoryItemLookUpEditType.NullText = "";
            // 
            // repositoryItemLookUpEditUnit
            // 
            _repositoryItemLookUpEditUnit.AutoHeight = false;
            _repositoryItemLookUpEditUnit.Buttons.AddRange(new[] {
            new EditorButton(ButtonPredefines.Combo)});
            _repositoryItemLookUpEditUnit.Columns.AddRange(new[] {
            new LookUpColumnInfo("NAME", "Name8")});
            _repositoryItemLookUpEditUnit.DisplayMember = "NAME";
            _repositoryItemLookUpEditUnit.Name = "repositoryItemLookUpEditUnit";
            _repositoryItemLookUpEditUnit.ShowFooter = false;
            _repositoryItemLookUpEditUnit.ShowHeader = false;
            _repositoryItemLookUpEditUnit.ValueMember = "ID";
            _repositoryItemLookUpEditUnit.NullText = "";
            // 
            // repositoryItemLookUpEditPosition
            // 
            _repositoryItemLookUpEditPosition.AutoHeight = false;
            _repositoryItemLookUpEditPosition.Buttons.AddRange(new[] {
            new EditorButton(ButtonPredefines.Combo)});
            _repositoryItemLookUpEditPosition.Columns.AddRange(new[] {
            new LookUpColumnInfo("NAME", "岗位名称")});
            _repositoryItemLookUpEditPosition.DisplayMember = "NAME";
            _repositoryItemLookUpEditPosition.Name = "repositoryItemLookUpEditPosition";
            _repositoryItemLookUpEditPosition.ShowFooter = false;
            _repositoryItemLookUpEditPosition.ShowHeader = false;
            _repositoryItemLookUpEditPosition.ValueMember = "ID";
            _repositoryItemLookUpEditPosition.NullText = "";
            // 
            // AssignmentItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            Name = "AssignmentItemControl";
            ((ISupportInitialize)(panelControl1)).EndInit();
            panelControl1.ResumeLayout(false);
            ((ISupportInitialize)(panelControl2)).EndInit();
            panelControl2.ResumeLayout(false);
            ((ISupportInitialize)(_gridControlAssignmentItem)).EndInit();
            ((ISupportInitialize)(_gridViewAssignmentItem)).EndInit();
            ((ISupportInitialize)(_repositoryItemLookUpEditType)).EndInit();
            ((ISupportInitialize)(_repositoryItemLookUpEditUnit)).EndInit();
            ((ISupportInitialize)(_repositoryItemLookUpEditPosition)).EndInit();
            ResumeLayout(false);
        }
        private GridControl _gridControlAssignmentItem;
        private GridColumn _colID;
        private GridColumn _colName;
        private GridColumn _colDescription;
        private GridColumn _colType;
        private GridColumn _colTarget;
        private GridColumn _colUnit;
        private GridColumn _colEnabled;
        private GridColumn _colVersionID;
        
        private RepositoryItemLookUpEdit _repositoryItemLookUpEditType;
        private RepositoryItemLookUpEdit _repositoryItemLookUpEditUnit;
        private GridColumn _colPositionID;
        private RepositoryItemLookUpEdit _repositoryItemLookUpEditPosition;
        private GridView _gridViewAssignmentItem;

        #endregion
        
        public AssignmentItemControl()
        {
            initializeComponent();
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();
            
            GridViewHelper.SetUpEditableGridView(_gridViewAssignmentItem, false, "任务指标定义", VersionType.ASSIGNMENT);
            
            _gridControlAssignmentItem.DataSource = new DataView(DataHolder.AssignmentItem);

            _repositoryItemLookUpEditType.DataSource = new DataView(DataHolder.AssignmentItemType)
            {
                RowFilter = "[ENABLED]=true"
            };

            _repositoryItemLookUpEditPosition.DataSource = new DataView(DataHolder.Position)
            {
                RowFilter = "[ENABLED]=true"
            };

            _repositoryItemLookUpEditUnit.DataSource = new DataView(DataHolder.Unit)
            {
                RowFilter = "[ENABLED]=true"
            };
            DataHolder.AssignmentItem.RowChanged += rowChanged;
            _gridViewAssignmentItem.InitNewRow += initNewRow;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            DataHolder.AssignmentItem.RowChanged += rowChanged;
            _gridViewAssignmentItem.ExpandAllGroups();
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            DataHolder.AssignmentItem.RowChanged -= rowChanged;
        }

        protected override void onSave()
        {
            base.onSave();
            DataHolder.AssignmentItemTableAdapter.Update(DataHolder.AssignmentItem);
        }

        protected override void onRevert()
        {
            base.onRevert();
            DataHolder.AssignmentItem.RejectChanges();
        }

        private void rowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add || e.Action == DataRowAction.Change || e.Action == DataRowAction.Delete)
            {
                EnableSave(true);
                EnableRevert(true);
                CanClose = false;
            }
        }

        private void initNewRow(object sender, InitNewRowEventArgs e)
        {
            var row = _gridViewAssignmentItem.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row["ID"] = Guid.NewGuid().ToString();
                row["ENABLED"] = true;
                row["VERSION_ID"] = GlobalSettings.AssignmentVersion;
            }
        }

    }
}
