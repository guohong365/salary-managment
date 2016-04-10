namespace Platform.ExceptionHandling
{
    using Platform.CSS;
    using Platform.CSS.SerialSink;
    using Platform.Identity;
    using Platform.Log;
    using Platform.Task.QueueTask;
    using Platform.Tracing;
    using Platform.Utils;
    using System;
    using System.Text;

    [QueueTaskSink("PlatformExpLog"), StackTracePass]
    public sealed class ExceptionHelper : FileLogBase, IQueueTaskSink
    {
        static ExceptionHelper()
        {
            ExceptionHelper sink = new ExceptionHelper();
            QueueTaskManager.RegisterQueueTaskSink(sink);
        }

        private static string GetExceptionInformation(Exception exp)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\r\n�쳣���ͣ�");
            builder.Append(exp.GetType());
            builder.Append("\r\n�쳣ԭ��");
            builder.Append(exp.Message);
            builder.Append("\r\n�쳣��ջ��\r\n");
            builder.Append(exp.StackTrace);
            builder.Append("\r\n�����ջ��\r\n");
            builder.Append(StackTraceUtility.GetStack());
            if (exp.InnerException != null)
            {
                builder.Append("\r\n�ڲ��쳣��");
                builder.Append(GetExceptionInformation(exp.InnerException));
            }
            return builder.ToString();
        }

        public static void HandleException(Exception exp)
        {
            HandleException(exp, null);
        }

        public static void HandleException(Exception exp, params string[] addedMessage)
        {
            bool flag = exp.GetType() == typeof(SecuritySerialSinkException);
            if ((!flag || CSSConfig.WriteSecurityLog) || CSSConfig.WriteSecurityConsoleLog)
            {
                try
                {
                    IUser currentThreadUser = UserManager.GetCurrentThreadUser();
                    string logMessage = ("�쳣�û���" + ((currentThreadUser == null) ? "���û���Ϣ" : currentThreadUser.ToString())) + "\r\n�쳣ʱ�䣺" + PlatformDateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    if (addedMessage != null)
                    {
                        logMessage = logMessage + "\r\n������Ϣ��";
                        for (int i = 0; i < addedMessage.Length; i++)
                        {
                            logMessage = logMessage + "\r\n" + addedMessage[i];
                        }
                    }
                    logMessage = logMessage + GetExceptionInformation(exp);
                    if (!flag || CSSConfig.WriteSecurityConsoleLog)
                    {
                        TraceHelper.WriteLine(logMessage);
                    }
                    if (!flag || CSSConfig.WriteSecurityLog)
                    {
                        QueueTaskManager.EnqueueTask("PlatformExpLog", new object[] { logMessage });
                    }
                }
                catch
                {
                }
            }
        }

        public void ProcessTask(params object[] infos)
        {
            try
            {
                if ((infos != null) && (infos.Length >= 1))
                {
                    string msg = (string)infos[0];
                    base.WriteLogFileMessage(msg);
                }
            }
            catch (Exception exception)
            {
                TraceHelper.WriteLine("Write PlatformExpLog:" + exception.Message);
            }
        }

        protected override string LogFileNameBase
        {
            get
            {
                return "Exception";
            }
        }

        public static int TaskCount
        {
            get
            {
                return QueueTaskManager.GetTaskCount("PlatformExpLog");
            }
        }
    }
}
