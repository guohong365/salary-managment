using System.Collections.Generic;
using System.Windows.Forms;

namespace SalarySystem.Managment.Basic
{
    public interface INavBarContorlManager
    {
        Control ContainerControl { get; }
        List<NavGroupDefine> NavGroupDefines { get; }
        void InitNavBar();
    }
}