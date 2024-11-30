using UnityEngine;
using UnityEditor;
using ResoniteBridge;
using static ResoniteBridge.ResoniteBridgeClientWrappers;



namespace ResoniteBridgeUnity {
	public class ResoniteUnityExporterEditorWindow : EditorWindow
	{
		string myString = "Hello World";
		bool groupEnabled;
		float myFloat = 1.23f;
		
		public static ResoniteBridgeClient bridgeClient;

		// Add menu item named "My Custom Window" to the Window menu
		[MenuItem("ResoniteUnityExporter/Open Resonite Unity Exporter")]
		public static void ShowWindow()
		{
			// Get existing open window or if none, make a new one
			EditorWindow.GetWindow(typeof(ResoniteUnityExporterEditorWindow));
		}

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
            Debug.Log("fAfter Assfembffly Reload");
        }

        void OnGUI()
		{
            ResoniteBridge.ResoniteBridgeClientWrappers.DebugLog = (string message) =>
            {
                Debug.Log(message);
            };

            if (bridgeClient == null) {
                
                bridgeClient = new ResoniteBridgeClient((string message) => { Debug.Log(message); });
				
            }
			if (bridgeClient.connected) {
				GUILayout.Label("Connected to Resonite", EditorStyles.boldLabel);
			}
			else {
				GUILayout.Label("Connecting to Resonite...", EditorStyles.boldLabel);
				return;
			}
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
				ResoniteBridgeValue currentEngine = ResoniteWrapper.FrooxEngine.Engine.Current;
                Debug.Log("Got current engine " + currentEngine);
                if (currentEngine != null) {
                    ResoniteBridgeValue worldManager = GetProperty(currentEngine, "WorldManager");
					Debug.Log("Got world manager " + worldManager);
                    ResoniteBridgeValue focusedWorld = GetProperty(worldManager, "FocusedWorld");
					Debug.Log("Got focused world " + focusedWorld);
					if (focusedWorld != null) {
						ResoniteBridgeValue rootSlot = GetProperty(focusedWorld, "RootSlot");
						Debug.Log("Got root slot " + rootSlot);
						CallMethod(rootSlot, "AddSlot", "Heyo");
					}
				}
				Debug.Log("Button 1");
			}
			if(GUILayout.Button("Button 2"))
			{
				Debug.Log("Button 2");
			}
			EditorGUILayout.EndHorizontal();
		}
	}
}