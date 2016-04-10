using System;
using System.Windows.Forms;

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
            if (!SystemInitalizer.Init())
            {
                MessageBox.Show("初始化失败，系统终止！");
                return;
            }

            Application.Run(new MainForm());
        }
    }
}
