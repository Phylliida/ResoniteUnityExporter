extern alias Froox;

using System;
using Froox::Elements.Assets;
using ResoniteUnityExporterShared;
using System.Collections.Generic;
using Froox::FrooxEngine;
using Froox::Elements.Core;
using MemoryMappedFileIPC;

namespace ImportFromUnityLib
{

    public class ImportMesh
    {
        static IEnumerator<Context> ImportToStaticMeshHelper(byte[] staticMeshBytes, OutputBytesHolder outputBytes)
        {
            // Load mesh data into a meshx
            yield return Context.ToBackground();
            StaticMesh_U2Res meshOut = SerializationUtils.DecodeObject<StaticMesh_U2Res>(staticMeshBytes);
            ImportFromUnityLib.DebugLog("Importing mesh " + meshOut.name);
            string name = meshOut.name;
            if (name == null || name.Length == 0)
            {
                name = "StaticMesh";
            }
            MeshX meshx = ConvertToMeshX(meshOut);
            // create assets slot
            yield return Context.ToWorld();
            World focusedWorld = ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld;
            // load meshx into localdb to get a url
            Froox::FrooxEngine.Store.LocalDB localDb = focusedWorld.Engine.LocalDB;
            string tempFilePath = localDb.GetTempFilePath("meshx");
            yield return Context.ToBackground();
            meshx.SaveToFile(tempFilePath);
            Uri url = localDb.ImportLocalAssetAsync(tempFilePath, Froox::FrooxEngine.Store.LocalDB.ImportLocation.Move).Result;
            // attach StaticMesh component with resulting url
            yield return Context.ToWorld();
            Slot assetsSlot = focusedWorld.AssetsSlot.FindChild(x => (ulong)x.ReferenceID == meshOut.rootAssetsSlot.id);
            StaticMesh staticMesh = assetsSlot.AttachComponent<StaticMesh>();
            staticMesh.URL.Value = url;
            // return refid of StaticMesh component
            RefID_U2Res result = new RefID_U2Res()
            {
                id = (ulong)staticMesh.ReferenceID
            };
            outputBytes.outputBytes = SerializationUtils.EncodeObject(result);
        }

