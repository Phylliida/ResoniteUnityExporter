using UnityEngine;
using UnityEditor;
using ResoniteBridgeLib;
using System.Collections.Generic;
using Assets.ResoniteUnityExporter.Editor.ResoniteTransfer.Converters;



namespace ResoniteUnityExporter {
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
			// on script reload we need to remember to Dispose it manually
			// otherwise unity will hang
			if (bridgeClient != null)
			{
				bridgeClient.Dispose();
				
				bridgeClient = null;
            }
        }
        public void OnAfterAssemblyReload()
        {
        }

        void Update()
        {
            // Your GUI code here
            Repaint();
        }


		void RegisterConverters()
		{
            transferManager.RegisterConverter<SkinnedMeshRenderer>(SkinnedMeshRendererConverter.ConvertSkinnedMeshRenderer);
        }

        // gui
        Transform parentObject;
		string exportSlotName;
		ResoniteTransferManager transferManager;
        void OnGUI()
		{
            if (bridgeClient == null) {

                transferManager = new ResoniteTransferManager();
				RegisterConverters();
				
                // bees
                bridgeClient = new ResoniteBridgeClient((string message) => { Debug.Log(message); });
				//return;
            }
            parentObject = (Transform)EditorGUILayout.ObjectField(
				"Parent object",
                parentObject,
				typeof(Transform),
				true
			);

            exportSlotName = EditorGUILayout.TextField(exportSlotName);

            if (GUILayout.Button("Restart connection"))
            {
				bridgeClient.Dispose();
				bridgeClient = null;
                bridgeClient = new ResoniteBridgeClient((string message) => { Debug.Log(message); });
            }
            // bees wow wow wow wow wow wow wow wow wow wow wow wow  wows wolw WOW wow wow
            if (bridgeClient.IsConnected()) {
				GUILayout.Label("Connected to Resonite", EditorStyles.boldLabel);
			}
			else {
				GUILayout.Label("Connecting to Resonite...", EditorStyles.boldLabel);
			}

			string labelText = parentObject == null ? "Sending all objects in scene" : "Sending all objects under parent object " + parentObject.name;
            GUILayout.Label(labelText);

			bool ready = bridgeClient.IsConnected();
			ready = true; // tmp
            EditorGUI.BeginDisabledGroup(!ready);

            if (GUILayout.Button("Export"))
            {
                transferManager.ConvertObjectAndChildren(exportSlotName, parentObject, bridgeClient);
                // First, mirror the hierarchy into resonite
            }
            EditorGUI.EndDisabledGroup();

            // bees

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
        }
	}
}