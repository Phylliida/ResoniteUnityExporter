// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System.Security;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Pipes
{
    /// <summary>
    /// Named pipe client. Use this to open the client end of a named pipes created with 
    /// NamedPipeServerStreamDotNet.
    /// </summary>
    public sealed partial class NamedPipeClientStreamDotNet : PipeStreamDotNet
    {
        // Maximum interval in milliseconds between which cancellation is checked.
        // Used by ConnectInternal. 50ms is fairly responsive time but really long time for processor.
        private const int CancellationCheckInterval = 50;
        private readonly string _normalizedPipePath;
        private readonly TokenImpersonationLevel _impersonationLevel;
        private readonly PipeOptionsDotNet _pipeOptions;
        private readonly HandleInheritability _inheritability;
        private readonly PipeDirectionDotNet _direction;

        // Creates a named pipe client using default server (same machine, or "."), and PipeDirectionDotNet.InOut 
        [SecuritySafeCritical]
        public NamedPipeClientStreamDotNet(String pipeName)
            : this(".", pipeName, PipeDirectionDotNet.InOut, PipeOptionsDotNet.None, TokenImpersonationLevel.None, HandleInheritability.None)
        { 
        }

        [SecuritySafeCritical]
        public NamedPipeClientStreamDotNet(String serverName, String pipeName)
            : this(serverName, pipeName, PipeDirectionDotNet.InOut, PipeOptionsDotNet.None, TokenImpersonationLevel.None, HandleInheritability.None)
        {
        }

        [SecuritySafeCritical]
        public NamedPipeClientStreamDotNet(String serverName, String pipeName, PipeDirectionDotNet direction)
            : this(serverName, pipeName, direction, PipeOptionsDotNet.None, TokenImpersonationLevel.None, HandleInheritability.None)
        {
        }

        [SecuritySafeCritical]
        public NamedPipeClientStreamDotNet(String serverName, String pipeName, PipeDirectionDotNet direction, PipeOptionsDotNet options)
            : this(serverName, pipeName, direction, options, TokenImpersonationLevel.None, HandleInheritability.None)
        {
        }

        [SecuritySafeCritical]
        public NamedPipeClientStreamDotNet(String serverName, String pipeName, PipeDirectionDotNet direction,
            PipeOptionsDotNet options, TokenImpersonationLevel impersonationLevel)
            : this(serverName, pipeName, direction, options, impersonationLevel, HandleInheritability.None)
        {
        }

        [SecuritySafeCritical]
        public NamedPipeClientStreamDotNet(String serverName, String pipeName, PipeDirectionDotNet direction,
            PipeOptionsDotNet options, TokenImpersonationLevel impersonationLevel, HandleInheritability inheritability)
            : base(direction, 0)
        {
            if (pipeName == null)
            {
                throw new ArgumentNullException(nameof(pipeName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName), SR.ArgumentNull_ServerName);
            }
            if (pipeName.Length == 0)
            {
                throw new ArgumentException(SR.Argument_NeedNonemptyPipeName);
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException(SR.Argument_EmptyServerName);
            }
            if ((options & ~(PipeOptionsDotNet.WriteThrough | PipeOptionsDotNet.Asynchronous)) != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(options), SR.ArgumentOutOfRange_OptionsInvalid);
            }
            if (impersonationLevel < TokenImpersonationLevel.None || impersonationLevel > TokenImpersonationLevel.Delegation)
            {
                throw new ArgumentOutOfRangeException(nameof(impersonationLevel), SR.ArgumentOutOfRange_ImpersonationInvalid);
            }
            if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
            {
                throw new ArgumentOutOfRangeException(nameof(inheritability), SR.ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable);
            }

            _normalizedPipePath = GetPipePath(serverName, pipeName);
            _direction = direction;
            _inheritability = inheritability;
            _impersonationLevel = impersonationLevel;
            _pipeOptions = options;
        }

        // Create a NamedPipeClientStreamDotNet from an existing server pipe handle.
        [SecuritySafeCritical]
        public NamedPipeClientStreamDotNet(PipeDirectionDotNet direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle)
            : base(direction, 0)
        {
            if (safePipeHandle == null)
            {
                throw new ArgumentNullException(nameof(safePipeHandle));
            }
            if (safePipeHandle.IsInvalid)
            {
                throw new ArgumentException(SR.Argument_InvalidHandle, nameof(safePipeHandle));
            }
            ValidateHandleIsPipe(safePipeHandle);

            InitializeHandle(safePipeHandle, true, isAsync);
            if (isConnected)
            {
                State = PipeState.Connected;
            }
        }

        ~NamedPipeClientStreamDotNet()
        {
            Dispose(false);
        }

        public void Connect()
        {
            Connect(Timeout.Infinite);
        }

        public void Connect(int timeout)
        {
            CheckConnectOperationsClient();

            if (timeout < 0 && timeout != Timeout.Infinite)
            {
                throw new ArgumentOutOfRangeException(nameof(timeout), SR.ArgumentOutOfRange_InvalidTimeout);
            }

            ConnectInternal(timeout, CancellationToken.None, Environment.TickCount);
        }

        [SecurityCritical]
        private void ConnectInternal(int timeout, CancellationToken cancellationToken, int startTime)
        {
            // This is the main connection loop. It will loop until the timeout expires.  
            int elapsed = 0;
            var sw = new SpinWait();
            do
            {
                cancellationToken.ThrowIfCancellationRequested();

                // Determine how long we should wait in this connection attempt
                int waitTime = timeout - elapsed;
                if (cancellationToken.CanBeCanceled && waitTime > CancellationCheckInterval)
                {
                    waitTime = CancellationCheckInterval;
                }

                // Try to connect.
                if (TryConnect(waitTime, cancellationToken))
                {
                    return;
                }

                // Some platforms may return immediately from TryConnect if the connection could not be made, 
                // e.g. WaitNamedPipe on Win32 will return immediately if the pipe hasn't yet been created,
                // and open on Unix will fail if the file isn't yet available.  Rather than just immediately
                // looping around again, do slightly smarter busy waiting.
                sw.SpinOnce();
            }
            while (timeout == Timeout.Infinite || (elapsed = unchecked(Environment.TickCount - startTime)) < timeout);

            throw new TimeoutException();
        }

        public Task ConnectAsync()
        {
            // We cannot avoid creating lambda here by using Connect method
            // unless we don't care about start time to be measured before the thread is started
            return ConnectAsync(Timeout.Infinite, CancellationToken.None);
        }

        public Task ConnectAsync(int timeout)
        {
            return ConnectAsync(timeout, CancellationToken.None);
        }

        public Task ConnectAsync(CancellationToken cancellationToken)
        {
            return ConnectAsync(Timeout.Infinite, cancellationToken);
        }

        public Task ConnectAsync(int timeout, CancellationToken cancellationToken)
        {
            CheckConnectOperationsClient();

            if (timeout < 0 && timeout != Timeout.Infinite)
            {
                throw new ArgumentOutOfRangeException(nameof(timeout), SR.ArgumentOutOfRange_InvalidTimeout);
            }

            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromCanceled(cancellationToken);
            }

            int startTime = Environment.TickCount; // We need to measure time here, not in the lambda
            return Task.Run(() => ConnectInternal(timeout, cancellationToken, startTime), cancellationToken);
        }

        // override because named pipe clients can't get/set properties when waiting to connect
        // or broken
        [SecurityCritical]
        protected internal override void CheckPipePropertyOperations()
        {
            base.CheckPipePropertyOperations();

            if (State == PipeState.WaitingToConnect)
            {
                throw new InvalidOperationException(SR.InvalidOperation_PipeNotYetConnected);
            }
            if (State == PipeState.Broken)
            {
                throw new IOException(SR.IO_PipeBroken);
            }
        }

        // named client is allowed to connect from broken
        private void CheckConnectOperationsClient()
        {
            if (State == PipeState.Connected)
            {
                throw new InvalidOperationException(SR.InvalidOperation_PipeAlreadyConnected);
            }
            if (State == PipeState.Closed)
            {
                throw Error.GetPipeNotOpen();
            }
        }
    }
}
