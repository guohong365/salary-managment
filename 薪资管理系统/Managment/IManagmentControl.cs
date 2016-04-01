using System;

namespace SalarySystem.Managment
{
    public delegate void ManagmentControlAction(object sender);

    public delegate bool ManagmentControlPreAction(object sender);

    public interface IManagmentControl: IDisposable
    {
        IManagmentControlContainer Container { get; }
        event ManagmentControlPreAction Applying;
        event ManagmentControlAction Applied;
        event ManagmentControlPreAction Reverting;
        event ManagmentControlAction Reverted;
        event ManagmentControlPreAction Closing;
        event ManagmentControlAction Closed;
        bool Apply();
        bool Revert();
        bool Close();
        bool SelfClose();
    }
}
