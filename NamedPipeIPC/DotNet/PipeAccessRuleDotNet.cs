// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using NamedPipeIPC.Resources;
using System.Security.AccessControl;
using System.Security.Principal;

namespace System.IO.Pipes
{
    // [System.Security.Permissions.HostProtection(MayLeakOnAbort = true)]
    public sealed class PipeAccessRuleDotNet : AccessRule
    {
        //
        // Constructor for creating access rules for pipe objects
        //
        public PipeAccessRuleDotNet( String identity, PipeAccessRightsDotNet rights, AccessControlType type)
            : this( new NTAccount(identity), AccessMaskFromRights(rights, type), false, type)
        {
        }

        public PipeAccessRuleDotNet( IdentityReference identity, PipeAccessRightsDotNet rights, AccessControlType type)
            : this(identity, AccessMaskFromRights(rights, type), false, type)
        {
        }

        //
        // Internal constructor to be called by public constructors
        // and the access rights factory methods
        //
        internal PipeAccessRuleDotNet( IdentityReference identity, int accessMask, bool isInherited, AccessControlType type)
            : base( identity, accessMask, isInherited, System.Security.AccessControl.InheritanceFlags.None, PropagationFlags.None, type)
        {
        }

        public PipeAccessRightsDotNet PipeAccessRights
        {
            get
            {
                return RightsFromAccessMask(base.AccessMask);
            }
        }

        // ACL's on pipes have a SYNCHRONIZE bit, and CreateFile ALWAYS asks for it.  
        // So for allows, let's always include this bit, and for denies, let's never
        // include this bit unless we're denying full control.  This is the right 
        // thing for users, even if it does make the model look asymmetrical from a
        // purist point of view.
        internal static int AccessMaskFromRights(PipeAccessRightsDotNet rights, AccessControlType controlType)
        {
            if (rights < (PipeAccessRightsDotNet)0 || rights > (PipeAccessRightsDotNet.FullControl | PipeAccessRightsDotNet.AccessSystemSecurity))
                throw new ArgumentOutOfRangeException(nameof(rights), Strings.ArgumentOutOfRange_NeedValidPipeAccessRights);

            if (controlType == AccessControlType.Allow)
            {
                rights |= PipeAccessRightsDotNet.Synchronize;
            }
            else if (controlType == AccessControlType.Deny)
            {
                if (rights != PipeAccessRightsDotNet.FullControl)
                {
                    rights &= ~PipeAccessRightsDotNet.Synchronize;
                }
            }

            return (int)rights;
        }

        internal static PipeAccessRightsDotNet RightsFromAccessMask(int accessMask)
        {
            return (PipeAccessRightsDotNet)accessMask;
        }
    }
}

