namespace Platform.CSS.Communication
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class ClientCommunicationTimesOutPromptDlg : Form
    {
        private Button button_Cancel;
        private Button button_Retry;
        private Button button1;
        private Container components;
        private Label label_Prompt;
        private Label label_Retry_Prompt;

        public ClientCommunicationTimesOutPromptDlg(int resendTimes, int resendCount, int receivedCount)
        {
            this.InitializeComponent();
            this.label_Prompt.Text = string.Concat(new object[] { "�Ѿ����� ", resendTimes, " �Σ��������� ", receivedCount, " �ֽ�" });
            this.label_Retry_Prompt.Text = "�Ƿ�������� " + resendCount + " �Σ�";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            this.label_Prompt = new Label();
            this.button_Retry = new Button();
            this.button_Cancel = new Button();
            this.label_Retry_Prompt = new Label();
            this.button1 = new Button();
            base.SuspendLayout();
            this.label_Prompt.Location = new Point(8, 8);
            this.label_Prompt.Name = "label_Prompt";
            this.label_Prompt.Size = new Size(240, 0x18);
            this.label_Prompt.TabIndex = 0;
            this.label_Prompt.TextAlign = ContentAlignment.MiddleLeft;
            this.button_Retry.DialogResult = DialogResult.Retry;
            this.button_Retry.FlatStyle = FlatStyle.Popup;
            this.button_Retry.Location = new Point(8, 0x48);
            this.button_Retry.Name = "button_Retry";
            this.button_Retry.TabIndex = 1;
            this.button_Retry.Text = "����";
            this.button_Cancel.DialogResult = DialogResult.Cancel;
            this.button_Cancel.FlatStyle = FlatStyle.Popup;
            this.button_Cancel.Location = new Point(0xa8, 0x48);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "ȡ��";
            this.label_Retry_Prompt.Location = new Point(8, 40);
            this.label_Retry_Prompt.Name = "label_Retry_Prompt";
            this.label_Retry_Prompt.Size = new Size(240, 0x18);
            this.label_Retry_Prompt.TabIndex = 3;
            this.label_Retry_Prompt.TextAlign = ContentAlignment.MiddleLeft;
            this.button1.DialogResult = DialogResult.Abort;
            this.button1.FlatStyle = FlatStyle.Popup;
            this.button1.Location = new Point(0x58, 0x48);
            this.button1.Name = "button1";
            this.button1.TabIndex = 4;
            this.button1.Text = "��������";
            base.AcceptButton = this.button_Retry;
            this.AutoScaleBaseSize = new Size(6, 14);
            base.CancelButton = this.button_Cancel;
            base.ClientSize = new Size(250, 0x67);
            base.ControlBox = false;
            base.Controls.Add(this.button1);
            base.Controls.Add(this.label_Retry_Prompt);
            base.Controls.Add(this.button_Cancel);
            base.Controls.Add(this.button_Retry);
            base.Controls.Add(this.label_Prompt);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ClientCommunicationTimesOutPromptDlg";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ͨѶ���Գ����޶�����";
            base.TopMost = true;
            base.ResumeLayout(false);
        }
    }
}
