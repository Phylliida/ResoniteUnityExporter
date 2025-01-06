using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace ResoniteBridgeLib
{
    public static class ResoniteBridgeUtils
    {
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

        /*
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

        public static T DecodeObject<T>(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                using (BsonDataReader reader = new BsonDataReader(ms))
                {
                    return serializer.Deserialize<T>(reader);
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
        */



        // custom serialization code because bson was very slow
        public static void ToByteArray(object source, byte[] destination, int offsetInDestination, int lenOfSourceInBytes)
        {
            GCHandle handle = GCHandle.Alloc(source, GCHandleType.Pinned);
            try
            {
                IntPtr pointer = handle.AddrOfPinnedObject();
                Marshal.Copy(pointer, destination, offsetInDestination, lenOfSourceInBytes);
            }
            finally
            {
                if (handle.IsAllocated)
                    handle.Free();
            }
        }

        // these could be made faster by using pointers and memcopy
        // but that's unsafe which is annoying
        public static byte[] ToByteArray<T>(T[] source) where T : struct
        {
            return ToByteArray(source, typeof(T), source.Length);
        }

        public static byte[] ToByteArray(object sourceArray, Type elementType, int sourceArrayLength)
        {
            byte[] destination = new byte[sourceArrayLength * Marshal.SizeOf(elementType)];
            ToByteArray(sourceArray, destination, 0, destination.Length);
            return destination;
        }

        
        public static T[] FromByteArray<T>(byte[] source) where T : struct
        {
            T[] destination = new T[source.Length / Marshal.SizeOf(typeof(T))];
            CopyToArray(destination, source);
            return destination;
        }

        public static ArrOut[] ConvertArray<ArrOut, ArrIn>(ArrIn[] inArr)
            where ArrIn : struct
            where ArrOut : struct
        {
            return FromByteArray<ArrOut>(ToByteArray<ArrIn>(inArr));
        }

        public static void CopyToArray<T>(T[] dest, byte[] source, int sourceOffset = 0, int numBytesToCopy = -1) where T : struct
        {
            // note: it would be nice to make dest an object but that crashes things, don't do that
            GCHandle handle = GCHandle.Alloc(dest, GCHandleType.Pinned);
            try
            {
                IntPtr pointer = handle.AddrOfPinnedObject();
                Marshal.Copy(source, sourceOffset, pointer, (numBytesToCopy >= 0) ? numBytesToCopy : source.Length);
            }
            finally
            {
                if (handle.IsAllocated)
                    handle.Free();
            }
        }
        public static void CopyArray<T1, T2>(T1[] src, T2[] dst)
            where T1 : struct
            where T2 : struct
        {
            // could be made faster using unsafe but ehh
            byte[] srcAsByte = ToByteArray(src);
            CopyToArray(dst, srcAsByte);
        }
        static string DecodeString(byte[] bytes, ref int offset)
        {
            int stringLengthInBytes = BitConverter.ToInt32(bytes, offset);
            offset += sizeof(Int32);
            string result = Encoding.UTF8.GetString(bytes, offset, stringLengthInBytes);
            offset += stringLengthInBytes;
            return result;
        }

        static void EncodeString(string str, byte[] outBytes, ref int offset, bool writeBytes)
        {
            byte[] strBytes = Encoding.UTF8.GetBytes(str);
            if (writeBytes) Buffer.BlockCopy(
                BitConverter.GetBytes(strBytes.Length), 0,
                outBytes, offset,
                sizeof(int));
            offset += sizeof(int);
            if (writeBytes) Buffer.BlockCopy(strBytes, 0, outBytes, offset, strBytes.Length);
            offset += strBytes.Length;
        }

        public static T DecodeObject<T>(byte[] bytes)
        {
            int offset = 0;
            return (T)DecodeObject(typeof(T), bytes, ref offset);
        }

        public static object DecodeObject(Type type, byte[] bytes, ref int offset)
        {
            // null check byte
            if(bytes[offset++] == 0)
            {
                return null;
            }
            object result;
            switch (type.ToString())
            {
                case "System.Single":
                    result = BitConverter.ToSingle(bytes, offset);
                    offset += sizeof(float);
                    break;
                case "System.Double":
                    result = BitConverter.ToDouble(bytes, offset);
                    offset += sizeof(double);
                    break;
                case "System.Boolean":
                    result = BitConverter.ToBoolean(bytes, offset);
                    offset += sizeof(bool);
                    break;
                case "System.Byte":
                    result = bytes[offset];
                    offset += sizeof(byte);
                    break;
                case "System.SByte":
                    result = bytes[offset];
                    offset += sizeof(sbyte);
                    break;
                case "System.Int16":
                    result = BitConverter.ToInt16(bytes, offset);
                    offset += sizeof(short);
                    break;
                case "System.UInt16":
                    result = BitConverter.ToUInt16(bytes, offset);
                    offset += sizeof(ushort);
                    break;
                case "System.Int32":
                    result = BitConverter.ToInt32(bytes, offset);
                    offset += sizeof(int);
                    break;
                case "System.UInt32":
                    result = BitConverter.ToUInt32(bytes, offset);
                    offset += sizeof(uint);
                    break;
                case "System.Int64":
                    result = BitConverter.ToInt64(bytes, offset);
                    offset += sizeof(long);
                    break;
                case "System.UInt64":
                    result = BitConverter.ToUInt64(bytes, offset);
                    offset += sizeof(ulong);
                    break;
                case "System.String":
                    return DecodeString(bytes, ref offset);
                default:
                    result = null;
                    break;
            }
            if (result != null)
            {
                return result;
            }
            if (type.IsArray)
            {
                long arrayLen = BitConverter.ToInt64(bytes, offset);
                offset += sizeof(long);
                Type arrayType = GetArrayType(type);

                int arraySizeInBytes = (int)(Marshal.SizeOf(arrayType) * arrayLen);
                //DebugLog("Got array of length " + arrayLen + " and of type " + arrayType.ToString());

                if (TypeRecursivelyHasAllPrimitiveFields(arrayType))
                {
                    //DebugLog("Nice array type:" + arrayType + " main type " + type);
                    object destArr = Array.CreateInstance(arrayType, arrayLen);
                    ThisStaticType().GetMethod("CopyToArray", BindingFlags.Static | BindingFlags.Public)
                        .MakeGenericMethod(arrayType)
                        .Invoke(null, new object[] { destArr, bytes, offset, arraySizeInBytes });
                    //CopyToArray(destArr, bytes, offset, arraySizeInBytes);
                    offset += arraySizeInBytes;
                    return destArr;
                }
                else
                {
                    //DebugLog("Manual array type:" + arrayType + " main type " + type);
                    object[] parms = new object[] { bytes, (int)arrayLen, offset };

                    object res = ThisStaticType().GetMethod("DecodeArraySlow", BindingFlags.Static | BindingFlags.NonPublic)
                        .MakeGenericMethod(arrayType)
                        .Invoke(null, parms);
                    offset = (int)parms[2];
                    return res;
                }
            }
            else
            {
                object res = CreateDefaultOfObject(type);
                //DebugLog("Running empty constructor for type " + type.ToString());
                foreach (FieldInfo field in GetTypeFields(type))
                {
                    //DebugLog("Got field " + field + " for type " + type.ToString());
                    field.SetValue(res, DecodeObject(field.FieldType, bytes, ref offset));
                }
                return res;
            }
        }

        static object CreateDefaultOfObject(Type type)
        {
            return Activator.CreateInstance(type);
        }

        static Type ThisStaticType()
        {
            // cursed shit to get typeof(this.GetType()) except for static methods
            return MethodBase.GetCurrentMethod().DeclaringType;
        }

        public static ResoniteBridgeServer.LogDelegate DebugLog = x => Console.WriteLine(x);

        static void EncodeObject(object obj, byte[] outBytes, ref int offset, bool writeBytes)
        {
            // null checking
            if (writeBytes) outBytes[offset] = (byte)((obj == null) ? 0 : 1);
            offset += 1;
            if (obj == null)
            {
                return;
            }
            // not null, actually parse the value
            Type objType = obj.GetType();
            switch (obj.GetType().ToString())
            {
                case "System.Boolean":
                    if (writeBytes) Buffer.BlockCopy(BitConverter.GetBytes((bool)obj), 0, outBytes, offset, sizeof(bool));
                    offset += sizeof(bool);
                    return;
                case "System.Single":
                    if (writeBytes) Buffer.BlockCopy(BitConverter.GetBytes((float)obj), 0, outBytes, offset, sizeof(float));
                    offset += sizeof(float);
                    return;
                case "System.Double":
                    if (writeBytes) Buffer.BlockCopy(BitConverter.GetBytes((double)obj), 0, outBytes, offset, sizeof(double));
                    offset += sizeof(double);
                    return;
                case "System.Byte":
                    if (writeBytes) outBytes[offset] = (byte)obj;
                    offset += sizeof(byte);
                    return;
                case "System.SByte":
                    if (writeBytes) outBytes[offset] = (byte)obj;
                    offset += sizeof(sbyte);
                    return;
                case "System.Int16":
                    if (writeBytes) Buffer.BlockCopy(BitConverter.GetBytes((short)obj), 0, outBytes, offset, sizeof(short));
                    offset += sizeof(short);
                    return;
                case "System.UInt16":
                    if (writeBytes) Buffer.BlockCopy(BitConverter.GetBytes((ushort)obj), 0, outBytes, offset, sizeof(ushort));
                    offset += sizeof(ushort);
                    return;
                case "System.Int32":
                    if (writeBytes) Buffer.BlockCopy(BitConverter.GetBytes((int)obj), 0, outBytes, offset, sizeof(int));
                    offset += sizeof(int);
                    return;
                case "System.UInt32":
                    if (writeBytes) Buffer.BlockCopy(BitConverter.GetBytes((uint)obj), 0, outBytes, offset, sizeof(uint));
                    offset += sizeof(uint);
                    return;
                case "System.Int64":
                    if (writeBytes) Buffer.BlockCopy(BitConverter.GetBytes((long)obj), 0, outBytes, offset, sizeof(long));
                    offset += sizeof(long);
                    return;
                case "System.UInt64":
                    if (writeBytes) Buffer.BlockCopy(BitConverter.GetBytes((ulong)obj), 0, outBytes, offset, sizeof(ulong));
                    offset += sizeof(ulong);
                    return;
                case "System.String":
                    EncodeString((string)obj, outBytes, ref offset, writeBytes);
                    return;
                default:
                    break;
            }
            if (objType.IsArray)
            {
                long arrayLength = (long)objType.GetProperty("LongLength")
                            .GetValue(obj);
                //// write length
                if (writeBytes) Buffer.BlockCopy(
                    BitConverter.GetBytes(arrayLength), 0,
                    outBytes, offset, sizeof(long));
                offset += sizeof(long);

                //// write contents
                Type arrayType = GetArrayType(objType);
                // it is all primitive types (or contains only stuff with primitive types, etc.)
                // so it serializes nicely
                // we can just grab the raw bytes
                if (TypeRecursivelyHasAllPrimitiveFields(arrayType))
                {
                    //DebugLog("Encoding array that can go directly: " + arrayType + " full type " + objType);
                    long numBytes = Marshal.SizeOf(arrayType) *
                        arrayLength;
                    // todo: if overflow when cast to int, chunk it
                    if (writeBytes) ToByteArray(obj, outBytes, offset, (int)numBytes);
                    offset += (int)numBytes;
                }
                // it has reference types (like string, objects, etc.)
                // we need to manually encode each type
                else
                {
                    //DebugLog("Encoding array manual: " + arrayType + " full type " + objType);
                    object[] parms = new object[] { obj, outBytes, offset, writeBytes };
                    // need to use reflection because we don't know the array type
                    ThisStaticType().GetMethod("EncodeArraySlow", BindingFlags.Static | BindingFlags.NonPublic)
                        .MakeGenericMethod(arrayType)
                        .Invoke(null, parms);
                    // ref types are passed like this
                    offset = (int)parms[2];
                }
            }
            else
            {
                foreach (FieldInfo field in GetTypeFields(objType))
                {
                    //DebugLog("Got field: " + field.Name + " of type " + objType.ToString());
                    EncodeObject(field.GetValue(obj), outBytes, ref offset, writeBytes);
                }
            }
        }

        static void EncodeArraySlow<T>(T[] arr, byte[] outBytes, ref int offset, bool writeBytes)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                EncodeObject(arr[i], outBytes, ref offset, writeBytes);
            }
        }
        static T[] DecodeArraySlow<T>(byte[] bytes, int arrayLength, ref int offset) where T : struct
        {
            T[] outArr = new T[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                outArr[i] = (T)DecodeObject(typeof(T), bytes, ref offset);
            }
            return outArr;
        }

        public static HashSet<Type> primitiveTypes = new HashSet<Type>()
        {
            typeof(System.Single),
            typeof(System.Double),
            typeof(System.Boolean),
            typeof(System.Byte),
            typeof(System.SByte),
            typeof(System.Int16),
            typeof(System.UInt16),
            typeof(System.Int32),
            typeof(System.UInt32),
            typeof(System.Int64),
            typeof(System.UInt64)
        };


        public static bool TypeRecursivelyHasAllPrimitiveFields(Type type)
        {
            return primitiveTypes.Contains(type) ||
                GetTypeFields(type).All(t =>
                primitiveTypes.Contains(t.FieldType) ||
                TypeRecursivelyHasAllPrimitiveFields(t.FieldType));
        }

        public static IEnumerable<FieldInfo> GetTypeFields(Type type)
        {
            foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                if (!field.IsSpecialName)
                {
                    yield return field;
                }
            }
        }

        public static Type GetArrayType(Type type)
        {
            return type.GetElementType();
        }

        public static byte[] EncodeObject(object obj)
        {
            int numBytes = 0;

            // dry run first to get buffer size
            EncodeObject(obj, null, ref numBytes, writeBytes: false);

            byte[] outputBytes = new byte[numBytes];

            int offset = 0;
            EncodeObject(obj, outputBytes, ref offset, writeBytes: true);
            return outputBytes;
        }
    }
}