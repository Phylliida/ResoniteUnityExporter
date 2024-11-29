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
            Debug.Log("After Assembffly Reload");
        }

        void OnGUI()
		{
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
			myString = EditorGUILayout.TextField("Teffxt Field", myString);

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
				ResoniteBridgeValue Engine = LookupType("FrooxEngine", "FrooxEngine.Engine");
	            Debug.Log("Got engine " + Engine);
                ResoniteBridgeValue currentEngine = GetProperty(Engine, "Current");
                Debug.Log("Got current engine " + currentEngine);
                if (currentEngine != null) {
                    ResoniteBridgeValue worldManager = GetProperty(currentEngine, "WorldManager");
					Debug.Log("Got world manager " + worldManager);
                    ResoniteBridgeValue focusedWorld = GetProperty(worldManager, "FocusedWorld");
					Debug.Log("Got focused world " + focusedWorld);
					if (focusedWorld != null) {
						CallMethod(focusedWorld, "AddSlot", "Heyo");
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