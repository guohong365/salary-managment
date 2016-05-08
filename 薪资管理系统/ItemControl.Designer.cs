namespace SalarySystem
{
    partial class ItemControl
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
            this.labelControlId = new DevExpress.XtraEditors.LabelControl();
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDesc = new DevExpress.XtraEditors.LabelControl();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.memoEditDesc = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlId
            // 
            this.labelControlId.Location = new System.Drawing.Point(26, 19);
            this.labelControlId.Name = "labelControlId";
            this.labelControlId.Size = new System.Drawing.Size(36, 14);
            this.labelControlId.TabIndex = 0;
            this.labelControlId.Text = "编号：";
            // 
            // labelControlName
            // 
            this.labelControlName.Location = new System.Drawing.Point(26, 54);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(36, 14);
            this.labelControlName.TabIndex = 2;
            this.labelControlName.Text = "名称：";
            // 
            // labelControlDesc
            // 
            this.labelControlDesc.Location = new System.Drawing.Point(26, 93);
            this.labelControlDesc.Name = "labelControlDesc";
            this.labelControlDesc.Size = new System.Drawing.Size(36, 14);
            this.labelControlDesc.TabIndex = 4;
            this.labelControlDesc.Text = "描述：";
            // 
            // textEditId
            // 
            this.textEditId.Location = new System.Drawing.Point(68, 16);
            this.textEditId.Name = "textEditId";
            this.textEditId.Size = new System.Drawing.Size(216, 21);
            this.textEditId.TabIndex = 1;
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(68, 51);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(216, 21);
            this.textEditName.TabIndex = 3;
            // 
            // memoEditDesc
            // 
            this.memoEditDesc.Location = new System.Drawing.Point(68, 91);
            this.memoEditDesc.Name = "memoEditDesc";
            this.memoEditDesc.Size = new System.Drawing.Size(216, 96);
            this.memoEditDesc.TabIndex = 5;
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memoEditDesc);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.textEditId);
            this.Controls.Add(this.labelControlDesc);
            this.Controls.Add(this.labelControlName);
            this.Controls.Add(this.labelControlId);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(312, 209);
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDesc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.LabelControl labelControlId;
        protected DevExpress.XtraEditors.LabelControl labelControlName;
        protected DevExpress.XtraEditors.LabelControl labelControlDesc;
        protected DevExpress.XtraEditors.TextEdit textEditId;
        protected DevExpress.XtraEditors.TextEdit textEditName;
        protected DevExpress.XtraEditors.MemoEdit memoEditDesc;
    }
}
