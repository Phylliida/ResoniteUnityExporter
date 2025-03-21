﻿extern alias Froox;

using Froox::FrooxEngine;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using Froox::Elements.Core;
using System.IO;
using System.Reflection;
using Froox::FrooxEngine.CommonAvatar;
using MemoryMappedFileIPC;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class ImportAvatar
    {
        public static IEnumerator<Context> ImportAvatarHelper(byte[] avatarBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToWorld();
            Avatar_U2Res avatarData = SerializationUtils.DecodeObject<Avatar_U2Res>(avatarBytes);
            ImportFromUnityLib.DebugLog("Importing avatar");
            List<Slot> allSlots = new List<Slot>();
            HashSet<RefID> bonesSet = new HashSet<RefID>();
            List<Slot> bones = new List<Slot>();
            World focusedWorld = ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld;
            // collect all renderer bones into one list to put in the rig
            foreach (RefID_U2Res rendererComponentRefID in avatarData.renderers)
            {
                IWorldElement rendererComponent = ImportFromUnityUtils.LookupRefID(rendererComponentRefID);
                if (rendererComponent != null)
                {
                    allSlots.Add(((Froox::FrooxEngine.Component)rendererComponent).Slot);
                }
                if (rendererComponent.GetType().ToString() == "FrooxEngine.SkinnedMeshRenderer")
                {
                    SkinnedMeshRenderer skinnedMesh = (SkinnedMeshRenderer)rendererComponent;
                    if (skinnedMesh.Bones != null)
                    {
                        foreach (Slot bone in skinnedMesh.Bones)
                        {
                            if (!bonesSet.Contains(bone.ReferenceID))
                            {
                                bonesSet.Add(bone.ReferenceID);
                                bones.Add(bone);
                                allSlots.Add(bone);
                            }
                        }
                    }
                }
            }

            Slot sharedParent = FindSharedParent(allSlots.ToArray());
            // add extra parent so vrik is happy
            Slot mainParentSlot = (Slot)ImportFromUnityUtils.LookupRefID(avatarData.mainParentSlot);
            if (avatarData.setupIK)
            {
                Slot parentParent = sharedParent.Parent.AddSlot(mainParentSlot.Name);
                sharedParent.SetParent(parentParent);
                sharedParent = parentParent;
            }


            Rig rig = sharedParent.AttachComponent<Rig>();
            foreach (Slot boneSlot in bones)
            {
                rig.Bones.Add().Value = boneSlot.ReferenceID;
            }

            float3 relativeCustomHeadPosition = float3.Zero;
            if (avatarData.hasCustomHeadPosition)
            {
                mainParentSlot.LocalScale = new float3(1, 1, 1);
                float3 customHeadPosition = new float3(avatarData.customHeadPosition.x, avatarData.customHeadPosition.y, avatarData.customHeadPosition.z);
                relativeCustomHeadPosition = sharedParent.GlobalPointToLocal(customHeadPosition);
                mainParentSlot.LocalScale = new float3(1.0f/avatarData.rescaleFactor, 1.0f / avatarData.rescaleFactor, 1.0f / avatarData.rescaleFactor);
            }
            if (avatarData.rescale)
            {
                // compute bounding box of all bones to estimate bounding box of mesh
                // we could also just directly compute bounding box of mesh but then we'd need
                // to transform and it depends on where the bones are, so this is good enough
                /*
                Elements.Core.BoundingBox box = new Elements.Core.BoundingBox();
                foreach (Slot bone in bones)
                {
                    box.Encapsulate(sharedParent.Parent.GlobalPointToLocal(bone.GlobalPosition));
                }
                float largestSize = Math.Max(box.Size.x, Math.Max(box.Size.y, box.Size.z));
                ImportFromUnityLib.DebugLog("Largest size:" + largestSize);
                ImportFromUnityLib.DebugLog("box:" + box.Size);
                float newScale = avatarData.targetScale / largestSize;
                // this ensures fov adjust is correct
                */
                float newScale = 1.0f / avatarData.rescaleFactor; // lets just use fixed adjust, hard coded on other side too
                //ImportFromUnityLib.DebugLog("Scale adjust:" + newScale);
                sharedParent.LocalScale *= new float3(newScale, newScale, newScale);
                // since we rescale with our custom parent, undo scale on the root
                mainParentSlot.LocalScale = new float3(1, 1, 1);
            }
            if (avatarData.floorOnOrigin)
            {
                Froox::Elements.Core.BoundingBox box = sharedParent.ComputeBoundingBox(false, focusedWorld.RootSlot);
                // we want this to be 0,0,0
                float3 currentFloorPos = box.Center - new float3(0, box.Size.y / 2.0f, 0);
                sharedParent.GlobalPosition = sharedParent.GlobalPosition - currentFloorPos;
            }
            
            // add material relay
            MeshRendererMaterialRelay materialRelay = sharedParent.AttachComponent<MeshRendererMaterialRelay>();
            mainParentSlot.GetComponentsInChildren<MeshRenderer>().ForEach(x =>
            {
                materialRelay.Renderers.Add(x);
            });

            // add objectroot
            sharedParent.AttachComponent<ObjectRoot>();

            if (avatarData.setupIK)
            {
                Slot renderSettingsSlot = sharedParent.AddSlot("Avatar Render Settings");
                AvatarRenderSettings renderSettings = renderSettingsSlot.AttachComponent<AvatarRenderSettings>();

                renderSettings.NearClip.Value = avatarData.nearClip;



                Slot assetsSlot = (Slot)ImportFromUnityUtils.LookupRefID(avatarData.assetsSlot);
                SetupIK(rig, sharedParent, assetsSlot,
                    avatarData.forceTPose,
                    avatarData.generateColliders,
                    avatarData.generateSkeletonBoneVisuals);

                BipedRig bipedRig = rig.Slot.GetComponent<BipedRig>();
                if (avatarData.setupAvatarCreator && bipedRig != null)
                {
                    Slot aviCreatorSlot = mainParentSlot.AddSlot("Avatar Creator");
                    AvatarCreator aviCreator = aviCreatorSlot.AttachComponent<AvatarCreator>();
                    // LocalUser.Root is null in standalone
                    if (focusedWorld.LocalUser != null && focusedWorld.LocalUser.Root != null && focusedWorld.LocalUser.Root.Slot != null)
                    {
                        aviCreatorSlot.AttachComponent<ReferenceField<User>>().Reference.Target = focusedWorld.LocalUser;
                        aviCreatorSlot.PositionInFrontOfUser(null, null, 1.25f);
                        aviCreatorSlot.FloorAtUserRoot(height: 0, user: focusedWorld.LocalUser);
                        aviCreatorSlot.PointAtUserHead(float3.Forward, verticalAxisOnly: true);
                    }
                    Slot head = bipedRig.TryGetBone(BodyNode.Head);
                    Slot rightHandRef = ((SyncRef<Slot>)aviCreator.GetType().GetField("_rightReference", BindingFlags.Instance | BindingFlags.NonPublic)
                        .GetValue(aviCreator)).Target;
                    Slot leftHandRef = ((SyncRef<Slot>)aviCreator.GetType().GetField("_leftReference", BindingFlags.Instance | BindingFlags.NonPublic)
                        .GetValue(aviCreator)).Target;

                    float3 aviCreatorScale = ComputeAviCreatorScale(bipedRig);
                    Slot headsetRef = ((SyncRef<Slot>)aviCreator.GetType().GetField("_headsetReference", BindingFlags.Instance | BindingFlags.NonPublic)
                    .GetValue(aviCreator)).Target;
                    // line up head
                    if (head != null)
                    {
                        headsetRef.GlobalPosition = avatarData.hasCustomHeadPosition
                            ? sharedParent.LocalPointToGlobal(relativeCustomHeadPosition)
                            : head.GlobalPosition;
                        headsetRef.GlobalRotation = head.GlobalRotation;
                        headsetRef.GlobalScale = aviCreatorScale;
                    }
                    // line up right hand (symmetry will take care of left hand)
                    Slot rightHand = bipedRig.TryGetBone(BodyNode.RightHand);
                    if (rightHand != null)
                    {
                        rightHandRef.GlobalPosition = rightHand.GlobalPosition;
                        float3 localScale = rightHandRef.Parent.GlobalScaleToLocal(aviCreatorScale);
                        rightHandRef.GlobalScale = aviCreatorScale;
                        SetAviCreatorHandRotation(bipedRig, aviCreator, localScale, true);
                    }
                    // line up left hand and check if not symmetric
                    Slot leftHand = bipedRig.TryGetBone(BodyNode.LeftHand);
                    if (leftHand != null)
                    {
                        // give mirror transform time to apply
                        floatQ prevRightHandRotation = rightHandRef.LocalRotation;
                        // manually compute mirror transform so we don't need to wait for update
                        float3 mirrorNormal = headsetRef.LocalDirectionToGlobal(float3.Right);
                        floatQ prevLeftHandRotation = leftHandRef.Parent.GlobalRotationToLocal(
                            MathX.ReflectRotation(rightHandRef.GlobalRotation, mirrorNormal)
                            );
                        leftHandRef.GlobalPosition = leftHand.GlobalPosition;
                        float3 localScale = leftHandRef.Parent.GlobalScaleToLocal(aviCreatorScale);
                        leftHandRef.GlobalScale = aviCreatorScale;
                        SetAviCreatorHandRotation(bipedRig, aviCreator, localScale, false);
                        floatQ computedLeftHandRotation = leftHandRef.LocalRotation;
                        // not symmetric hands, turn off symmetry
                        // (greater than 5 degrees difference, that's quite a bit)
                        float angleDiff = Math.Abs(MathX.Angle(prevLeftHandRotation, computedLeftHandRotation));
                        if (angleDiff > 5.0f && angleDiff < 355.0f)
                        {
                            Sync<bool> useSymmetry = (Sync<bool>)aviCreator
                                .GetType()
                                .GetField("_useSymmetry", BindingFlags.Instance | BindingFlags.NonPublic)
                                .GetValue(aviCreator);
                            useSymmetry.Value = false;
                            // call on changes callback to update
                            aviCreator
                                .GetType()
                                .GetMethod("OnChanges", BindingFlags.Instance | BindingFlags.NonPublic)
                                .Invoke(aviCreator, new object[] { });
                            // wait for changes to update
                            yield return Context.WaitForNextUpdate();
                            yield return Context.WaitForNextUpdate();
                            yield return Context.ToWorld();
                            // set right hand back to what it was before
                            rightHandRef.GlobalPosition = rightHand.GlobalPosition;
                            rightHandRef.LocalRotation = prevRightHandRotation;
                        }
                    }
                }
                else if (avatarData.setupAvatarCreator && bipedRig == null)
                {
                    ImportFromUnityLib.DebugLog("Failed to detect humanoid rig, not setting up avatar creator");
                }
            }


            // ik
            // return refid of Slot holding everything
            RefID_U2Res result = new RefID_U2Res()
            {
                id = (ulong)sharedParent.ReferenceID
            };
            
            outputBytes.outputBytes = SerializationUtils.EncodeObject(result);
        }

        static float3[] relativeFingerPositionsRight = new float3[] {
            new float3(-0.0944553f, -0.06033006f, 0.1202253f), // thumb
            new float3(-0.03632067f, -0.0295704f, 0.2140587f), // index
            new float3(-0.01105062f, -0.02654553f, 0.2155553f), // middle
            new float3(0.01396004f, -0.02654572f, 0.2100046f), // ring
            new float3(0.03692787f, -0.02956969f, 0.1954267f) // pinky
        };

        static float3[] relativeFingerPositionsLeft = new float3[]
        {
            new float3(0.09763367f, -0.06523453f, 0.1208142f), // thumb
            new float3(0.03690476f, -0.02722489f, 0.209686f), // index
            new float3(0.01103727f, -0.02597604f, 0.2162421f), // middle
            new float3(-0.0133688f, -0.0280386f, 0.2088304f), // ring
            new float3(-0.03593383f, -0.03025665f, 0.1963694f) // pinky
        };

        static BodyNode[][] leftFingerOrders = new BodyNode[][]
        {
            new BodyNode[]
            {
                BodyNode.LeftThumb_Metacarpal,
                BodyNode.LeftThumb_Proximal,
                BodyNode.LeftThumb_Distal,
                BodyNode.LeftThumb_Tip,
            },
            new BodyNode[]
            {
                BodyNode.LeftIndexFinger_Metacarpal,
                BodyNode.LeftIndexFinger_Proximal,
                BodyNode.LeftIndexFinger_Intermediate,
                BodyNode.LeftIndexFinger_Distal,
                BodyNode.LeftIndexFinger_Tip,
            },
            new BodyNode[]
            {
                BodyNode.LeftMiddleFinger_Metacarpal,
                BodyNode.LeftMiddleFinger_Proximal,
                BodyNode.LeftMiddleFinger_Intermediate,
                BodyNode.LeftMiddleFinger_Distal,
                BodyNode.LeftMiddleFinger_Tip,
            },
            new BodyNode[]
            {
                BodyNode.LeftRingFinger_Metacarpal,
                BodyNode.LeftRingFinger_Proximal,
                BodyNode.LeftRingFinger_Intermediate,
                BodyNode.LeftRingFinger_Distal,
                BodyNode.LeftRingFinger_Tip,
           },
            new BodyNode[]
            {
                BodyNode.LeftPinky_Metacarpal,
                BodyNode.LeftPinky_Proximal,
                BodyNode.LeftPinky_Intermediate,
                BodyNode.LeftPinky_Distal,
                BodyNode.LeftPinky_Tip,
            },
        };

        static BodyNode[][] rightFingerOrders = new BodyNode[][]
        {
            new BodyNode[]
            {
                BodyNode.RightThumb_Metacarpal,
                BodyNode.RightThumb_Proximal,
                BodyNode.RightThumb_Distal,
                BodyNode.RightThumb_Tip,
            },
            new BodyNode[]
            {
                BodyNode.RightIndexFinger_Metacarpal,
                BodyNode.RightIndexFinger_Proximal,
                BodyNode.RightIndexFinger_Intermediate,
                BodyNode.RightIndexFinger_Distal,
                BodyNode.RightIndexFinger_Tip,
            },
            new BodyNode[]
            {
                BodyNode.RightMiddleFinger_Metacarpal,
                BodyNode.RightMiddleFinger_Proximal,
                BodyNode.RightMiddleFinger_Intermediate,
                BodyNode.RightMiddleFinger_Distal,
                BodyNode.RightMiddleFinger_Tip,
            },
            new BodyNode[]
            {
                BodyNode.RightRingFinger_Metacarpal,
                BodyNode.RightRingFinger_Proximal,
                BodyNode.RightRingFinger_Intermediate,
                BodyNode.RightRingFinger_Distal,
                BodyNode.RightRingFinger_Tip,
           },
            new BodyNode[]
            {
                BodyNode.RightPinky_Metacarpal,
                BodyNode.RightPinky_Proximal,
                BodyNode.RightPinky_Intermediate,
                BodyNode.RightPinky_Distal,
                BodyNode.RightPinky_Tip,
            },
        };

        static Slot[] GetFingerTips(BipedRig bipedRig, bool rightSide, out float3[] tipRefs, bool includeThumb)
        {
            BodyNode[][] fingerOrders = rightSide ? rightFingerOrders : leftFingerOrders;
            float3[] handTipRefs = rightSide ? relativeFingerPositionsRight : relativeFingerPositionsLeft;
            List<Slot> fingerTips = new List<Slot>();
            List<float3> tipRefsList = new List<float3>();
            for(int i = 0; i < fingerOrders.Length; i++)
            {
                //ImportFromUnityLib.DebugLog("Finger order:" + fingerOrders[i]);
                BodyNode[] fingerOrder = fingerOrders[i];
                // todo: lookup positions for left hand
                if (!includeThumb && fingerOrder[0].ToString().ToLower().Contains("thumb"))
                {
                    continue;
                }
                // get furthest part of finger available
                Slot fingerTip = null;
                foreach (BodyNode fingerPart in fingerOrder)
                {
                    //ImportFromUnityLib.DebugLog("Finger part:" + fingerPart);
                    Slot curTip = bipedRig.TryGetBone(fingerPart);
                    if (curTip != null)
                    {
                        fingerTip = curTip;
                    }
                }
                if (fingerTip != null)
                {
                    //ImportFromUnityLib.DebugLog("Got tip for finger:" + fingerTip + " with i " + i);
                    tipRefsList.Add(handTipRefs[i]);
                    //ImportFromUnityLib.DebugLog("set tip for finger:" + fingerTip);
                    fingerTips.Add(fingerTip);
                }
            }
            tipRefs = tipRefsList.ToArray();
            return fingerTips.ToArray();
        }

        static void SetAviCreatorHandRotation(BipedRig bipedRig, AvatarCreator avatarCreator, float3 localScale, bool rightSide)
        {
            float3 globalFingerTipRef1;
            float3 globalFingerTipRef2;
            float3 localAviCreatorTipRef1;
            float3 localAviCreatorTipRef2;
            Slot[] nonThumbFingerTips = GetFingerTips(bipedRig, rightSide, out float3[] noThumbAviCreatorTipRefs, includeThumb: false);
            Slot avatarCreatorHand = avatarCreator.Slot.FindChild(rightSide ? "RightHand" : "LeftHand", matchSubstring: false, ignoreCase: false, maxDepth: 0);
            // only one finger, need to also use thumb for other ref
            if (nonThumbFingerTips.Length <= 1)
            {
                Slot[] withThumbFingerTips = GetFingerTips(bipedRig, rightSide, out float3[] aviCreatorTipRefs, includeThumb: true);
                if (withThumbFingerTips.Length <= 1)
                {
                    Slot handSlot = bipedRig.TryGetBone(rightSide ? BodyNode.RightHand : BodyNode.LeftHand);
                    if (handSlot == null)
                    {
                        // idk what u want from me
                        return;
                    }
                    Slot fingerSlot = null;
                    if (withThumbFingerTips.Length == 0)
                    {
                        // sometimes they have a finger end slot we can use
                        Slot[] childFingers =
                            handSlot.GetAllChildren()
                            .Where(x => !x.LocalPosition.Approximately(float3.Zero, 0.0001f))
                            .ToArray();
                        if (childFingers.Length > 0)
                        {
                            fingerSlot = childFingers[0];
                        }
                    }
                    else
                    {
                        fingerSlot = withThumbFingerTips[0];
                    }
                    if (fingerSlot == null)
                    {
                        // just align with hand rotation, not much else we can do
                        avatarCreatorHand.GlobalRotation = handSlot.GlobalRotation;
                        return;
                    }
                    else
                    {
                        float3 fingerDir = avatarCreatorHand.GlobalPosition - fingerSlot.GlobalPosition;
                        // it's just zero
                        if (fingerDir.Approximately(float3.Zero, 0.00001f))
                        {
                            // just align with hand rotation, not much else we can do
                            avatarCreatorHand.GlobalRotation = handSlot.GlobalRotation;
                            return;
                        }
                        else
                        {
                            // make two fake fingers going out from cross of up and dir from hand to finger
                            float3 fanOutDir = MathX.Cross(fingerDir.Normalized, float3.Up);
                            globalFingerTipRef1 = fingerSlot.GlobalPosition - fanOutDir * 0.01f;
                            globalFingerTipRef2 = fingerSlot.GlobalPosition + fanOutDir * 0.01f;
                            localAviCreatorTipRef1 = rightSide
                                ? relativeFingerPositionsRight[1]
                                : relativeFingerPositionsLeft[1]; // index finger
                            localAviCreatorTipRef2 = rightSide
                                ? relativeFingerPositionsRight[3]
                                : relativeFingerPositionsLeft[3]; // ring finger
                        }
                    }
                }
                else
                {
                    globalFingerTipRef1 = withThumbFingerTips[0].GlobalPosition;
                    globalFingerTipRef2 = withThumbFingerTips[1].GlobalPosition;
                    localAviCreatorTipRef1 = aviCreatorTipRefs[0];
                    localAviCreatorTipRef2 = aviCreatorTipRefs[1];
                }
            }
            else
            {
                // do first and last (non-thumb) finger, these are furthest apart which makes aligning nicer
                globalFingerTipRef1 = nonThumbFingerTips[0].GlobalPosition;
                globalFingerTipRef2 = nonThumbFingerTips[nonThumbFingerTips.Length-1].GlobalPosition;
                localAviCreatorTipRef1 = noThumbAviCreatorTipRefs[0];
                localAviCreatorTipRef2 = noThumbAviCreatorTipRefs[nonThumbFingerTips.Length-1];
            }
            // now we have two finger points (fingerTipRef1 and fingerTipRef2)
            // and two points on the avatar creator glove that we want to align to those points
            // so we want to find a rotation for avatarCreatorHand such that
            // Distance(
            //   avatarCreatorHand.LocalPointToGlobal(aviCreatorTipRef1),
            //    fingerTipRef1
            // ) +
            // Distance(
            //   avatarCreatorHand.LocalPointToGlobal(aviCreatorTipRef2),
            //    fingerTipRef2
            // )
            // is minimized

            // to do this, first find the rotation that aligns the midpoints:
            float3 globalFingerTipMidpoint = (globalFingerTipRef1 + globalFingerTipRef2) / 2.0f;
            float3 localFingerTipMidpoint = avatarCreatorHand.GlobalPointToLocal(globalFingerTipMidpoint);
            float3 localAviTipRefsMidpoint = (localAviCreatorTipRef1 + localAviCreatorTipRef2) / 2.0f;
            floatQ lineUpMidpointRotation = floatQ.FromToRotation(localAviTipRefsMidpoint.Normalized, localFingerTipMidpoint.Normalized);
            avatarCreatorHand.LocalRotation = avatarCreatorHand.LocalRotation * lineUpMidpointRotation;
            // double check we did it right
            float3 newDirToFingerTipMidpoint = avatarCreatorHand.GlobalPointToLocal(globalFingerTipMidpoint);
            //ImportFromUnityLib.DebugLog("got new finger tip midpoint:" + newDirToFingerTipMidpoint.Normalized);
            //ImportFromUnityLib.DebugLog("target direction is        :" + localAviTipRefsMidpoint.Normalized);

            // now the midpoint is lined up, we just need to rotate around vecToFingerTipMidpoint until the two points are best aligned
            // there's probably an analytic solution (feel free to PR such a solution) but iterative is good enough for a one-time thing
            int ITERS = 2000;
            
            float minScore = float.MaxValue;
            floatQ bestRotation = floatQ.Identity;
            floatQ baseLocalRotation = avatarCreatorHand.LocalRotation;
            float3 localPosition = avatarCreatorHand.LocalPosition;
            float3 globalPosition = avatarCreatorHand.Parent.LocalPointToGlobal(localPosition);
            float3 globalScale = avatarCreatorHand.Parent.LocalScaleToGlobal(localScale);
            for (int i = 0; i < ITERS; i++)
            {
                float angleRotation = 360f * (i / (float)(ITERS - 1));
                floatQ localRotation = baseLocalRotation * floatQ.AxisAngle(localAviTipRefsMidpoint, angleRotation);
                avatarCreatorHand.LocalRotation = localRotation;
                    float score = (
                       avatarCreatorHand.LocalPointToGlobal(localAviCreatorTipRef1) -
                       globalFingerTipRef1
                    ).Magnitude + (
                       avatarCreatorHand.LocalPointToGlobal(localAviCreatorTipRef2) -
                       globalFingerTipRef2
                    ).Magnitude;
                //ImportFromUnityLib.DebugLog("Got score:" + score + " with angle " + angleRotation);
                //ImportFromUnityLib.DebugLog("fingerTipRef1: " + globalFingerTipRef1);
                //ImportFromUnityLib.DebugLog("avi tip ref  : " + avatarCreatorHand.LocalPointToGlobal(localAviCreatorTipRef1));
                //ImportFromUnityLib.DebugLog("fingerTipRef1: " + globalFingerTipRef2);
                //ImportFromUnityLib.DebugLog("avi tip ref  : " + avatarCreatorHand.LocalPointToGlobal(localAviCreatorTipRef2));
                if (score < minScore)
                {
                    //ImportFromUnityLib.DebugLog("Got best score:" + score + " with angle " + angleRotation);
                    minScore = score;
                    bestRotation = localRotation;
                }
            }
            avatarCreatorHand.LocalRotation = bestRotation;
        }

        // loops through fingers to get bounding box of size
        static float3 GetHandSize(BipedRig rig, bool rightSide)
        {
            Froox::Elements.Core.BoundingBox box = new Froox::Elements.Core.BoundingBox();
            box.MakeEmpty();
            Slot handBone = rig.TryGetBone(rightSide ? BodyNode.RightHand : BodyNode.LeftHand);
            if (handBone != null)
            {
                box.Encapsulate(handBone.Parent.GlobalPointToLocal(handBone.GlobalPosition));
                BodyNode[][] fingerOrders = rightSide ? rightFingerOrders : leftFingerOrders;
                foreach (BodyNode[] fingerPieces in fingerOrders)
                {
                    foreach (BodyNode fingerPiece in fingerPieces)
                    {
                        Slot fingerPieceSlot = rig.TryGetBone(fingerPiece);
                        if (fingerPieceSlot != null)
                        {
                            float3 relativePosition = handBone.Parent.GlobalPointToLocal(fingerPieceSlot.GlobalPosition);
                            box.Encapsulate(relativePosition);
                        }
                    }
                }
            }
            return box.Size;
        }

        static float3 ComputeAviCreatorScale(BipedRig rig)
        {
            float3 avgSize = new float3(0,0,0);
            int numSizesFound = 0;
            foreach (bool rightSide in new bool[] { false, true })
            {
                Slot handSlot = rig.TryGetBone(rightSide ? BodyNode.RightHand : BodyNode.LeftHand);
                if (handSlot != null)
                {
                    float resultSize;
                    float3 handSizeByBoundingBox = handSlot.ComputeBoundingBox(includeInactive: true, space: handSlot.Parent).Size;
                    float maxSizeByBoundingBox = Math.Max(Math.Max(handSizeByBoundingBox.x, handSizeByBoundingBox.y), handSizeByBoundingBox.z);
                    float3 handSizeByFingers = GetHandSize(rig, rightSide);
                    float maxSizeByFingers = Math.Max(Math.Max(handSizeByFingers.x, handSizeByFingers.y), handSizeByFingers.z);
                    // if bounding box is substantially bigger, rely on finger size
                    // this is in case they are holding something that messed up bounds
                    // (as long as finger estimate is not too small, say, if they have no fingers)
                    if (maxSizeByBoundingBox > maxSizeByFingers *  1.5f &&
                        maxSizeByFingers > 0.01f)
                    {
                        resultSize = maxSizeByFingers;
                    }
                    // otherwise, bounding box tends to be slightly better
                    else
                    {
                        resultSize = maxSizeByBoundingBox;
                    }
                    avgSize += handSlot.Parent.LocalScaleToGlobal(new float3(resultSize, resultSize, resultSize));
                    numSizesFound += 1;
                }
            }
            if (numSizesFound > 0)
            {
                // compute average (vrik doesn't support hands being different sizes, so, just do average)
                avgSize /= numSizesFound;
                return avgSize / 0.23f; // this is the distance from center of wrist to end of avatar creator fingers
            }
            else
            {
                return new float3(1,1,1);
            }
        }

        static Slot GetSharedParent(Slot a, Slot b)
        {
            if (a.ReferenceID == b.ReferenceID)
            {
                return a;
            }
            else
            {
                return b.GetNearestSharedParent(a);
            }

        }

        public static Slot FindSharedParent(Slot[] slots)
        {
            if (slots.Length == 0)
            {
                return ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld.RootSlot;
            }
            Slot sharedParent = slots[0];
            foreach (Slot slot in slots)
            {
                sharedParent = GetSharedParent(slot, sharedParent);
            }
            return sharedParent;
        }

        public static void SetupIK(Rig rig, Slot targetSlot, Slot assetsSlot, bool forceTPose=true, bool generateColliders=true, bool generateSkeletonBoneVisuals=false)
        {
            // need to use hacky reflection stuff because they are private
            // make ModelImportData
            Type modelImportDataType = typeof(ModelImporter).GetTypeInfo()
                .DeclaredNestedTypes
                .Where(t => t.Name == "ModelImportData").First();
            Type[] constructorTypes = new Type[] {
                    typeof(string),
                    typeof(Froox::Assimp.Scene),
                    typeof(Slot),
                    typeof(Slot),
                    typeof(ModelImportSettings),
                    typeof(IProgressIndicator)
                };            
            // these are the only settings this import method uses
            ModelImportSettings modelImportSettings = new ModelImportSettings()
            {
                ForceTpose=forceTPose,
                SetupIK=true,
                GenerateColliders=generateColliders,
                GenerateSkeletonBoneVisuals=generateSkeletonBoneVisuals,
            };
            object[] constructorParameters = new object[]
            {
                    Path.GetTempPath(), // file (idk it doesn't really matter what we pass here as long as it's a valid file---
                    null, // scene
                    targetSlot, // target slot
                    assetsSlot, // assets slot
                    modelImportSettings, // import settings
                    null // progress indicator
            };

            object modelImportData = modelImportDataType.GetConstructor(constructorTypes)
                .Invoke(constructorParameters);

            //ImportFromUnityLib.DebugLog("Got model import data " + modelImportData);

            // Call GenerateRigBones, which makes the IK
            var generateRigBonesMethod = typeof(ModelImporter)
                .GetMethods(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                .Where(method => method.Name == "GenerateRigBones" &&
                    method.GetParameters().Length == 2)
                .First();
            //ImportFromUnityLib.DebugLog("Got generate rig bones method " + generateRigBonesMethod);
            generateRigBonesMethod.Invoke(null, new object[]
            {
                rig,
                modelImportData
            });
        }

        public static async Task<byte[]> ImportAvatarFunc(byte[] avatarBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunCoroutine(ImportAvatarHelper(avatarBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }
    }
}
