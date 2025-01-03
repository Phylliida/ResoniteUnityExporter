﻿using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using Elements.Assets;
using ResoniteUnityExporterShared;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Xml.Linq;
using FrooxEngine;
using Elements.Core;
using ResoniteBridgeLib;

namespace ImportFromUnityLib
{
    public class ImportMesh
    {

        public static void Register(ResoniteBridgeLib.ResoniteBridgeServer server)
        {
            server.RegisterProcessor("ImportToStaticMesh", ImportToStaticMesh);
            server.RegisterProcessor("TestBees", SimpleTest);
        }

        public static byte[] SimpleTest(byte[] data)
        {
            Float3_U2Res input = ResoniteBridgeUtils.DecodeObject<Float3_U2Res>(data);
            Float3_U2Res result = new Float3_U2Res()
            {
                x = input.x + 1,
                y = input.y - 2,
                z = input.z * 2,
            };
            return ResoniteBridgeUtils.EncodeObject(result);
        }

        public static bool NotEmpty<T>(T[] arr)
        {
            return arr != null && arr.Length > 0;
        }

        public static byte[] ImportToStaticMesh(byte[] staticMeshBytes)
        {
            // tobackground...
            StaticMesh_U2Res meshOut = ResoniteBridgeLib.ResoniteBridgeUtils.DecodeObject<StaticMesh_U2Res>(staticMeshBytes);
            string name = meshOut.name;
            if (name == null || name.Length == 0)
            {
                name = "StaticMesh";
            }
            MeshX meshx = ConvertToMeshX(meshOut);
            World focusedWorld = Engine.Current.WorldManager.FocusedWorld;
            AutoResetEvent finished = new AutoResetEvent(false);
            RefID_U2Res result = new RefID_U2Res()
            {
                id = 0
            };
            Engine.Current.WorldManager.FocusedWorld.RunSynchronously(() =>
            {
                try
                {
                    FrooxEngine.Slot targetSlot = focusedWorld.RootSlot.AddSlot(name);
                    FrooxEngine.Slot assetsSlot = focusedWorld.AssetsSlot.AddSlot(name);
                    assetsSlot.AttachComponent<FrooxEngine.AssetOptimizationBlock>().Persistent = false;
                    FrooxEngine.Store.LocalDB localDb = focusedWorld.Engine.LocalDB;
                    string tempFilePath = localDb.GetTempFilePath("meshx");
                    meshx.SaveToFile(tempFilePath);
                    Uri url = localDb.ImportLocalAssetAsync(tempFilePath, FrooxEngine.Store.LocalDB.ImportLocation.Move).Result;
                    // toworld...
                    FrooxEngine.StaticMesh staticMesh = assetsSlot.AddSlot("Mesh").AttachComponent<FrooxEngine.StaticMesh>();
                    staticMesh.URL.Value = url;
                    ulong refId = (ulong)staticMesh.ReferenceID;
                    result = new RefID_U2Res()
                    {
                        id = refId
                    };
                }
                finally
                {
                    finished.Set();
                }
            });
            finished.WaitOne();
            return ResoniteBridgeUtils.EncodeObject(result);
        }

        public static MeshX ConvertToMeshX(StaticMesh_U2Res mesh)
        {
            // todo: provide option to ignore bones and ignore vertex colors
            MeshX meshx = new MeshX();
            int numVertices = mesh.positions.Length;
            bool hasNormals = NotEmpty(mesh.normals);
            meshx.HasNormals = hasNormals;
            bool hasTangents = NotEmpty(mesh.tangents);
            meshx.HasTangents = hasTangents;
            // todo: do they ever have colors32 without colors? (maybe we need to convert)
            meshx.HasColors = NotEmpty(mesh.colors);
            // todo: is this right? maybe we need to look at bindposes too
            meshx.HasBoneBindings = NotEmpty(mesh.boneBindings);
            // todo: make little drop down auto generate if need to configure options for thing
            // like a material needs to auto convert, which do u use?
            // they force all submeshes from the same import to have the same dimensions
            // but I think that's guaranteed by unity so we are ok
            
            
            meshx.IncreaseVertexCount(mesh.positions.Length);
            for (int uv = 0; uv < mesh.uvChannels.Length; uv++)
            {
                meshx.SetUV_Dimension(uv, mesh.uvChannels[uv].dimension);
            }

            U2ResUtils.CopyArray(mesh.positions, meshx.RawPositions);
            if (meshx.HasColors)
            {
                U2ResUtils.CopyArray(mesh.colors, meshx.RawColors);
            }
            if (hasNormals)
            {
                U2ResUtils.CopyArray(mesh.normals, meshx.RawNormals);
            }
            if (hasTangents)
            {
                U2ResUtils.CopyArray(mesh.tangents, meshx.RawTangents);
            }


            for (int uv = 0; uv < mesh.uvChannels.Length; uv++)
            {
                UVArray_U2Res uvChannel = mesh.uvChannels[uv];
                int curDimension = uvChannel.dimension;
                if (curDimension == 2)
                {
                    U2ResUtils.CopyArray(uvChannel.uv_2D, meshx.GetRawUVs(uv));
                }
                else if (curDimension == 3)
                {
                    U2ResUtils.CopyArray(uvChannel.uv_3D, meshx.GetRawUVs_3D(uv));
                }
                else if (curDimension == 4)
                {
                    U2ResUtils.CopyArray(uvChannel.uv_4D, meshx.GetRawUVs_4D(uv));
                }
            }

            // submesh (index buffers)
            List<Elements.Assets.Submesh> submeshes = new List<Elements.Assets.Submesh>();
            for (int subMeshI = 0; subMeshI < mesh.submeshes.Length; subMeshI++)
            {
                Elements.Assets.TriangleSubmesh submesh = meshx.AddSubmesh<Elements.Assets.TriangleSubmesh>();
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
                U2ResUtils.CopyArray(indices, submesh.RawIndicies);
            }

            for (int blendShapeI = 0; blendShapeI < mesh.blendShapes.Length; blendShapeI++)
            {
                BlendShape_U2Res blendShape = mesh.blendShapes[blendShapeI];
                string blendShapeName = blendShape.name;
                Elements.Assets.BlendShape blendShapeX = meshx.AddBlendShape(blendShapeName);
                blendShapeX.HasNormals = meshx.HasNormals;
                blendShapeX.HasTangents = meshx.HasTangents;
                int blendShapeFrameCount = blendShape.frames.Length;
                for (int blendShapeFrameI = 0; blendShapeFrameI < blendShapeFrameCount; blendShapeFrameI++)
                {
                    BlendShapeFrame_U2Res blendShapeFrame = blendShape.frames[blendShapeFrameI];
                    // todo: ModelImporter just uses 1.0 for weight, should we do that?
                    Elements.Assets.BlendShapeFrame blendShapeFrameX = blendShapeX.AddFrame(blendShapeFrame.frameWeight);
                    U2ResUtils.CopyArray(blendShapeFrame.positions, blendShapeFrameX.RawPositions);

                    if (hasNormals)
                    {
                        U2ResUtils.CopyArray(blendShapeFrame.normals, blendShapeFrameX.RawNormals);
                    }

                    if (hasTangents)
                    {
                        U2ResUtils.CopyArray(blendShapeFrame.tangents, blendShapeFrameX.RawTangents);
                    }
                }
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
