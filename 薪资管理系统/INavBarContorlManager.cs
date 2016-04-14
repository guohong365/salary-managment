using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraNavBar;

namespace SalarySystem
{
    public interface INavBarContorlManager
    {
        Control ContainerControl { get; set; }
        List<NavGroupDefine> NavGroupDefines { get; }
        NavBarControl NavBarControl { get; set; }
        void InitNavBar();
    }
}