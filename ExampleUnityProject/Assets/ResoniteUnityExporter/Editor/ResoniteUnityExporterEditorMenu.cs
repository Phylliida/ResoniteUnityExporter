
using System.Collections.Generic;
using System.Linq;
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
			meshx.HasNormals = NotEmpty(unityMesh.normals);
			meshx.HasTangents = NotEmpty(unityMesh.tangents);
			meshx.HasColors = NotEmpty(unityMesh.colors) || NotEmpty(unityMesh.colors32);
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

			Elements.Assets.VertexCollection resultVertices = new Elements.Assets.VertexCollection();
			UnityEngine.Vector3[] vertices = unityMesh.GetVertices();
			float[] vertexRawData = new float[vertices.Length*3];
			System.Runtime.InteropServices.Marshal.Copy(vertices,
				vertexRawData, 
				0, 
				vertices.Length*3);
			for (int i = 0; i < vertices.Length; i++)
			{
				vertexRawData[i * 3] = vertices[i].x;
				vertexRawData[i * 3+1] = vertices[i].y;
				vertexRawData[i * 3+2] = vertices[i].z;
			}
			
			resultVertices._vertices = ;
			meshx.AddVertices(vertices.Length, resultVertices);
		}
		
		
		[MenuItem("ResoniteUnityExporter/Ayy")]
		private static void DoSomething()
		{
			
			Debug.Log("Menu item clicked!");
			
			// Put your menu action code here
		}
	}
}