// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace System.IO.Pipes
{
    /// <summary>
    /// Anonymous pipe server stream
    /// </summary>
    public sealed partial class AnonymousPipeServerStreamDotNet : PipeStreamDotNet
    {
        private SafePipeHandle _clientHandle;
        private bool _clientHandleExposed;

        [SecuritySafeCritical]
        public AnonymousPipeServerStreamDotNet()
            : this(PipeDirectionDotNet.Out, HandleInheritability.None, 0)
        {
        }

        [SecuritySafeCritical]
        public AnonymousPipeServerStreamDotNet(PipeDirectionDotNet direction)
            : this(direction, HandleInheritability.None, 0)
        {
        }

        [SecuritySafeCritical]
        public AnonymousPipeServerStreamDotNet(PipeDirectionDotNet direction, HandleInheritability inheritability)
            : this(direction, inheritability, 0)
        { 
        }

        // Create an AnonymousPipeServerStreamDotNet from two existing pipe handles.
        [SecuritySafeCritical]
        public AnonymousPipeServerStreamDotNet(PipeDirectionDotNet direction, SafePipeHandle serverSafePipeHandle, SafePipeHandle clientSafePipeHandle)
            : base(direction, 0)
        {
            if (direction == PipeDirectionDotNet.InOut)
            {
                throw new NotSupportedException(SR.NotSupported_AnonymousPipeUnidirectional);
            }
            if (serverSafePipeHandle == null)
            {
                throw new ArgumentNullException(nameof(serverSafePipeHandle));
            }
            if (clientSafePipeHandle == null)
            {
                throw new ArgumentNullException(nameof(clientSafePipeHandle));
            }
            if (serverSafePipeHandle.IsInvalid)
            {
                throw new ArgumentException(SR.Argument_InvalidHandle, nameof(serverSafePipeHandle));
            }
            if (clientSafePipeHandle.IsInvalid)
            {
                throw new ArgumentException(SR.Argument_InvalidHandle, nameof(clientSafePipeHandle));
            }
            ValidateHandleIsPipe(serverSafePipeHandle);
            ValidateHandleIsPipe(clientSafePipeHandle);

            InitializeHandle(serverSafePipeHandle, true, false);

            _clientHandle = clientSafePipeHandle;
            _clientHandleExposed = true;
            State = PipeState.Connected;
        }

        // bufferSize is used as a suggestion; specify 0 to let OS decide
        // This constructor instantiates the PipeSecurity using just the inheritability flag
        [SecuritySafeCritical]
        public AnonymousPipeServerStreamDotNet(PipeDirectionDotNet direction, HandleInheritability inheritability, int bufferSize)
            : base(direction, bufferSize)
        {
            if (direction == PipeDirectionDotNet.InOut)
            {
                throw new NotSupportedException(SR.NotSupported_AnonymousPipeUnidirectional);
            }
            if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
            {
                throw new ArgumentOutOfRangeException(nameof(inheritability), SR.ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable);
            }

            Create(direction, inheritability, bufferSize);
        }

        ~AnonymousPipeServerStreamDotNet()
        {
            Dispose(false);
        }

        // This method should exist until we add a first class way of passing handles between parent and child
        // processes. For now, people do it via command line arguments. 
        [SecurityCritical]
        [SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Runtime.InteropServices.SafeHandle.DangerousGetHandle", Justification = "By design")]
        public String GetClientHandleAsString()
        {
            _clientHandleExposed = true;
            GC.SuppressFinalize(_clientHandle);
            return _clientHandle.DangerousGetHandle().ToString();
        }

        public SafePipeHandle ClientSafePipeHandle
        {
            [SecurityCritical]
            get
            {
                _clientHandleExposed = true;
                return _clientHandle;
            }
        }

        // This method is an annoying one but it has to exist at least until we make passing handles between 
        // processes first class.  We need this because once the child handle is inherited, the OS considers
        // the parent and child's handles to be different.  Therefore, if a child closes its handle, our 
        // Read/Write methods won't throw because the OS will think that there is still a child handle around
        // that can still Write/Read to/from the other end of the pipe.
        //
        // Ideally, we would want the Process class to close this handle after it has been inherited.  See
        // the pipe spec future features section for more information.
        // 
        // Right now, this is the best signal to set the anonymous pipe as connected; if this is called, we
        // know the client has been passed the handle and so the connection is live.
        [SecurityCritical]
        public void DisposeLocalCopyOfClientHandle()
        {
            if (_clientHandle != null && !_clientHandle.IsClosed)
            {
                _clientHandle.Dispose();
            }
        }

        [SecurityCritical]
        protected override void Dispose(bool disposing)
        {
            try
            {
                // We should dispose of the client handle if it was not exposed. 
                if (!_clientHandleExposed && _clientHandle != null && !_clientHandle.IsClosed)
                {
                    _clientHandle.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Anonymous pipes do not support message mode so there is no need to use the base version that P/Invokes here.
        public override PipeTransmissionModeDotNet TransmissionMode
        {
            [SecurityCritical]
            get { return PipeTransmissionModeDotNet.Byte; }
        }

        public override PipeTransmissionModeDotNet ReadMode
        {
            [SecurityCritical]
            set
            {
                CheckPipePropertyOperations();

                if (value < PipeTransmissionModeDotNet.Byte || value > PipeTransmissionModeDotNet.Message)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), SR.ArgumentOutOfRange_TransmissionModeByteOrMsg);
                }
                if (value == PipeTransmissionModeDotNet.Message)
                {
                    throw new NotSupportedException(SR.NotSupported_AnonymousPipeMessagesNotSupported);
                }
            }
        }
    }
}
