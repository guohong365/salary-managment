namespace SalarySystem.Execute
{
    partial class EvaluationPerformanceControl
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
            this.evalFormsControl1 = new SalarySystem.Execute.EvalFormsControl();
            this.SuspendLayout();
            // 
            // evalFormsControl1
            // 
            this.evalFormsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evalFormsControl1.EmployeePerformance = null;
            this.evalFormsControl1.Location = new System.Drawing.Point(0, 0);
            this.evalFormsControl1.Margin = new System.Windows.Forms.Padding(0);
            this.evalFormsControl1.Name = "evalFormsControl1";
            this.evalFormsControl1.Size = new System.Drawing.Size(675, 495);
            this.evalFormsControl1.TabIndex = 0;
            // 
            // EvaluationPerformanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.evalFormsControl1);
            this.Name = "EvaluationPerformanceControl";
            this.Size = new System.Drawing.Size(675, 495);
            this.ResumeLayout(false);

        }

        #endregion

        private EvalFormsControl evalFormsControl1;
    }
}
