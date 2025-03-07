extern alias Froox;

using Froox::Elements.Core;
using Froox::FrooxEngine;
using MemoryMappedFileIPC;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class ImportLOD
    {
        public static void ImportLODHelper(byte[] lodBytes, OutputBytesHolder outputBytes)
        {
            LODGroup_U2Res lodGroupData = SerializationUtils.DecodeObject<LODGroup_U2Res>(lodBytes);
            Slot attachSlot = (Slot)ImportFromUnityUtils.LookupRefID(lodGroupData.target);
            RefID resultRefID = RefID.Null;
            if (attachSlot != null)
            {
                ImportFromUnityLib.DebugLog("Importing lod on " + attachSlot.Name);
                LODGroup lodGroup = attachSlot.AttachComponent<LODGroup>();
                //lodGroup.LODs = 
                // lodGroupData.localReferencePoint seems to not be relevant
                // nor is .size or lastLODBillboard
                lodGroup.AnimateCrossFading.Value = lodGroupData.animateCrossFading;
                lodGroup.EnabledField.Value = lodGroupData.enabled;
                lodGroup.CrossFade.Value = lodGroupData.fadeMode == LODFadeMode_U2Res.CrossFade;
                int i = 0;
                foreach (LOD_U2Res lod in lodGroupData.LODs)
                {
                    MeshRenderer[] meshRenderers = lod.renderers != null
                        ? lod.renderers.Where(rendererRefID => rendererRefID.id != 0)
                                       .Select(rendererRefID => ImportFromUnityUtils.LookupRefID(rendererRefID))
                                       .Select(renderer => renderer as MeshRenderer)
                                       .Where(renderer => renderer != null)
                                       .ToArray()
                        : new MeshRenderer[0];
                    lodGroup.AddLOD(lod.screenRelativeTransitionHeight, meshRenderers);
                    lodGroup.LODs[i].FadeTransitionWidth.Value = lod.fadeTransitionWidth;
                    i += 1;
                }
                resultRefID = lodGroup.ReferenceID;
            }
            // return refid of sphere collider
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = (ulong)resultRefID
            };

            outputBytes.outputBytes = SerializationUtils.EncodeObject(outputRefID);
        }
        public static async Task<byte[]> ImportLODFunc(byte[] lodBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() =>ImportLODHelper(lodBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }
    }
}
