// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using NamedPipeIPC.Resources;
using System.IO;
using System.Security.AccessControl;

namespace System.IO.Pipes
{
    public static class PipesAclExtensionsDotNet
    {
        public static PipeSecurityDotNet GetAccessControl(this PipeStreamDotNet stream)
        {
            // Checks that State != WaitingToConnect and State != Closed
            var handle = stream.SafePipeHandle;

            // PipeState must be Disconnected, Connected, or Broken
            return new PipeSecurityDotNet(handle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
        }

        public static void SetAccessControl(this PipeStreamDotNet stream, PipeSecurityDotNet pipeSecurity)
        {
            if (pipeSecurity == null)
            {
                throw new ArgumentNullException(nameof(pipeSecurity));
            }

            // Checks that State != WaitingToConnect and State != Closed
            var handle = stream.SafePipeHandle;

            // Checks that State != Broken
            if (stream is NamedPipeClientStream && !stream.IsConnected)
            {
                throw new IOException(Strings.IO_IO_PipeBroken);
            }

            // PipeState must be either Disconected or Connected
            pipeSecurity.Persist(handle);
        }
    }
}
