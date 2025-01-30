using UnityEngine;
using UnityEditor;
using ResoniteBridgeLib;
using System.Collections.Generic;
using Assets.ResoniteUnityExporter.Editor.ResoniteTransfer.Converters;
using System.Numerics;
using System.IO;
using System;



namespace ResoniteUnityExporter {
	public class ResoniteUnityExporterEditorWindow : EditorWindow
	{
        static void OnApplicationQuit()
        {

        }
        static ResoniteUnityExporterEditorWindow()
        {
            EditorApplication.update += ExecuteCoroutine;
            EditorApplication.quitting += EditorApplication_quitting;
        }

        private static void EditorApplication_quitting()
        {
            // we need to clean this up manually
            bridgeClient.Dispose();
        }

        static int iters = 0;
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
            iters += 1;
        }

        public static ResoniteBridgeClient bridgeClient;

        static int windowWidth = 460;
        static int windowHeight = 600;

		// Add menu item named "My Custom Window" to the Window menu
		[MenuItem("ResoniteUnityExporter/Open Resonite Unity Exporter")]
		public static void ShowWindow()
		{
			// Get existing open window or if none, make a new one
            var window = EditorWindow.GetWindow(typeof(ResoniteUnityExporterEditorWindow));
            window.minSize = new UnityEngine.Vector2(windowWidth, windowHeight); // Minimum size
            window.maxSize = new UnityEngine.Vector2(windowWidth, windowHeight); // Maximum size (same as min for fixed size)
        }


