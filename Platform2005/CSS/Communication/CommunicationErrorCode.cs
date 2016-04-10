namespace Platform.CSS.Communication
{
    using Platform.Configuration;
    using System;
    using System.Collections;

    public sealed class CommunicationErrorCode
    {
        [ConfigCollectionItem("/CommunicationErrorCode", null, null, typeof(string))]
        private static Hashtable m_CommunicationErrorCode = null;

        private static void BeforeInitialize()
        {
        }

        public static string GetErrorMessage(int code)
        {
            if (m_CommunicationErrorCode == null)
            {
                 return ("δ֪���󣡣�������� " + code + "��");
            }
            string text = m_CommunicationErrorCode[code.ToString()] as string;
            if (text == null)
            {
                return ("δ֪���󣡣�������� " + code + "��");
            }
            return string.Concat(new object[] { text, "��������� ", code, "��" });
        }
    }
}
