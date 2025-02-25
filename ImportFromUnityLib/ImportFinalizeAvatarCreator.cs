using FrooxEngine;
using MemoryMappedFileIPC;
using ResoniteUnityExporterShared;
using System.Collections.Generic;

namespace ImportFromUnityLib
{
    public class ImportFinalizeAvatarCreator
    {
        static IEnumerator<Context> ImportFinalizeAvatarCreatorHelper(byte[] materialBytes, OutputBytesHolder outputBytes)
        {
            // Load mesh data into a meshx
            yield return Context.ToBackground();
            FinalizeAvatarCreator_U2Res finalizeAviCreatorData = SerializationUtils.DecodeObject<FinalizeAvatarCreator_U2Res>(materialBytes);
            yield return Context.ToWorld();

            Slot mainParentSlot = (Slot)ImportFromUnityUtils.LookupRefID(finalizeAviCreatorData.mainParentSlot);

            AvatarCreator aviCreator = mainParentSlot.GetComponentInChildren<AvatarCreator>();

            bool finished = false;

            if (aviCreator != null)
            {
                // it's private so use reflection to access
                aviCreator.GetType()
                    .GetMethod("RunCreate", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .Invoke(aviCreator, new object[] { });
                finished = true;
            }

            // todo:
            // _DetailMask_ST,_DetailMask_TexelSize,_DetailMask_HDR,
            // _ParallaxMap_ST,_ParallaxMap_TexelSize,_ParallaxMap_HDR,
            // return refid of StaticMesh component
            outputBytes.outputBytes = SerializationUtils.EncodeObject(finished);
        }

        /// <summary>
        /// Takes static mesh data and makes a StaticMesh asset
        /// </summary>
        /// <param name="staticMeshBytes"></param>
        /// <returns>bytes representing RefID_U2Res that contains the static mesh asset component</returns>
        public static byte[] ImportFinalizeAvatarCreatorFunc(byte[] finalizeDataBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportFinalizeAvatarCreatorHelper(finalizeDataBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }
    }
}
