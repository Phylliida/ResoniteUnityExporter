// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Runtime.InteropServices;
using NamedPipeIPC.Resources;

namespace System.IO.Pipes
{
    //[System.Security.Permissions.HostProtection(MayLeakOnAbort = true)]
    public class PipeSecurityDotNet : NativeObjectSecurity
    {
        public PipeSecurityDotNet()
            : base(false, ResourceType.KernelObject) { }

        // Used by PipeStream.GetAccessControl
        internal PipeSecurityDotNet(SafePipeHandle safeHandle, AccessControlSections includeSections)
            : base(false, ResourceType.KernelObject, safeHandle, includeSections) { }

        public void AddAccessRule(PipeAccessRuleDotNet rule)
        {
            if (rule == null)
                throw new ArgumentNullException(nameof(rule));

            base.AddAccessRule(rule);
        }

        public void SetAccessRule(PipeAccessRuleDotNet rule)
        {
            if (rule == null)
                throw new ArgumentNullException(nameof(rule));

            base.SetAccessRule(rule);
        }

        public void ResetAccessRule(PipeAccessRuleDotNet rule)
        {
            if (rule == null)
                throw new ArgumentNullException(nameof(rule));

            base.ResetAccessRule(rule);
        }

        public bool RemoveAccessRule(PipeAccessRuleDotNet rule)
        {
            if (rule == null)
            {
                throw new ArgumentNullException(nameof(rule));
            }

            // If the rule to be removed matches what is there currently then 
            // remove it unaltered. That is, don't mask off the Synchronize bit.
            AuthorizationRuleCollection rules = GetAccessRules(true, true, rule.IdentityReference.GetType());

            for (int i = 0; i < rules.Count; i++)
            {
                PipeAccessRuleDotNet fsrule = rules[i] as PipeAccessRuleDotNet;

                if ((fsrule != null) && (fsrule.PipeAccessRights == rule.PipeAccessRights)
                        && (fsrule.IdentityReference == rule.IdentityReference)
                        && (fsrule.AccessControlType == rule.AccessControlType))
                {
                    return base.RemoveAccessRule(rule);
                }
            }

            // It didn't exactly match any of the current rules so remove this way:
            // mask off the synchronize bit (that is automatically added for Allow)
            // before removing the ACL. The logic here should be same as Deny and hence
            // fake a call to AccessMaskFromRights as though the ACL is for Deny
            if (rule.PipeAccessRights != PipeAccessRightsDotNet.FullControl)
            {
                return base.RemoveAccessRule(new PipeAccessRuleDotNet(
                            rule.IdentityReference,
                            PipeAccessRuleDotNet.AccessMaskFromRights(rule.PipeAccessRights, AccessControlType.Deny),
                            false,
                            rule.AccessControlType));
            }
            else
            {
                return base.RemoveAccessRule(rule);
            }
        }

        public void RemoveAccessRuleSpecific(PipeAccessRuleDotNet rule)
        {
            if (rule == null)
            {
                throw new ArgumentNullException(nameof(rule));
            }

            // If the rule to be removed matches what is there currently then 
            // remove it unaltered. That is, don't mask off the Synchronize bit
            AuthorizationRuleCollection rules = GetAccessRules(true, true,
                    rule.IdentityReference.GetType());

            for (int i = 0; i < rules.Count; i++)
            {
                PipeAccessRuleDotNet fsrule = rules[i] as PipeAccessRuleDotNet;

                if ((fsrule != null) && (fsrule.PipeAccessRights == rule.PipeAccessRights)
                    && (fsrule.IdentityReference == rule.IdentityReference)
                    && (fsrule.AccessControlType == rule.AccessControlType))
                {
                    base.RemoveAccessRuleSpecific(rule);
                    return;
                }
            }

            // It wasn't an exact match so try masking the sychronize bit (that is 
            // automatically added for Allow) before removing the ACL. The logic 
            // here should be same as Deny and hence fake a call to 
            // AccessMaskFromRights as though the ACL is for Deny
            if (rule.PipeAccessRights != PipeAccessRightsDotNet.FullControl)
            {
                base.RemoveAccessRuleSpecific(new PipeAccessRuleDotNet(rule.IdentityReference,
                    PipeAccessRuleDotNet.AccessMaskFromRights(rule.PipeAccessRights, AccessControlType.Deny),
                    false,
                    rule.AccessControlType));
            }
            else
            {
                base.RemoveAccessRuleSpecific(rule);
            }
        }

