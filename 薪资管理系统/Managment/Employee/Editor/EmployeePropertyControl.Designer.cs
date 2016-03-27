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
            this.dateTimePickerEntryTime = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxLeader = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxSalaryLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEditDismissionTime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEntryTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEntryTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxLeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxSalaryLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDismissionTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDismissionTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlId
            // 
            this.labelControlId.Location = new System.Drawing.Point(31, 19);
            // 
            // labelControlName
            // 
            this.labelControlName.Location = new System.Drawing.Point(31, 56);
            this.labelControlName.TabIndex = 2;
            // 
            // labelControlDesc
            // 
            this.labelControlDesc.Location = new System.Drawing.Point(31, 278);
            this.labelControlDesc.TabIndex = 14;
            // 
            // textEditId
            // 
            this.textEditId.Location = new System.Drawing.Point(73, 16);
            this.textEditId.Size = new System.Drawing.Size(233, 21);
            this.textEditId.TabIndex = 1;
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(73, 53);
            this.textEditName.Size = new System.Drawing.Size(233, 21);
            this.textEditName.TabIndex = 3;
            // 
            // memoEditDesc
            // 
            this.memoEditDesc.Location = new System.Drawing.Point(73, 275);
            this.memoEditDesc.Size = new System.Drawing.Size(233, 76);
            this.memoEditDesc.TabIndex = 15;
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
            this.dateTimePickerEntryTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "入职时间：";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Location = new System.Drawing.Point(73, 127);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxPosition.Size = new System.Drawing.Size(233, 21);
            this.comboBoxPosition.TabIndex = 7;
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(26, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "岗位：";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(26, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "主管：";
            // 
            // comboBoxLeader
            // 
            this.comboBoxLeader.Location = new System.Drawing.Point(73, 201);
            this.comboBoxLeader.Name = "comboBoxLeader";
            this.comboBoxLeader.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxLeader.Size = new System.Drawing.Size(233, 21);
            this.comboBoxLeader.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "工资级别：";
            // 
            // comboBoxSalaryLevel
            // 
            this.comboBoxSalaryLevel.Location = new System.Drawing.Point(73, 164);
            this.comboBoxSalaryLevel.Name = "comboBoxSalaryLevel";
            this.comboBoxSalaryLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxSalaryLevel.Size = new System.Drawing.Size(233, 21);
            this.comboBoxSalaryLevel.TabIndex = 9;
            // 
            // dateEditDismissionTime
            // 
            this.dateEditDismissionTime.EditValue = null;
            this.dateEditDismissionTime.Location = new System.Drawing.Point(73, 238);
            this.dateEditDismissionTime.Name = "dateEditDismissionTime";
            this.dateEditDismissionTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDismissionTime.Properties.NullDate = new System.DateTime(1753, 1, 1, 22, 42, 0, 0);
            this.dateEditDismissionTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditDismissionTime.Size = new System.Drawing.Size(233, 21);
            this.dateEditDismissionTime.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 241);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "离职时间：";
            // 
            // EmployeePropertyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateEditDismissionTime);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.comboBoxSalaryLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxLeader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerEntryTime);
            this.Name = "EmployeePropertyControl";
            this.Size = new System.Drawing.Size(324, 366);
            this.FillControls += new SalarySystem.Managment.Editor.FillControls(this.EmployeePropertyControl_FillControls);
            this.Retrive += new SalarySystem.Managment.Editor.Retrive(this.EmployeePropertyControl_Retrive);
            this.Load += new System.EventHandler(this.EmployeePropertyControl_Load);
            this.Controls.SetChildIndex(this.dateTimePickerEntryTime, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.comboBoxPosition, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.comboBoxLeader, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.comboBoxSalaryLevel, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.dateEditDismissionTime, 0);
            this.Controls.SetChildIndex(this.memoEditDesc, 0);
            this.Controls.SetChildIndex(this.labelControlId, 0);
            this.Controls.SetChildIndex(this.labelControlName, 0);
            this.Controls.SetChildIndex(this.labelControlDesc, 0);
            this.Controls.SetChildIndex(this.textEditId, 0);
            this.Controls.SetChildIndex(this.textEditName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEntryTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEntryTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxLeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxSalaryLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDismissionTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDismissionTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateEdit dateTimePickerEntryTime;
        private LabelControl label3;
        private ComboBoxEdit comboBoxPosition;
        private LabelControl label4;
        private LabelControl label5;
        private ComboBoxEdit comboBoxLeader;
        private LabelControl label6;
        private ComboBoxEdit comboBoxSalaryLevel;
        private DateEdit dateEditDismissionTime;
        private LabelControl labelControl1;
        
    }
}
