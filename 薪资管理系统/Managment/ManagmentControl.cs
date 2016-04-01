using System.Windows.Forms;

namespace SalarySystem.Managment
{
    public class ManagmentControl : IManagmentControl
    {
        private IManagmentControlContainer _container;
        private Control _thisControl;

        public ManagmentControl(Control thisControl)
        {
            _thisControl = thisControl;
        }

        public virtual Control Control
        {
            get { return _thisControl; }
        }
        
        public virtual IManagmentControlContainer Container
        {
            get { return _container; }
            set { _container = value; }
        }

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
        public virtual bool Apply()
        {
            if (onApplying())
            {
                onApplied();
                return true;
            }
            return false;
        }

        public bool Revert()
        {
            if (onReverting())
            {
                onReverted();
                return true;
            }
            return false;
        }

        public bool Close()
        {
            if (onClosing())
            {   
                onClosed();
                return true;
            }
            return false;
        }

        public bool SelfClose()
        {
            bool ret=Close();
            _container.ChildClosed();
            return ret;
        }

        protected virtual void onClosed()
        {
            ManagmentControlAction handler = Closed;
            if (handler != null) handler(this);
        }

        public void Dispose()
        {
            _container = null;
            _thisControl = null;
        }
    }
}