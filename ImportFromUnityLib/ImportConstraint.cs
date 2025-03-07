extern alias Froox;

using Froox::FrooxEngine;
using MemoryMappedFileIPC;
using ResoniteUnityExporterShared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class ImportConstraint
    {
        public static void ImportPositionConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            PositionConstraint_U2Res constraintData = SerializationUtils.DecodeObject<PositionConstraint_U2Res>(constraintBytes);
            if (constraintData.target.id != 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);
                ImportFromUnityLib.DebugLog("Importing position constraint on " + target.Name);

            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = 0, // set this
            };
            outputBytes.outputBytes = SerializationUtils.EncodeObject(outputRefID);
        }

        public static async Task<byte[]> ImportPositionConstraintFunc(byte[] constraintBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => ImportPositionConstraintHelper(constraintBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }

        public static void ImportRotationConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            RotationConstraint_U2Res constraintData = SerializationUtils.DecodeObject<RotationConstraint_U2Res>(constraintBytes);
            if (constraintData.target.id != 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);
                ImportFromUnityLib.DebugLog("Importing rotation constraint on " + target.Name);

            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = 0, // set this
            };
            outputBytes.outputBytes = SerializationUtils.EncodeObject(outputRefID);
        }

        public static async Task<byte[]> ImportRotationConstraintFunc(byte[] constraintBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => ImportRotationConstraintHelper(constraintBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }


        public static void ImportScaleConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            ScaleConstraint_U2Res constraintData = SerializationUtils.DecodeObject<ScaleConstraint_U2Res>(constraintBytes);
            if (constraintData.target.id != 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);
                ImportFromUnityLib.DebugLog("Importing scale constraint on " + target.Name);

            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = 0, // set this
            };
            outputBytes.outputBytes = SerializationUtils.EncodeObject(outputRefID);
        }

        public static async Task<byte[]> ImportScaleConstraintFunc(byte[] constraintBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => ImportScaleConstraintHelper(constraintBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }


        public static void ImportAimConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            AimConstraint_U2Res constraintData = SerializationUtils.DecodeObject<AimConstraint_U2Res>(constraintBytes);
            if (constraintData.target.id != 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);
                ImportFromUnityLib.DebugLog("Importing aim constraint on " + target.Name);

            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = 0, // set this
            };
            outputBytes.outputBytes = SerializationUtils.EncodeObject(outputRefID);
        }

        public static async Task<byte[]> ImportAimConstraintFunc(byte[] constraintBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => ImportAimConstraintHelper(constraintBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }


        public static void ImportParentConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            ParentConstraint_U2Res constraintData = SerializationUtils.DecodeObject<ParentConstraint_U2Res>(constraintBytes);
            if (constraintData.target.id != 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);
                ImportFromUnityLib.DebugLog("Importing parent constraint on " + target.Name);

            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = 0, // set this
            };
            outputBytes.outputBytes = SerializationUtils.EncodeObject(outputRefID);
        }

        public static async Task<byte[]> ImportParentConstraintFunc(byte[] constraintBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => ImportParentConstraintHelper(constraintBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }


        public static void ImportLookAtConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            LookAtConstraint_U2Res constraintData = SerializationUtils.DecodeObject<LookAtConstraint_U2Res>(constraintBytes);
            if (constraintData.target.id != 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);
                ImportFromUnityLib.DebugLog("Importing look at constraint on " + target.Name);

            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = 0, // set this
            };
            outputBytes.outputBytes = SerializationUtils.EncodeObject(outputRefID);
        }

        public static async Task<byte[]> ImportLookAtConstraintFunc(byte[] constraintBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => ImportLookAtConstraintHelper(constraintBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }


    }
}
