extern alias Froox;

using Froox::Elements.Core;
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
            if (constraintData.target.id != 0 && constraintData.sources != null && constraintData.sources.Length > 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);
                ImportFromUnityLib.DebugLog("Importing position constraint on " + target.Name);
                Slot positionConstraint = target.AddSlot("Position constraint");
                DynamicVariableSpace posConstraintSpace = positionConstraint.AttachComponent<DynamicVariableSpace>();
                posConstraintSpace.OnlyDirectBinding.Value = true;
                float totalWeight = 0.0f;
                foreach (ConstraintSource_U2Res source in constraintData.sources)
                {
                    totalWeight += source.weight;
                }
                // don't divide by zero
                if (totalWeight == 0.0f)
                {
                    totalWeight = 1.0f;
                }
                posConstraintSpace.SpaceName.Value = "PosConstraint";
                var applyAxesField = positionConstraint.AttachComponent<DynamicValueVariable<float3>>();
                applyAxesField.Value.Value = new float3(
                    constraintData.affectsPositionAxes.x ? 1 : 0,
                    constraintData.affectsPositionAxes.y ? 1 : 0,
                    constraintData.affectsPositionAxes.z ? 1 : 0);
                applyAxesField.VariableName.Value = "PosConstraint/ApplyAxes";
                float3 offset = new float3(
                        constraintData.positionAtRest.x,
                        constraintData.positionAtRest.y,
                        constraintData.positionAtRest.z) -
                    new float3(
                        constraintData.positionOffset.x,
                        constraintData.positionOffset.y,
                        constraintData.positionOffset.z
                        );
                var offsetField = positionConstraint.AttachComponent<DynamicValueVariable<float3>>();
                offsetField.Value.Value = offset;
                offsetField.VariableName.Value = "PosConstraint/Offset";

                for (int i = 0; i < constraintData.sources.Length; i++)
                {
                    var source = constraintData.sources[i];
                    string sourceName = "Source" + (i + 1);
                    var sourceField = positionConstraint.AttachComponent<DynamicReferenceVariable<Slot>>();
                    Slot sourceSlot = (Slot)ImportFromUnityUtils.LookupRefID(source.transform);
                    sourceField.Reference.Value = sourceSlot.ReferenceID;
                    sourceField.VariableName.Value = "PosConstraint/" + sourceName;

                    var sourceWeightField = positionConstraint.AttachComponent<DynamicValueVariable<float>>();
                    // we need to normalize weights for the maths to work
                    sourceWeightField.Value.Value = source.weight/totalWeight;
                    sourceWeightField.VariableName.Value = "PosConstraint/" + sourceName + "Weight";
                }

                var outputDriver = positionConstraint.AttachComponent<DynamicValueVariableDriver<float3>>();
                var outputField = positionConstraint.AttachComponent<DynamicValueVariable<float3>>();
                outputField.VariableName.Value = "PosConstraint/Output";
                outputDriver.VariableName.Value = "PosConstraint/Output";

                var posDriver = positionConstraint.AttachComponent<BooleanReferenceDriver<IField<float3>>>();
                posDriver.TargetReference.Value = outputDriver.Target.ReferenceID;
                var enabledField = positionConstraint.AttachComponent<DynamicField<bool>>();
                enabledField.TargetField.Value = posDriver.State.ReferenceID;
                enabledField.VariableName.Value = "PosConstraint/Enabled";

                posDriver.TrueTarget.Value = positionConstraint.Parent.Position_Field.ReferenceID;
                posDriver.State.Value = constraintData.isActive;


                // todo: the actual flux
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
