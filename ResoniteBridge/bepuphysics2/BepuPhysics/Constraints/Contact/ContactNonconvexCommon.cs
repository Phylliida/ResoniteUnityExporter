﻿using BepuPhysics.CollisionDetection;
using BepuUtilities.Memory;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using static BepuUtilities.GatherScatter;
using BepuUtilities;

namespace BepuPhysics.Constraints.Contact
{
    public struct NonconvexContactPrestepData
    {
        public Vector3Wide Offset;
        public Vector<float> Depth;
        public Vector3Wide Normal;
    }

    public interface INonconvexContactPrestep<TPrestep> : IContactPrestep<TPrestep> where TPrestep : struct, INonconvexContactPrestep<TPrestep>
    {
        ref NonconvexContactPrestepData GetContact(ref TPrestep prestep, int index);

    }

    public interface ITwoBodyNonconvexContactPrestep<TPrestep> : INonconvexContactPrestep<TPrestep> where TPrestep : struct, ITwoBodyNonconvexContactPrestep<TPrestep>
    {
        ref Vector3Wide GetOffsetB(ref TPrestep prestep);
    }


    public interface INonconvexContactAccumulatedImpulses<TAccumulatedImpulses> : IContactAccumulatedImpulses<TAccumulatedImpulses> where TAccumulatedImpulses : struct, INonconvexContactAccumulatedImpulses<TAccumulatedImpulses>
    {
        ref NonconvexAccumulatedImpulses GetImpulsesForContact(ref TAccumulatedImpulses impulses, int index);
    }