        /// <summary>
        /// Takes static mesh data and makes a StaticMesh asset
        /// </summary>
        /// <param name="staticMeshBytes"></param>
        /// <returns>bytes representing RefID_U2Res that contains the static mesh asset component</returns>
        public static byte[] ImportToStaticMeshFunc(byte[] staticMeshBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportToStaticMeshHelper(staticMeshBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }

        public static MeshX ConvertToMeshX(StaticMesh_U2Res mesh)
        {
            // todo: provide option to ignore bones and ignore vertex colors
            MeshX meshx = new MeshX();
            int numVertices = mesh.positions.Length;
            bool hasNormals = ImportFromUnityUtils.NotEmpty(mesh.normals);
            meshx.HasNormals = hasNormals;
            bool hasTangents = ImportFromUnityUtils.NotEmpty(mesh.tangents);
            meshx.HasTangents = hasTangents;
            // todo: do they ever have colors32 without colors? (maybe we need to convert)
            meshx.HasColors = ImportFromUnityUtils.NotEmpty(mesh.colors);
            // todo: is this right? maybe we need to look at bindposes too
            meshx.HasBoneBindings = ImportFromUnityUtils.NotEmpty(mesh.boneBindings);
            // todo: make little drop down auto generate if need to configure options for thing
            // like a material needs to auto convert, which do u use?
            // they force all submeshes from the same import to have the same dimensions
            // but I think that's guaranteed by unity so we are ok

            meshx.AddVertices(mesh.positions.Length);
            for (int uv = 0; uv < mesh.uvChannels.Length; uv++)
            {
                meshx.SetUV_Dimension(uv, mesh.uvChannels[uv].dimension);
            }

            SerializationUtils.CopyArray(mesh.positions, meshx.RawPositions);
            if (meshx.HasColors)
            {
                SerializationUtils.CopyArray(mesh.colors, meshx.RawColors);
            }
            if (hasNormals)
            {
                SerializationUtils.CopyArray(mesh.normals, meshx.RawNormals);
            }
            if (hasTangents)
            {
                SerializationUtils.CopyArray(mesh.tangents, meshx.RawTangents);
            }


            for (int uv = 0; uv < mesh.uvChannels.Length; uv++)
            {
                UVArray_U2Res uvChannel = mesh.uvChannels[uv];
                int curDimension = uvChannel.dimension;
                if (curDimension == 2)
                {
                    meshx.SetHasUV(uv, true);
                    SerializationUtils.CopyArray(uvChannel.uv_2D, meshx.GetRawUVs(uv));
                }
                else if (curDimension == 3)
                {
                    meshx.SetHasUV_3D(uv, true);
                    SerializationUtils.CopyArray(uvChannel.uv_3D, meshx.GetRawUVs_3D(uv));
                }
                else if (curDimension == 4)
                {
                    meshx.SetHasUV_4D(uv, true);
                    SerializationUtils.CopyArray(uvChannel.uv_4D, meshx.GetRawUVs_4D(uv));
                }
            }

            // submesh (index buffers)
            List<Froox::Elements.Assets.Submesh> submeshes = new List<Froox::Elements.Assets.Submesh>();
            for (int subMeshI = 0; subMeshI < mesh.submeshes.Length; subMeshI++)
            {
                Froox::Elements.Assets.TriangleSubmesh submesh = meshx.AddSubmesh<Froox::Elements.Assets.TriangleSubmesh>();
                int[] indices = mesh.submeshes[subMeshI].indicies;
                if (mesh.importSettings.reverse)
                {
                    int[] reversedIndices = new int[indices.Length];
                    for (int i = 0; i < indices.Length; i += 3)
                    {
                        int a = indices[i];
                        int b = indices[i + 1];
                        int c = indices[i + 2];
                        indices[i] = c;
                        indices[i + 1] = b;
                        indices[i + 2] = a;
                    }
                    indices = reversedIndices;
                }
                int numPrimitives = indices.Length / 3;
                submesh.SetCount(numPrimitives);
                SerializationUtils.CopyArray(indices, submesh.RawIndicies);
            }

            for (int blendShapeI = 0; blendShapeI < mesh.blendShapes.Length; blendShapeI++)
            {
                BlendShape_U2Res blendShape = mesh.blendShapes[blendShapeI];
                string blendShapeName = blendShape.name;
                Froox::Elements.Assets.BlendShape blendShapeX = meshx.AddBlendShape(blendShapeName);
                blendShapeX.HasNormals = meshx.HasNormals;
                blendShapeX.HasTangents = meshx.HasTangents;
                int blendShapeFrameCount = blendShape.frames.Length;
                for (int blendShapeFrameI = 0; blendShapeFrameI < blendShapeFrameCount; blendShapeFrameI++)
                {
                    BlendShapeFrame_U2Res blendShapeFrame = blendShape.frames[blendShapeFrameI];
                    // todo: ModelImporter just uses 1.0 for weight, should we do that?
                    Froox::Elements.Assets.BlendShapeFrame blendShapeFrameX = blendShapeX.AddFrame(blendShapeFrame.frameWeight);
                    SerializationUtils.CopyArray(blendShapeFrame.positions, blendShapeFrameX.RawPositions);

                    if (hasNormals)
                    {
                        SerializationUtils.CopyArray(blendShapeFrame.normals, blendShapeFrameX.RawNormals);
                    }

                    if (hasTangents)
                    {
                        SerializationUtils.CopyArray(blendShapeFrame.tangents, blendShapeFrameX.RawTangents);
                    }
                }
            }

            if (mesh.bones != null && mesh.bones.Length > 0)
            {
                foreach (Bone_U2Res bone in mesh.bones)
                {
                    //ImportFromUnityLib.DebugLog("Bone:" + bone.name);
                    Froox::Elements.Assets.Bone bonex = meshx.AddBone(bone.name);
                    bonex.BindPose = new float4x4(bone.bindPose.m00, bone.bindPose.m01, bone.bindPose.m02, bone.bindPose.m03,
                                                  bone.bindPose.m10, bone.bindPose.m11, bone.bindPose.m12, bone.bindPose.m13,
                                                  bone.bindPose.m20, bone.bindPose.m21, bone.bindPose.m22, bone.bindPose.m23,
                                                  bone.bindPose.m30, bone.bindPose.m31, bone.bindPose.m32, bone.bindPose.m33);
                }
                meshx.HasBoneBindings = true; // this allocates the bindings
                BoneBinding_U2Res[] boneBindings = mesh.boneBindings;
                for (int i = 0; i < numVertices; i++)
                {
                    meshx.RawBoneBindings[i].weight0 = boneBindings[i].weight0;
                    meshx.RawBoneBindings[i].weight1 = boneBindings[i].weight1;
                    meshx.RawBoneBindings[i].weight2 = boneBindings[i].weight2;
                    meshx.RawBoneBindings[i].weight3 = boneBindings[i].weight3;
                    meshx.RawBoneBindings[i].boneIndex0 = boneBindings[i].boneIndex0;
                    meshx.RawBoneBindings[i].boneIndex1 = boneBindings[i].boneIndex1;
                    meshx.RawBoneBindings[i].boneIndex2 = boneBindings[i].boneIndex2;
                    meshx.RawBoneBindings[i].boneIndex3 = boneBindings[i].boneIndex3;
                }
                meshx.SortTrimAndNormalizeBoneWeights();
                meshx.FillInEmptyBindings(0);
            }

            if (mesh.importSettings.makeDualSided)
            {
                meshx.MakeDualSided();
            }
            if (mesh.importSettings.makeFlatShaded)
            {
                meshx.ConvertToFlatShading();
            }
            meshx.StripEmptyBlendshapes();
            if (mesh.importSettings.calculateTangents)
            {
                meshx.RecalculateTangentsMikktspace();
            }
            return meshx;
        }
    }
}
