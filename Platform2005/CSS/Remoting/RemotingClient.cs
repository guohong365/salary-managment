namespace Platform.CSS.Remoting
{
    using Platform.CSS;
    using Platform.CSS.Communication;
    using Platform.Tracing;
    using System;

    public sealed class RemotingClient
    {
        public static object RemoteExecute(string fullMethodName, byte[] parametersDirect, object[] parameters)
        {
            return RemoteExecute(CSSConfig.CommunicationClientDefaultSetting, fullMethodName, parametersDirect, parameters);
        }

        public static object RemoteExecute(string settingName, string fullMethodName, byte[] parametersDirect, object[] parameters)
        {
            object returnResult;
            TraceHelper.WriteMessage("���÷�����" + fullMethodName);
            long ticks = DateTime.Now.Ticks;
            try
            {
                RemotingPacket packet = new RemotingPacket();
                packet.FullMethodName = fullMethodName;
                packet.ParametersDirect = parametersDirect;
                packet.Parameters = parameters;
                packet.ReturnResult = null;
                RemotingPacket packet2 = ClientCommunication.SendPacket(settingName, packet, false) as RemotingPacket;
                if (packet2 == null)
                {
                    throw new Exception("���ã�" + fullMethodName + " -- ͨѶ�쳣");
                }
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parametersDirect[i] != 0)
                    {
                        parameters[i] = packet2.Parameters[i];
                    }
                }
                returnResult = packet2.ReturnResult;
            }
            finally
            {
                long num3 = DateTime.Now.Ticks;
                TimeSpan span = new TimeSpan(num3 - ticks);
                TraceHelper.WriteLine(" -- ����ִ��ʱ�䣺" + span.TotalSeconds);
            }
            return returnResult;
        }

        public static object RemoteExecute(string typeName, string method, string paramsTypes, byte[] parametersDirect, object[] parameters)
        {
            return RemoteExecute(CSSConfig.CommunicationClientDefaultSetting, typeName, method, paramsTypes, parametersDirect, parameters);
        }

        public static object RemoteExecute(string settingName, string typeName, string method, string paramsTypes, byte[] parametersDirect, object[] parameters)
        {
            return RemoteExecute(settingName, typeName + "::" + method + "(" + paramsTypes + ")", parametersDirect, parameters);
        }
    }
}
