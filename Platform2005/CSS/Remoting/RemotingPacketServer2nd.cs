namespace Platform.CSS.Remoting
{
    using Platform.CSS;
    using Platform.CSS.Communication;
    using Platform.CSS.Communication.Packet;
    using Platform.CSS.Communication.PacketHandler;
    using Platform.Identity;
    using Platform.Log;
    using Platform.Tracing;
    using System;
    using System.Collections;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class RemotingPacketServer2nd : ICommunicationPacketHandler
    {
        private Hashtable m_RemoteMethodTable = new Hashtable();

        public static event AfterRemoteCallEventHandler AfterRemoteCall;

        public static event BeforeRemoteCallEventHandler BeforeRemoteCall;

        public CommunicationPacketBase HandlePacket(Guid packetID, CommunicationPacketBase packet)
        {
            RemotingPacket2nd packetnd = packet as RemotingPacket2nd;
            long ticks = DateTime.Now.Ticks;
            bool hasException = false;
            try
            {
                if (BeforeRemoteCall != null)
                {
                    BeforeRemoteCall(packetID, packetnd.FullMethodName, packetnd.Parameters);
                }
            }
            catch
            {
            }
            try
            {
                packetnd.ReturnResult = this.Invoke(packetnd.FullMethodName, packetnd.Parameters);
            }
            catch (Exception exception)
            {
                hasException = true;
                throw exception;
            }
            finally
            {
                try
                {
                    long num2 = DateTime.Now.Ticks;
                    IUser currentThreadUser = UserManager.GetCurrentThreadUser();
                    string userInfo = (currentThreadUser == null) ? packetnd.IPEndPoint.ToString() : currentThreadUser.ToString();
                    TimeSpan span = new TimeSpan(num2 - ticks);
                    OperationLogSink.Write(userInfo, packetnd.FullMethodName, "ִ��ʱ�� " + span.TotalSeconds + " ��");
                }
                catch
                {
                }
                try
                {
                    if (AfterRemoteCall != null)
                    {
                        AfterRemoteCall(packetID, packetnd.FullMethodName, hasException);
                    }
                }
                catch
                {
                }
            }
            for (int i = 0; i < packetnd.ParametersDirect.Length; i++)
            {
                if (packetnd.ParametersDirect[i] == 0)
                {
                    packetnd.Parameters[i] = null;
                }
            }
            return packetnd;
        }

        public void InstanceLoadAssemblyRemotingAssemblies()
        {
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                this.InstanceRegisterRemotingAssembly(assembly);
            }
        }

        public void InstanceRegisterRemotingAssembly(Assembly asm)
        {
            int registedCount = 0;
            Remote2ndClassAssemblyAttribute[] customAttributes = asm.GetCustomAttributes(typeof(Remote2ndClassAssemblyAttribute), false) as Remote2ndClassAssemblyAttribute[];
            if (customAttributes.Length >= 1)
            {
                foreach (Remote2ndClassAssemblyAttribute attribute in customAttributes)
                {
                    this.InstanceRegisterRemotingClass(attribute.Type, out registedCount);
                }
            }
        }

        public void InstanceRegisterRemotingClass(Type type)
        {
            int num;
            this.InstanceRegisterRemotingClass(type, out num);
        }

        public void InstanceRegisterRemotingClass(Type type, out int registedCount)
        {
            registedCount = 0;
            RemotingClassAttribute[] customAttributes = type.GetCustomAttributes(typeof(RemotingClassAttribute), false) as RemotingClassAttribute[];
            if (customAttributes.Length >= 1)
            {
                string name = customAttributes[0].Name;
                switch (name)
                {
                    case null:
                    case "":
                        name = type.Name;
                        break;
                }
                string text2 = customAttributes[0].Namespace;
                if ((text2 == null) || (text2 == ""))
                {
                    text2 = type.Namespace;
                }
                object obj2 = Activator.CreateInstance(type);
                foreach (MethodInfo info in type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                    UnRemotingAttribute[] attributeArray2 = info.GetCustomAttributes(typeof(UnRemotingAttribute), false) as UnRemotingAttribute[];
                    if (attributeArray2.Length <= 0)
                    {
                        string key = null;
                        RemotingMethodAttribute[] attributeArray3 = info.GetCustomAttributes(typeof(RemotingMethodAttribute), false) as RemotingMethodAttribute[];
                        if ((attributeArray3 != null) && (attributeArray3.Length > 0))
                        {
                            key = attributeArray3[0].FullName;
                        }
                        if (key == null)
                        {
                            ParameterInfo[] parameters = info.GetParameters();
                            if (parameters == null)
                            {
                                goto Label_01D6;
                            }
                            string text4 = "";
                            for (int i = 0; i < parameters.Length; i++)
                            {
                                text4 = text4 + parameters[i].ParameterType.Name;
                                if (i < (parameters.Length - 1))
                                {
                                    text4 = text4 + ",";
                                }
                            }
                            key = text2 + "+" + name + "::" + info.Name + "(" + text4 + ")";
                        }
                        RemoteCallItem item = new RemoteCallItem(info.IsStatic ? null : obj2, info);
                        if (this.m_RemoteMethodTable.ContainsKey(key))
                        {
                            TraceHelper.WriteLine("���󣺴����ظ��ĵ��ýӿڣ�" + key);
                        }
                        this.m_RemoteMethodTable[key] = item;
                        registedCount++;
                    Label_01D6: ;
                    }
                }
                TraceHelper.WriteLine(string.Concat(new object[] { "����Remote�ӿڴ���", type.FullName, "��ɣ��ӿ�����", (int)registedCount }));
            }
        }

        private object Invoke(string fullMethodName, object[] parameters)
        {
            RemoteCallItem item = this.m_RemoteMethodTable[fullMethodName] as RemoteCallItem;
            if (item == null)
            {
                throw new Exception("��Ч���÷�����" + fullMethodName);
            }
            return item.Method.Invoke(item.Instance, parameters);
        }

        public static void LoadAssemblyRemotingAssemblies()
        {
            LoadAssemblyRemotingAssemblies(CSSConfig.CommunicationServerDefaultSetting);
        }

        public static void LoadAssemblyRemotingAssemblies(string settingName)
        {
            RemotingPacketServer2nd communicationPacketHandler = ServerCommunication.GetCommunicationPacketHandler(settingName, typeof(RemotingPacket2nd)) as RemotingPacketServer2nd;
            if (communicationPacketHandler != null)
            {
                communicationPacketHandler.InstanceLoadAssemblyRemotingAssemblies();
            }
        }

        public static void RegisterRemotingAssembly(Assembly asm)
        {
            RegisterRemotingAssembly(CSSConfig.CommunicationServerDefaultSetting, asm);
        }

        public static void RegisterRemotingAssembly(string settingName, Assembly asm)
        {
            RemotingPacketServer2nd communicationPacketHandler = ServerCommunication.GetCommunicationPacketHandler(settingName, typeof(RemotingPacket2nd)) as RemotingPacketServer2nd;
            if (communicationPacketHandler != null)
            {
                communicationPacketHandler.InstanceRegisterRemotingAssembly(asm);
            }
        }

        public static void RegisterRemotingClass(Type type)
        {
            RegisterRemotingClass(CSSConfig.CommunicationServerDefaultSetting, type);
        }

        public static void RegisterRemotingClass(string settingName, Type type)
        {
            RemotingPacketServer2nd communicationPacketHandler = ServerCommunication.GetCommunicationPacketHandler(settingName, typeof(RemotingPacket2nd)) as RemotingPacketServer2nd;
            if (communicationPacketHandler != null)
            {
                communicationPacketHandler.InstanceRegisterRemotingClass(type);
            }
        }

        public static void RegisterRemotingClass(Type type, out int registedCount)
        {
            RegisterRemotingClass(CSSConfig.CommunicationServerDefaultSetting, type, out registedCount);
        }

        public static void RegisterRemotingClass(string settingName, Type type, out int registedCount)
        {
            RemotingPacketServer2nd communicationPacketHandler = ServerCommunication.GetCommunicationPacketHandler(settingName, typeof(RemotingPacket2nd)) as RemotingPacketServer2nd;
            if (communicationPacketHandler == null)
            {
                registedCount = 0;
            }
            else
            {
                communicationPacketHandler.InstanceRegisterRemotingClass(type, out registedCount);
            }
        }

        public bool CacheResult
        {
            get
            {
                return true;
            }
        }

        public bool IsBroadcastHandler
        {
            get
            {
                return false;
            }
        }

        internal sealed class RemoteCallItem
        {
            public object Instance;
            public MethodInfo Method;

            public RemoteCallItem(object instance, MethodInfo method)
            {
                this.Method = method;
                this.Instance = instance;
            }
        }
    }
}
