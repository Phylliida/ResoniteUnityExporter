

using System.Runtime.InteropServices;
using System.Security;

namespace System.Threading
{

    public sealed class ThreadPoolBoundHandleDotNet : IDisposable
    {
        private const int E_HANDLE = -2147024890;

        private const int E_INVALIDARG = -2147024809;

        [SecurityCritical]
        private readonly SafeHandle _handle;

        private bool _isDisposed;

        public SafeHandle Handle
        {
            [SecurityCritical]
            get
            {
                return _handle;
            }
        }

        [SecurityCritical]
        private ThreadPoolBoundHandleDotNet(SafeHandle handle)
        {
            _handle = handle;
        }

        [SecurityCritical]
        public static ThreadPoolBoundHandleDotNet BindHandle(SafeHandle handle)
        {
            if (handle == null)
            {
                throw new ArgumentNullException("handle");
            }

            if (handle.IsClosed || handle.IsInvalid)
            {
                throw new ArgumentException("Argument_InvalidHandle", "handle");
            }

            try
            {
                bool flag = ThreadPool.BindHandle(handle);
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147024890)
                {
                    throw new ArgumentException("Argument_InvalidHandle", "handle");
                }

                if (ex.HResult == -2147024809)
                {
                    throw new ArgumentException("Argument_AlreadyBoundOrSyncHandle", "handle");
                }

                throw;
            }

            return new ThreadPoolBoundHandleDotNet(handle);
        }

        [CLSCompliant(false)]
        [SecurityCritical]
        public unsafe NativeOverlapped* AllocateNativeOverlapped(IOCompletionCallback callback, object state, object pinData)
        {
            if (callback == null)
            {
                throw new ArgumentNullException("callback");
            }

            EnsureNotDisposed();
            ThreadPoolBoundHandleOverlappedDotNet threadPoolBoundHandleOverlapped = new ThreadPoolBoundHandleOverlappedDotNet(callback, state, pinData, null);
            threadPoolBoundHandleOverlapped._boundHandle = this;
            return threadPoolBoundHandleOverlapped._nativeOverlapped;
        }

        [CLSCompliant(false)]
        [SecurityCritical]
        public unsafe NativeOverlapped* AllocateNativeOverlapped(PreAllocatedOverlappedDotNet preAllocated)
        {
            if (preAllocated == null)
            {
                throw new ArgumentNullException("preAllocated");
            }

            EnsureNotDisposed();
            preAllocated.AddRef();
            try
            {
                ThreadPoolBoundHandleOverlappedDotNet overlapped = preAllocated._overlapped;
                if (overlapped._boundHandle != null)
                {
                    throw new ArgumentException("Argument_PreAllocatedAlreadyAllocated", "preAllocated");
                }

                overlapped._boundHandle = this;
                return overlapped._nativeOverlapped;
            }
            catch
            {
                preAllocated.Release();
                throw;
            }
        }

        [CLSCompliant(false)]
        [SecurityCritical]
        public unsafe void FreeNativeOverlapped(NativeOverlapped* overlapped)
        {
            if (overlapped == null)
            {
                throw new ArgumentNullException("overlapped");
            }

            ThreadPoolBoundHandleOverlappedDotNet overlappedWrapper = GetOverlappedWrapper(overlapped, this);
            if (overlappedWrapper._boundHandle != this)
            {
                throw new ArgumentException("Argument_NativeOverlappedWrongBoundHandle", "overlapped");
            }

            if (overlappedWrapper._preAllocated != null)
            {
                overlappedWrapper._preAllocated.Release();
            }
            else
            {
                Overlapped.Free(overlapped);
            }
        }

        [CLSCompliant(false)]
        [SecurityCritical]
        public unsafe static object GetNativeOverlappedState(NativeOverlapped* overlapped)
        {
            if (overlapped == null)
            {
                throw new ArgumentNullException("overlapped");
            }

            ThreadPoolBoundHandleOverlappedDotNet overlappedWrapper = GetOverlappedWrapper(overlapped, null);
            return overlappedWrapper._userState;
        }

        [SecurityCritical]
        private unsafe static ThreadPoolBoundHandleOverlappedDotNet GetOverlappedWrapper(NativeOverlapped* overlapped, ThreadPoolBoundHandleDotNet expectedBoundHandle)
        {
            try
            {
                return (ThreadPoolBoundHandleOverlappedDotNet)Overlapped.Unpack(overlapped);
            }
            catch (NullReferenceException innerException)
            {
                throw new ArgumentException("Argument_NativeOverlappedAlreadyFree", "overlapped", innerException);
            }
        }

        public void Dispose()
        {
            _isDisposed = true;
        }

        private void EnsureNotDisposed()
        {
            if (_isDisposed)
            {
                throw new ObjectDisposedException(GetType().ToString());
            }
        }
    }
}