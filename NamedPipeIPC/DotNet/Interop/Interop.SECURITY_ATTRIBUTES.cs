// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class Kernel32
    {
        internal class SecurityAttriutes : IDisposable
        {
            SECURITY_ATTRIBUTES secAttrs;
            public IntPtr ptr;
            internal SecurityAttriutes(SECURITY_ATTRIBUTES secAttrs)
            {
                this.secAttrs = secAttrs;

                // Allocate unmanaged memory for the structure
                ptr = Marshal.AllocHGlobal(Marshal.SizeOf<SECURITY_ATTRIBUTES>());
                Marshal.StructureToPtr(secAttrs, ptr, false);
            }

            public void Dispose()
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct SECURITY_ATTRIBUTES
        {
            internal uint nLength;
            internal IntPtr lpSecurityDescriptor;
            internal BOOL bInheritHandle;
        }
    }
}
