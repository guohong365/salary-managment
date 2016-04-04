using System.Windows.Forms;

namespace SalarySystem.Managment
{
    public class ManagmentControl : IManagmentControl
    {
        private readonly Control _thisControl;

        public ManagmentControl(Control thisControl, IManagmentControlContainer container)
        {
            _thisControl = thisControl;
            Container = container;
        }

        public virtual Control Control
        {
            get { return _thisControl; }
        }

        public bool Dirty { get; set; }

        public IManagmentControlContainer Container { get; private set; }
        public event ManagmentControlPreAction Applying;

        protected virtual bool onApplying()
        {
            ManagmentControlPreAction handler = Applying;
            if (handler != null) 
                return handler(this);
            return true;
        }

        public event ManagmentControlAction Applied;

        protected virtual void onApplied()
        {
            ManagmentControlAction handler = Applied;
            if (handler != null) handler(this);
        }

        public event ManagmentControlPreAction Reverting;

        protected virtual bool onReverting()
        {
            ManagmentControlPreAction handler = Reverting;
            if (handler != null) 
                return handler(this);
            return true;
        }

        public event ManagmentControlAction Reverted;

        protected virtual void onReverted()
        {
            ManagmentControlAction handler = Reverted;
            if (handler != null) handler(this);
        }

        public event ManagmentControlPreAction Closing;

        protected virtual bool onClosing()
        {
            ManagmentControlPreAction handler = Closing;
            if (handler != null)
                return handler(this);
            return true;
        }

        public event ManagmentControlAction Closed;
        public virtual void Apply()
        {
            if (onApplying())
            {
                onApplied();
            }
        }

        public void Revert()
        {
            if (onReverting())
            {
                onReverted();
            }
        }

        public void Close()
        {
            if (onClosing())
            {   
                onClosed();
            }
        }

        public bool TryClose()
        {
            if (!Dirty) return true;
            DialogResult result = MessageBox.Show(_thisControl, "数据已修改，是否保存？", "警告", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
            switch (result)
            {
                case DialogResult.Yes:
                    Apply();
                    return true;
                case DialogResult.No:
                    Revert();
                    return true;
                case DialogResult.Cancel:
                    return false;
            }
            return true;
        }

        protected virtual void onClosed()
        {
            ManagmentControlAction handler = Closed;
            if (handler != null) handler(this);
        }
     }
}