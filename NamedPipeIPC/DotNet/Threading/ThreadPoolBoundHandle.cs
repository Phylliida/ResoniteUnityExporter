using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Threading
{
    internal struct DeferredDisposableLifetimeDotNet<T> where T : class, IDeferredDisposableDotNet
    {
        private int _count;

        public bool AddRef(T obj)
        {
            int num;
            int value;
            do
            {
                num = Volatile.Read(ref _count);
                if (num < 0)
                {
                    throw new ObjectDisposedException(typeof(T).ToString());
                }

                value = checked(num + 1);
            }
            while (Interlocked.CompareExchange(ref _count, value, num) != num);
            return true;
        }

        [SecurityCritical]
        public void Release(T obj)
        {
            int num3;
            while (true)
            {
                int num = Volatile.Read(ref _count);
                if (num > 0)
                {
                    int num2 = num - 1;
                    if (Interlocked.CompareExchange(ref _count, num2, num) == num)
                    {
                        if (num2 == 0)
                        {
                            obj.OnFinalRelease(disposed: false);
                        }

                        return;
                    }
                }
                else
                {
                    num3 = num + 1;
                    if (Interlocked.CompareExchange(ref _count, num3, num) == num)
                    {
                        break;
                    }
                }
            }

            if (num3 == -1)
            {
                obj.OnFinalRelease(disposed: true);
            }
        }

        [SecuritySafeCritical]
        public void Dispose(T obj)
        {
            int num;
            int num2;
            do
            {
                num = Volatile.Read(ref _count);
                if (num < 0)
                {
                    return;
                }

                num2 = -1 - num;
            }
            while (Interlocked.CompareExchange(ref _count, num2, num) != num);
            if (num2 == -1)
            {
                obj.OnFinalRelease(disposed: true);
            }
        }
    }

    internal interface IDeferredDisposableDotNet
    {
        [SecurityCritical]
        void OnFinalRelease(bool disposed);
    }
    public sealed class PreAllocatedOverlappedDotNet : IDisposable, IDeferredDisposableDotNet
    {
        [SecurityCritical]
        internal readonly ThreadPoolBoundHandleOverlappedDotNet _overlapped;

        private DeferredDisposableLifetimeDotNet<PreAllocatedOverlappedDotNet> _lifetime;

        [CLSCompliant(false)]
        [SecuritySafeCritical]
        public PreAllocatedOverlappedDotNet(IOCompletionCallback callback, object state, object pinData)
        {
            if (callback == null)
            {
                throw new ArgumentNullException("callback");
            }

            _overlapped = new ThreadPoolBoundHandleOverlappedDotNet(callback, state, pinData, this);
        }

        internal bool AddRef()
        {
            return _lifetime.AddRef(this);
        }

        [SecurityCritical]
        internal void Release()
        {
            _lifetime.Release(this);
        }

        public void Dispose()
        {
            _lifetime.Dispose(this);
            GC.SuppressFinalize(this);
        }

        ~PreAllocatedOverlappedDotNet()
        {
            if (!Environment.HasShutdownStarted)
            {
                Dispose();
            }
        }

        [SecurityCritical]
        unsafe void IDeferredDisposableDotNet.OnFinalRelease(bool disposed)
        {
            if (_overlapped != null)
            {
                if (disposed)
                {
                    Overlapped.Free(_overlapped._nativeOverlapped);
                    return;
                }

                _overlapped._boundHandle = null;
                _overlapped._completed = false;
                *_overlapped._nativeOverlapped = default(NativeOverlapped);
            }
        }
    }

    [SecurityCritical]
    internal sealed class ThreadPoolBoundHandleOverlappedDotNet : Overlapped
    {
        private unsafe static readonly IOCompletionCallback s_completionCallback = CompletionCallback;

        private readonly IOCompletionCallback _userCallback;

        internal readonly object _userState;

        internal PreAllocatedOverlappedDotNet _preAllocated;

        internal unsafe NativeOverlapped* _nativeOverlapped;

        internal ThreadPoolBoundHandleDotNet _boundHandle;

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
            if (threadPoolBoundHandleOverlapped._boundHandle == null)
            {
                throw new InvalidOperationException("Argument_NativeOverlappedAlreadyFree");
            }

            threadPoolBoundHandleOverlapped._userCallback(errorCode, numBytes, nativeOverlapped);
        }
    }
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


        [MethodImpl(MethodImplOptions.InternalCall)]
        [SecurityCritical]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        private static extern bool BindIOCompletionCallbackNative(IntPtr fileHandle);

        /*
        // from threadpool decomp
        [SecuritySafeCritical]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        static bool ThreadPoolBindHandle(SafeHandle osHandle)
        {
            if (osHandle == null)
            {
                throw new ArgumentNullException("osHandle");
            }

            bool flag = false;
            bool success = false;
            RuntimeHelpers.PrepareConstrainedRegions();
            try
            {
                osHandle.DangerousAddRef(ref success);
                return BindIOCompletionCallbackNative(osHandle.DangerousGetHandle());
            }
            finally
            {
                if (success)
                {
                    osHandle.DangerousRelease();
                }
            }
        }
        */

        [SecurityCritical]
        public static ThreadPoolBoundHandleDotNet BindHandle(SafeHandle handle)
        {
            if (handle == null)
            {
                throw new ArgumentNullException("handle");
            }

            if (handle.IsClosed || handle.IsInvalid)
            {
                throw new ArgumentException("Argument_InvalidHandle");
            }

            try
            {
                // todo: replace with ThreadPoolBindHandle
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
