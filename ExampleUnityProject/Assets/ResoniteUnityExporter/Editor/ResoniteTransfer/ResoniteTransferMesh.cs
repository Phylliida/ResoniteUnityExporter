﻿using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static ResoniteUnityExporter.ResoniteTransferUtils;

namespace ResoniteUnityExporter
{
    public class ResoniteTransferMesh
    {
        public static List<UnityEngine.Rendering.VertexAttribute> AllUVAttributes =
            new List<UnityEngine.Rendering.VertexAttribute>()
            {
                UnityEngine.Rendering.VertexAttribute.TexCoord0,
                UnityEngine.Rendering.VertexAttribute.TexCoord1,
                UnityEngine.Rendering.VertexAttribute.TexCoord2,
                UnityEngine.Rendering.VertexAttribute.TexCoord3,
                UnityEngine.Rendering.VertexAttribute.TexCoord4,
                UnityEngine.Rendering.VertexAttribute.TexCoord5,
                UnityEngine.Rendering.VertexAttribute.TexCoord6,
                UnityEngine.Rendering.VertexAttribute.TexCoord7
            };

        public static int[] GetMeshUVChannelDimensions(UnityEngine.Mesh unityMesh, out int[] actualTexCoordIndices)
        {
            // Coroutines is a property

            List<int> texCoordIndices = new List<int>();
            List<int> texCoordDimensions = new List<int>();
            foreach (UnityEngine.Rendering.VertexAttributeDescriptor descriptor in unityMesh.GetVertexAttributes())
            {
                int uvIndex = AllUVAttributes.IndexOf(descriptor.attribute);
                if (uvIndex != -1)
                {
                    texCoordIndices.Add(uvIndex);
                    texCoordDimensions.Add(descriptor.dimension);
                }
            }
            actualTexCoordIndices = texCoordIndices.ToArray();
            return texCoordDimensions.ToArray();
        }
        public static ResoniteUnityExporterShared.StaticMesh_U2Res ConvertMesh(UnityEngine.Mesh unityMesh, string[] boneNames)
        {
            Debug.Log("Starting export mesh");
            // todo: provide option to ignore bones and ignore vertex colors
            StaticMesh_U2Res meshx = new StaticMesh_U2Res();
            meshx.name = unityMesh.name;
            int[] uvDimensions = GetMeshUVChannelDimensions(unityMesh, out int[] actualTexCoordIndices);

            Float3_U2Res[] vertices = null;
            Float3_U2Res[] normals = null;
            Float4_U2Res[] tangents = null;
            int numVertices;
            using (Timer _ = new Timer("Mesh data"))
            {
                vertices = ResoniteBridgeUtils.ConvertArray<Float3_U2Res, UnityEngine.Vector3>(unityMesh.vertices);
                numVertices = vertices.Length;
                meshx.positions = vertices;
                if (NotEmpty(unityMesh.colors))
                {
                    // important to use .colors instead of .colors32 on the unityMesh
                    // because colors32 stores each r,g,b,a as a byte instead of a float
                    // so this conversion would not work without manually fixing
                    meshx.colors = ResoniteBridgeUtils.ConvertArray<Float4_U2Res, UnityEngine.Color>(unityMesh.colors);
                }

                if (NotEmpty(unityMesh.normals))
                {
                    normals = ResoniteBridgeUtils.ConvertArray<Float3_U2Res, UnityEngine.Vector3>(unityMesh.normals);
                    meshx.normals = normals;
                }
                if (NotEmpty(unityMesh.tangents))
                {
                    tangents = ResoniteBridgeUtils.ConvertArray<Float4_U2Res, UnityEngine.Vector4>(unityMesh.tangents);
                    meshx.tangents = tangents;
                }
            }
            Debug.Log("Loaded mesh vertex data");

            // uvs are stored as UV_Array[] uv_channels
            // where uv_channels[0] is for UV0 array, uv_channels[1] is for UV1 array, etc.
            // inside a UV_Array they have three arrays,
            // float2[] uv_2D
            // float3[] uv_3D
            // float4[] uv_4D
            // so we can just set that directly
            using (Timer _ = new Timer("UV data"))
            {
                UVArray_U2Res[] allUvs = new UVArray_U2Res[uvDimensions.Length];
                for (int i = 0; i < uvDimensions.Length; i++)
                {
                    allUvs[i] = new UVArray_U2Res();
                    int curDimension = uvDimensions[i];
                    if (curDimension == 2)
                    {
                        List<UnityEngine.Vector2> uvs = new List<UnityEngine.Vector2>(unityMesh.vertexCount);
                        unityMesh.GetUVs(actualTexCoordIndices[i], uvs);
                        allUvs[i].uv_2D = ResoniteBridgeUtils.ConvertArray<Float2_U2Res, UnityEngine.Vector2>(uvs.ToArray());
                    }
                    else if (curDimension == 3)
                    {
                        List<UnityEngine.Vector3> uvs = new List<UnityEngine.Vector3>(unityMesh.vertexCount);
                        unityMesh.GetUVs(actualTexCoordIndices[i], uvs);
                        allUvs[i].uv_3D = ResoniteBridgeUtils.ConvertArray<Float3_U2Res, UnityEngine.Vector3>(uvs.ToArray());
                    }
                    else if (curDimension == 4)
                    {
                        List<UnityEngine.Vector4> uvs = new List<UnityEngine.Vector4>(unityMesh.vertexCount);
                        unityMesh.GetUVs(actualTexCoordIndices[i], uvs);
                        allUvs[i].uv_4D = ResoniteBridgeUtils.ConvertArray<Float4_U2Res, UnityEngine.Vector4>(uvs.ToArray());
                    }
                }
                meshx.uvChannels = allUvs;
            }
            Debug.Log("Loaded mesh uv channels");

            using (Timer _ = new Timer("Submesh data"))
            {

                // submesh (index buffers)
                TriSubmesh_U2Res[] submeshes = new TriSubmesh_U2Res[unityMesh.subMeshCount];
                for (int subMeshI = 0; subMeshI < unityMesh.subMeshCount; subMeshI++)
                {
                    UnityEngine.Rendering.SubMeshDescriptor subMeshDescriptor = unityMesh.GetSubMesh(subMeshI);
                    TriSubmesh_U2Res submesh = new TriSubmesh_U2Res();
                    // todo: Lines, LineStrip, Points
                    int[] indicies = unityMesh.GetIndices(subMeshI);
                    int numPrimitives = 0;
                    bool reverse = false;
                    if (subMeshDescriptor.topology == UnityEngine.MeshTopology.Triangles)
                    {
                        numPrimitives = indicies.Length / 3;
                        if (reverse)
                        {
                            // do it in place because why not
                            for (int triI = 0; triI < indicies.Length; triI++)
                            {
                                int v0 = indicies[triI];
                                int v1 = indicies[triI + 1];
                                int v2 = indicies[triI + 2];
                                indicies[triI] = v2;
                                indicies[triI + 1] = v1;
                                indicies[triI + 2] = v0;
                            }
                        }
                    }
                    else if (subMeshDescriptor.topology == UnityEngine.MeshTopology.Quads)
                    {
                        // turn each quad into two tris
                        numPrimitives = 2 * (indicies.Length / 4);
                        int[] triIndicies = new int[numPrimitives * 3];
                        int triIndex = 0;
                        for (int quadI = 0; quadI < indicies.Length; quadI += 4)
                        {
                            int v0 = indicies[quadI];
                            int v1 = indicies[quadI + 1];
                            int v2 = indicies[quadI + 2];
                            int v3 = indicies[quadI + 3];
                            if (reverse)
                            {
                                triIndicies[triIndex++] = v3;
                                triIndicies[triIndex++] = v2;
                                triIndicies[triIndex++] = v1;

                                triIndicies[triIndex++] = v3;
                                triIndicies[triIndex++] = v1;
                                triIndicies[triIndex++] = v0;
                            }
                            else
                            {
                                triIndicies[triIndex++] = v0;
                                triIndicies[triIndex++] = v1;
                                triIndicies[triIndex++] = v2;

                                triIndicies[triIndex++] = v0;
                                triIndicies[triIndex++] = v2;
                                triIndicies[triIndex++] = v3;
                            }
                        }
                        indicies = triIndicies;
                    }
                    submesh.indicies = indicies;
                    submeshes[subMeshI] = submesh;
                }
                meshx.submeshes = submeshes; // hhf
            }

            using (Timer _ = new Timer("Blendshape data"))
            {

                BlendShape_U2Res[] blendShapes = new BlendShape_U2Res[unityMesh.blendShapeCount];

                for (int blendShapeI = 0; blendShapeI < unityMesh.blendShapeCount; blendShapeI++)
                {
                    BlendShape_U2Res blendShape = new BlendShape_U2Res();
                    blendShape.name = unityMesh.GetBlendShapeName(blendShapeI);
                    int blendShapeFrameCount = unityMesh.GetBlendShapeFrameCount(blendShapeI);
                    blendShape.frames = new BlendShapeFrame_U2Res[blendShapeFrameCount];
                    for (int blendShapeFrameI = 0; blendShapeFrameI < blendShapeFrameCount; blendShapeFrameI++)
                    {
                        BlendShapeFrame_U2Res frame = new BlendShapeFrame_U2Res();
                        // todo: ModelImporter just uses 1.0 for weight, should we do that?
                        frame.frameWeight = unityMesh.GetBlendShapeFrameWeight(blendShapeI, blendShapeFrameI);
                        UnityEngine.Vector3[] deltaVertices = new UnityEngine.Vector3[numVertices];
                        UnityEngine.Vector3[] deltaNormals = null;
                        if (normals != null)
                        {
                            deltaNormals = new UnityEngine.Vector3[numVertices];
                        }

                        UnityEngine.Vector3[] deltaTangents = null;
                        if (tangents != null)
                        {
                            deltaTangents = new UnityEngine.Vector3[numVertices];
                        }

                        unityMesh.GetBlendShapeFrameVertices(
                            blendShapeI,
                            blendShapeFrameI,
                            deltaVertices,
                            deltaNormals,
                            deltaTangents
                        );

                        Float3_U2Res[] frameVertices = ResoniteBridgeUtils.ConvertArray<Float3_U2Res, UnityEngine.Vector3>(deltaVertices);
                        for (int i = 0; i < numVertices; i++)
                        {
                            frameVertices[i].x = frameVertices[i].x - vertices[i].x;
                            frameVertices[i].y = frameVertices[i].y - vertices[i].y;
                            frameVertices[i].z = frameVertices[i].z - vertices[i].z;
                        }
                        frame.positions = frameVertices;

                        if (normals != null)
                        {
                            Float3_U2Res[] frameNormals = ResoniteBridgeUtils.ConvertArray<Float3_U2Res, UnityEngine.Vector3>(deltaNormals);
                            for (int i = 0; i < numVertices; i++)
                            {
                                frameNormals[i].x = frameNormals[i].x - normals[i].x;
                                frameNormals[i].y = frameNormals[i].y - normals[i].y;
                                frameNormals[i].z = frameNormals[i].z - normals[i].z;
                            }
                            frame.normals = frameNormals;
                        }

                        if (tangents != null)
                        {
                            Float3_U2Res[] frameTangents = ResoniteBridgeUtils.ConvertArray<Float3_U2Res, UnityEngine.Vector3>(deltaTangents);
                            for (int i = 0; i < numVertices; i++)
                            {
                                frameTangents[i].x = frameTangents[i].x - tangents[i].x;
                                frameTangents[i].y = frameTangents[i].y - tangents[i].y;
                                frameTangents[i].z = frameTangents[i].z - tangents[i].z;
                            }
                            frame.tangents = frameTangents;
                        }
                        blendShape.frames[blendShapeFrameI] = frame;
                    }
                    blendShapes[blendShapeI] = blendShape;
                }
                meshx.blendShapes = blendShapes;
            }
            Debug.Log("Loaded mesh index buffers");

            // todo: they have some normal flipping thing if normals are wrong, do we need that?

            using (Timer _ = new Timer("Bone data"))
            {
                var numBonesPerVertex = unityMesh.GetBonesPerVertex();
                var boneWeights = unityMesh.GetAllBoneWeights();
                meshx.bones = new Bone_U2Res[boneNames.Length];
                meshx.boneBindings = new BoneBinding_U2Res[numVertices];
                UnityEngine.Matrix4x4[] boneBindposes = unityMesh.bindposes;
                if (numBonesPerVertex.Length > 0 && boneWeights.Length > 0)
                {
                    for (int boneI = 0; boneI < boneNames.Length; boneI++)
                    {
                        meshx.bones[boneI] = new Bone_U2Res();
                        meshx.bones[boneI].name = boneNames[boneI];
                        meshx.bones[boneI].bindPose = ConvertMatrix4x4(boneBindposes[boneI]);
                    }
                    int boneWeightIndex = 0;
                    // unity has us traverse over all them in this weird way
                    for (int vertexI = 0; vertexI < numVertices; vertexI++)
                    {
                        byte numBones = numBonesPerVertex[vertexI];
                        BoneBinding_U2Res boneBinding = new BoneBinding_U2Res();
                        meshx.boneBindings[vertexI] = boneBinding;
                        for (int boneI = 0; boneI < numBones; boneI++)
                        {
                            UnityEngine.BoneWeight1 boneWeight = boneWeights[boneWeightIndex++];
                            switch (boneI)
                            {
                                case 0:
                                    boneBinding.boneIndex0 = boneWeight.boneIndex;
                                    boneBinding.weight0 = boneWeight.weight;
                                    break;
                                case 1:
                                    boneBinding.boneIndex1 = boneWeight.boneIndex;
                                    boneBinding.weight1 = boneWeight.weight;
                                    break;
                                case 2:
                                    boneBinding.boneIndex2 = boneWeight.boneIndex;
                                    boneBinding.weight2 = boneWeight.weight;
                                    break;
                                case 3:
                                    boneBinding.boneIndex3 = boneWeight.boneIndex;
                                    boneBinding.weight3 = boneWeight.weight;
                                    break;
                                // sadly resonite only supports up to 4 bones per vertex
                                default:
                                    break;
                            }
                            // luckily unity is already sorted (todo: is decending order correct?)
                        }
                    }
                    //
                    //meshx.SortTrimAndNormalizeBoneWeights();
                    //meshx.FillInEmptyBindings(0);
                }
            }
            Debug.Log("Finished, sending mesh data");

            return meshx;
        }

