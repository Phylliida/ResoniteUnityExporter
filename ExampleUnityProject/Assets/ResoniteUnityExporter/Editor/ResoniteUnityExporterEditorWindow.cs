using UnityEngine;
using UnityEditor;
using ResoniteBridgeLib;
using System.Collections.Generic;
using Assets.ResoniteUnityExporter.Editor.ResoniteTransfer.Converters;
using System.Numerics;
using System.IO;
using System;
using System.Linq;



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

        static int windowWidth = 480;
        static int windowHeight = 700;

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

        // uses scene camera to capture from a given position+rot+scale
        public Texture2D CaptureFromPosition(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, float nearClip, int width = 1920, int height = 1080)
        {
            SceneView sceneView = SceneView.lastActiveSceneView;
            if (sceneView == null) return null;

            // Store original transform
            UnityEngine.Vector3 originalPos = sceneView.camera.transform.position;
            UnityEngine.Quaternion originalRot = sceneView.camera.transform.rotation;
            UnityEngine.Vector3 originalScale = sceneView.camera.transform.localScale;
            float originalNearClip = sceneView.camera.nearClipPlane;

            // Move camera
            sceneView.camera.transform.position = position;
            sceneView.camera.transform.rotation = rotation;
            sceneView.camera.transform.localScale = scale;
            sceneView.camera.nearClipPlane = nearClip;

            // Setup render texture
            RenderTexture rt = new RenderTexture(width, height, 24);
            RenderTexture prev = RenderTexture.active;
            sceneView.camera.targetTexture = rt;
            RenderTexture.active = rt;

            // Render and read
            sceneView.camera.Render();
            Texture2D screenshot = new Texture2D(width, height, TextureFormat.RGB24, false);
            screenshot.ReadPixels(new Rect(0, 0, width, height), 0, 0);
            screenshot.Apply();
        
            // Restore camera
            sceneView.camera.transform.position = originalPos;
            sceneView.camera.transform.rotation = originalRot;
            sceneView.camera.transform.localScale = originalScale;
            sceneView.camera.targetTexture = null;
            sceneView.camera.nearClipPlane = originalNearClip;
            RenderTexture.active = prev;

            // Cleanup
            rt.Release();
            UnityEngine.Object.DestroyImmediate(rt);
            return screenshot;
        }

        public GameObject[] FindObjectsWithName(GameObject parent, string searchTerm)
        {
            if (parent == null)
            {
                List<GameObject> results = new List<GameObject>();
                foreach (GameObject rootObject in UnityEngine.SceneManagement.SceneManager.GetActiveScene()
                    .GetRootGameObjects())
                {
                    results.AddRange(FindObjectsWithName(rootObject, searchTerm));
                }
                return results.ToArray();
            }
            else
            {
                List<GameObject> results = new List<GameObject>();
                if (parent.name.ToLower().Contains(searchTerm))
                {
                    results.Add(parent);
                }
                Transform[] children = parent.GetComponentsInChildren<Transform>(true); // true includes inactive objects
                foreach (Transform child in children)
                {
                    if (child.gameObject.name.ToLower().Contains(searchTerm.ToLower()))
                    {
                        results.Add(child.gameObject);
                    }
                }
                return results.ToArray();
            }
        }

        GameObject FindHeadObject()
        {
            GameObject targetObject =
                parentObject != null
                ? parentObject.gameObject
                : null;
            GameObject[] heads = FindObjectsWithName(targetObject, "head");
            if (heads.Length == 0)
            {
                return null;
            }
            // if multiple heads, look for head that has neck above it
            GameObject head = heads[0];
            if (heads.Length > 0)
            {
                head = heads
                    .Where(g => g.transform.parent.name.ToLower().Contains("neck"))
                    .FirstOrDefault();
            }
            return head;
        }

        Texture2D CaptureViewFromHead(int width, int height, float nearClip, out bool foundHead)
        {
            GameObject headObject = FindHeadObject();
            foundHead = headObject != null;
            if (headObject != null)
            {
                return CaptureFromPosition(
                    headObject.transform.position,
                    headObject.transform.rotation,
                    headObject.transform.lossyScale, 
                    nearClip,
                    width, height);
            }
            // no head found, just do origin
            else
            {
                return CaptureFromPosition(
                    new UnityEngine.Vector3(0,0,0),
                    UnityEngine.Quaternion.identity,
                    new UnityEngine.Vector3(1,1,1),
                    nearClip,
                    width, height);
            }
        }

        void RegisterConverters()
		{
            transferManager.RegisterConverter<SkinnedMeshRenderer>(SkinnedMeshRendererConverter.ConvertSkinnedMeshRenderer);
        }

        bool ranAnyRuns = false;
        bool setupAvatarCreator = true;
        bool setupIK = true;
        bool sendingAvatar = true;

        float nearClip = 0f;
        float prevNearClip = 0f;

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
        private Texture2D headViewTex;
        private bool foundHead = false;

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
        void DrawTextureCenter(Texture2D texture, Rect containerRect)
        {
            float aspectRatio = (float)texture.width / texture.height;
            float width = containerRect.width;
            float height = width / aspectRatio;

            // Adjust if too tall
            if (height > containerRect.height)
            {
                height = containerRect.height;
                width = height * aspectRatio;
            }

            // Calculate centered position
            float x = containerRect.x + (containerRect.width - width) * 0.5f;
            float y = containerRect.y + (containerRect.height - height) * 0.5f;

            Rect drawRect = new Rect(x, y, width, height);
            EditorGUI.DrawPreviewTexture(drawRect, texture);
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
                    Debug.Log(message); 
                });
            }
            // Display the title image at original size and centered
            if (titleTexture != null)
            {
                float imageWidth = titleTexture.width/2;
                float imageHeight = titleTexture.height/2;

                // Calculate centered position
                float xPos = (position.width - imageWidth) * 0.5f;

                // Create rect for the image
                Rect imageRect = new Rect(xPos, 10, imageWidth, imageHeight);

                // Reserve space in the layout
                GUILayoutUtility.GetRect(position.width, imageHeight + 20); // +20 for padding

                // Draw the texture
                GUI.DrawTexture(imageRect, titleTexture, ScaleMode.StretchToFill);
            }

            if (bridgeClient.publisher.NumActiveConnections() > 0 && bridgeClient.subscriber.NumActiveConnections() > 0)
            {
                GUI.color = Color.green;
                GUILayout.Label("Connected to Resonite", customLabelStyle);
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

                if (prevNearClip != nearClip || headViewTex == null
                    || (!foundHead && sendingAvatar)) // this is incase they modify hierarchy to have a head
                {
                    headViewTex = CaptureViewFromHead(256, 128, nearClip, out foundHead);
                    prevNearClip = nearClip;
                }
                GUILayout.Label(foundHead ? "Found head" : "Could not find any object with 'head' in name (not case sensitive)");
                nearClip = EditorGUILayout.Slider("Near clip", nearClip, 0f, 0.5f); // min is 0, max is 1
                GUILayout.Label("Make near clip as small as possible, yet large enough so nothing is in the way");
                // Draw texture
                Rect rect = EditorGUILayout.GetControlRect(false, headViewTex.height);
                DrawTextureCenter(headViewTex, rect);
                GUIStyle centeredStyle = new GUIStyle(GUI.skin.label);
                centeredStyle.alignment = TextAnchor.MiddleCenter;

                GUILayout.Label("View preview", centeredStyle);
                EditorGUI.EndDisabledGroup();
            }
            
            /* for debuggin
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
                    nearClip = nearClip,
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