using SalarySystem.Execute;

namespace SalarySystem.Definition
{
    public delegate void ManagmentControlAction(object sender);

    public delegate bool ManagmentControlPreAction(object sender);

    public interface IManagmentControl
    {
        bool Dirty { get; set; }
        IManagmentControlContainer Container { get; }
        event ManagmentControlPreAction Applying;
        event ManagmentControlAction Applied;
        event ManagmentControlPreAction Reverting;
        event ManagmentControlAction Reverted;
        event ManagmentControlPreAction Closing;
        event ManagmentControlAction Closed;
        void Apply();
        void Revert();
        void Close();
        bool TryClose();
    }
}
