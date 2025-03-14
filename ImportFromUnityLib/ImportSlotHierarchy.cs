﻿extern alias Froox;

using Froox::FrooxEngine;
using Froox::Elements.Core;
using MemoryMappedFileIPC;
using ResoniteUnityExporterShared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class ImportSlotHierarchy
    {
        public static async Task<byte[]> ImportSlotHierarchyFunc(byte[] hierarchyBytes)
        {
            OutputBytesHolder outputHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => AddHierarchy(hierarchyBytes, outputHolder));
            return outputHolder.outputBytes;
        }

        public static Slot AddObjectAndChildren(Slot parentSlot, Object_U2Res obj, List<ObjectLookup_U2Res> lookups)
        {
            Slot addedSlot = parentSlot.AddSlot(obj.name);
            addedSlot.LocalPosition = new float3(obj.localPosition.x,
                            obj.localPosition.y,
                            obj.localPosition.z);
            addedSlot.LocalRotation = new floatQ(obj.localRotation.x,
                            obj.localRotation.y,
                            obj.localRotation.z,
                            obj.localRotation.w);
            addedSlot.LocalScale = new float3(obj.localScale.x,
                            obj.localScale.y,
                            obj.localScale.z);
            addedSlot.ActiveSelf = obj.enabled;

            ObjectLookup_U2Res lookup = new ObjectLookup_U2Res()
            {
                refId = new RefID_U2Res()
                {
                    id = (ulong)addedSlot.ReferenceID
                },
                uniqueId = obj.uniqueId
            };
            lookups.Add(lookup);
            if (obj.children != null)
            {
                foreach (Object_U2Res child in obj.children)
                {
                    AddObjectAndChildren(addedSlot, child, lookups);
                }
            }
            return addedSlot;
        }
        static void AddHierarchy(byte[] hierarchyBytes, OutputBytesHolder outputHolder)
        {
            //// decode bytes
            ObjectHierarchy_U2Res hierarchy = SerializationUtils.DecodeObject<ObjectHierarchy_U2Res>(hierarchyBytes);
            ImportFromUnityLib.DebugLog("Importing slot hierarchy");


            //// create assets slot 
            Slot worldAssets = ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld.AssetsSlot;
            Slot assetsSlot = worldAssets.FindChild(hierarchy.hierarchyName, matchSubstring: false, ignoreCase: false, maxDepth: 0);
            // it's dangerous to remove any assets slots, so just remove old assets slot if it has a comment with our name on it
            if (assetsSlot != null &&
                assetsSlot.GetComponent<Comment>() != null &&
                assetsSlot.GetComponent<Comment>().Text.Value == hierarchy.hierarchyName)
            {
                assetsSlot.Destroy();
            }
            assetsSlot = worldAssets.AddSlot(hierarchy.hierarchyName);
            // add the comment saying we are assets from this, also add asset optimization block as is standard
            assetsSlot.AttachComponent<AssetOptimizationBlock>().Persistent = false;
            assetsSlot.AttachComponent<Comment>().Text.Value = hierarchy.hierarchyName;

            //// create root slot
            Slot parentSlot = ImportFromUnityUtils.GetAddingSlot();
            Slot targetSlot = parentSlot.FindChild(hierarchy.hierarchyName, matchSubstring: false, ignoreCase: false, maxDepth: 0);
            // if target slot not found, create it
            if (targetSlot == null)
            {
                targetSlot = parentSlot.AddSlot(hierarchy.hierarchyName);
            }
            // otherwise, empty it out, we will fill it ourselves
            // this way if they press the button multiple times it'll just be updated with most recent status
            else
            {
                targetSlot.DestroyChildren();
                targetSlot.RemoveAllComponents(x => true);
            }

            //// create the hierarchy
            List<ObjectLookup_U2Res> lookups = new List<ObjectLookup_U2Res>();
            foreach (Object_U2Res obj in hierarchy.objects)
            {
                AddObjectAndChildren(targetSlot, obj, lookups);
            }
            targetSlot.LocalScale = new float3(1.0f / hierarchy.rescaleFactor, 1.0f / hierarchy.rescaleFactor, 1.0f / hierarchy.rescaleFactor);
            //// encode lookup and return it
            ObjectLookups_U2Res outputLookups = new ObjectLookups_U2Res()
            {
                lookups = lookups.ToArray(),
                mainParentSlot = new RefID_U2Res()
                {
                    id = (ulong)targetSlot.ReferenceID
                },
                rootAssetSlot = new RefID_U2Res()
                {
                    id = (ulong)assetsSlot.ReferenceID
                }
            };
            outputHolder.outputBytes = SerializationUtils.EncodeObject(outputLookups);
        }

    }
}
