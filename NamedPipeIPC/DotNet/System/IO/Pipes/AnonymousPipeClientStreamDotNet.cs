// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace System.IO.Pipes
{
    /// <summary>
    /// Anonymous pipe client. Use this to open the client end of an anonymous pipes created with AnonymousPipeServerStreamDotNet.
    /// </summary>
    public sealed partial class AnonymousPipeClientStreamDotNet : PipeStreamDotNet
    {
        [SecuritySafeCritical]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string", Justification = "By design")]
        public AnonymousPipeClientStreamDotNet(String pipeHandleAsString)
            : this(PipeDirectionDotNet.In, pipeHandleAsString)
        {
        }

        [SecurityCritical]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string", Justification = "By design")]
        public AnonymousPipeClientStreamDotNet(PipeDirectionDotNet direction, String pipeHandleAsString)
            : base(direction, 0)
        {
            if (direction == PipeDirectionDotNet.InOut)
            {
                throw new NotSupportedException(SR.NotSupported_AnonymousPipeUnidirectional);
            }
            if (pipeHandleAsString == null)
            {
                throw new ArgumentNullException(nameof(pipeHandleAsString));
            }

            // Initialize SafePipeHandle from String and check if it's valid. First see if it's parseable
            long result = 0;
            bool parseable = long.TryParse(pipeHandleAsString, out result);
            if (!parseable)
            {
                throw new ArgumentException(SR.Argument_InvalidHandle, nameof(pipeHandleAsString));
            }

            // next check whether the handle is invalid
            SafePipeHandle safePipeHandle = new SafePipeHandle((IntPtr)result, true);
            if (safePipeHandle.IsInvalid)
            {
                throw new ArgumentException(SR.Argument_InvalidHandle, nameof(pipeHandleAsString));
            }

            Init(direction, safePipeHandle);
        }

        [SecurityCritical]
        public AnonymousPipeClientStreamDotNet(PipeDirectionDotNet direction, SafePipeHandle safePipeHandle)
            : base(direction, 0)
        {
            if (direction == PipeDirectionDotNet.InOut)
            {
                throw new NotSupportedException(SR.NotSupported_AnonymousPipeUnidirectional);
            }
            if (safePipeHandle == null)
            {
                throw new ArgumentNullException(nameof(safePipeHandle));
            }
            if (safePipeHandle.IsInvalid)
            {
                throw new ArgumentException(SR.Argument_InvalidHandle, nameof(safePipeHandle));
            }

            Init(direction, safePipeHandle);
        }

        [SecuritySafeCritical]
        private void Init(PipeDirectionDotNet direction, SafePipeHandle safePipeHandle)
        {
            Debug.Assert(direction != PipeDirectionDotNet.InOut, "anonymous pipes are unidirectional, caller should have verified before calling Init");
            Debug.Assert(safePipeHandle != null && !safePipeHandle.IsInvalid, "safePipeHandle must be valid");
            ValidateHandleIsPipe(safePipeHandle);
            
            InitializeHandle(safePipeHandle, true, false);
            State = PipeState.Connected;
        }

        ~AnonymousPipeClientStreamDotNet()
        {
            Dispose(false);
        }

        // Anonymous pipes do not support message readmode so there is no need to use the base version
        // which P/Invokes (and sometimes fails).
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
