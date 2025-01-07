using Newtonsoft.Json;
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
using System.Net.NetworkInformation;
using static OfficialAssets.Graphics;

namespace ImportFromUnityLib
{
    public class ImportMesh
    {

        public static void Register(ResoniteBridgeLib.ResoniteBridgeServer server)
        {
            server.RegisterProcessor("ImportToStaticMesh", ImportToStaticMesh);
            server.RegisterProcessor("TestBees", SimpleTest);
            server.RegisterProcessor("ImportSlotHierarchy", ImportSlotHierarchy);
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

        public static void AddObjectAndChildren(Slot parentSlot, Object_U2Res obj, List<ObjectLookup_U2Res> lookups)
        {
            Slot addedSlot = parentSlot.AddSlot(obj.name);
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
        }

        public static Slot GetAddingSlot()
        {
            return Engine.Current.WorldManager.FocusedWorld.LocalUserSpace;
        }

        static IEnumerator<Context> AddHierarchy(byte[] hierarchyBytes, OutputBytesHolder outputHolder)
        {
            // decode bytes
            yield return Context.ToBackground();
            ObjectHierarchy_U2Res hierarchy = ResoniteBridgeLib.ResoniteBridgeUtils.DecodeObject<ObjectHierarchy_U2Res>(hierarchyBytes);
            // create hierarchy slots and lookup
            yield return Context.ToWorld();
            Slot parentSlot = GetAddingSlot();
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
            List<ObjectLookup_U2Res> lookups = new List<ObjectLookup_U2Res>();
            foreach (Object_U2Res obj in hierarchy.objects)
            {
                AddObjectAndChildren(targetSlot, obj, lookups);
            }
            // encode lookup and return it
            yield return Context.ToBackground();
            ObjectLookups_U2Res outputLookups = new ObjectLookups_U2Res()
            {
                lookups = lookups.ToArray()
            };
            outputHolder.outputBytes = ResoniteBridgeUtils.EncodeObject(outputLookups);
        }

        class OutputBytesHolder
        {
            public byte[] outputBytes;
        }

        public static byte[] ImportSlotHierarchy(byte[] hierarchyBytes)
        {
            OutputBytesHolder outputHolder = new OutputBytesHolder();
            RunOnWorldThread(AddHierarchy(hierarchyBytes, outputHolder));
            return outputHolder.outputBytes;
        }

        static IEnumerator<Context> ActionWrapper(IEnumerator<Context> action, TaskCompletionSource<bool> completion)
        {
            try
            {
                yield return Context.WaitFor(action);
            }
            finally
            {
                completion.SetResult(result: true);
            }
        }

        public static bool RunOnWorldThread(IEnumerator<Context> action)
        {
            TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
            Engine.Current.WorldManager.FocusedWorld.RootSlot.StartCoroutine(ActionWrapper(action, taskCompletionSource));
            return taskCompletionSource.Task.GetAwaiter().GetResult();
        }


        static IEnumerator<Context> ImportToStaticMeshHelper(byte[] staticMeshBytes, OutputBytesHolder outputBytes)
        {
            // Load mesh data into a meshx
            yield return Context.ToBackground();
            StaticMesh_U2Res meshOut = ResoniteBridgeLib.ResoniteBridgeUtils.DecodeObject<StaticMesh_U2Res>(staticMeshBytes);
            string name = meshOut.name;
            if (name == null || name.Length == 0)
            {
                name = "StaticMesh";
            }
            MeshX meshx = ConvertToMeshX(meshOut);
            // create assets slot
            yield return Context.ToWorld();
            World focusedWorld = FrooxEngine.Engine.Current.WorldManager.FocusedWorld;
            FrooxEngine.Slot assetsSlot = focusedWorld.AssetsSlot.AddSlot(name);
            assetsSlot.AttachComponent<FrooxEngine.AssetOptimizationBlock>().Persistent = false;
            // load meshx into localdb to get a url
            FrooxEngine.Store.LocalDB localDb = focusedWorld.Engine.LocalDB;
            string tempFilePath = localDb.GetTempFilePath("meshx");
            yield return Context.ToBackground();
            meshx.SaveToFile(tempFilePath);
            Uri url = localDb.ImportLocalAssetAsync(tempFilePath, FrooxEngine.Store.LocalDB.ImportLocation.Move).Result;
            // attach StaticMesh component with resulting url
            yield return Context.ToWorld();
            FrooxEngine.StaticMesh staticMesh = assetsSlot.AttachComponent<FrooxEngine.StaticMesh>();
            staticMesh.URL.Value = url;
            // return refid of StaticMesh component
            RefID_U2Res result = new RefID_U2Res()
            {
                id = (ulong)staticMesh.ReferenceID
            };
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(result);
        }

        /// <summary>
        /// Takes static mesh data and makes a StaticMesh asset
        /// </summary>
        /// <param name="staticMeshBytes"></param>
        /// <returns>bytes representing RefID_U2Res that contains the static mesh asset component</returns>
        public static byte[] ImportToStaticMesh(byte[] staticMeshBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            RunOnWorldThread(ImportToStaticMeshHelper(staticMeshBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
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

            ResoniteBridgeUtils.CopyArray(mesh.positions, meshx.RawPositions);
            if (meshx.HasColors)
            {
                ResoniteBridgeUtils.CopyArray(mesh.colors, meshx.RawColors);
            }
            if (hasNormals)
            {
                ResoniteBridgeUtils.CopyArray(mesh.normals, meshx.RawNormals);
            }
            if (hasTangents)
            {
                ResoniteBridgeUtils.CopyArray(mesh.tangents, meshx.RawTangents);
            }


            for (int uv = 0; uv < mesh.uvChannels.Length; uv++)
            {
                UVArray_U2Res uvChannel = mesh.uvChannels[uv];
                int curDimension = uvChannel.dimension;
                if (curDimension == 2)
                {
                    ResoniteBridgeUtils.CopyArray(uvChannel.uv_2D, meshx.GetRawUVs(uv));
                }
                else if (curDimension == 3)
                {
                    ResoniteBridgeUtils.CopyArray(uvChannel.uv_3D, meshx.GetRawUVs_3D(uv));
                }
                else if (curDimension == 4)
                {
                    ResoniteBridgeUtils.CopyArray(uvChannel.uv_4D, meshx.GetRawUVs_4D(uv));
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
                ResoniteBridgeUtils.CopyArray(indices, submesh.RawIndicies);
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
                    ResoniteBridgeUtils.CopyArray(blendShapeFrame.positions, blendShapeFrameX.RawPositions);

                    if (hasNormals)
                    {
                        ResoniteBridgeUtils.CopyArray(blendShapeFrame.normals, blendShapeFrameX.RawNormals);
                    }

                    if (hasTangents)
                    {
                        ResoniteBridgeUtils.CopyArray(blendShapeFrame.tangents, blendShapeFrameX.RawTangents);
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