        public static RefID_U2Res SendMeshToResonite(HierarchyLookup hierarchyLookup, UnityEngine.Mesh mesh, string[] boneNames, ResoniteBridgeClient bridgeClient)
        {
            StaticMesh_U2Res convertedMesh = ConvertMesh(mesh, boneNames.ToArray());
            convertedMesh.rootAssetsSlot = hierarchyLookup.rootAssetsSlot;

            byte[] encoded = null;

            using (Timer _ = new Timer("Encoding"))
            {
                encoded = ResoniteBridgeUtils.EncodeObject(convertedMesh);
                // test to make sure encodes correctly
                //StaticMesh_U2Res decoded = ResoniteBridgeUtils.DecodeObject<StaticMesh_U2Res>(encoded);
                //CheckAllEqual(convertedMesh, decoded);
            }
            using (Timer _ = new Timer("Processing Static Mesh"))
            {
                bridgeClient.SendMessageSync(
                    "ImportToStaticMesh",
                    encoded,
                    -1,
                    out byte[] outBytes,
                    out bool isError
                    );
                if (isError)
                {
                    throw new Exception(ResoniteBridgeUtils.DecodeString(outBytes));
                }
                RefID_U2Res staticMeshRefId = ResoniteBridgeUtils.DecodeObject<RefID_U2Res>(outBytes);
                Debug.Log("Got refid for static mesh of " + staticMeshRefId.id);
                return staticMeshRefId;
            }
        }
    }
}