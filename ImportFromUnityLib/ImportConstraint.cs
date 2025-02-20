using FrooxEngine;
using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class ImportConstraint
    {
        public static IEnumerator<Context> ImportPositionConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToWorld();
            PositionConstraint_U2Res constraintData = ResoniteBridgeUtils.DecodeObject<PositionConstraint_U2Res>(constraintBytes);
            if (constraintData.target.id != 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);

            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = 0, // set this
            };
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(outputRefID);
        }

        public static byte[] ImportPositionConstraintFunc(byte[] constraintBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportPositionConstraintHelper(constraintBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }

        public static IEnumerator<Context> ImportRotationConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToWorld();
            RotationConstraint_U2Res constraintData = ResoniteBridgeUtils.DecodeObject<RotationConstraint_U2Res>(constraintBytes);
            if (constraintData.target.id != 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);

            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = 0, // set this
            };
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(outputRefID);
        }

        public static byte[] ImportRotationConstraintFunc(byte[] constraintBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportRotationConstraintHelper(constraintBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }


        public static IEnumerator<Context> ImportScaleConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToWorld();
            ScaleConstraint_U2Res constraintData = ResoniteBridgeUtils.DecodeObject<ScaleConstraint_U2Res>(constraintBytes);
            if (constraintData.target.id != 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);

            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = 0, // set this
            };
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(outputRefID);
        }

        public static byte[] ImportScaleConstraintFunc(byte[] constraintBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportScaleConstraintHelper(constraintBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }


        public static IEnumerator<Context> ImportAimConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToWorld();
            AimConstraint_U2Res constraintData = ResoniteBridgeUtils.DecodeObject<AimConstraint_U2Res>(constraintBytes);
            if (constraintData.target.id != 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);

            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = 0, // set this
            };
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(outputRefID);
        }

        public static byte[] ImportAimConstraintFunc(byte[] constraintBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportAimConstraintHelper(constraintBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }


        public static IEnumerator<Context> ImportParentConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToWorld();
            ParentConstraint_U2Res constraintData = ResoniteBridgeUtils.DecodeObject<ParentConstraint_U2Res>(constraintBytes);
            if (constraintData.target.id != 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);

            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = 0, // set this
            };
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(outputRefID);
        }

        public static byte[] ImportParentConstraintFunc(byte[] constraintBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportParentConstraintHelper(constraintBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }


        public static IEnumerator<Context> ImportLookAtConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToWorld();
            LookAtConstraint_U2Res constraintData = ResoniteBridgeUtils.DecodeObject<LookAtConstraint_U2Res>(constraintBytes);
            if (constraintData.target.id != 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);

            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = 0, // set this
            };
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(outputRefID);
        }

        public static byte[] ImportLookAtConstraintFunc(byte[] constraintBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportLookAtConstraintHelper(constraintBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }


    }
}
