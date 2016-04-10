namespace Platform.Log
{
    using Platform;
    using Platform.IO;
    using Platform.Tracing;
    using Platform.Utils;
    using System;
    using System.IO;

    public abstract class FileLogBase
    {
        private StreamWriter m_LogFile;
        private string m_LogFileDate;

        protected bool SetupLogFile()
        {
            bool flag;
            try
            {
                lock (this)
                {
                    string text = PlatformDateTime.Now.ToString("yyyy-MM-dd");
                    if ((this.m_LogFileDate == null) || (this.m_LogFileDate != text))
                    {
                        if (this.m_LogFile != null)
                        {
                            this.m_LogFile.Flush();
                            this.m_LogFile.Close();
                            this.m_LogFile = null;
                        }
                        this.m_LogFileDate = text;
                        string path = PlatformConfig.BasePath + @"\Log";
                        PathUtility.MakeDirectory(path);
                        string text3 = path + @"\" + this.LogFileNameBase + " " + this.m_LogFileDate + ".txt";
                        this.m_LogFile = new StreamWriter(text3, true, PlatformConfig.TextEncoding);
                        TraceHelper.WriteLine("������־�ļ���" + text3);
                        this.m_LogFile.WriteLine();
                        this.m_LogFile.WriteLine("---- ��ʼ��¼������־��" + PlatformDateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    flag = true;
                }
            }
            catch (Exception exception)
            {
                TraceHelper.WriteLine("������¼�ļ�����" + PlatformConfig.BasePath + @"\Log\" + this.LogFileNameBase + " " + this.m_LogFileDate + ".txt" + exception.Message);
                flag = false;
            }
            return flag;
        }

        protected void WriteLogFileMessage(string msg)
        {
            if (this.SetupLogFile())
            {
                lock (this.m_LogFile)
                {
                    this.m_LogFile.WriteLine(msg);
                    this.m_LogFile.Flush();
                }
            }
        }

        protected abstract string LogFileNameBase { get; }
    }
}