        public void AddAuditRule(PipeAuditRuleDotNet rule)
        {
            base.AddAuditRule(rule);
        }

        public void SetAuditRule(PipeAuditRuleDotNet rule)
        {
            base.SetAuditRule(rule);
        }

        public bool RemoveAuditRule(PipeAuditRuleDotNet rule)
        {
            return base.RemoveAuditRule(rule);
        }

        public void RemoveAuditRuleAll(PipeAuditRuleDotNet rule)
        {
            base.RemoveAuditRuleAll(rule);
        }

        public void RemoveAuditRuleSpecific(PipeAuditRuleDotNet rule)
        {
            base.RemoveAuditRuleSpecific(rule);
        }

        public override AccessRule AccessRuleFactory(IdentityReference identityReference,
                int accessMask, bool isInherited, InheritanceFlags inheritanceFlags,
                PropagationFlags propagationFlags, AccessControlType type)
        {
            // Throw if inheritance flags or propagation flags set. Have to include in signature
            // since this is an override
            if (inheritanceFlags != InheritanceFlags.None)
            {
                throw new ArgumentException(Strings.Argument_NonContainerInvalidAnyFlag, nameof(inheritanceFlags));
            }
            if (propagationFlags != PropagationFlags.None)
            {
                throw new ArgumentException(Strings.Argument_NonContainerInvalidAnyFlag, nameof(propagationFlags));
            }

            return new PipeAccessRuleDotNet(
                identityReference,
                accessMask,
                isInherited,
                type);

        }


        public sealed override AuditRule AuditRuleFactory(
            IdentityReference identityReference,
            int accessMask,
            bool isInherited,
            InheritanceFlags inheritanceFlags,
            PropagationFlags propagationFlags,
            AuditFlags flags)
        {

            // Throw if inheritance flags or propagation flags set. Have to include in signature
            // since this is an override
            if (inheritanceFlags != InheritanceFlags.None)
            {
                throw new ArgumentException(Strings.Argument_NonContainerInvalidAnyFlag, nameof(inheritanceFlags));
            }
            if (propagationFlags != PropagationFlags.None)
            {
                throw new ArgumentException(Strings.Argument_NonContainerInvalidAnyFlag, nameof(propagationFlags));
            }

            return new PipeAuditRuleDotNet(
                identityReference,
                accessMask,
                isInherited,
                flags);
        }

        private AccessControlSections GetAccessControlSectionsFromChanges()
        {
            AccessControlSections persistRules = AccessControlSections.None;
            if (AccessRulesModified)
                persistRules = AccessControlSections.Access;
            if (AuditRulesModified)
                persistRules |= AccessControlSections.Audit;
            if (OwnerModified)
                persistRules |= AccessControlSections.Owner;
            if (GroupModified)
                persistRules |= AccessControlSections.Group;
            return persistRules;
        }

        protected internal void Persist(SafeHandle handle)
        {
            WriteLock();

            try
            {
                AccessControlSections persistRules = GetAccessControlSectionsFromChanges();
                base.Persist(handle, persistRules);
                OwnerModified = GroupModified = AuditRulesModified = AccessRulesModified = false;
            }
            finally
            {
                WriteUnlock();
            }
        }

        protected internal void Persist(String name)
        {
            WriteLock();

            try
            {
                AccessControlSections persistRules = GetAccessControlSectionsFromChanges();
                base.Persist(name, persistRules);
                OwnerModified = GroupModified = AuditRulesModified = AccessRulesModified = false;
            }
            finally
            {
                WriteUnlock();
            }
        }

        public override Type AccessRightType
        {
            get
            {
                return typeof(PipeAccessRightsDotNet);
            }
        }

        public override Type AccessRuleType
        {
            get
            {
                return typeof(PipeAccessRuleDotNet);
            }
        }

        public override Type AuditRuleType
        {
            get
            {
                return typeof(PipeAuditRuleDotNet);
            }
        }
    }
}

