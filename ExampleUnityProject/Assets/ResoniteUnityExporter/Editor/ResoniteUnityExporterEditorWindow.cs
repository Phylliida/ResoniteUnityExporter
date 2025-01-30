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
        private Texture2D rainbowBorderTexture;
        private Texture2D backgroundTexture;

        void InitializeStyles()
        {
            // Create text style
            customLabelStyle = new GUIStyle(EditorStyles.label);
            customLabelStyle.normal.textColor = Color.white;
            customLabelStyle.fontSize = 12;

            // Create button style
            customButtonStyle = new GUIStyle(GUI.skin.button);
            customButtonStyle.normal.textColor = Color.white;

            // Create rainbow border texture (horizontal gradient)
            rainbowBorderTexture = new Texture2D(256, 1);
            Color[] colors = new Color[256];
            for (int i = 0; i < 256; i++)
            {
                float hue = i / 255f;
                colors[i] = Color.HSVToRGB(hue, 1f, 1f);
            }
            rainbowBorderTexture.SetPixels(colors);
            rainbowBorderTexture.wrapMode = TextureWrapMode.Clamp;
            rainbowBorderTexture.Apply();

            // Create dark background texture
            backgroundTexture = new Texture2D(1, 1);
            backgroundTexture.SetPixel(0, 0, new Color(0.1f, 0.1f, 0.12f));
            backgroundTexture.Apply();
        }


        void OnGUI()
        {
            if (customLabelStyle == null)
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

                bridgeClient = new ResoniteBridgeClient(channelName, serverFolder, (string message) => { Debug.Log(message); });
                //return;
            }

            // Draw background
            GUI.DrawTexture(new Rect(0, 0, position.width, position.height), backgroundTexture);

            // Draw rainbow borders
            float borderSize = 2f;
            GUILayout.Label("(Unofficial) Resonite Unity Exporter", customLabelStyle);

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

            EditorGUILayout.Space(10);

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