extern alias Froox;

using Froox::Elements.Core;
using Froox::FrooxEngine;
using Froox::FrooxEngine.ProtoFlux;
using Froox::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes;
using Froox::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots;
using Froox::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Transform;
using Froox::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables;
using Froox::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators;
using MemoryMappedFileIPC;
using ResoniteUnityExporterShared;
using System.Collections.Generic;
using System.Threading.Tasks;
using Froox::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes;
using System.Reflection;
using Froox::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math;

namespace ImportFromUnityLib
{
    public class ImportConstraint
    {
        public static void ImportPositionConstraintHelper(byte[] constraintBytes, OutputBytesHolder outputBytes)
        {
            PositionConstraint_U2Res constraintData = SerializationUtils.DecodeObject<PositionConstraint_U2Res>(constraintBytes);
            RefID outputRefId = RefID.Null;
            if (constraintData.target.id != 0 && constraintData.sources != null && constraintData.sources.Length > 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);
                ImportFromUnityLib.DebugLog("Importing position constraint on " + target.Name);
                // simple version, just use relative positioner component and we are done
                if (constraintData.sources.Length == 1 
                    && constraintData.sources[0].weight == 1 
                    && constraintData.affectsPositionAxes.x
                    && constraintData.affectsPositionAxes.y
                    && constraintData.affectsPositionAxes.z)
                {
                    RelativePositioner relativePositioner = target.AttachComponent<RelativePositioner>();
                    relativePositioner.Reference.Value = (RefID)constraintData.sources[0].transform.id;
                    relativePositioner.ReferenceOffset.Value = new float3(
                        constraintData.positionOffset.x,
                        constraintData.positionOffset.y,
                        constraintData.positionOffset.z
                    );
                    relativePositioner.ReferenceBoundsSpace.LocalSpace.Value = target.ReferenceID;
                    relativePositioner.ReferenceBoundsSpace.UseParentSpace.Value = true;
                    outputRefId = relativePositioner.ReferenceID;
                }
                // more complex version because multiple constraints or only subset of axes
                else
                {
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
                    float3 offset =
                        // new float3( don't need this
                        //    constraintData.positionAtRest.x,
                        //    constraintData.positionAtRest.y,
                        //    constraintData.positionAtRest.z) +
                        new float3(
                            constraintData.positionOffset.x,
                            constraintData.positionOffset.y,
                            constraintData.positionOffset.z
                            );

                    var offsetField = positionConstraint.AttachComponent<DynamicValueVariable<float3>>();
                    offsetField.VariableName.Value = "PosConstraint/Offset";
                    offsetField.Value.Value = offset;

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
                        float sourceWeight = source.weight / totalWeight;
                        // unity doesn't normalize if there is only one
                        if (constraintData.sources.Length == 1)
                        {
                            sourceWeight = source.weight;
                        }
                        sourceWeightField.Value.Value = sourceWeight;
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

                    T AddFluxNode<T>(float3 position) where T : Component
                    {
                        Slot fluxSlot = positionConstraint.AddSlot(typeof(T).Name);
                        fluxSlot.Position_Field.Value = position;
                        return (T)fluxSlot.AttachComponent(typeof(T));
                    }

                    /*
                    // useful debugging code to see if the assembly is correct or if we accidentally loaded another copy of it
                    ImportFromUnityLib.DebugLog("Have assembly of ref object: " + typeof(RefObjectInput<Slot>).Assembly.Location);
                    ImportFromUnityLib.DebugLog("Have assembly of ref object: " + typeof(RefObjectInput<Slot>).Assembly);

                    var typeManager = positionConstraint.World.Types;

                    Dictionary<Assembly, int> assemblyLookup = (Dictionary<Assembly, int>)typeManager.GetType()
                        .GetField("_assemblyToIndex", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .GetValue(typeManager);
                    ImportFromUnityLib.DebugLog("Is it contained in? " + assemblyLookup.ContainsKey(typeof(RefObjectInput<Slot>).Assembly));
                    ImportFromUnityLib.DebugLog("Is it contained in for slot? " + assemblyLookup.ContainsKey(typeof(Slot).Assembly));
                    foreach (var assembly in assemblyLookup.Keys )
                    {
                        ImportFromUnityLib.DebugLog("Have assembly" + assembly.Location);
                        ImportFromUnityLib.DebugLog("Have assembly" + assembly);
                    }
                    var encodingType = typeManager.EncodeType(typeof(RefObjectInput<Slot>));
                    */
                    var inputNode = AddFluxNode<RefObjectInput<Slot>>(new float3(0.165f, 0.81375f, 0));
                    inputNode.Target.Value = positionConstraint.Parent.ReferenceID;

                    var getParent = AddFluxNode<GetParentSlot>(new float3(0.405f, 0.73865f, 0));
                    getParent.Instance.Value = inputNode.ReferenceID;

                    var localTransform = AddFluxNode<LocalTransform>(new float3(0.87f, 0.933f, 0));
                    localTransform.Instance.Value = inputNode.ReferenceID;

                    var posConstraintOffsetNode = AddFluxNode<DynamicVariableValueInput<float3>>(new float3(0.87f, 0.75f, 0));
                    var posConstraintOffsetNodeValue = posConstraintOffsetNode.Slot.AttachComponent<GlobalValue<string>>();
                    posConstraintOffsetNode.VariableName.Value = posConstraintOffsetNodeValue.ReferenceID;
                    posConstraintOffsetNodeValue.Value.Value = "PosConstraint/Offset";

                    var sumAll = AddFluxNode<ValueAddMulti<float3>>(new float3(1.08f, 0.57f, 0f));
                    sumAll.Inputs.Add().Value = posConstraintOffsetNode.Value.ReferenceID;

                    for (int i = 0; i < constraintData.sources.Length; i++)
                    {
                        var sourceStr = "Source" + (i + 1);
                        float yOffset = i * (0.28875f - 0.483f);
                        var dynObjInput = AddFluxNode<DynamicVariableObjectInput<Slot>>(new float3(0.27f, 0.483f + yOffset, 0));
                        var dynObjInputValue = dynObjInput.Slot.AttachComponent<GlobalValue<string>>();
                        dynObjInputValue.Value.Value = "PosConstraint/" + sourceStr;
                        dynObjInput.VariableName.Value = dynObjInputValue.ReferenceID;
                        var globalTransformSource = AddFluxNode<GlobalTransform>(new float3(0.405f, 0.483f + yOffset, 0));
                        globalTransformSource.Instance.Value = dynObjInput.Value.ReferenceID;

                        var transformPointSource = AddFluxNode<TransformPoint>(new float3(0.585f, 0.543f + yOffset, 0));
                        transformPointSource.ToSpace.Value = getParent.ReferenceID;
                        transformPointSource.SourcePoint.Value = globalTransformSource.GlobalPosition.ReferenceID;

                        var weightSource = AddFluxNode<DynamicVariableValueInput<float>>(new float3(0.72f, 0.48375f + yOffset));
                        var weightSourceValue = weightSource.Slot.AttachComponent<GlobalValue<string>>();
                        weightSourceValue.Value.Value = "PosConstraint/" + sourceStr + "Weight";
                        weightSource.VariableName.Value = weightSourceValue.ReferenceID;

                        var mulSourceWeight = AddFluxNode<Mul_Float3_Float>(new float3(0.87f, 0.558f + yOffset, 0f));
                        mulSourceWeight.A.Value = transformPointSource.ReferenceID;
                        mulSourceWeight.B.Value = weightSource.Value.ReferenceID;
                        sumAll.Inputs.Add().Value = mulSourceWeight.ReferenceID;
                    }

                    var whichAxesActivatedNode = AddFluxNode<DynamicVariableValueInput<float3>>(new float3(1.125f, 0.81375f, 0));
                    var whichAxesActivatedNodeValue = whichAxesActivatedNode.Slot.AttachComponent<GlobalValue<string>>();
                    whichAxesActivatedNodeValue.Value.Value = "PosConstraint/ApplyAxes";
                    whichAxesActivatedNode.VariableName.Value = whichAxesActivatedNodeValue.ReferenceID;

                    var mulByWhichNode = AddFluxNode<ValueMul<float3>>(new float3(new float3(1.32f, 0.708f, 0)));
                    mulByWhichNode.A.Value = whichAxesActivatedNode.Value.ReferenceID;
                    mulByWhichNode.B.Value = sumAll.ReferenceID;

                    var oneMinusWhichAxesActivatedNode = AddFluxNode<ValueOneMinus<float3>>(new float3(1.32f, 0.8437f, 0));
                    oneMinusWhichAxesActivatedNode.X.Value = whichAxesActivatedNode.Value.ReferenceID;

                    var mulByLocalPosNode = AddFluxNode<ValueMul<float3>>(new float3(1.515f, 0.9627f, 0));
                    mulByLocalPosNode.A.Value = localTransform.LocalPosition.ReferenceID;
                    mulByLocalPosNode.B.Value = oneMinusWhichAxesActivatedNode.ReferenceID;

                    var valueAddFinal = AddFluxNode<ValueAdd<float3>>(new float3(1.71f, 0.738f, 0));
                    valueAddFinal.A.Value = mulByLocalPosNode.ReferenceID;
                    valueAddFinal.B.Value = mulByWhichNode.ReferenceID;

                    var finalDrive = AddFluxNode<ValueFieldDrive<float3>>(new float3(1.92f, 0.75f, 0));
                    finalDrive.Value.Value = valueAddFinal.ReferenceID;
                    finalDrive.GetRootProxy(true).Drive.Value = outputField.Value.ReferenceID;
                    outputRefId = positionConstraint.ReferenceID;
                    positionConstraint.Scale_Field.Value = new float3(constraintData.rescaleFactor, constraintData.rescaleFactor, constraintData.rescaleFactor);
                }
            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = (ulong)outputRefId, // set this
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
            RefID outputRefId = RefID.Null;
            if (constraintData.target.id != 0 && constraintData.sources != null && constraintData.sources.Length > 0)
            {
                Slot target = (Slot)ImportFromUnityUtils.LookupRefID(constraintData.target);
                ImportFromUnityLib.DebugLog("Importing position constraint on " + target.Name);
                Slot scaleConstraint = target.AddSlot("Scale constraint");
                DynamicVariableSpace scaleConstraintSpace = scaleConstraint.AttachComponent<DynamicVariableSpace>();
                scaleConstraintSpace.OnlyDirectBinding.Value = true;
                scaleConstraintSpace.SpaceName.Value = "ScaleConstraint";
                var applyAxesField = scaleConstraint.AttachComponent<DynamicValueVariable<float3>>();
                applyAxesField.Value.Value = new float3(
                    constraintData.affectsScaleAxes.x ? 1 : 0,
                    constraintData.affectsScaleAxes.y ? 1 : 0,
                    constraintData.affectsScaleAxes.z ? 1 : 0);
                applyAxesField.VariableName.Value = "ScaleConstraint/ApplyAxes";
                float3 offset =
                    // new float3( don't need this
                    //    constraintData.positionAtRest.x,
                    //    constraintData.positionAtRest.y,
                    //    constraintData.positionAtRest.z) +
                    new float3(
                        constraintData.scaleOffset.x,
                        constraintData.scaleOffset.y,
                        constraintData.scaleOffset.z
                        );

                var offsetField = scaleConstraint.AttachComponent<DynamicValueVariable<float3>>();
                offsetField.VariableName.Value = "ScaleConstraint/Offset";
                offsetField.Value.Value = offset;

                for (int i = 0; i < constraintData.sources.Length; i++)
                {
                    var source = constraintData.sources[i];
                    string sourceName = "Source" + (i + 1);
                    var sourceField = scaleConstraint.AttachComponent<DynamicReferenceVariable<Slot>>();
                    Slot sourceSlot = (Slot)ImportFromUnityUtils.LookupRefID(source.transform);
                    sourceField.Reference.Value = sourceSlot.ReferenceID;
                    sourceField.VariableName.Value = "ScaleConstraint/" + sourceName;

                    var sourceWeightField = scaleConstraint.AttachComponent<DynamicValueVariable<float>>();
                    // we need to normalize weights for the maths to work
                    float sourceWeight = source.weight;
                    sourceWeightField.Value.Value = sourceWeight;
                    sourceWeightField.VariableName.Value = "ScaleConstraint/" + sourceName + "Weight";
                }

                var outputDriver = scaleConstraint.AttachComponent<DynamicValueVariableDriver<float3>>();
                var outputField = scaleConstraint.AttachComponent<DynamicValueVariable<float3>>();
                outputField.VariableName.Value = "ScaleConstraint/Output";
                outputDriver.VariableName.Value = "ScaleConstraint/Output";

                var scaleDriver = scaleConstraint.AttachComponent<BooleanReferenceDriver<IField<float3>>>();
                scaleDriver.TargetReference.Value = outputDriver.Target.ReferenceID;
                var enabledField = scaleConstraint.AttachComponent<DynamicField<bool>>();
                enabledField.TargetField.Value = scaleDriver.State.ReferenceID;
                enabledField.VariableName.Value = "ScaleConstraint/Enabled";

                scaleDriver.TrueTarget.Value = scaleConstraint.Parent.Scale_Field.ReferenceID;
                scaleDriver.State.Value = constraintData.isActive;

                T AddFluxNode<T>(float3 position) where T : Component
                {
                    Slot fluxSlot = scaleConstraint.AddSlot(typeof(T).Name);
                    fluxSlot.Position_Field.Value = position;
                    return (T)fluxSlot.AttachComponent(typeof(T));
                }

                /*
                // useful debugging code to see if the assembly is correct or if we accidentally loaded another copy of it
                ImportFromUnityLib.DebugLog("Have assembly of ref object: " + typeof(RefObjectInput<Slot>).Assembly.Location);
                ImportFromUnityLib.DebugLog("Have assembly of ref object: " + typeof(RefObjectInput<Slot>).Assembly);

                var typeManager = positionConstraint.World.Types;

                Dictionary<Assembly, int> assemblyLookup = (Dictionary<Assembly, int>)typeManager.GetType()
                    .GetField("_assemblyToIndex", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .GetValue(typeManager);
                ImportFromUnityLib.DebugLog("Is it contained in? " + assemblyLookup.ContainsKey(typeof(RefObjectInput<Slot>).Assembly));
                ImportFromUnityLib.DebugLog("Is it contained in for slot? " + assemblyLookup.ContainsKey(typeof(Slot).Assembly));
                foreach (var assembly in assemblyLookup.Keys )
                {
                    ImportFromUnityLib.DebugLog("Have assembly" + assembly.Location);
                    ImportFromUnityLib.DebugLog("Have assembly" + assembly);
                }
                var encodingType = typeManager.EncodeType(typeof(RefObjectInput<Slot>));
                */
                // formula is (source1Scale ^ weight1*source2Scale ^ weight2*...*scaleOffset ^ numSources)^(1 / sumOfAllWeights)
                var inputNode = AddFluxNode<RefObjectInput<Slot>>(new float3(0.165f, 0.81375f, 0));
                inputNode.Target.Value = scaleConstraint.Parent.ReferenceID;

                var getParent = AddFluxNode<GetParentSlot>(new float3(0.405f, 0.73865f, 0));
                getParent.Instance.Value = inputNode.ReferenceID;

                var localTransform = AddFluxNode<LocalTransform>(new float3(0.94f, 1.23f, 0));
                localTransform.Instance.Value = inputNode.ReferenceID;

                var whichAxesActivatedNode = AddFluxNode<DynamicVariableValueInput<float3>>(new float3(1.1998f, 1.025f, 0));
                var whichAxesActivatedNodeValue = whichAxesActivatedNode.Slot.AttachComponent<GlobalValue<string>>();
                whichAxesActivatedNodeValue.Value.Value = "ScaleConstraint/ApplyAxes";
                whichAxesActivatedNode.VariableName.Value = whichAxesActivatedNodeValue.ReferenceID;

                var scaleConstraintOffsetNode = AddFluxNode<DynamicVariableValueInput<float3>>(new float3(0.9098f, 0.901f, 0));
                var scaleConstraintOffsetNodeValue = scaleConstraintOffsetNode.Slot.AttachComponent<GlobalValue<string>>();
                scaleConstraintOffsetNode.VariableName.Value = scaleConstraintOffsetNodeValue.ReferenceID;
                scaleConstraintOffsetNodeValue.Value.Value = "ScaleConstraint/Offset";

                var powForScaleOffset = AddFluxNode<Pow_Float3_Float>(new float3(1.195f, 0.907f, 0));
                var inputForOffsetPow = AddFluxNode<ValueInput<float>>(new float3(1.043f, 0.86698f, 0));
                inputForOffsetPow.Value.Value = constraintData.sources.Length;
                powForScaleOffset.N.Value = scaleConstraintOffsetNode.Value.ReferenceID;
                powForScaleOffset.Power.Value = inputForOffsetPow.ReferenceID;

                var mulAll = AddFluxNode<ValueMulMulti<float3>>(new float3(1.367f, 0.595f, 0f));
                mulAll.Inputs.Add().Value = whichAxesActivatedNode.Value.ReferenceID;
                mulAll.Inputs.Add().Value = powForScaleOffset.ReferenceID;

                var addAllWeights = AddFluxNode<ValueAddMulti<float>>(new float3(0.901f, 0.753f, 0));

                for (int i = 0; i < constraintData.sources.Length; i++)
                {
                    var sourceStr = "Source" + (i + 1);
                    float yOffset = i * (0.28875f - 0.483f);
                    var dynObjInput = AddFluxNode<DynamicVariableObjectInput<Slot>>(new float3(0.27f, 0.483f + yOffset, 0));
                    var dynObjInputValue = dynObjInput.Slot.AttachComponent<GlobalValue<string>>();
                    dynObjInputValue.Value.Value = "ScaleConstraint/" + sourceStr;
                    dynObjInput.VariableName.Value = dynObjInputValue.ReferenceID;
                    var globalTransformSource = AddFluxNode<GlobalTransform>(new float3(0.405f, 0.483f + yOffset, 0));
                    globalTransformSource.Instance.Value = dynObjInput.Value.ReferenceID;

                    var transformScaleSource = AddFluxNode<TransformScale>(new float3(0.585f, 0.543f + yOffset, 0));
                    transformScaleSource.ToSpace.Value = getParent.ReferenceID;
                    transformScaleSource.SourceScale.Value = globalTransformSource.GlobalScale.ReferenceID;

                    var weightSource = AddFluxNode<DynamicVariableValueInput<float>>(new float3(0.72f, 0.48375f + yOffset));
                    var weightSourceValue = weightSource.Slot.AttachComponent<GlobalValue<string>>();
                    weightSourceValue.Value.Value = "ScaleConstraint/" + sourceStr + "Weight";
                    weightSource.VariableName.Value = weightSourceValue.ReferenceID;

                    addAllWeights.Inputs.Add().Value = weightSource.Value.ReferenceID;

                    var powSourceWeight = AddFluxNode<Pow_Float3_Float>(new float3(0.88f, 0.558f + yOffset, 0f));
                    powSourceWeight.N.Value = transformScaleSource.ReferenceID;
                    powSourceWeight.Power.Value = weightSource.Value.ReferenceID;
                    mulAll.Inputs.Add().Value = powSourceWeight.ReferenceID;
                }

                var reciprocalInput = AddFluxNode<ValueReciprocal<float>>(new float3(1.187f, 0.7187f, 0));
                reciprocalInput.N.Value = addAllWeights.ReferenceID;

                var powByWeightReciprocal = AddFluxNode<Pow_Float3_Float>(new float3(1.546f, 0.741f, 0));
                powByWeightReciprocal.N.Value = mulAll.ReferenceID;
                powByWeightReciprocal.Power.Value = reciprocalInput.ReferenceID;

                var oneMinusWhichAxesActivatedNode = AddFluxNode<ValueOneMinus<float3>>(new float3(1.3726f, 1.0526f, 0));
                oneMinusWhichAxesActivatedNode.X.Value = whichAxesActivatedNode.Value.ReferenceID;

                var mulByLocalScaleNode = AddFluxNode<ValueMul<float3>>(new float3(1.527f, 1.0982f, 0));
                mulByLocalScaleNode.A.Value = localTransform.LocalScale.ReferenceID;
                mulByLocalScaleNode.B.Value = oneMinusWhichAxesActivatedNode.ReferenceID;

                var valueAddFinal = AddFluxNode<ValueAdd<float3>>(new float3(1.815f, 0.805f, 0));
                valueAddFinal.A.Value = mulByLocalScaleNode.ReferenceID;
                valueAddFinal.B.Value = powByWeightReciprocal.ReferenceID;

                var checkIfAllZeroWeights = AddFluxNode<ValueEquals<float>>(new float3(1.8097f, 0.975f, 0));
                checkIfAllZeroWeights.A.Value = addAllWeights.ReferenceID;
                var conditionalOnAllZero = AddFluxNode<ValueConditional<float3>>(new float3(1.997f, 1.1615f, 0));
                conditionalOnAllZero.Condition.Value = checkIfAllZeroWeights.ReferenceID;
                conditionalOnAllZero.OnTrue.Value = localTransform.LocalScale.ReferenceID;
                conditionalOnAllZero.OnFalse.Value = valueAddFinal.ReferenceID;

                var finalDrive = AddFluxNode<ValueFieldDrive<float3>>(new float3(2.2291f, 1.2014f, 0));
                finalDrive.Value.Value = conditionalOnAllZero.ReferenceID;
                finalDrive.GetRootProxy(true).Drive.Value = outputField.Value.ReferenceID;
                outputRefId = scaleConstraint.ReferenceID;
                scaleConstraint.Scale_Field.Value = new float3(constraintData.rescaleFactor, constraintData.rescaleFactor, constraintData.rescaleFactor);
            }
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = (ulong)outputRefId,
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
