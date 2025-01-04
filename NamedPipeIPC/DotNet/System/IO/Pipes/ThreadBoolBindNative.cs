using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NamedPipeIPC.DotNet.System.IO.Pipes
{
    public class ThreadPoolBindHandleNative : IDisposable
    {
        private IntPtr _completionPort;
        private bool _disposed;

        [StructLayout(LayoutKind.Sequential)]
        public struct OVERLAPPED
        {
            public IntPtr Internal;
            public IntPtr InternalHigh;
            public Union OffsetUnion;
            public IntPtr EventHandle;
            public IntPtr StatePtr;  // For our state tracking

            [StructLayout(LayoutKind.Explicit)]
            public struct Union
            {
                [FieldOffset(0)]
                public uint Offset;
                [FieldOffset(4)]
                public uint OffsetHigh;
                [FieldOffset(0)]
                public IntPtr Pointer;
            }
        }

        private class OverlappedState
        {
            public IOCompletionCallback Callback { get; set; }
            public object State { get; set; }
            public GCHandle OverlappedHandle { get; set; }
            public GCHandle? PinnedData { get; set; }
        }

        public delegate void IOCompletionCallback(uint errorCode, uint numBytes, IntPtr overlappedPtr);

        public ThreadPoolBindHandleNative(SafeHandle handle)
        {
            if (handle == null) throw new ArgumentNullException(nameof(handle));
            if (handle.IsClosed || handle.IsInvalid) throw new ArgumentException("Handle is invalid", nameof(handle));
            NativeOverlapped a;
            // Create IOCP and bind it to the handle
            _completionPort = CreateIoCompletionPort(
                handle.DangerousGetHandle(),
                IntPtr.Zero,
                UIntPtr.Zero,
                0);

            if (_completionPort == IntPtr.Zero)
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
        }

        public unsafe NativeOverlapped* AllocateNativeOverlapped(
            IOCompletionCallback callback,
            object state,
            byte[] pinData)
        {
            if (_disposed) throw new ObjectDisposedException(nameof(ThreadPoolBindHandleNative));
            if (callback == null) throw new ArgumentNullException(nameof(callback));

            var overlapped = new OVERLAPPED();

            // Create and store state
            var overlappedState = new OverlappedState
            {
                Callback = callback,
                State = state
            };

            // Pin the state
            var stateHandle = GCHandle.Alloc(overlappedState);
            overlapped.StatePtr = GCHandle.ToIntPtr(stateHandle);

            // Pin the OVERLAPPED structure
            overlappedState.OverlappedHandle = GCHandle.Alloc(overlapped, GCHandleType.Pinned);

            // Pin additional data if provided
            if (pinData != null)
            {
                overlappedState.PinnedData = GCHandle.Alloc(pinData, GCHandleType.Pinned);
            }

            return (NativeOverlapped*)overlappedState.OverlappedHandle.AddrOfPinnedObject();
        }

        public static unsafe void FreeNativeOverlapped(NativeOverlapped* overlapped)
        {
            if (overlapped == null) return;

            var managedOverlapped = Marshal.PtrToStructure<OVERLAPPED>(new IntPtr(overlapped));

            if (managedOverlapped.StatePtr != IntPtr.Zero)
            {
                var stateHandle = GCHandle.FromIntPtr(managedOverlapped.StatePtr);
                var state = (OverlappedState)stateHandle.Target;

                // Free all pinned resources
                if (state.PinnedData.HasValue)
                {
                    state.PinnedData.Value.Free();
                }
                state.OverlappedHandle.Free();
                stateHandle.Free();
            }
        }

        public static unsafe object GetNativeOverlappedState(NativeOverlapped* overlapped)
        {
            if (overlapped == null) throw new ArgumentNullException(nameof(overlapped));

            var managedOverlapped = Marshal.PtrToStructure<OVERLAPPED>(new IntPtr(overlapped));

            if (managedOverlapped.StatePtr == IntPtr.Zero)
                return null;

            var stateHandle = GCHandle.FromIntPtr(managedOverlapped.StatePtr);
            var state = (OverlappedState)stateHandle.Target;
            return state.State;
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                if (_completionPort != IntPtr.Zero)
                {
                    CloseHandle(_completionPort);
                    _completionPort = IntPtr.Zero;
                }
                _disposed = true;
            }
        }

        // P/Invoke declarations
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateIoCompletionPort(
            IntPtr FileHandle,
            IntPtr ExistingCompletionPort,
            UIntPtr CompletionKey,
            uint NumberOfConcurrentThreads);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr handle);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetQueuedCompletionStatus(
            IntPtr CompletionPort,
            out uint lpNumberOfBytesTransferred,
            out UIntPtr lpCompletionKey,
            out IntPtr lpOverlapped,
            uint dwMilliseconds);
    }
}
