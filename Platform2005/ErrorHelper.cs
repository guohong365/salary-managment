namespace Platform
{
    using System;
    using System.Collections;

    public sealed class ErrorHelper
    {
        public const int COMMERR_CONNECTION_FAILED = 0xc9;
        public const int COMMERR_GETCHANNEL_FAILED = 0xcc;
        public const int COMMERR_GETCHANNELS_FAILED = 0xcb;
        public const int COMMERR_SERIAL_FAILED = 0xcd;
        public const int COMMERR_SETTINGNAME_EMPTY = 0xca;
        public const int COMMERR_START = 200;
        public const int ERR_PLATFORM = 100;
        public const int ERR_SUCCEED = 0;
        private static Hashtable m_Errors = new Hashtable();
        public const int SERIALERR_CLSID_NOFOUND = 0x131;
        public const int SERIALERR_CLSID_NOREGISTED = 0x132;
        public const int SERIALERR_CLSID_READ = 0x130;
        public const int SERIALERR_DESERIAL = 0x12f;
        public const int SERIALERR_EXCEPTION = 0x12d;
        public const int SERIALERR_READDATA = 0x12e;
        public const int SERIALERR_SINK = 0x133;
        public const int SERIALERR_START = 300;

        static ErrorHelper()
        {
            m_Errors[0] = "�����ɹ�";
            m_Errors[0xc9] = "����ʧ��";
            m_Errors[0xca] = "������Ϊ��";
            m_Errors[0xcb] = "��ȡ����ͨ��ʧ��";
            m_Errors[0xcc] = "��ȡͨѶͨ��ʧ��";
            m_Errors[0xcd] = "���л����ݴ���";
            m_Errors[0xcc] = "��ȡͨѶͨ��ʧ��";
        }
    }
}
