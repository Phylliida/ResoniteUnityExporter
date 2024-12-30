using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    public class U2ResUtils
    {
        // these could be made faster by using pointers and memcopy
        // but that's unsafe which is annoying
        private static byte[] ToByteArray<T>(T[] source) where T : struct
        {
            GCHandle handle = GCHandle.Alloc(source, GCHandleType.Pinned);
            try
            {
                IntPtr pointer = handle.AddrOfPinnedObject();
                byte[] destination = new byte[source.Length * Marshal.SizeOf(typeof(T))];
                Marshal.Copy(pointer, destination, 0, destination.Length);
                return destination;
            }
            finally
            {
                if (handle.IsAllocated)
                    handle.Free();
            }
        }

        private static void CopyToArray<T>(T[] dest, byte[] source) where T : struct
        {
            GCHandle handle = GCHandle.Alloc(dest, GCHandleType.Pinned);
            try
            {
                IntPtr pointer = handle.AddrOfPinnedObject();
                Marshal.Copy(source, 0, pointer, source.Length);
            }
            finally
            {
                if (handle.IsAllocated)
                    handle.Free();
            }

        }
        private static T[] FromByteArray<T>(byte[] source) where T : struct
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

        public static void CopyArray<T1, T2>(T1[] src, T2[] dst)
            where T1 : struct
            where T2 : struct
        {
            // could be made faster using unsafe but ehh
            byte[] srcAsByte = ToByteArray(src);
            CopyToArray(dst, srcAsByte);
        }
    }
}
