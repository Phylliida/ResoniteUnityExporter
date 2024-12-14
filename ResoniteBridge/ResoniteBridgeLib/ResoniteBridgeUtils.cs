using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

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

        static JsonSerializer serializer = new JsonSerializer();
        static ResoniteBridgeUtils()
        {
            serializer.NullValueHandling = NullValueHandling.Ignore;
        }

        public static byte[] EncodeObject(object obj)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                using (BsonDataWriter writer = new BsonDataWriter(ms))
                {
                    serializer.Serialize(writer, obj);
                    return ms.ToArray();
                }
            }
        }

        public static object DecodeObject(byte[] bytes, System.Type t)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                using (BsonDataReader reader = new BsonDataReader(ms))
                {
                    return serializer.Deserialize(reader, t);
                }
            }
        }
    }
}