    static class NonconvexConstraintHelpers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void CopyContactData(int contactCount, ref NonconvexConstraintContactData sourceContacts, ref NonconvexContactPrestepData targetContacts)
        {
            for (int i = 0; i < contactCount; ++i)
            {
                ref var sourceContact = ref Unsafe.Add(ref sourceContacts, i);
                ref var targetContact = ref Unsafe.Add(ref targetContacts, i);
                GetFirst(ref targetContact.Offset.X) = sourceContact.OffsetA.X;
                GetFirst(ref targetContact.Offset.Y) = sourceContact.OffsetA.Y;
                GetFirst(ref targetContact.Offset.Z) = sourceContact.OffsetA.Z;

                GetFirst(ref targetContact.Normal.X) = sourceContact.Normal.X;
                GetFirst(ref targetContact.Normal.Y) = sourceContact.Normal.Y;
                GetFirst(ref targetContact.Normal.Z) = sourceContact.Normal.Z;

                GetFirst(ref targetContact.Depth) = sourceContact.PenetrationDepth;
            }
        }
        //TODO: These could share even more, but... this already handles the 14
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ApplyTwoBodyDescription<TDescription, TPrestep>(ref TDescription description, ref TypeBatch batch, int bundleIndex, int innerIndex)
              where TPrestep : struct, ITwoBodyNonconvexContactPrestep<TPrestep>
              where TDescription : struct, INonconvexTwoBodyContactConstraintDescription<TDescription>
        {
            Debug.Assert(batch.TypeId == description.ConstraintTypeId, "The type batch passed to the description must match the description's expected type.");
            ref var target = ref GetOffsetInstance(ref Buffer<TPrestep>.Get(ref batch.PrestepData, bundleIndex), innerIndex);

            ref var sourceCommon = ref description.GetCommonProperties(ref description);
            ref var targetOffsetB = ref target.GetOffsetB(ref target);
            GetFirst(ref targetOffsetB.X) = sourceCommon.OffsetB.X;
            GetFirst(ref targetOffsetB.Y) = sourceCommon.OffsetB.Y;
            GetFirst(ref targetOffsetB.Z) = sourceCommon.OffsetB.Z;

            ref var targetMaterial = ref target.GetMaterialProperties(ref target);
            GetFirst(ref targetMaterial.FrictionCoefficient) = sourceCommon.FrictionCoefficient;
            GetFirst(ref targetMaterial.SpringSettings.AngularFrequency) = sourceCommon.SpringSettings.AngularFrequency;
            GetFirst(ref targetMaterial.SpringSettings.TwiceDampingRatio) = sourceCommon.SpringSettings.TwiceDampingRatio;
            GetFirst(ref targetMaterial.MaximumRecoveryVelocity) = sourceCommon.MaximumRecoveryVelocity;

            ref var sourceContacts = ref description.GetFirstContact(ref description);
            ref var targetContacts = ref target.GetContact(ref target, 0);
            CopyContactData(description.ContactCount, ref sourceContacts, ref targetContacts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ApplyOneBodyDescription<TDescription, TPrestep>(ref TDescription description, ref TypeBatch batch, int bundleIndex, int innerIndex)
              where TPrestep : struct, INonconvexContactPrestep<TPrestep>
              where TDescription : struct, INonconvexOneBodyContactConstraintDescription<TDescription>
        {
            Debug.Assert(batch.TypeId == description.ConstraintTypeId, "The type batch passed to the description must match the description's expected type.");
            ref var target = ref GetOffsetInstance(ref Buffer<TPrestep>.Get(ref batch.PrestepData, bundleIndex), innerIndex);

            ref var sourceCommon = ref description.GetCommonProperties(ref description);
            ref var materialCommon = ref target.GetMaterialProperties(ref target);
            GetFirst(ref materialCommon.FrictionCoefficient) = sourceCommon.FrictionCoefficient;
            GetFirst(ref materialCommon.SpringSettings.AngularFrequency) = sourceCommon.SpringSettings.AngularFrequency;
            GetFirst(ref materialCommon.SpringSettings.TwiceDampingRatio) = sourceCommon.SpringSettings.TwiceDampingRatio;
            GetFirst(ref materialCommon.MaximumRecoveryVelocity) = sourceCommon.MaximumRecoveryVelocity;

            ref var sourceContacts = ref description.GetFirstContact(ref description);
            ref var targetContacts = ref target.GetContact(ref target, 0);
            CopyContactData(description.ContactCount, ref sourceContacts, ref targetContacts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void CopyContactData(int contactCount, ref NonconvexContactPrestepData sourceContacts, ref NonconvexConstraintContactData targetContacts)
        {
            for (int i = 0; i < contactCount; ++i)
            {
                ref var source = ref Unsafe.Add(ref sourceContacts, i);
                ref var target = ref Unsafe.Add(ref targetContacts, i);
                target.OffsetA = new Vector3(GetFirst(ref source.Offset.X), GetFirst(ref source.Offset.Y), GetFirst(ref source.Offset.Z));
                target.Normal = new Vector3(GetFirst(ref source.Normal.X), GetFirst(ref source.Normal.Y), GetFirst(ref source.Normal.Z));
                target.PenetrationDepth = GetFirst(ref source.Depth);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void BuildTwoBodyDescription<TDescription, TPrestep>(ref TypeBatch batch, int bundleIndex, int innerIndex, out TDescription description)
              where TPrestep : struct, ITwoBodyNonconvexContactPrestep<TPrestep>
              where TDescription : struct, INonconvexTwoBodyContactConstraintDescription<TDescription>
        {
            Debug.Assert(batch.TypeId == default(TDescription).ConstraintTypeId, "The type batch passed to the description must match the description's expected type.");
            ref var prestep = ref GetOffsetInstance(ref Buffer<TPrestep>.Get(ref batch.PrestepData, bundleIndex), innerIndex);

            Vector3Wide.ReadFirst(prestep.GetOffsetB(ref prestep), out var offsetB);
            ref var materialSource = ref prestep.GetMaterialProperties(ref prestep);
            PairMaterialProperties material;
            material.FrictionCoefficient = GetFirst(ref materialSource.FrictionCoefficient);
            material.SpringSettings.AngularFrequency = GetFirst(ref materialSource.SpringSettings.AngularFrequency);
            material.SpringSettings.TwiceDampingRatio = GetFirst(ref materialSource.SpringSettings.TwiceDampingRatio);
            material.MaximumRecoveryVelocity = GetFirst(ref materialSource.MaximumRecoveryVelocity);

            //TODO: Replace with Unsafe.SkipInit?
            description = default;
            description.CopyManifoldWideProperties(ref offsetB, ref material);

            ref var descriptionContacts = ref description.GetFirstContact(ref description);
            ref var prestepContacts = ref prestep.GetContact(ref prestep, 0);
            CopyContactData(description.ContactCount, ref prestepContacts, ref descriptionContacts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void BuildOneBodyDescription<TDescription, TPrestep>(ref TypeBatch batch, int bundleIndex, int innerIndex, out TDescription description)
              where TPrestep : struct, INonconvexContactPrestep<TPrestep>
              where TDescription : struct, INonconvexOneBodyContactConstraintDescription<TDescription>
        {
            Debug.Assert(batch.TypeId == default(TDescription).ConstraintTypeId, "The type batch passed to the description must match the description's expected type.");
            ref var prestep = ref GetOffsetInstance(ref Buffer<TPrestep>.Get(ref batch.PrestepData, bundleIndex), innerIndex);

            ref var materialSource = ref prestep.GetMaterialProperties(ref prestep);
            PairMaterialProperties material;
            material.FrictionCoefficient = GetFirst(ref materialSource.FrictionCoefficient);
            material.SpringSettings.AngularFrequency = GetFirst(ref materialSource.SpringSettings.AngularFrequency);
            material.SpringSettings.TwiceDampingRatio = GetFirst(ref materialSource.SpringSettings.TwiceDampingRatio);
            material.MaximumRecoveryVelocity = GetFirst(ref materialSource.MaximumRecoveryVelocity);

            //TODO: Replace with Unsafe.SkipInit?
            description = default;
            description.CopyManifoldWideProperties(ref material);

            ref var descriptionContacts = ref description.GetFirstContact(ref description);
            ref var prestepContacts = ref prestep.GetContact(ref prestep, 0);
            CopyContactData(description.ContactCount, ref prestepContacts, ref descriptionContacts);
        }
    }


    public struct NonconvexAccumulatedImpulses
    {
        public Vector2Wide Tangent;
        public Vector<float> Penetration;
    }

    public struct NonconvexOneBodyProjectionCommon
    {
        public BodyInertias InertiaA;
        public Vector<float> FrictionCoefficient;
        public Vector<float> SoftnessImpulseScale;
    }
    public struct NonconvexTwoBodyProjectionCommon
    {
        public BodyInertias InertiaA;
        public BodyInertias InertiaB;
        public Vector<float> FrictionCoefficient;
        public Vector<float> SoftnessImpulseScale;
    }
    public struct ContactNonconvexOneBodyProjection
    {
        public Vector3Wide Normal;
        public TangentFrictionOneBody.Projection Tangent;
        public PenetrationLimitOneBodyProjection Penetration;
    }
    public struct ContactNonconvexTwoBodyProjection
    {
        public Vector3Wide Normal;
        public TangentFriction.Projection Tangent;
        public PenetrationLimitProjection Penetration;
    }

    public interface INonconvexOneBodyProjection<TProjection> where TProjection : INonconvexOneBodyProjection<TProjection>
    {
        ref ContactNonconvexOneBodyProjection GetFirstContact(ref TProjection description);
        int ContactCount { get; }

        ref NonconvexOneBodyProjectionCommon GetCommonProperties(ref TProjection projection);
    }
    public interface INonconvexTwoBodyProjection<TProjection> where TProjection : INonconvexTwoBodyProjection<TProjection>
    {
        ref ContactNonconvexTwoBodyProjection GetFirstContact(ref TProjection description);
        int ContactCount { get; }

        ref NonconvexTwoBodyProjectionCommon GetCommonProperties(ref TProjection projection);
    }

    public struct ContactNonconvexOneBodyFunctions<TPrestep, TProjection, TAccumulatedImpulses> :
        IOneBodyContactConstraintFunctions<TPrestep, TProjection, TAccumulatedImpulses>
        where TPrestep : struct, INonconvexContactPrestep<TPrestep>
        where TProjection : struct, INonconvexOneBodyProjection<TProjection>
        where TAccumulatedImpulses : struct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Prestep(Bodies bodies, ref Vector<int> bodyReferences, int count,
            float dt, float inverseDt, ref BodyInertias inertia, ref TPrestep prestep, out TProjection projection)
        {
            //TODO: This is another area where it's highly doubtful that the compiler will ever figure out that this initialization is unnecessary.
            //While we could jump through some nasty contortions now to resolve this, we'll instead opt for a little inefficient simplicity while waiting for generic pointer support
            //to more cleanly fix the issue.
            projection = default;
            ref var prestepMaterial = ref prestep.GetMaterialProperties(ref prestep);
            ref var projectionCommon = ref projection.GetCommonProperties(ref projection);
            projectionCommon.InertiaA = inertia;
            projectionCommon.FrictionCoefficient = prestepMaterial.FrictionCoefficient;
            ref var prestepContactStart = ref prestep.GetContact(ref prestep, 0);
            ref var projectionContactStart = ref projection.GetFirstContact(ref projection);
            SpringSettingsWide.ComputeSpringiness(prestepMaterial.SpringSettings, dt, out var positionErrorToVelocity, out var effectiveMassCFMScale, out projectionCommon.SoftnessImpulseScale);
            for (int i = 0; i < projection.ContactCount; ++i)
            {
                ref var prestepContact = ref Unsafe.Add(ref prestepContactStart, i);
                ref var projectionContact = ref Unsafe.Add(ref projectionContactStart, i);
                projectionContact.Normal = prestepContact.Normal;
                Helpers.BuildOrthonormalBasis(prestepContact.Normal, out var x, out var z);
                TangentFrictionOneBody.Prestep(ref x, ref z, ref prestepContact.Offset, ref projectionCommon.InertiaA, out projectionContact.Tangent);
                PenetrationLimitOneBody.Prestep(projectionCommon.InertiaA,
                    prestepContact.Offset, prestepContact.Normal, prestepContact.Depth,
                    positionErrorToVelocity, effectiveMassCFMScale, prestepMaterial.MaximumRecoveryVelocity, inverseDt,
                    out projectionContact.Penetration);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void WarmStart(ref BodyVelocities wsvA, ref TProjection projection, ref TAccumulatedImpulses accumulatedImpulses)
        {
            //Note that, unlike convex manifolds, we simply solve every contact in sequence rather than tangent->penetration.
            //This is not for any principled reason- only simplicity. May want to reconsider later, but remember the significant change in access pattern.
            ref var common = ref projection.GetCommonProperties(ref projection);
            ref var contactStart = ref projection.GetFirstContact(ref projection);
            ref var accumulatedImpulsesStart = ref Unsafe.As<TAccumulatedImpulses, NonconvexAccumulatedImpulses>(ref accumulatedImpulses);
            for (int i = 0; i < projection.ContactCount; ++i)
            {
                ref var contact = ref Unsafe.Add(ref contactStart, i);
                ref var contactImpulse = ref Unsafe.Add(ref accumulatedImpulsesStart, i);
                Helpers.BuildOrthonormalBasis(contact.Normal, out var x, out var z);
                TangentFrictionOneBody.WarmStart(ref x, ref z, ref contact.Tangent, ref common.InertiaA, ref contactImpulse.Tangent, ref wsvA);
                PenetrationLimitOneBody.WarmStart(contact.Penetration, common.InertiaA, contact.Normal, contactImpulse.Penetration, ref wsvA);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Solve(ref BodyVelocities wsvA, ref TProjection projection, ref TAccumulatedImpulses accumulatedImpulses)
        {
            //Note that, unlike convex manifolds, we simply solve every contact in sequence rather than tangent->penetration.
            //This is not for any principled reason- only simplicity. May want to reconsider later, but remember the significant change in access pattern.
            ref var common = ref projection.GetCommonProperties(ref projection);
            ref var contactStart = ref projection.GetFirstContact(ref projection);
            ref var accumulatedImpulsesStart = ref Unsafe.As<TAccumulatedImpulses, NonconvexAccumulatedImpulses>(ref accumulatedImpulses);
            for (int i = 0; i < projection.ContactCount; ++i)
            {
                ref var contact = ref Unsafe.Add(ref contactStart, i);
                ref var contactImpulse = ref Unsafe.Add(ref accumulatedImpulsesStart, i);
                Helpers.BuildOrthonormalBasis(contact.Normal, out var x, out var z);
                var maximumTangentImpulse = common.FrictionCoefficient * contactImpulse.Penetration;
                TangentFrictionOneBody.Solve(ref x, ref z, ref contact.Tangent, ref common.InertiaA, ref maximumTangentImpulse, ref contactImpulse.Tangent, ref wsvA);
                PenetrationLimitOneBody.Solve(contact.Penetration, common.InertiaA, contact.Normal, common.SoftnessImpulseScale,
                    ref contactImpulse.Penetration, ref wsvA);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IncrementallyUpdateContactData(in Vector<float> dt, in BodyVelocities velocity, ref TPrestep prestep)
        {
            ref var prestepContactStart = ref prestep.GetContact(ref prestep, 0);
            for (int i = 0; i < prestep.ContactCount; ++i)
            {
                ref var prestepContact = ref Unsafe.Add(ref prestepContactStart, i);
                PenetrationLimitOneBody.UpdatePenetrationDepth(dt, prestepContact.Offset, prestepContact.Normal, velocity, ref prestepContact.Depth);
            }
        }
    }

    public struct ContactNonconvexTwoBodyFunctions<TPrestep, TProjection, TAccumulatedImpulses> :
        IContactConstraintFunctions<TPrestep, TProjection, TAccumulatedImpulses>
        where TPrestep : struct, ITwoBodyNonconvexContactPrestep<TPrestep>
        where TProjection : struct, INonconvexTwoBodyProjection<TProjection>
        where TAccumulatedImpulses : struct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Prestep(Bodies bodies, ref TwoBodyReferences bodyReferences, int count,
            float dt, float inverseDt, ref BodyInertias inertiaA, ref BodyInertias inertiaB, ref TPrestep prestep, out TProjection projection)
        {
            //TODO: This is another area where it's highly doubtful that the compiler will ever figure out that this initialization is unnecessary.
            //While we could jump through some nasty contortions now to resolve this, we'll instead opt for a little inefficient simplicity while waiting for generic pointer support
            //to more cleanly fix the issue.
            projection = default;
            ref var prestepMaterial = ref prestep.GetMaterialProperties(ref prestep);
            ref var prestepOffsetB = ref prestep.GetOffsetB(ref prestep);
            ref var projectionCommon = ref projection.GetCommonProperties(ref projection);
            projectionCommon.InertiaA = inertiaA;
            projectionCommon.InertiaB = inertiaB;
            projectionCommon.FrictionCoefficient = prestepMaterial.FrictionCoefficient;
            ref var prestepContactStart = ref prestep.GetContact(ref prestep, 0);
            ref var projectionContactStart = ref projection.GetFirstContact(ref projection);
            SpringSettingsWide.ComputeSpringiness(prestepMaterial.SpringSettings, dt, out var positionErrorToVelocity, out var effectiveMassCFMScale, out projectionCommon.SoftnessImpulseScale);
            for (int i = 0; i < projection.ContactCount; ++i)
            {
                ref var prestepContact = ref Unsafe.Add(ref prestepContactStart, i);
                ref var projectionContact = ref Unsafe.Add(ref projectionContactStart, i);
                projectionContact.Normal = prestepContact.Normal;
                Helpers.BuildOrthonormalBasis(prestepContact.Normal, out var x, out var z);
                Vector3Wide.Subtract(prestepContact.Offset, prestepOffsetB, out var contactOffsetB);
                TangentFriction.Prestep(ref x, ref z, ref prestepContact.Offset, ref contactOffsetB, ref projectionCommon.InertiaA, ref projectionCommon.InertiaB, out projectionContact.Tangent);
                PenetrationLimit.Prestep(projectionCommon.InertiaA, projectionCommon.InertiaB,
                    prestepContact.Offset, contactOffsetB, prestepContact.Normal, prestepContact.Depth, 
                    positionErrorToVelocity, effectiveMassCFMScale, prestepMaterial.MaximumRecoveryVelocity, inverseDt,
                    out projectionContact.Penetration);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void WarmStart(ref BodyVelocities wsvA, ref BodyVelocities wsvB, ref TProjection projection, ref TAccumulatedImpulses accumulatedImpulses)
        {
            //Note that, unlike convex manifolds, we simply solve every contact in sequence rather than tangent->penetration.
            //This is not for any principled reason- only simplicity. May want to reconsider later, but remember the significant change in access pattern.
            ref var common = ref projection.GetCommonProperties(ref projection);
            ref var contactStart = ref projection.GetFirstContact(ref projection);
            ref var accumulatedImpulsesStart = ref Unsafe.As<TAccumulatedImpulses, NonconvexAccumulatedImpulses>(ref accumulatedImpulses);
            for (int i = 0; i < projection.ContactCount; ++i)
            {
                ref var contact = ref Unsafe.Add(ref contactStart, i);
                ref var contactImpulse = ref Unsafe.Add(ref accumulatedImpulsesStart, i);
                Helpers.BuildOrthonormalBasis(contact.Normal, out var x, out var z);
                TangentFriction.WarmStart(ref x, ref z, ref contact.Tangent, ref common.InertiaA, ref common.InertiaB, ref contactImpulse.Tangent, ref wsvA, ref wsvB);
                PenetrationLimit.WarmStart(contact.Penetration, common.InertiaA, common.InertiaB, contact.Normal, contactImpulse.Penetration, ref wsvA, ref wsvB);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Solve(ref BodyVelocities wsvA, ref BodyVelocities wsvB, ref TProjection projection, ref TAccumulatedImpulses accumulatedImpulses)
        {
            //Note that, unlike convex manifolds, we simply solve every contact in sequence rather than tangent->penetration.
            //This is not for any principled reason- only simplicity. May want to reconsider later, but remember the significant change in access pattern.
            ref var common = ref projection.GetCommonProperties(ref projection);
            ref var contactStart = ref projection.GetFirstContact(ref projection);
            ref var accumulatedImpulsesStart = ref Unsafe.As<TAccumulatedImpulses, NonconvexAccumulatedImpulses>(ref accumulatedImpulses);
            for (int i = 0; i < projection.ContactCount; ++i)
            {
                ref var contact = ref Unsafe.Add(ref contactStart, i);
                ref var contactImpulse = ref Unsafe.Add(ref accumulatedImpulsesStart, i);
                Helpers.BuildOrthonormalBasis(contact.Normal, out var x, out var z);
                var maximumTangentImpulse = common.FrictionCoefficient * contactImpulse.Penetration;
                TangentFriction.Solve(ref x, ref z, ref contact.Tangent, ref common.InertiaA, ref common.InertiaB, ref maximumTangentImpulse, ref contactImpulse.Tangent, ref wsvA, ref wsvB);
                PenetrationLimit.Solve(contact.Penetration, common.InertiaA, common.InertiaB, contact.Normal, common.SoftnessImpulseScale, ref contactImpulse.Penetration, ref wsvA, ref wsvB);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IncrementallyUpdateContactData(in Vector<float> dt, in BodyVelocities velocityA, in BodyVelocities velocityB, ref TPrestep prestep)
        {
            ref var prestepOffsetB = ref prestep.GetOffsetB(ref prestep);
            ref var prestepContactStart = ref prestep.GetContact(ref prestep, 0);
            for (int i = 0; i < prestep.ContactCount; ++i)
            {
                ref var prestepContact = ref Unsafe.Add(ref prestepContactStart, i);
                PenetrationLimit.UpdatePenetrationDepth(dt, prestepContact.Offset, prestepOffsetB, prestepContact.Normal, velocityA, velocityB, ref prestepContact.Depth);
            }
        }
    }
}
