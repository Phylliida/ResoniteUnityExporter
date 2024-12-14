using System.Text;

namespace ResoniteBridge
{
    public static class ResoniteBridgeUtils {
        public static UnicodeEncoding stringEncoding = new UnicodeEncoding();
        public static byte[] EncodeString(string str)
        {
            return stringEncoding.GetBytes(str);
        }

        public static string DecodeString(byte[] bytes)
        {
            return stringEncoding.GetString(bytes);
        }
    }
}