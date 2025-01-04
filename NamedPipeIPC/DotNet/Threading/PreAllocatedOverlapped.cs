

using System.Security;

namespace System.Threading
{
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
}