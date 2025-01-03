// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using NamedPipeIPC.Resources;
using System.Security.AccessControl;
using System.Security.Principal;

namespace System.IO.Pipes
{
    //[System.Security.Permissions.HostProtection(MayLeakOnAbort = true)]
    public sealed class PipeAuditRuleDotNet : AuditRule
    {
        public PipeAuditRuleDotNet(
            IdentityReference identity,
            PipeAccessRightsDotNet rights,
            AuditFlags flags)
            : this(
                identity,
                AccessMaskFromRights(rights),
                false,
                flags)
        {
        }

        public PipeAuditRuleDotNet(
            String identity,
            PipeAccessRightsDotNet rights,
            AuditFlags flags)
            : this(
                new NTAccount(identity),
                AccessMaskFromRights(rights),
                false,
                flags)
        {
        }

        internal PipeAuditRuleDotNet(
            IdentityReference identity,
            int accessMask,
            bool isInherited,
            AuditFlags flags)
            : base(
                identity,
                accessMask,
                isInherited,
                InheritanceFlags.None,
                PropagationFlags.None,
                flags)
        {
        }

        private static int AccessMaskFromRights(PipeAccessRightsDotNet rights)
        {
            if (rights < (PipeAccessRightsDotNet)0 || rights > (PipeAccessRightsDotNet.FullControl | PipeAccessRightsDotNet.AccessSystemSecurity))
            {
                throw new ArgumentOutOfRangeException(nameof(rights), Strings.ArgumentOutOfRange_NeedValidPipeAccessRights);
            }

            return (int)rights;
        }

        public PipeAccessRightsDotNet PipeAccessRights
        {
            get
            {
                return PipeAccessRuleDotNet.RightsFromAccessMask(base.AccessMask);
            }
        }
    }
}

