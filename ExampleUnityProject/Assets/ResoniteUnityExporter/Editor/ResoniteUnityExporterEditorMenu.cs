
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Elements.Assets;
//using ResoniteBridge;
using UnityEngine;
using UnityEditor;
using ResoniteUnityExporterShared;
using ResoniteBridgeLib;
using System.Xml.Linq;
using UnityEngine.XR;
using UnityEngine.Assertions.Must;
using System.Runtime.InteropServices;


namespace ResoniteBridgeUnity
{
	public class ResoniteUnityExporterEditorMenu
	{

		public static RefID_U2Res ImportSkinnedMesh(UnityEngine.SkinnedMeshRenderer skinnedMeshRenderer, ResoniteBridgeClient bridgeClient)
		{
            List<string> boneNames = new List<string>();
            if (NotEmpty(skinnedMeshRenderer.bones))
            {
                foreach (UnityEngine.Transform bone in skinnedMeshRenderer.bones)
                {
                    boneNames.Add(bone.name);
                }
            }

			StaticMesh_U2Res convertedMesh = ConvertMesh(skinnedMeshRenderer.sharedMesh, boneNames.ToArray());

			bridgeClient.SendMessageSync(
                "ImportToStaticMesh",
				ResoniteBridgeUtils.EncodeObject(convertedMesh),
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

        public static bool NotEmpty<T>(T[] arr)
        {
            return arr != null && arr.Length > 0;
        }



        public static Matrix4x4_U2Res ConvertMatrix4x4(UnityEngine.Matrix4x4 mat)
        {
            return new Matrix4x4_U2Res()
			{
				m00=mat.m00, m01=mat.m01, m02= mat.m02, m03=mat.m03,
				m10=mat.m10, m11=mat.m11, m12= mat.m12, m13=mat.m13,
				m20=mat.m20, m21=mat.m21, m22= mat.m22, m23=mat.m23,
				m30=mat.m30, m31=mat.m31, m32= mat.m32, m33=mat.m33
            };
        }

        public static ResoniteUnityExporterShared.StaticMesh_U2Res ConvertMesh(UnityEngine.Mesh unityMesh, string[] boneNames)
        {
			// todo: provide option to ignore bones and ignore vertex colors
			StaticMesh_U2Res meshx = new StaticMesh_U2Res();
			meshx.name = unityMesh.name;
            int[] uvDimensions = GetMeshUVChannelDimensions(unityMesh, out int[] actualTexCoordIndices);

            Float3_U2Res[] vertices = U2ResUtils.ConvertArray<Float3_U2Res, UnityEngine.Vector3>(unityMesh.vertices);
            meshx.positions = vertices;
			int numVertices = vertices.Length;
            if (NotEmpty(unityMesh.colors))
            {
                // important to use .colors instead of .colors32 on the unityMesh
                // because colors32 stores each r,g,b,a as a byte instead of a float
                // so this conversion would not work without manually fixing
                meshx.colors = U2ResUtils.ConvertArray<Float4_U2Res, UnityEngine.Color>(unityMesh.colors);
            }

            Float3_U2Res[] normals = null;
            if (NotEmpty(unityMesh.normals))
            {
                normals = U2ResUtils.ConvertArray<Float3_U2Res, UnityEngine.Vector3>(unityMesh.normals);
                meshx.normals = normals;
            }
            Float4_U2Res[] tangents = null;
            if (NotEmpty(unityMesh.tangents))
            {
                tangents = U2ResUtils.ConvertArray<Float4_U2Res, UnityEngine.Vector4>(unityMesh.tangents);
                meshx.tangents = tangents;
            }

            // uvs are stored as UV_Array[] uv_channels
            // where uv_channels[0] is for UV0 array, uv_channels[1] is for UV1 array, etc.
            // inside a UV_Array they have three arrays,
            // float2[] uv_2D
            // float3[] uv_3D
            // float4[] uv_4D
            // so we can just set that directly
            UVArray_U2Res[] allUvs = new UVArray_U2Res[uvDimensions.Length];
            for (int i = 0; i < uvDimensions.Length; i++)
            {
                allUvs[i] = new UVArray_U2Res();
                int curDimension = uvDimensions[i];
                if (curDimension == 2)
                {
                    List<UnityEngine.Vector2> uvs = new List<UnityEngine.Vector2>(unityMesh.vertexCount);
                    unityMesh.GetUVs(actualTexCoordIndices[i], uvs);
                    allUvs[i].uv_2D = U2ResUtils.ConvertArray<Float2_U2Res, UnityEngine.Vector2>(uvs.ToArray());
                }
                else if (curDimension == 3)
                {
                    List<UnityEngine.Vector3> uvs = new List<UnityEngine.Vector3>(unityMesh.vertexCount);
                    unityMesh.GetUVs(actualTexCoordIndices[i], uvs);
                    allUvs[i].uv_3D = U2ResUtils.ConvertArray<Float3_U2Res, UnityEngine.Vector3>(uvs.ToArray());
                }
                else if (curDimension == 4)
                {
                    List<UnityEngine.Vector4> uvs = new List<UnityEngine.Vector4>(unityMesh.vertexCount);
                    unityMesh.GetUVs(actualTexCoordIndices[i], uvs);
                    allUvs[i].uv_4D = U2ResUtils.ConvertArray<Float4_U2Res, UnityEngine.Vector4>(uvs.ToArray());
                }
            }
            meshx.uvChannels = allUvs;

            // submesh (index buffers)
            TriSubmesh_U2Res[] submeshes = new TriSubmesh_U2Res[unityMesh.subMeshCount];
            for (int subMeshI = 0; subMeshI < unityMesh.subMeshCount; subMeshI++)
            {
                UnityEngine.Rendering.SubMeshDescriptor subMeshDescriptor = unityMesh.GetSubMesh(subMeshI);
				TriSubmesh_U2Res submesh = new TriSubmesh_U2Res();
				submeshes[subMeshI] = submesh;
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
            }

			BlendShape_U2Res[] blendShapes = new BlendShape_U2Res[unityMesh.blendShapeCount];

            for (int blendShapeI = 0; blendShapeI < unityMesh.blendShapeCount; blendShapeI++)
            {
				BlendShape_U2Res blendShape = new BlendShape_U2Res();
				blendShapes[blendShapeI] = blendShape;
                blendShape.name = unityMesh.GetBlendShapeName(blendShapeI);
                int blendShapeFrameCount = unityMesh.GetBlendShapeFrameCount(blendShapeI);
				blendShape.frames = new BlendShapeFrame_U2Res[blendShapeFrameCount];
                for (int blendShapeFrameI = 0; blendShapeFrameI < blendShapeFrameCount; blendShapeFrameI++)
                {
					BlendShapeFrame_U2Res frame = new BlendShapeFrame_U2Res();
					blendShape.frames[blendShapeFrameI] = frame;
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

                    Float3_U2Res[] frameVertices = U2ResUtils.ConvertArray<Float3_U2Res, UnityEngine.Vector3>(deltaVertices);
                    for (int i = 0; i < numVertices; i++)
                    {
                        frameVertices[i].x = frameVertices[i].x - vertices[i].x;
                        frameVertices[i].y = frameVertices[i].y - vertices[i].y;
                        frameVertices[i].z = frameVertices[i].z - vertices[i].z;
                    }
					frame.positions = frameVertices;

                    if (normals != null)
                    {
                        Float3_U2Res[] frameNormals = U2ResUtils.ConvertArray<Float3_U2Res, UnityEngine.Vector3>(deltaNormals);
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
                        Float3_U2Res[] frameTangents = U2ResUtils.ConvertArray<Float3_U2Res, UnityEngine.Vector3>(deltaTangents);
                        for (int i = 0; i < numVertices; i++)
                        {
                            frameTangents[i].x = frameTangents[i].x - tangents[i].x;
                            frameTangents[i].y = frameTangents[i].y - tangents[i].y;
                            frameTangents[i].z = frameTangents[i].z - tangents[i].z;
                        }
						frame.tangents = frameTangents;
                    }
                }
            }

            // todo: they have some normal flipping thing if normals are wrong, do we need that?

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

			/*
            bool makeDualSided = false;
            bool makeFlatShaded = false;
            bool calculateTangents = false;
            if (makeDualSided)
            {
                meshx.MakeDualSided();
            }
            if (makeFlatShaded)
            {
                meshx.ConvertToFlatShading();
            }
            meshx.StripEmptyBlendshapes();
            if (calculateTangents)
            {
                meshx.RecalculateTangentsMikktspace();
            }
			*/

            return meshx;
        }
    }
}
		/*
			// modified from FrooxEngine ModelImporter.cs
			string name = objectRoot.name;
			FrooxEngine.World focusedWorld = FrooxEngine.Engine.Current.WorldManager.FocusedWorld;
			FrooxEngine.Slot targetSlot = focusedWorld.RootSlot.AddSlot(name);
			FrooxEngine.Slot assetsSlot = focusedWorld.AssetsSlot.AddSlot(name);
			assetsSlot.AttachComponent<FrooxEngine.AssetOptimizationBlock>().Persistent = false;
			/*
			yield return FrooxEngine.Context.ToBackground();
			// internally froox engine rotates around y axis 180 degrees (idk why)
			// and then calls string text = ModelPreimporter.Preimport(file, localDB.TemporaryPath);
			// which uses Blender/FreeCad to convert to glb/obj, respectively
			// we don't need to do this since we have the raw data
			FrooxEngine.Animator animator = null; 
			FrooxEngine.ModelImporter.ModelImportData data = null;
			
			// this is passed in as argument: todo: lookup default values
			FrooxEngine.ModelImportSettings settings = new FrooxEngine.ModelImportSettings();
			settings.Scale = 1.0f;
			
			// some magic numbers from ModelImporter.cs
			Assimp.AssimpContext assimpContext = new Assimp.AssimpContext();
			assimpContext.Scale = settings.Scale;
			assimpContext.SetConfig(new Assimp.Configs.NormalSmoothingAngleConfig(66f));
			assimpContext.SetConfig(new Assimp.Configs.TangentSmoothingAngleConfig(10f));
			// Note: removed Assimp.PostProcessSteps.PopulateArmatureData because my version of assimp doesn't have that
			// idk why
			Assimp.PostProcessSteps postProcessSteps = Assimp.PostProcessSteps.JoinIdenticalVertices | Assimp.PostProcessSteps.ImproveCacheLocality | Assimp.PostProcessSteps.GenerateUVCoords | Assimp.PostProcessSteps.FindInstances | Assimp.PostProcessSteps.FlipWindingOrder;
			if (settings.DeduplicateInstances)
			{
				postProcessSteps |= Assimp.PostProcessSteps.FindInstances;
			}
			if (settings.OptimizeModel)
			{
				postProcessSteps |= Assimp.PostProcessSteps.OptimizeMeshes | Assimp.PostProcessSteps.OptimizeGraph;
			}
			if (settings.CalculateNormals)
			{
				postProcessSteps |= Assimp.PostProcessSteps.GenerateSmoothNormals;
			}
			if (settings.ImportBones)
			{
				postProcessSteps |= Assimp.PostProcessSteps.LimitBoneWeights;
			}
			Assimp.Scene scene = assimpContext.ImportFile(file, postProcessSteps);
			assimpContext.Dispose();
			Elements.Core.IProgressIndicator progressIndicator = null;
			data = new FrooxEngine.ModelImporter.ModelImportData(file, scene, targetSlot, assetsSlot, settings, progressIndicator);
			// this just does some transformations on the scene data
			FrooxEngine.ModelImporter.PreprocessScene(scene);
			if (settings.SplitSubmeshes)
			{
				// this just recursively splits any submeshes into their own mesh
				FrooxEngine.ModelImporter.SplitSubmeshes(scene.RootNode);
			}
			// this is the call
			yield return FrooxEngine.Context.WaitFor(
				FrooxEngine.ModelImporter.ImportNode(
					scene.RootNode, targetSlot, data));
			// this is what ImportNode does
			if (scene.RootNode.MeshCount > 0)
			{
				yield return FrooxEngine.Context.WaitFor(
					FrooxEngine.ModelImporter.ImportMesh(node.MeshIndices, data));
			}
			// ... more stuff, but firsst
			// this is what ImportMesh does
			
			
			
			* /			
			
			
			
			
		}

		public static bool NotEmpty<T>(T[] arr)
		{
			return arr != null && arr.Length > 0;
		}

		public void SkinnedMeshRendererToSlot(UnityEngine.SkinnedMeshRenderer skinnedMeshRenderer, FrooxEngine.Slot attachingSlot, FrooxEngine.Slot assetsSlot)
		{
			List<string> boneNames = new List<string>();
			if (NotEmpty(skinnedMeshRenderer.bones))
			{
				foreach (UnityEngine.Transform bone in skinnedMeshRenderer.bones)
				{
					boneNames.Add(bone.name);
				}
			}

			Elements.Assets.MeshX meshx = UnityMeshToMeshX(skinnedMeshRenderer.sharedMesh, boneNames.ToArray());
			
			ResoniteBridgeClientWrappers.SetThreadState(ResoniteBridgeServer.ThreadState.Background);
			FrooxEngine.Store.LocalDB localDb = attachingSlot.World.Engine.LocalDB;
			string tempFilePath = localDb.GetTempFilePath("meshx");
			meshx.SaveToFile(tempFilePath);
			Uri url = localDb.ImportLocalAssetAsync(tempFilePath, FrooxEngine.Store.LocalDB.ImportLocation.Move).Result;
			//yield return FrooxEngine.Context.ToWorld();
			ResoniteBridgeClientWrappers.SetThreadState(ResoniteBridgeServer.ThreadState.World);
			FrooxEngine.StaticMesh staticMesh = assetsSlot.AddSlot("Mesh").AttachComponent<FrooxEngine.StaticMesh>();
			staticMesh.URL.Value = url;
		
		}
		
		public Elements.Assets.MeshX UnityMeshToMeshX(UnityEngine.Mesh unityMesh, string[] boneNames=null)
		{
			// todo: provide option to ignore bones and ignore vertex colors
			Elements.Assets.MeshX meshx = new Elements.Assets.MeshX();
			meshx.IncreaseVertexCount(unityMesh.vertexCount);
			int numVertices = unityMesh.vertexCount;
			bool hasNormals = NotEmpty(unityMesh.normals);
			meshx.HasNormals = hasNormals;
			bool hasTangents = NotEmpty(unityMesh.tangents);
			meshx.HasTangents = hasTangents;
			// todo: do they ever have colors32 without colors? (maybe we need to convert)
			meshx.HasColors = NotEmpty(unityMesh.colors);
			// todo: is this right? maybe we need to look at bindposes too
			meshx.HasBoneBindings = NotEmpty(unityMesh.boneWeights);
			// todo: make little drop down auto generate if need to configure options for thing
			// like a material needs to auto convert, which do u use?
			// they force all submeshes from the same import to have the same dimensions
			// but I think that's guaranteed by unity so we are ok
			int[] uvDimensions = GetMeshUVChannelDimensions(unityMesh, out int[] actualTexCoordIndices);
			for (int i = 0; i < uvDimensions.Length; i++)
			{
				meshx.SetUV_Dimension(i, uvDimensions[i]);
			}

			Elements.Core.float3[] vertices = ConvertArray<Elements.Core.float3, UnityEngine.Vector3>(unityMesh.vertices);
			meshx.positions = vertices;
			if (meshx.HasColors)
			{
				// important to use .colors instead of .colors32 on the unityMesh
				// because colors32 stores each r,g,b,a as a byte instead of a float
				// so this conversion would not work without manually fixing
				meshx.colors = ConvertArray<Elements.Core.color, UnityEngine.Color>(unityMesh.colors);
			}

			Elements.Core.float3[] normals = null;
			if (hasNormals)
			{
				normals = ConvertArray<Elements.Core.float3, UnityEngine.Vector3>(unityMesh.normals);
				meshx.normals = normals;
			}
			Elements.Core.float4[] tangents = null;
			if (hasTangents)
			{
				tangents = ConvertArray<Elements.Core.float4, UnityEngine.Vector4>(unityMesh.tangents);
				meshx.tangents = tangents;
			}
			
			// uvs are stored as UV_Array[] uv_channels
			// where uv_channels[0] is for UV0 array, uv_channels[1] is for UV1 array, etc.
			// inside a UV_Array they have three arrays,
			// float2[] uv_2D
			// float3[] uv_3D
			// float4[] uv_4D
			// so we can just set that directly
			Elements.Assets.MeshX.UV_Array[] allUvs = new Elements.Assets.MeshX.UV_Array[uvDimensions.Length];
			for (int i = 0; i < uvDimensions.Length; i++)
			{
				allUvs[i] = new MeshX.UV_Array();
				int curDimension = uvDimensions[i];
				if (curDimension == 2)
				{
					List<UnityEngine.Vector2> uvs = new List<UnityEngine.Vector2>(unityMesh.vertexCount);
					unityMesh.GetUVs(actualTexCoordIndices[i], uvs);
					allUvs[i].uv_2D = ConvertArray<Elements.Core.float2, UnityEngine.Vector2>(uvs.ToArray());
				}
				else if (curDimension == 3)
				{
					List<UnityEngine.Vector3> uvs = new List<UnityEngine.Vector3>(unityMesh.vertexCount);
					unityMesh.GetUVs(actualTexCoordIndices[i], uvs);
					allUvs[i].uv_3D = ConvertArray<Elements.Core.float3, UnityEngine.Vector3>(uvs.ToArray());
				}
				else if (curDimension == 4)
				{
					List<UnityEngine.Vector4> uvs = new List<UnityEngine.Vector4>(unityMesh.vertexCount);
					unityMesh.GetUVs(actualTexCoordIndices[i], uvs);
					allUvs[i].uv_4D = ConvertArray<Elements.Core.float4, UnityEngine.Vector4>(uvs.ToArray());
				}
			}

			meshx.uv_channels = allUvs;
			
			// submesh (index buffers)
			List<Elements.Assets.Submesh> submeshes = new List<Elements.Assets.Submesh>();
			for(int subMeshI = 0; subMeshI < unityMesh.subMeshCount; subMeshI++)
			{
				UnityEngine.Rendering.SubMeshDescriptor subMeshDescriptor = unityMesh.GetSubMesh(subMeshI);
				Elements.Assets.TriangleSubmesh submesh = meshx.AddSubmesh<Elements.Assets.TriangleSubmesh>();
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
							int v1 = indicies[triI+1];
							int v2 = indicies[triI+2];
							indicies[triI] = v2;
							indicies[triI+1] = v1;
							indicies[triI+2] = v0;
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
						int v1 = indicies[quadI+1];
						int v2 = indicies[quadI+2];
						int v3 = indicies[quadI+3];
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
				int[] primitiveIDs = new int[numPrimitives];
				for (int i = 0; i < numPrimitives; i++)
				{
					primitiveIDs[i] = i;
				}
				submesh.indicies = indicies;
				submesh.primitiveIDs = primitiveIDs;
				submesh._currentID = numPrimitives;
				submesh.Count = numPrimitives;
			}

			for (int blendShapeI = 0; blendShapeI < unityMesh.blendShapeCount; blendShapeI++)
			{
				string blendShapeName = unityMesh.GetBlendShapeName(blendShapeI);
				Elements.Assets.BlendShape blendShape = meshx.AddBlendShape(blendShapeName);
				int blendShapeFrameCount = unityMesh.GetBlendShapeFrameCount(blendShapeI);
				for (int blendShapeFrameI = 0; blendShapeFrameI < blendShapeFrameCount; blendShapeFrameI++)
				{
					float frameWeight = unityMesh.GetBlendShapeFrameWeight(blendShapeI, blendShapeFrameI);
					// todo: ModelImporter just uses 1.0 for weight, should we do that?
					Elements.Assets.BlendShapeFrame blendShapeFrame = blendShape.AddFrame(frameWeight);
					UnityEngine.Vector3[] deltaVertices = new UnityEngine.Vector3[numVertices];
					UnityEngine.Vector3[] deltaNormals = null;
					if (hasNormals)
					{
						deltaNormals = new UnityEngine.Vector3[numVertices];
					}

					UnityEngine.Vector3[] deltaTangents = null;
					if (hasTangents)
					{
						deltaTangents = new UnityEngine.Vector3[numVertices];
					}
					
					blendShape.HasNormals = meshx.HasNormals;
					blendShape.HasTangents = meshx.HasTangents;

					unityMesh.GetBlendShapeFrameVertices(
						blendShapeI,
						blendShapeFrameI,
						deltaVertices,
						deltaNormals,
						deltaTangents
					);

					Elements.Core.float3[] frameVertices = ConvertArray<Elements.Core.float3, UnityEngine.Vector3>(deltaVertices);
					for (int i = 0; i < numVertices; i++)
					{
						frameVertices[i] = frameVertices[i] - vertices[i];
					}
					blendShapeFrame.positions = frameVertices;

					if (hasNormals)
					{
						Elements.Core.float3[] frameNormals = ConvertArray<Elements.Core.float3, UnityEngine.Vector3>(deltaNormals);
						for (int i = 0; i < numVertices; i++)
						{
							frameNormals[i] = frameNormals[i] - normals[i];
						}
						blendShapeFrame.normals = frameNormals;
					}
					
					if (hasTangents)
					{
						Elements.Core.float3[] frameTangents = ConvertArray<Elements.Core.float3, UnityEngine.Vector3>(deltaTangents);
						for (int i = 0; i < numVertices; i++)
						{
							frameTangents[i] = frameTangents[i] - tangents[i].xyz;
						}
						blendShapeFrame.tangents = frameTangents;
					}
				}
			}
			
			// todo: they have some normal flipping thing if normals are wrong, do we need that?

			var numBonesPerVertex = unityMesh.GetBonesPerVertex();
			var boneWeights = unityMesh.GetAllBoneWeights();
			UnityEngine.Matrix4x4[] boneBindposes = unityMesh.bindposes;
			if (numBonesPerVertex.Length > 0 && boneWeights.Length > 0)
			{
				Dictionary<string, Elements.Assets.Bone> stringToBone = new Dictionary<string, Elements.Assets.Bone>();
				Elements.Assets.BoneBinding[] boneBindings = new Elements.Assets.BoneBinding[numVertices];
				for (int boneI = 0; boneI < boneNames.Length; boneI++)
				{
					string boneName = boneNames[boneI];
					Elements.Core.float4x4 boneBindPose = ConvertMatrix4x4(boneBindposes[boneI]);
					if (!stringToBone.TryGetValue(boneName, out Elements.Assets.Bone bone))
					{
						bone = meshx.AddBone(boneName);
						bone.BindPose = boneBindPose;
						stringToBone.Add(boneName, bone);
					}
				}
				int boneWeightIndex = 0;
				// unity has us traverse over all them in this weird way
				for (int vertexI = 0; vertexI < numVertices; vertexI++)
				{
					byte numBones = numBonesPerVertex[vertexI];
					BoneBinding boneBinding = new BoneBinding();
					for (int boneI = 0; boneI < numBones; boneI++)
					{
						UnityEngine.BoneWeight1 boneWeight = boneWeights[boneWeightIndex++];
						switch (boneI)
						{
							case 0:
								boneBindings[vertexI].boneIndex0 = boneWeight.boneIndex;
								boneBindings[vertexI].weight0 = boneWeight.weight;
								break;
							case 1:
								boneBindings[vertexI].boneIndex1 = boneWeight.boneIndex;
								boneBindings[vertexI].weight1 = boneWeight.weight;
								break;
							case 2:
								boneBindings[vertexI].boneIndex2 = boneWeight.boneIndex;
								boneBindings[vertexI].weight2 = boneWeight.weight;
								break;
							case 3:
								boneBindings[vertexI].boneIndex3 = boneWeight.boneIndex;
								boneBindings[vertexI].weight3 = boneWeight.weight;
								break;
							// sadly resonite only supports up to 4 bones per vertex
							default:
								break;
						}
						// luckily unity is already sorted (todo: is decending order correct?)
					}
				}
				meshx.boneBindings = boneBindings;
				meshx.SortTrimAndNormalizeBoneWeights();
				meshx.FillInEmptyBindings(0);
			}

			bool makeDualSided = false;
			bool makeFlatShaded = false;
			bool calculateTangents = false;
			if (makeDualSided)
			{
				meshx.MakeDualSided();
			}
			if (makeFlatShaded)
			{
				meshx.ConvertToFlatShading();
			}
			meshx.StripEmptyBlendshapes();
			if (calculateTangents)
			{
				meshx.RecalculateTangentsMikktspace();
			}

			return meshx;
		}

		public Elements.Core.float4x4 ConvertMatrix4x4(UnityEngine.Matrix4x4 mat)
		{
			return new Elements.Core.float4x4(
				mat.m00, mat.m01, mat.m02, mat.m03,
				mat.m10, mat.m11, mat.m12, mat.m13,
				mat.m20, mat.m21, mat.m22, mat.m23,
				mat.m30, mat.m31, mat.m32, mat.m33);
		}

		/// <summary>
		/// Note that this only works for arrays that use the same underlying data
		/// i.e. it assumes sizes are the same and just copies the raw representation
		/// </summary>
		/// <param name="inArr"></param>
		/// <typeparam name="ArrIn"></typeparam>
		/// <typeparam name="ArrOut"></typeparam>
		/// <returns></returns>
		public static ArrOut[] ConvertArray<ArrOut, ArrIn>(ArrIn[] inArr)
		{
			ArrOut[] outArr = new ArrOut[inArr.Length];
			Buffer.BlockCopy(
				inArr, 0,
				outArr, 0,
				inArr.Length);
			return outArr;
		}
		
		
		[MenuItem("ResoniteUnityExporter/Ayy")]
		private static void DoSomething()
		{
			
			Debug.Log("Menu item clicked!");
			
			// Put your menu action code here
		}
	}
}
*/