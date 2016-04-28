namespace SalarySystem.Salary
{
    partial class SalaryDetailControl
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
            this.gridControlSalaryDetail = new DevExpress.XtraGrid.GridControl();
            this.gridViewSalaryDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalaryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSalaryDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 469);
            this.panelControl1.Size = new System.Drawing.Size(666, 40);
            // 
            // simpleButtonRevert
            // 
            this.simpleButtonRevert.Location = new System.Drawing.Point(586, 9);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(505, 9);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlSalaryDetail);
            this.panelControl2.Size = new System.Drawing.Size(666, 469);
            // 
            // gridControlSalaryDetail
            // 
            this.gridControlSalaryDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSalaryDetail.Location = new System.Drawing.Point(2, 2);
            this.gridControlSalaryDetail.MainView = this.gridViewSalaryDetail;
            this.gridControlSalaryDetail.Name = "gridControlSalaryDetail";
            this.gridControlSalaryDetail.Size = new System.Drawing.Size(662, 465);
            this.gridControlSalaryDetail.TabIndex = 0;
            this.gridControlSalaryDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSalaryDetail});
            // 
            // gridViewSalaryDetail
            // 
            this.gridViewSalaryDetail.GridControl = this.gridControlSalaryDetail;
            this.gridViewSalaryDetail.Name = "gridViewSalaryDetail";
            // 
            // SalaryDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SalaryDetailControl";
            this.Size = new System.Drawing.Size(666, 509);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalaryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSalaryDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlSalaryDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSalaryDetail;
    }
}
