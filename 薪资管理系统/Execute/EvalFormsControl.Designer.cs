namespace SalarySystem.Execute
{
    partial class EvalFormsControl
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
            this.xtraTabControlEvalForms = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlEvalForms)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControlEvalForms
            // 
            this.xtraTabControlEvalForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlEvalForms.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlEvalForms.Margin = new System.Windows.Forms.Padding(0);
            this.xtraTabControlEvalForms.Name = "xtraTabControlEvalForms";
            this.xtraTabControlEvalForms.Size = new System.Drawing.Size(729, 554);
            this.xtraTabControlEvalForms.TabIndex = 3;
            // 
            // EvalFormsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControlEvalForms);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EvalFormsControl";
            this.Size = new System.Drawing.Size(729, 554);
            this.Load += new System.EventHandler(this.onControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlEvalForms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlEvalForms;

    }
}
