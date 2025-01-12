using UnityEngine;
using UnityEditor;
using ResoniteBridgeLib;
using System.Collections.Generic;
using Assets.ResoniteUnityExporter.Editor.ResoniteTransfer.Converters;



namespace ResoniteUnityExporter {
	public class ResoniteUnityExporterEditorWindow : EditorWindow
	{
        static ResoniteUnityExporterEditorWindow()
        {
            EditorApplication.update += ExecuteCoroutine;
        }
        // lets us run coroutines in editor, modified from https://discussions.unity.com/t/coroutine-in-editor/4970/6
        private static void ExecuteCoroutine()
        {
            if (CoroutinesInProgress.Count <= 0)
            {
                return;
            }

            for(int i = CoroutinesInProgress.Count-1; i >= 0; i--)
            {
                if(!CoroutinesInProgress[i].MoveNext())
                {
                    CoroutinesInProgress.RemoveAt(i);
                }
            }
        }

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
            // stop all running coroutines
            CoroutinesInProgress.Clear();
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
        static List<System.Collections.IEnumerator> CoroutinesInProgress = new List<System.Collections.IEnumerator>();
        void OnGUI()
		{
            if (bridgeClient == null) {

				
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
            // bees wow wow wow woffffw wow wo ffw wow wow wow wow wow wow  wows wolw WOW wow wow
            if (bridgeClient.publisher.IsConnected())
            {
                GUILayout.Label("Publisher Connected to Resonite", EditorStyles.boldLabel);
            }
            else
            {
                GUILayout.Label("Publisher Connecting to Resonite...", EditorStyles.boldLabel);
            }
            if (bridgeClient.subscriber.IsConnected())
            {
                GUILayout.Label("Subscriber Connected to Resonite", EditorStyles.boldLabel);
            }
            else
            {
                GUILayout.Label("Subscriber Connecting to Resonite...", EditorStyles.boldLabel);
            }


            string labelText = parentObject == null ? "Sending all objects in scene" : "Sending all objects under parent object " + parentObject.name;
            GUILayout.Label(labelText);

			bool ready = bridgeClient.IsConnected();
			ready = true; // tmp
            EditorGUI.BeginDisabledGroup(!ready);

            if (GUILayout.Button("Export"))
            {
                transferManager = new ResoniteTransferManager();
                RegisterConverters();
                System.Collections.IEnumerator coroutine = transferManager.ConvertObjectAndChildren(exportSlotName, parentObject, bridgeClient);
                CoroutinesInProgress.Add(coroutine);
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