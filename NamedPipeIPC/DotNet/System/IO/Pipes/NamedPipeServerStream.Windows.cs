// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Pipes
{
    /// <summary>
    /// Named pipe server
    /// </summary>
    public sealed partial class NamedPipeServerStreamDotNet : PipeStreamDotNet
    {
        [SecurityCritical]
        private void Create(string pipeName, PipeDirectionDotNet direction, int maxNumberOfServerInstances,
                PipeTransmissionModeDotNet transmissionMode, PipeOptionsDotNet options, int inBufferSize, int outBufferSize,
                HandleInheritability inheritability)
        {
            Debug.Assert(pipeName != null && pipeName.Length != 0, "fullPipeName is null or empty");
            Debug.Assert(direction >= PipeDirectionDotNet.In && direction <= PipeDirectionDotNet.InOut, "invalid pipe direction");
            Debug.Assert(inBufferSize >= 0, "inBufferSize is negative");
            Debug.Assert(outBufferSize >= 0, "outBufferSize is negative");
            Debug.Assert((maxNumberOfServerInstances >= 1 && maxNumberOfServerInstances <= 254) || (maxNumberOfServerInstances == MaxAllowedServerInstances), "maxNumberOfServerInstances is invalid");
            Debug.Assert(transmissionMode >= PipeTransmissionModeDotNet.Byte && transmissionMode <= PipeTransmissionModeDotNet.Message, "transmissionMode is out of range");

            string fullPipeName = Path.GetFullPath(@"\\.\pipe\" + pipeName);

            // Make sure the pipe name isn't one of our reserved names for anonymous pipes.
            if (String.Equals(fullPipeName, @"\\.\pipe\anonymous", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentOutOfRangeException(nameof(pipeName), SR.ArgumentOutOfRange_AnonymousReserved);
            }


            int openMode = ((int)direction) |
                           (maxNumberOfServerInstances == 1 ? Interop.Kernel32.FileOperations.FILE_FLAG_FIRST_PIPE_INSTANCE : 0) |
                           (int)options;

            // We automatically set the ReadMode to match the TransmissionMode.
            int pipeModes = (int)transmissionMode << 2 | (int)transmissionMode << 1;

            // Convert -1 to 255 to match win32 (we asserted that it is between -1 and 254).
            if (maxNumberOfServerInstances == MaxAllowedServerInstances)
            {
                maxNumberOfServerInstances = 255;
            }

            Interop.Kernel32.SECURITY_ATTRIBUTES secAttrs = PipeStreamDotNet.GetSecAttrs(inheritability);
            using (Interop.Kernel32.SecurityAttriutes attrs = new Interop.Kernel32.SecurityAttriutes(secAttrs))
            {
                SafePipeHandle handle = Interop.Kernel32.CreateNamedPipe(fullPipeName, openMode, pipeModes,
                    maxNumberOfServerInstances, outBufferSize, inBufferSize, 0, attrs.ptr);

                if (handle.IsInvalid)
                {
                    throw Win32Marshal.GetExceptionForLastWin32Error();
                }

                InitializeHandle(handle, false, (options & PipeOptionsDotNet.Asynchronous) != 0);
            }
        }

        // This will wait until the client calls Connect().  If we return from this method, we guarantee that
        // the client has returned from its Connect call.   The client may have done so before this method 
        // was called (but not before this server is been created, or, if we were servicing another client, 
        // not before we called Disconnect), in which case, there may be some buffer already in the pipe waiting
        // for us to read.  See NamedPipeClientStreamDotNet.Connect for more information.
        [SecurityCritical]
        [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "Security model of pipes: demand at creation but no subsequent demands")]
        public void WaitForConnection()
        {
            CheckConnectOperationsServerWithHandle();

            if (IsAsync)
            {
                WaitForConnectionCoreAsync(CancellationToken.None).GetAwaiter().GetResult();
            }
            else
            {
                if (!Interop.Kernel32.ConnectNamedPipe(InternalHandle, IntPtr.Zero))
                {
                    int errorCode = Marshal.GetLastWin32Error();

                    if (errorCode != Interop.Errors.ERROR_PIPE_CONNECTED)
                    {
                        throw Win32Marshal.GetExceptionForWin32Error(errorCode);
                    }

                    // pipe already connected
                    if (errorCode == Interop.Errors.ERROR_PIPE_CONNECTED && State == PipeState.Connected)
                    {
                        throw new InvalidOperationException(SR.InvalidOperation_PipeAlreadyConnected);
                    }
                    // If we reach here then a connection has been established.  This can happen if a client 
                    // connects in the interval between the call to CreateNamedPipe and the call to ConnectNamedPipe. 
                    // In this situation, there is still a good connection between client and server, even though 
                    // ConnectNamedPipe returns zero.
                }
                State = PipeState.Connected;
            }
        }

        public Task WaitForConnectionAsync(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromCanceled(cancellationToken);
            }

            if (!IsAsync)
            {
                return Task.Factory.StartNew(s => ((NamedPipeServerStreamDotNet)s).WaitForConnection(),
                    this, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
            }

            return WaitForConnectionCoreAsync(cancellationToken);
        }

        [SecurityCritical]
        public void Disconnect()
        {
            CheckDisconnectOperations();

            // Disconnect the pipe.
            if (!Interop.Kernel32.DisconnectNamedPipe(InternalHandle))
            {
                throw Win32Marshal.GetExceptionForLastWin32Error();
            }

            State = PipeState.Disconnected;
        }

        // Gets the username of the connected client.  Not that we will not have access to the client's 
        // username until it has written at least once to the pipe (and has set its impersonationLevel 
        // argument appropriately). 
        [SecurityCritical]
        public String GetImpersonationUserName()
        {
            CheckWriteOperations();

            StringBuilder userName = new StringBuilder(Interop.Kernel32.CREDUI_MAX_USERNAME_LENGTH + 1);

            if (!Interop.Kernel32.GetNamedPipeHandleState(InternalHandle, IntPtr.Zero, IntPtr.Zero,
                IntPtr.Zero, IntPtr.Zero, userName, userName.Capacity))
            {
                throw WinIOError(Marshal.GetLastWin32Error());
            }

            return userName.ToString();
        }

        // -----------------------------
        // ---- PAL layer ends here ----
        // -----------------------------

        // This method calls a delegate while impersonating the client. Note that we will not have
        // access to the client's security token until it has written at least once to the pipe 
        // (and has set its impersonationLevel argument appropriately). 
        public void RunAsClient(PipeStreamImpersonationWorker impersonationWorker)
        {
            CheckWriteOperations();
            ExecuteHelper execHelper = new ExecuteHelper(impersonationWorker, InternalHandle);
            RuntimeHelpers.ExecuteCodeWithGuaranteedCleanup(tryCode, cleanupCode, execHelper);

            // now handle win32 impersonate/revert specific errors by throwing corresponding exceptions
            if (execHelper._impersonateErrorCode != 0)
            {
                WinIOError(execHelper._impersonateErrorCode);
            }
            else if (execHelper._revertImpersonateErrorCode != 0)
            {
                WinIOError(execHelper._revertImpersonateErrorCode);
            }
        }

        // the following are needed for CER

        private static RuntimeHelpers.TryCode tryCode = new RuntimeHelpers.TryCode(ImpersonateAndTryCode);
        private static RuntimeHelpers.CleanupCode cleanupCode = new RuntimeHelpers.CleanupCode(RevertImpersonationOnBackout);

        private static void ImpersonateAndTryCode(Object helper)
        {
            ExecuteHelper execHelper = (ExecuteHelper)helper;

            RuntimeHelpers.PrepareConstrainedRegions();
            try { }
            finally
            {
                if (Interop.Advapi32.ImpersonateNamedPipeClient(execHelper._handle))
                {
                    execHelper._mustRevert = true;
                }
                else
                {
                    execHelper._impersonateErrorCode = Marshal.GetLastWin32Error();
                }

            }

            if (execHelper._mustRevert)
            { // impersonate passed so run user code
                execHelper._userCode();
            }
        }

        private static void RevertImpersonationOnBackout(Object helper, bool exceptionThrown)
        {
            ExecuteHelper execHelper = (ExecuteHelper)helper;

            if (execHelper._mustRevert)
            {
                if (!Interop.Advapi32.RevertToSelf())
                {
                    execHelper._revertImpersonateErrorCode = Marshal.GetLastWin32Error();
                }
            }
        }

        internal class ExecuteHelper
        {
            internal PipeStreamImpersonationWorker _userCode;
            internal SafePipeHandle _handle;
            internal bool _mustRevert;
            internal int _impersonateErrorCode;
            internal int _revertImpersonateErrorCode;

            [SecurityCritical]
            internal ExecuteHelper(PipeStreamImpersonationWorker userCode, SafePipeHandle handle)
            {
                _userCode = userCode;
                _handle = handle;
            }
        }

        // Async version of WaitForConnection.  See the comments above for more info.
        private unsafe Task WaitForConnectionCoreAsync(CancellationToken cancellationToken)
        {
            CheckConnectOperationsServerWithHandle();

            if (!IsAsync)
            {
                throw new InvalidOperationException(SR.InvalidOperation_PipeNotAsync);
            }

            var completionSource = new ConnectionCompletionSource(this, cancellationToken);

            if (!Interop.Kernel32.ConnectNamedPipe(InternalHandle, completionSource.Overlapped))
            {
                int errorCode = Marshal.GetLastWin32Error();

                switch (errorCode)
                {
                    case Interop.Errors.ERROR_IO_PENDING:
                        break;

                    // If we are here then the pipe is already connected, or there was an error
                    // so we should unpin and free the overlapped.
                    case Interop.Errors.ERROR_PIPE_CONNECTED:
                        // IOCompletitionCallback will not be called because we completed synchronously.
                        completionSource.ReleaseResources();
                        if (State == PipeState.Connected)
                        {
                            throw new InvalidOperationException(SR.InvalidOperation_PipeAlreadyConnected);
                        }
                        completionSource.SetCompletedSynchronously();

                        // We return a cached task instead of TaskCompletionSource's Task allowing the GC to collect it.
                        return Task.CompletedTask;

                    default:
                        completionSource.ReleaseResources();
                        throw Win32Marshal.GetExceptionForWin32Error(errorCode);
                }
            }

            // If we are here then connection is pending.
            completionSource.RegisterForCancellation();

            return completionSource.Task;
        }

        private void CheckConnectOperationsServerWithHandle()
        {
            if (InternalHandle == null)
            {
                throw new InvalidOperationException(SR.InvalidOperation_PipeHandleNotSet);
            }
            CheckConnectOperationsServer();
        }
    }
}
