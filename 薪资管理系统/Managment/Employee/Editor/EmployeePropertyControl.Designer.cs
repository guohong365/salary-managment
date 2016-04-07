using DevExpress.XtraEditors;

namespace SalarySystem.Managment.Employee.Editor
{
    partial class EmployeePropertyControl
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
            this.dateTimePickerEntryTime = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDismissionTime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditPosition = new DevExpress.XtraEditors.LookUpEdit();
            this.tpositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEditLeader = new DevExpress.XtraEditors.LookUpEdit();
            this.temployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEntryTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEntryTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDismissionTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDismissionTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlId
            // 
            this.labelControlId.Location = new System.Drawing.Point(31, 19);
            // 
            // labelControlName
            // 
            this.labelControlName.Location = new System.Drawing.Point(31, 56);
            // 
            // labelControlDesc
            // 
            this.labelControlDesc.Location = new System.Drawing.Point(31, 241);
            this.labelControlDesc.TabIndex = 14;
            // 
            // textEditId
            // 
            this.textEditId.Location = new System.Drawing.Point(73, 16);
            this.textEditId.Size = new System.Drawing.Size(233, 21);
            this.textEditId.TabIndex = 0;
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(73, 53);
            this.textEditName.Size = new System.Drawing.Size(233, 21);
            this.textEditName.TabIndex = 1;
            // 
            // memoEditDesc
            // 
            this.memoEditDesc.Location = new System.Drawing.Point(73, 238);
            this.memoEditDesc.Size = new System.Drawing.Size(233, 76);
            this.memoEditDesc.TabIndex = 6;
            // 
            // dateTimePickerEntryTime
            // 
            this.dateTimePickerEntryTime.EditValue = new System.DateTime(2016, 3, 24, 0, 0, 0, 0);
            this.dateTimePickerEntryTime.Location = new System.Drawing.Point(73, 90);
            this.dateTimePickerEntryTime.Name = "dateTimePickerEntryTime";
            this.dateTimePickerEntryTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimePickerEntryTime.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateTimePickerEntryTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTimePickerEntryTime.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateTimePickerEntryTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTimePickerEntryTime.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateTimePickerEntryTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateTimePickerEntryTime.Size = new System.Drawing.Size(233, 21);
            this.dateTimePickerEntryTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "入职时间：";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(31, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "岗位：";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(31, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "主管：";
            // 
            // dateEditDismissionTime
            // 
            this.dateEditDismissionTime.EditValue = null;
            this.dateEditDismissionTime.Location = new System.Drawing.Point(73, 201);
            this.dateEditDismissionTime.Name = "dateEditDismissionTime";
            this.dateEditDismissionTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDismissionTime.Properties.NullDate = new System.DateTime(1753, 1, 1, 22, 42, 0, 0);
            this.dateEditDismissionTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditDismissionTime.Size = new System.Drawing.Size(233, 21);
            this.dateEditDismissionTime.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 204);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "离职时间：";
            // 
            // lookUpEditPosition
            // 
            this.lookUpEditPosition.Location = new System.Drawing.Point(73, 127);
            this.lookUpEditPosition.Name = "lookUpEditPosition";
            this.lookUpEditPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPosition.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "岗位编号", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "岗位名称", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditPosition.Properties.DataSource = this.tpositionBindingSource;
            this.lookUpEditPosition.Properties.DisplayMember = "NAME";
            this.lookUpEditPosition.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.lookUpEditPosition.Properties.NullText = "";
            this.lookUpEditPosition.Properties.NullValuePrompt = "选择岗位";
            this.lookUpEditPosition.Properties.NullValuePromptShowForEmptyValue = true;
            this.lookUpEditPosition.Properties.ValueMember = "ID";
            this.lookUpEditPosition.Size = new System.Drawing.Size(233, 21);
            this.lookUpEditPosition.TabIndex = 3;
            this.lookUpEditPosition.EditValueChanged += new System.EventHandler(this.lookUpEditPosition_EditValueChanged);
            // 
            // tpositionBindingSource
            // 
            this.tpositionBindingSource.DataMember = "t_position";
            this.tpositionBindingSource.DataSource = typeof(SalarySystem.Data.DataSetSalary);
            // 
            // lookUpEditLeader
            // 
            this.lookUpEditLeader.Location = new System.Drawing.Point(73, 164);
            this.lookUpEditLeader.Name = "lookUpEditLeader";
            this.lookUpEditLeader.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditLeader.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "员工编号", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "员工姓名", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditLeader.Properties.DataSource = this.temployeeBindingSource;
            this.lookUpEditLeader.Size = new System.Drawing.Size(233, 21);
            this.lookUpEditLeader.TabIndex = 4;
            // 
            // temployeeBindingSource
            // 
            this.temployeeBindingSource.DataMember = "t_employee";
            this.temployeeBindingSource.DataSource = typeof(SalarySystem.Data.DataSetSalary);
            // 
            // EmployeePropertyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditLeader);
            this.Controls.Add(this.lookUpEditPosition);
            this.Controls.Add(this.dateEditDismissionTime);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerEntryTime);
            this.Name = "EmployeePropertyControl";
            this.Size = new System.Drawing.Size(324, 328);
            this.FillControls += new SalarySystem.Managment.Editor.FillControls(this.EmployeePropertyControl_FillControls);
            this.Retrive += new SalarySystem.Managment.Editor.Retrive(this.EmployeePropertyControl_Retrive);
            this.Load += new System.EventHandler(this.EmployeePropertyControl_Load);
            this.Controls.SetChildIndex(this.dateTimePickerEntryTime, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.dateEditDismissionTime, 0);
            this.Controls.SetChildIndex(this.memoEditDesc, 0);
            this.Controls.SetChildIndex(this.labelControlId, 0);
            this.Controls.SetChildIndex(this.labelControlName, 0);
            this.Controls.SetChildIndex(this.labelControlDesc, 0);
            this.Controls.SetChildIndex(this.textEditId, 0);
            this.Controls.SetChildIndex(this.textEditName, 0);
            this.Controls.SetChildIndex(this.lookUpEditPosition, 0);
            this.Controls.SetChildIndex(this.lookUpEditLeader, 0);
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEntryTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEntryTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDismissionTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDismissionTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temployeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateEdit dateTimePickerEntryTime;
        private LabelControl label3;
        private LabelControl label4;
        private LabelControl label5;
        private DateEdit dateEditDismissionTime;
        private LabelControl labelControl1;
        private LookUpEdit lookUpEditPosition;
        private System.Windows.Forms.BindingSource tpositionBindingSource;
        private LookUpEdit lookUpEditLeader;
        private System.Windows.Forms.BindingSource temployeeBindingSource;
        
    }
}
