#region Assembly mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\mscorlib.dll
// Decompiled with ICSharpCode.Decompiler 8.1.1.7464
#endregion

using System.Security;

namespace System.Threading
{

    [SecurityCritical]
    internal sealed class ThreadPoolBoundHandleOverlappedDotNet : Overlapped
    {
        private unsafe static readonly IOCompletionCallback s_completionCallback = CompletionCallback;

        private readonly IOCompletionCallback _userCallback;

        internal readonly object _userState;

        internal PreAllocatedOverlappedDotNet _preAllocated;

        internal unsafe NativeOverlapped* _nativeOverlapped;

        internal bool _completed;

        public unsafe ThreadPoolBoundHandleOverlappedDotNet(IOCompletionCallback callback, object state, object pinData, PreAllocatedOverlappedDotNet preAllocated)
        {
            _userCallback = callback;
            _userState = state;
            _preAllocated = preAllocated;
            _nativeOverlapped = Pack(s_completionCallback, pinData);
            _nativeOverlapped->OffsetLow = 0;
            _nativeOverlapped->OffsetHigh = 0;
        }

        private unsafe static void CompletionCallback(uint errorCode, uint numBytes, NativeOverlapped* nativeOverlapped)
        {
            ThreadPoolBoundHandleOverlappedDotNet threadPoolBoundHandleOverlapped = (ThreadPoolBoundHandleOverlappedDotNet)Overlapped.Unpack(nativeOverlapped);
            if (threadPoolBoundHandleOverlapped._completed)
            {
                throw new InvalidOperationException("InvalidOperation_NativeOverlappedReused");
            }

            threadPoolBoundHandleOverlapped._completed = true;

            threadPoolBoundHandleOverlapped._userCallback(errorCode, numBytes, nativeOverlapped);
        }
    }
}
