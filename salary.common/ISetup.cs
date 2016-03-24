using System.Windows.Forms;

namespace salary
{
    public interface ISetup
    {
        int Save();
        int Init();
        int Check();
        string GetErrorMessage(int error);
        UserControl GetControl();
        void Deinit();
    }
}
