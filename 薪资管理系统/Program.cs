using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace SalarySystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OfficeSkins.Register();
            BonusSkins.Register();
            //SkinManager.EnableFormSkins();
            //SkinManager.EnableFormSkinsIfNotVista();

            if (!SystemInitalizer.Init())
            {
                MessageBox.Show("初始化失败，系统终止！");
                return;
            }
            try
            {
                Application.Run(new MainForm());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
