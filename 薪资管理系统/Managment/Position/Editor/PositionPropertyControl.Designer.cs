namespace SalarySystem.Managment.Position.Editor
{
    partial class PositionPropertyControl
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditLeaderPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLeaderPosition.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlId
            // 
            this.labelControlId.Location = new System.Drawing.Point(27, 19);
            // 
            // labelControlName
            // 
            this.labelControlName.Location = new System.Drawing.Point(27, 53);
            // 
            // labelControlDesc
            // 
            this.labelControlDesc.Location = new System.Drawing.Point(27, 121);
            // 
            // textEditId
            // 
            this.textEditId.Location = new System.Drawing.Point(69, 16);
            this.textEditId.Size = new System.Drawing.Size(215, 21);
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(69, 50);
            this.textEditName.Size = new System.Drawing.Size(215, 21);
            // 
            // memoEditDesc
            // 
            this.memoEditDesc.Location = new System.Drawing.Point(69, 118);
            this.memoEditDesc.Size = new System.Drawing.Size(215, 96);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "上级岗位：";
            // 
            // comboBoxEditLeaderPosition
            // 
            this.comboBoxEditLeaderPosition.Location = new System.Drawing.Point(69, 84);
            this.comboBoxEditLeaderPosition.Name = "comboBoxEditLeaderPosition";
            this.comboBoxEditLeaderPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditLeaderPosition.Size = new System.Drawing.Size(215, 21);
            this.comboBoxEditLeaderPosition.TabIndex = 7;
            // 
            // PositionPropertyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxEditLeaderPosition);
            this.Controls.Add(this.labelControl1);
            this.Name = "PositionPropertyControl";
            this.Size = new System.Drawing.Size(298, 232);
            this.FillControls += new SalarySystem.Managment.Editor.FillControls(this.PositionPropertyControl_FillControls);
            this.Retrive += new SalarySystem.Managment.Editor.Retrive(this.PositionPropertyControl_Retrive);
            this.Controls.SetChildIndex(this.labelControlId, 0);
            this.Controls.SetChildIndex(this.labelControlName, 0);
            this.Controls.SetChildIndex(this.labelControlDesc, 0);
            this.Controls.SetChildIndex(this.textEditId, 0);
            this.Controls.SetChildIndex(this.textEditName, 0);
            this.Controls.SetChildIndex(this.memoEditDesc, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.comboBoxEditLeaderPosition, 0);
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLeaderPosition.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditLeaderPosition;
    }
}
