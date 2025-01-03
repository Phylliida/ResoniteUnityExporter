// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
using NamedPipeIPC.Resources;

namespace System.IO
{
    // Only static data; no need to serialize
    internal static class Error
    {
        internal static Exception GetEndOfFile()
        {
            return new EndOfStreamException(Strings.IO_EOF_ReadBeyondEOF);
        }

        internal static Exception GetPipeNotOpen()
        {
            return new ObjectDisposedException(null, Strings.ObjectDisposed_PipeClosed);
        }

        internal static Exception GetReadNotSupported()
        {
            return new NotSupportedException(Strings.NotSupported_UnreadableStream);
        }

        internal static Exception GetSeekNotSupported()
        {
            return new NotSupportedException(Strings.NotSupported_UnseekableStream);
        }

        internal static Exception GetWriteNotSupported()
        {
            return new NotSupportedException(Strings.NotSupported_UnwritableStream);
        }

        internal static Exception GetOperationAborted()
        {
            return new IOException(Strings.IO_OperationAborted);
        }
    }
}
