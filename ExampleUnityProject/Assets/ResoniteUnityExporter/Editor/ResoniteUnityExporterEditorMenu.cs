
using System;
using System.Collections.Generic;
using System.Linq;
using Elements.Assets;
using UnityEngine;
using UnityEditor;


namespace ResoniteBridgeUnity {
	public class ResoniteUnityExporterEditorMenu
	{
		private IEnumerator<FrooxEngine.Context> ImportFromObject(UnityEngine.GameObject objectRoot)
		{
			// modified from FrooxEngine ModelImporter.cs
			string name = objectRoot.name;
			FrooxEngine.World focusedWorld = FrooxEngine.Engine.Current.WorldManager.FocusedWorld;
			FrooxEngine.Slot targetSlot = focusedWorld.RootSlot.AddSlot(name);
			FrooxEngine.Slot assetsSlot = focusedWorld.AssetsSlot.AddSlot(name);
			assetsSlot.AttachComponent<FrooxEngine.AssetOptimizationBlock>().Persistent = false;
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
			
			
			
			
			
			
			
		}

		public static bool NotEmpty<T>(T[] arr)
		{
			return arr != null && arr.Length > 0;
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
		
		public int[] GetMeshUVChannelDimensions(UnityEngine.Mesh unityMesh, out int[] actualTexCoordIndices)
		{
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
		
		
		
		public Elements.Assets.MeshX UnityMeshToMeshX(UnityEngine.Mesh unityMesh)
		{
			// todo: provide option to ignore bones and ignore vertex colors
			Elements.Assets.MeshX meshx = new Elements.Assets.MeshX();
			meshx.IncreaseVertexCount(unityMesh.vertexCount);
			int numVertices = unityMesh.vertexCount;
			meshx.HasNormals = NotEmpty(unityMesh.normals);
			meshx.HasTangents = NotEmpty(unityMesh.tangents);
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

			Elements.Core.float3[] vertices = ConvertArray<Elements.Core.float3, UnityEngine.Vertex3>(unityMesh.GetVertices());
			meshx.positions = vertices;
			if (meshx.HasColors)
			{
				// important to use .colors instead of .colors32 on the unityMesh
				// because colors32 stores each r,g,b,a as a byte instead of a float
				// so this conversion would not work without manually fixing
				meshx.colors = ConvertArray<Elements.Core.color, UnityEngine.Color>(unityMesh.colors);
			}

			Elements.Core.float3[] normals = null;
			if (meshx.HasNormals)
			{
				normals = ConvertArray<Elements.Core.float3, UnityEngine.Vertex3>(unityMesh.normals);
				meshx.normals = normals;
			}
			Elements.Core.float4[] tangents = null;
			if (meshx.HasTangents)
			{
				tangents = ConvertArray<Elements.Core.float4, UnityEngine.Vertex4>(unityMesh.tangents);
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
				int blendShapeFrameCount = unityMesh.GetblendShapeFrameCount(blendShapeI);
				for (int blendShapeFrameI = 0; blendShapeFrameI < blendShapeFrameCount; blendShapeFrameI++)
				{
					float frameWeight = unityMesh.GetBlendShapeFrameWeight(blendShapeI, blendShapeFrameI);
					Elements.Assets.BlendShapeFrame blendShapeFrame = blendShape.AddFrame(frameWeight);
					UnityEngine.Vector3[] deltaVertices = new UnityEngine.Vector3[numVertices];
					UnityEngine.Vector3[] deltaNormals = new UnityEngine.Vector3[numVertices];
					UnityEngine.Vector3[] deltaTangents = new UnityEngine.Vector3[numVertices];
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

					if (blendShape.HasNormals)
					{
						Elements.Core.float3[] frameNormals = ConvertArray<Elements.Core.float3, UnityEngine.Vector3>(deltaNormals);
						for (int i = 0; i < numVertices; i++)
						{
							frameNormals[i] = frameNormals[i] - normals[i];
						}
						blendShapeFrame.normals = frameNormals;
					}
					
					if (blendShape.HasTangents)
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