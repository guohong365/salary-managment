﻿using System.Windows.Forms;

namespace SalarySystem
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