        // stuff for recreating connection on reload of scripts
        void OnEnable()
        {
            AssemblyReloadEvents.beforeAssemblyReload += OnBeforeAssemblyReload;
            AssemblyReloadEvents.afterAssemblyReload += OnAfterAssemblyReload;
            titleContent = new GUIContent("Resonite Unity Exporter");
            minSize = new UnityEngine.Vector2(windowWidth, windowHeight);
            maxSize = new UnityEngine.Vector2(windowWidth, windowHeight);
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
            // reinitialize style
            customButtonStyle = null;
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

        bool ranAnyRuns = false;
        bool setupAvatarCreator = true;
        bool setupIK = true;
        bool sendingAvatar = true;

        public static string DebugProgressString = "";
        public static string DebugProgressStringDetail = "";
        // gui
        Transform parentObject;
		string exportSlotName;
		ResoniteTransferManager transferManager;
        static List<System.Collections.IEnumerator> CoroutinesInProgress = new List<System.Collections.IEnumerator>();
        private GUIStyle customLabelStyle;
        private GUIStyle customButtonStyle;
        private GUIStyle headerStyle;
        private Texture2D titleTexture;

        void InitializeStyles()
        {
            // Create text style
            customLabelStyle = new GUIStyle(EditorStyles.label);
            customLabelStyle.normal.textColor = Color.white;
            customLabelStyle.fontSize = 12;

            // Create button style
            customButtonStyle = new GUIStyle(GUI.skin.button);
            customButtonStyle.normal.textColor = Color.white;
            
            // Title texture 
            titleTexture = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/ResoniteUnityExporter/ResoniteUnityImporterLogo.png");
        }


        void OnGUI()
        {
            if (customLabelStyle == null || customButtonStyle == null || headerStyle == null)
            {
                InitializeStyles();
            }
            string serverFolder = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                            "UnityResoniteImporter",
                            "IPCConnections",
                            "Servers"
                        );
            string channelName = "UnityResoniteImporter";

            if (bridgeClient == null)
            {
                // bees

                bridgeClient = new ResoniteBridgeClient(channelName, serverFolder, (string message) => { 
                    // uncomment this for debugging info about connections
                    //Debug.Log(message); 
                });
            }
            // Display the title image at original size and centered
            if (titleTexture != null)
            {
                float imageWidth = titleTexture.width;
                float imageHeight = titleTexture.height;

                // Calculate centered position
                float xPos = (position.width - imageWidth) * 0.5f;

                // Create rect for the image
                Rect imageRect = new Rect(xPos, 10, imageWidth, imageHeight);

                // Reserve space in the layout
                GUILayoutUtility.GetRect(position.width, imageHeight + 20); // +20 for padding

                // Draw the texture
                GUI.DrawTexture(imageRect, titleTexture, ScaleMode.ScaleToFit);
            }

            if (bridgeClient.publisher.NumActiveConnections() > 0 && bridgeClient.subscriber.NumActiveConnections() > 0)
            {
                GUI.color = Color.green;
                GUILayout.Label("Connected to Resonite (2/2)", customLabelStyle);
            }
            else if (bridgeClient.publisher.NumActiveConnections() > 0)
            {
                GUI.color = Color.yellow;
                GUILayout.Label("Connecting to Resonite (1/2 - need subscriber)", customLabelStyle);
            }
            else if (bridgeClient.subscriber.NumActiveConnections() > 0)
            {
                GUI.color = Color.yellow;
                GUILayout.Label("Connecting to Resonite (1/2 - need publisher)", customLabelStyle);
            }
            else
            {
                GUI.color = Color.red;
                GUILayout.Label("Not connected to Resonite", customLabelStyle);
            }
            GUI.color = Color.white;

            EditorGUILayout.Space(5);

            exportSlotName = EditorGUILayout.TextField("Avatar/World Name", exportSlotName);
            parentObject = (Transform)EditorGUILayout.ObjectField(
                new GUIContent("Select the object to export", "Select the object to export"),
                parentObject,
                typeof(Transform),
                true
            );

            string labelText = parentObject == null ? "No object selected, sending all objects in scene" : "Sending object " + parentObject.name;
            GUILayout.Label(labelText);

            using (new EditorGUILayout.VerticalScope(EditorStyles.helpBox))
            {
                GUILayout.Label("Settings");
                sendingAvatar = EditorGUILayout.ToggleLeft("Sending Avatar", sendingAvatar);
                sendingAvatar = !EditorGUILayout.ToggleLeft("Sending World", !sendingAvatar);
                EditorGUI.BeginDisabledGroup(!sendingAvatar);
                if (!sendingAvatar)
                {
                    EditorGUILayout.ToggleLeft("Setup Inverse Kinematics (Recommended)", false);
                    EditorGUILayout.ToggleLeft("Setup Avatar Creator (Recommended)", false);
                }
                else
                {
                    setupIK = EditorGUILayout.ToggleLeft("Setup Inverse Kinematics (Recommended)", setupIK);
                    setupAvatarCreator = EditorGUILayout.ToggleLeft("Setup Avatar Creator (Recommended)", setupAvatarCreator);
                }
                EditorGUI.EndDisabledGroup();
            }

            /* for debugging
            if (GUILayout.Button("Restart connection"))
            {
				bridgeClient.Dispose();
				bridgeClient = null;
                bridgeClient = new ResoniteBridgeClient(channelName, serverFolder, (string message) => { Debug.Log(message); });
            }
            */
            EditorGUILayout.Space(5);



            bool ready = bridgeClient.NumActiveConnections() > 0;

            EditorGUI.BeginDisabledGroup(!ready && CoroutinesInProgress.Count == 0);

            if (GUILayout.Button("Export to Resonite", customButtonStyle))
            {
                if (exportSlotName == null || exportSlotName == "")
                {
                    exportSlotName = "Untitled"; // BLAH
                }
                transferManager = new ResoniteTransferManager();
                RegisterConverters();
                DebugProgressString = "";
                System.Collections.IEnumerator coroutine = transferManager.ConvertObjectAndChildren(exportSlotName, parentObject, bridgeClient, new ResoniteTransferSettings()
                {
                    setupAvatarCreator = setupAvatarCreator,
                    setupIK = setupIK,
                });
                CoroutinesInProgress.Add(coroutine);
                iters = 0;
                ranAnyRuns = true;
                // First, mirror the hierarchy into resonite
            }
            EditorGUI.EndDisabledGroup();
            string progressLabel = "Iters: " + iters + " ... (in progress, please wait)";
            if (CoroutinesInProgress.Count == 0)
            {
                DebugProgressString = "";
                DebugProgressStringDetail = "";
                progressLabel = ranAnyRuns ? "Done" : "";
            }
            using (new EditorGUILayout.VerticalScope(EditorStyles.helpBox))
            {
                GUILayout.Label(progressLabel, customLabelStyle);
                GUILayout.Label(DebugProgressString, customLabelStyle);
                GUILayout.Label(DebugProgressStringDetail, customLabelStyle);
            }
        }
    }
}