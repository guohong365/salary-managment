using DevExpress.XtraEditors;

namespace salary.main.employee
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
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePickerEntryTime = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxId = new DevExpress.XtraEditors.TextEdit();
            this.textBoxName = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxLeader = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxSalaryLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEntryTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEntryTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxLeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxSalaryLevel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(55, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // dateTimePickerEntryTime
            // 
            this.dateTimePickerEntryTime.EditValue = new System.DateTime(2016, 3, 24, 0, 0, 0, 0);
            this.dateTimePickerEntryTime.Location = new System.Drawing.Point(97, 97);
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
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "入职时间：";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Location = new System.Drawing.Point(97, 137);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxPosition.Size = new System.Drawing.Size(233, 21);
            this.comboBoxPosition.TabIndex = 7;
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(55, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "岗位：";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(55, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "主管：";
            // 
            // textBoxId
            // 
            this.textBoxId.EditValue = "";
            this.textBoxId.Location = new System.Drawing.Point(97, 17);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(233, 21);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.EditValue = "";
            this.textBoxName.Location = new System.Drawing.Point(97, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(233, 21);
            this.textBoxName.TabIndex = 3;
            // 
            // comboBoxLeader
            // 
            this.comboBoxLeader.Location = new System.Drawing.Point(97, 217);
            this.comboBoxLeader.Name = "comboBoxLeader";
            this.comboBoxLeader.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxLeader.Size = new System.Drawing.Size(233, 21);
            this.comboBoxLeader.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(31, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "工资级别：";
            // 
            // comboBoxSalaryLevel
            // 
            this.comboBoxSalaryLevel.Location = new System.Drawing.Point(97, 177);
            this.comboBoxSalaryLevel.Name = "comboBoxSalaryLevel";
            this.comboBoxSalaryLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxSalaryLevel.Size = new System.Drawing.Size(233, 21);
            this.comboBoxSalaryLevel.TabIndex = 9;
            // 
            // EmployeePropertyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxSalaryLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxLeader);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerEntryTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeePropertyControl";
            this.Size = new System.Drawing.Size(373, 265);
            this.Load += new System.EventHandler(this.EmployeePropertyControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEntryTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerEntryTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxLeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxSalaryLevel.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl label1;
        private LabelControl label2;
        private DateEdit dateTimePickerEntryTime;
        private LabelControl label3;
        private ComboBoxEdit comboBoxPosition;
        private LabelControl label4;
        private LabelControl label5;
        private TextEdit textBoxId;
        private TextEdit textBoxName;
        private ComboBoxEdit comboBoxLeader;
        private LabelControl label6;
        private ComboBoxEdit comboBoxSalaryLevel;
    }
}
