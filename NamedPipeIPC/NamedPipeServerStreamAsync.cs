using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NamedPipeIPC
{

    public class NativeEvent : IDisposable
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern SafeWaitHandle CreateEvent(
             IntPtr lpEventAttributes,
             bool bManualReset,
             bool bInitialState,
             string lpName);

        public WaitHandle waitHandle;
        public SafeWaitHandle safeWaitHandle;
        public IntPtr overlappedPtr = IntPtr.Zero;       

        // needed to convert SafeWaitHandle to WaitHandle
        private class SafeWaitHandleWrapper : System.Threading.WaitHandle
        {
            public SafeWaitHandleWrapper(SafeWaitHandle handle)
            {
                this.SafeWaitHandle = handle;
            }
        }

        private bool initialized = false;

        public NativeEvent()
        {
            safeWaitHandle = CreateEvent(IntPtr.Zero, true, false, null);
            if (safeWaitHandle.IsInvalid)
            {
                throw new IOException($"Failed to create event. Error: {Marshal.GetLastWin32Error()}");
            }
            // weird casting stuff needed to get the IntPtr
            NativeOverlapped overlapped = new NativeOverlapped
            {
                EventHandle = safeWaitHandle.DangerousGetHandle()
            };

            overlappedPtr = Marshal.AllocHGlobal(Marshal.SizeOf<NativeOverlapped>());
            Marshal.StructureToPtr(overlapped, overlappedPtr, false);
            
            // wrapper if we need to use a WaitHandle
            waitHandle = new SafeWaitHandleWrapper(safeWaitHandle);
            initialized = true;
        }

        public void Dispose()
        {
            if (initialized)
            {
                waitHandle.Dispose();
                Marshal.FreeHGlobal(overlappedPtr);
            }
            safeWaitHandle.Dispose();
        }
    }


    // manual implementation of this using pinvoke
    // because some mono environments (such as Resonite) doesn't implement this

    public class NamedPipeServerStreamAsync : PipeStream
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern SafeFileHandle CreateNamedPipe(
            string lpName,
            uint dwOpenMode,
            uint dwPipeMode,
            uint nMaxInstances,
            uint nOutBufferSize,
            uint nInBufferSize,
            uint nDefaultTimeOut,
            IntPtr lpSecurityAttributes);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ConnectNamedPipe(
            SafeFileHandle hNamedPipe,
            IntPtr lpOverlapped);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool DisconnectNamedPipe(
            SafeFileHandle hNamedPipe);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadFile(
            SafeFileHandle hFile,
            byte[] lpBuffer,
            uint nNumberOfBytesToRead,
            ref uint lpNumberOfBytesRead,
            IntPtr lpOverlapped);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteFile(
            SafeFileHandle hFile,
            byte[] lpBuffer,
            uint nNumberOfBytesToWrite,
            ref uint lpNumberOfBytesWritten,
            IntPtr lpOverlapped);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetOverlappedResult(
            SafeFileHandle hFile,
            IntPtr lpOverlapped,
            out uint lpNumberOfBytesTransferred,
            bool bWait);


        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CancelIo(SafeFileHandle handle);

        private const uint PIPE_ACCESS_DUPLEX = 0x00000003;
        private const uint FILE_FLAG_OVERLAPPED = 0x40000000;
        private const uint PIPE_TYPE_BYTE = 0x00000000;
        private const uint PIPE_READMODE_BYTE = 0x00000000;
        private const uint PIPE_WAIT = 0x00000000;
        private const uint ERROR_IO_PENDING = 997;
        private const uint BUFFER_SIZE = 4096;

        public const int MaxAllowedServerInstances = -1;
        private readonly string _pipeName;
        private SafeFileHandle _pipeHandle;
        private bool _isConnected;

        public NamedPipeServerStreamAsync(string pipeName)
            : this(pipeName, PipeDirection.InOut) { }

        public NamedPipeServerStreamAsync(string pipeName, PipeDirection direction)
            : this(pipeName, direction, MaxAllowedServerInstances) { }

        public NamedPipeServerStreamAsync(string pipeName, PipeDirection direction, int maxNumberOfServerInstances)
            : base(direction, (int)BUFFER_SIZE)
        {
            if (pipeName == null) throw new ArgumentNullException(nameof(pipeName));
            if (pipeName.Length == 0) throw new ArgumentException("Pipe name cannot be empty", nameof(pipeName));
            if (pipeName == "anonymous") throw new ArgumentOutOfRangeException(nameof(pipeName));
            if (pipeName.Contains(":")) throw new NotSupportedException("Pipe name cannot contain colons");
            if (maxNumberOfServerInstances < -1 || maxNumberOfServerInstances > 254)
                throw new ArgumentOutOfRangeException(nameof(maxNumberOfServerInstances));

            _pipeName = @"\\.\pipe\" + pipeName;
            Initialize(maxNumberOfServerInstances);
        }

        private void Initialize(int maxNumberOfServerInstances)
        {
            uint instances = maxNumberOfServerInstances == -1 ? 255 : (uint)maxNumberOfServerInstances;

            _pipeHandle = CreateNamedPipe(
                _pipeName,
                PIPE_ACCESS_DUPLEX | FILE_FLAG_OVERLAPPED,
                PIPE_TYPE_BYTE | PIPE_READMODE_BYTE | PIPE_WAIT,
                instances,
                BUFFER_SIZE,
                BUFFER_SIZE,
                0,
                IntPtr.Zero);

            if (_pipeHandle.IsInvalid)
            {
                throw new IOException($"Failed to create named pipe. Error: {Marshal.GetLastWin32Error()}");
            }
        }

        public Task WaitForConnectionAsync(CancellationToken cancellationToken)
        {
            if (_isConnected)
                throw new InvalidOperationException("Pipe is already connected");

            return WaitForConnectionAsyncHelper(cancellationToken);
        }

        private async Task WaitForConnectionAsyncHelper(CancellationToken cancellationToken)
        {
            using (NativeEvent connectEvent = new NativeEvent())
            {
                if (!ConnectNamedPipe(_pipeHandle, connectEvent.overlappedPtr))
                {
                    int error = Marshal.GetLastWin32Error();
                    if (error != ERROR_IO_PENDING) // ERROR_IO_PENDING (still in progress)
                    {
                        throw new IOException($"Failed to connect to named pipe. Error: {error}");
                    }
                }
                
                try
                {
                    await Task.Run(() =>
                    {
                        WaitHandle.WaitAny(new WaitHandle[] { connectEvent.waitHandle, cancellationToken.WaitHandle });
                    }, cancellationToken);
                    
                    if (cancellationToken.IsCancellationRequested)
                    {
                        throw new OperationCanceledException(cancellationToken);
                    }

                    _isConnected = true;
                }
                catch
                {
                    CancelIo(_pipeHandle);
                    throw;
                }
            }
        }

        public void Disconnect()
        {
            if (!_isConnected)
                throw new InvalidOperationException("Pipe is not connected");

            if (_pipeHandle != null && !_pipeHandle.IsInvalid)
            {
                DisconnectNamedPipe(_pipeHandle);
                _isConnected = false;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_isConnected)
                {
                    Disconnect();
                }
                _pipeHandle?.Dispose();
            }
            base.Dispose(disposing);
        }

        public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));
            if (offset < 0) throw new ArgumentOutOfRangeException(nameof(offset));
            if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
            if (offset + count > buffer.Length) throw new ArgumentException("Invalid offset or count");
            if (!_isConnected) throw new InvalidOperationException("Pipe is not connected");

            using (var overlapped = new NativeEvent())
            {
                uint bytesRead = 0;
                if (!ReadFile(_pipeHandle, buffer, (uint)count, ref bytesRead, overlapped.overlappedPtr))
                {
                    int error = Marshal.GetLastWin32Error();
                    if (error != ERROR_IO_PENDING)
                    {
                        throw new IOException($"Read failed with error: {error}");
                    }

                    await Task.Run(() =>
                    {
                        WaitHandle.WaitAny(new WaitHandle[] { overlapped.waitHandle, cancellationToken.WaitHandle });
                    }, cancellationToken);
                        
                    if (cancellationToken.IsCancellationRequested)
                    {
                        CancelIo(_pipeHandle);
                        throw new OperationCanceledException(cancellationToken);
                    }

                    if (!GetOverlappedResult(_pipeHandle, overlapped.overlappedPtr, out bytesRead, true))
                    {
                        throw new IOException($"Read operation failed: {Marshal.GetLastWin32Error()}");
                    }
                }
                Console.WriteLine(bytesRead + " ffread bytes");
                return (int)bytesRead;
            }
        }

        public override async Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));
            if (offset < 0) throw new ArgumentOutOfRangeException(nameof(offset));
            if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
            if (offset + count > buffer.Length) throw new ArgumentException("Invalid offset or count");
            if (!_isConnected) throw new InvalidOperationException("Pipe is not connected");

            using (var overlapped = new NativeEvent())
            {
                uint bytesWritten = 0;
                if (!WriteFile(_pipeHandle, buffer, (uint)count, ref bytesWritten, overlapped.overlappedPtr))
                {
                    int error = Marshal.GetLastWin32Error();
                    if (error != ERROR_IO_PENDING)
                    {
                        throw new IOException($"Write failed with error: {error}");
                    }

                    try
                    {
                        await Task.Run(() =>
                        {
                            WaitHandle.WaitAny(new WaitHandle[] { overlapped.waitHandle, cancellationToken.WaitHandle });
                        }, cancellationToken);
                        
                        if (cancellationToken.IsCancellationRequested)
                        {
                            throw new OperationCanceledException(cancellationToken);
                        }
                        
                        if (!GetOverlappedResult(_pipeHandle, overlapped.overlappedPtr, out bytesWritten, true))
                        {
                            throw new IOException($"Write operation failed: {Marshal.GetLastWin32Error()}");
                        }
                    }
                    catch
                    {
                        CancelIo(_pipeHandle);
                        throw;
                    }
                }
            }
        }
    }
}
