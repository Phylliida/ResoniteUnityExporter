using UnityEngine;
using UnityEditor;
using ResoniteBridgeLib;
using ResoniteUnityExporterShared;



namespace ResoniteBridgeUnity {
	public class ResoniteUnityExporterEditorWindow : EditorWindow
	{
		
		public static ResoniteBridgeClient bridgeClient;

		// Add menu item named "My Custom Window" to the Window menu
		[MenuItem("ResoniteUnityExporter/Open Resonite Unity Exporter")]
		public static void ShowWindow()
		{
			// Get existing open window or if none, make a new one
			EditorWindow.GetWindow(typeof(ResoniteUnityExporterEditorWindow));
		}

		
		// stuff for recreating connection on reload of scripts
        void OnEnable()
        {
            AssemblyReloadEvents.beforeAssemblyReload += OnBeforeAssemblyReload;
            AssemblyReloadEvents.afterAssemblyReload += OnAfterAssemblyReload;
        }

        void OnDisable()
        {
            AssemblyReloadEvents.beforeAssemblyReload -= OnBeforeAssemblyReload;
            AssemblyReloadEvents.afterAssemblyReload -= OnAfterAssemblyReload;
        }
        public void OnBeforeAssemblyReload()
        {
			if (bridgeClient != null)
			{
				bridgeClient.Dispose();
				
				bridgeClient = null;
            }
        }
        public void OnAfterAssemblyReload()
        {
        }


		// gui
		SkinnedMeshRenderer skinnedMesh;
        void OnGUI()
		{
            if (bridgeClient == null) {
                
                bridgeClient = new ResoniteBridgeClient((string message) => { Debug.Log(message); });
				
            }
            skinnedMesh = (SkinnedMeshRenderer)EditorGUILayout.ObjectField(
				"Skinned Mesh",
				skinnedMesh,
				typeof(SkinnedMeshRenderer),
				true
			);

            if (bridgeClient.IsConnected()) {
				GUILayout.Label("Connected to Resonite", EditorStyles.boldLabel);
			}
			else {
				GUILayout.Label("Connecting to Resonite...", EditorStyles.boldLabel);
				return;
			}

			if (skinnedMesh == null)
			{
				GUILayout.Label("Need skinned mesh");
				return;
			}

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("Export"))
            {
				ResoniteUnityExporterEditorMenu.ImportSkinnedMesh(skinnedMesh, bridgeClient);
            }
            EditorGUILayout.EndHorizontal();


            /*
			myString = EditorGUILayout.TextField("Tefffxt Field", myString);

			groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
			myFloat = EditorGUILayout.Slider("Slider", myFloat, 0, 5);
			EditorGUILayout.EndToggleGroup();

			if(GUILayout.Button("Press Me"))
			{
				Debug.Log("Button pressed!");
			}

			// Example of creating a horizontal group of controls
			EditorGUILayout.BeginHorizontal();
			if(GUILayout.Button("Button 1"))
			{
				FrooxEngine.Engine engine = FrooxEngine.Engine.Current;
                Debug.Log("Got current engine " + engine.UID);
				if (engine != null)
				{
					FrooxEngine.World world = engine.WorldManager.FocusedWorld;
					if (world != null)
					{
						world.RootSlot.AddSlot("beees");
					}
				}
				Debug.Log("Button 1");
			}
			if(GUILayout.Button("Button 2"))
			{
				Debug.Log("Button 2");
			}
			*/
            EditorGUILayout.EndHorizontal();
		}
	}
}