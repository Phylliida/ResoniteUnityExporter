using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace ResoniteUnityExporter
{

    public class OutputHolder<T>
    {
        public T value;
    }
    public struct ResoniteTransferSettings
    {
        public bool makeAvatar;
        public bool setupAvatarCreator;
        public bool setupIK;
        public bool pressCreateAvatar;
        public bool renameSlots;
        public float nearClip;
        public Dictionary<int, string> materialMappings;
        public bool makePackage;
        public bool includeAssetVariantsInPackage;
    }
    public class ResoniteTransferManager
    {
        Dictionary<Type, object> converters = new Dictionary<Type, object>();
        Dictionary<string, object> componentLookup = new Dictionary<string, object>();
        public ResoniteTransferManager()
        {

        }

        static Type ThisStaticType()
        {
            // cursed shit to get typeof(this.GetType()) except for static methods
            return MethodBase.GetCurrentMethod().DeclaringType;
        }

        Dictionary<Type, MethodInfo> methodCache;
        MethodInfo convertComponentMethod;
        public HierarchyLookup hierarchy;
        public ResoniteTransferSettings settings;
        public Transform rootTransform;

        public IEnumerator ConvertObjectAndChildren(string hierarchyName, Transform rootTransform, ResoniteBridgeClient bridgeClient, ResoniteTransferSettings settings)
        {
            this.settings = settings;
            this.rootTransform = rootTransform;


            bool duplicated = false;
            bool ranPreprocess = false;
            
            // need to run VRChat initializer
#if RUE_HAS_VRCSDK
            if (rootTransform != null && settings.makeAvatar && ResoniteTransferUtils.IsAvatarsSDKAvailable())
            {
                // duplicate it
                Transform prev = rootTransform;
                duplicated = true;
                ranPreprocess = true;
                this.rootTransform = rootTransform = UnityEngine.Object.Instantiate(rootTransform);
                rootTransform.name = prev.name;

                VRC.SDKBase.Editor.BuildPipeline.VRCBuildPipelineCallbacks.OnPreprocessAvatar(rootTransform.gameObject);
#if RUE_HAS_NDMF
                nadena.dev.ndmf.AvatarProcessor.ProcessAvatar(rootTransform.gameObject);
#endif
            }
            else if(!settings.makeAvatar)
            {
                // don't do this
                //VRC.SDKBase.Editor.BuildPipeline.VRCBuildPipelineCallbacks.OnPreprocessScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene());
                //ranPreprocess = true;
            }
#endif

            if (rootTransform != null && settings.makeAvatar && settings.renameSlots)
            {
                Animator rootTransformAnimator = rootTransform.GetComponent<Animator>();
                if (rootTransformAnimator != null)
                {
                    // duplictate it (if we haven't already) and rename bones so they align with Resonite whenever possible
                    if (!duplicated)
                    {
                        Transform prev = rootTransform;
                        rootTransform = UnityEngine.Object.Instantiate(rootTransform);
                        duplicated = true;
                        rootTransform.name = prev.name;
                        this.rootTransform = rootTransform;
                    }
                    ArmatureRenamer.RenameArmature(rootTransform.gameObject, rootTransformAnimator);
                }
            }


            try
            {
                ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "";
                ResoniteUnityExporterEditorWindow.DebugProgressString = "Copying hierarchy";
                yield return null;
                OutputHolder<HierarchyLookup> outputHierarchy = new OutputHolder<HierarchyLookup>();
                var hierarchyEn = ResoniteTransferHierarchy.CreateHierarchy(this, hierarchyName, rootTransform, bridgeClient, outputHierarchy);
                while (hierarchyEn.MoveNext())
                {
                    yield return null;
                }
                hierarchy = outputHierarchy.value;
                yield return null;
                methodCache = new Dictionary<Type, MethodInfo>();
                convertComponentMethod = ThisStaticType().GetMethod("ConvertComponent");
                ResoniteUnityExporterEditorWindow.TotalTransferObjectCount = 0;
                // dry run first to get counts for progress bar
                foreach (ObjectHolder obj in hierarchy.GetObjects())
                {
                    GameObject gameObject = obj.gameObject;
                    RefID_U2Res refID = obj.slotRefId;
                    foreach (UnityEngine.Component component in gameObject.GetComponents<UnityEngine.Component>())
                    {
                        // sometimes it gives null components??
                        if (component != null)
                        {
                            // ignore transform and mesh filters
                            if (component.GetType() != typeof(UnityEngine.Transform) &&
                                component.GetType() != typeof(UnityEngine.MeshFilter) &&
                                CanConvertComponent(component))
                            {
                                 ResoniteUnityExporterEditorWindow.TotalTransferObjectCount += 1;
                            }
                        }
                    }
                }


                ResoniteUnityExporterEditorWindow.CurTransferObjectCount = 0;
                foreach (ObjectHolder obj in hierarchy.GetObjects())
                {
                    GameObject gameObject = obj.gameObject;
                    RefID_U2Res refID = obj.slotRefId;
                    foreach (UnityEngine.Component component in gameObject.GetComponents<UnityEngine.Component>())
                    {
                        // sometimes it gives null components??
                        if (component != null)
                        {
                            // ignore transform
                            if (component.GetType() != typeof(UnityEngine.Transform) &&
                                component.GetType() != typeof(UnityEngine.MeshFilter) && 
                                CanConvertComponent(component))
                            {
                                var en = LookupComponent(component, new OutputHolder<object>());
                                ExceptionSafeIterator iteratorHolder = new ExceptionSafeIterator(en);

                                while (iteratorHolder.MoveNext())
                                {
                                    yield return null;
                                }
                                if (iteratorHolder.ExceptionOccurred)
                                {
                                    Debug.LogError("Got exception processing component: " + component.GetType());
                                    Debug.LogError("Of object: " + obj.gameObject.name + String.Format(" with refid ID{0:X}", refID.id));
                                    List<GameObject> parents = new List<GameObject>();
                                    GameObject curObj = obj.gameObject;
                                    while (curObj != null)
                                    {
                                        parents.Add(curObj);
                                        if (curObj.transform.parent != null)
                                        {
                                            curObj = curObj.transform.parent.gameObject;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    Debug.LogError("Parent chain:\n" + string.Join("\n", parents.Select(x => x.name)));
                                    // this preserves stack trace and lets us catch exception in iterator,
                                    // but lets us do other stuff first
                                    System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((System.Exception)iteratorHolder.CaughtException).Throw();
                                }
                                ResoniteUnityExporterEditorWindow.CurTransferObjectCount += 1;    
                            }
                        }
                    }
                }

                if (settings.pressCreateAvatar && settings.makeAvatar && settings.setupAvatarCreator)
                {
                    ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "";
                    ResoniteUnityExporterEditorWindow.DebugProgressString = "Finalizing Create Avatar";
                    FinalizeAvatarCreator_U2Res finalizeData = new FinalizeAvatarCreator_U2Res()
                    {
                        mainParentSlot = hierarchy.mainParentSlot
                    };
                    OutputHolder<object> output = new OutputHolder<object>();
                    var en = hierarchy.Call<bool, FinalizeAvatarCreator_U2Res>("FinalizeAvatarCreator", finalizeData, output);
                    while (en.MoveNext())
                    {
                        yield return null;
                    }
                }
                if (settings.makePackage)
                {
                    ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "";
                    ResoniteUnityExporterEditorWindow.DebugProgressString = "Making Resonite Package";
                    string packagePath = EditorUtility.SaveFilePanel(
                            "Select path to save .resonitepackage",
                            Application.dataPath,
                            hierarchyName,    // default filename
                            "resonitepackage"             // file extension
                        );

                    if (!String.IsNullOrEmpty(packagePath))
                    {
                        PackageInfo_U2Res packageInfo = new PackageInfo_U2Res()
                        {
                            includeVariants = settings.includeAssetVariantsInPackage,
                            mainParentSlot = hierarchy.mainParentSlot,
                            packagePath = packagePath,
                        };
                        OutputHolder<object> output = new OutputHolder<object>();
                        var en = hierarchy.Call<bool, PackageInfo_U2Res>("MakePackage", packageInfo, output);
                        while (en.MoveNext())
                        {
                            yield return null;
                        }
                    }

                }
            }
            finally
            {
#if RUE_HAS_VRCSDK
                if (ranPreprocess)
                {
                    if (settings.makeAvatar)
                    {
                        VRC.SDKBase.Editor.BuildPipeline.VRCBuildPipelineCallbacks.OnPostprocessAvatar();
#if RUE_HAS_NDMF
                    nadena.dev.ndmf.AvatarProcessor.CleanTemporaryAssets();
#endif
                    }
                    else
                    {

                        VRC.SDKBase.Editor.BuildPipeline.VRCBuildPipelineCallbacks.OnPostprocessScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene());
                    }
                    if (this.rootTransform != null && duplicated)
                    {
                        GameObject.DestroyImmediate(this.rootTransform.gameObject);
                    }
                }
#endif

            }
        }

        public void RegisterConverter<T>(Func<T, GameObject, RefID_U2Res, HierarchyLookup, ResoniteTransferSettings, OutputHolder<object>, IEnumerator<object>> converter) where T : UnityEngine.Component
        {
            converters[typeof(T)] = converter;
        }

        public UnityEngine.Component[] GetComponents(Type type)
        {
            GameObject[] gameObjects = (rootTransform == null)
                ? UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects()
                // otherwise, just do the given object as root
                : new GameObject[] { rootTransform.gameObject };

            return gameObjects.SelectMany(g => g.GetComponentsInChildren(type)).ToArray();

        }

        public T[] GetComponents<T>() where T : UnityEngine.Component
        {
            return GetComponents(typeof(T)).Select(x => { return (T)x; }).ToArray();

        }

        public IEnumerator<object> LookupAllComponentsOfType<T>(OutputHolder<object[]> outputs)
        {
            return LookupAllComponentsOfType(typeof(T), outputs);
        }

        public IEnumerator<object> LookupAllComponentsOfType(Type type, OutputHolder<object[]> outputs)
        {
            List<object> results = new List<object>();
            List<Transform> parentTransforms = new List<Transform>();
            GameObject[] gameObjects = (rootTransform == null)
            ? UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects()
            // otherwise, just do the given object as root
            : new GameObject[] { rootTransform.gameObject };
            foreach (var gameObject in gameObjects)
            {
                foreach (var component in gameObject.GetComponentsInChildren(type))
                {
                    OutputHolder<object> output = new OutputHolder<object>();
                    var enumerator = LookupComponent(component, output);
                    while (enumerator.MoveNext())
                    {
                        yield return null;
                    }
                    results.Add(output.value);
                }
            }

            outputs.value = results.ToArray();
        }

        public bool CanConvertComponent(UnityEngine.Component component)
        {
            return converters.ContainsKey(component.GetType());
        }

        public IEnumerator<object> LookupComponent(UnityEngine.Component component, OutputHolder<object> output)
        {
            if (componentLookup.TryGetValue(component.GetInstanceID().ToString(), out object componentObj))
            {
                output.value = componentObj;
            }
            else
            {
                ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "";
                ResoniteUnityExporterEditorWindow.DebugProgressString = "Converting component: " + component.GetType() + " on object " + component.gameObject.name;
                yield return null;

                MethodInfo convertMethod = null;
                if (!methodCache.TryGetValue(component.GetType(), out convertMethod))
                {
                    convertMethod = convertComponentMethod.MakeGenericMethod(component.GetType());
                    methodCache.Add(component.GetType(), convertMethod);
                }
                IEnumerator en = (IEnumerator)convertMethod.Invoke(this, new object[]
                {
                            component, hierarchy, settings, output
                });
                object result = en.Current;
                while (en.MoveNext())
                {
                    result = en.Current;
                    yield return null;
                }
                componentLookup[component.GetInstanceID().ToString()] = output.value;
                yield return null;
            }
        }

        public IEnumerator<object> ConvertComponent<T>(T component, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> outputHolder) where T : UnityEngine.Component
        {
            GameObject holder = component.transform.gameObject;
            if (converters.TryGetValue(typeof(T), out object converter))
            {
                Func<T, GameObject, RefID_U2Res, HierarchyLookup, ResoniteTransferSettings, OutputHolder<object>, IEnumerator<object>>
                    convertAction = 
                    (Func<T, GameObject, RefID_U2Res, HierarchyLookup, ResoniteTransferSettings, OutputHolder<object>, IEnumerator<object>>)
                    converter;
                RefID_U2Res holderRefID = hierarchy.LookupSlot(holder.GetInstanceID().ToString());
                IEnumerator<object> en = convertAction(component, holder, holderRefID, hierarchy, settings, outputHolder);
                object result = en.Current;
                while (en.MoveNext())
                {
                    result = en.Current;
                    yield return null;
                }
                yield return result;
            }
            else
            {
                Debug.Log("No converters available for type: " + typeof(T) + " on object " + holder.name);
                yield return null;
            }
        }

        public void UnregisterConverter<T>(Action<T> converter)
        {
            converters.Remove(typeof(T));
        }
    }
}
