using System;

namespace SalarySystem.Managment
{
    public delegate void ChildClosedNotification(object sender);
    public interface IManagmentControlContainer: IDisposable
    {
        IManagmentControl ManagmentControl { get; }
        void CloseMangmentControl();
        void ChildClosed();
    }

    public class ManagmentControlContrainer : IManagmentControlContainer
    {
         IManagmentControl _managmentControl;

        public ManagmentControlContrainer(IManagmentControl managmentControl)
        {
            _managmentControl = managmentControl;
        }

        public void Dispose()
        {
            _managmentControl = null;
        }

        public IManagmentControl ManagmentControl { get { return _managmentControl; } }

        public void CloseMangmentControl()
        {
            _managmentControl.Close();
        }

        public void ChildClosed()
        {
        }
    }
}
