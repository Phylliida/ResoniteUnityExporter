using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Unity.Mathematics;
using UnityEditor;
using UnityEditor.Graphs;
using UnityEngine;
using static UnityEngine.UIElements.VisualElement;

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
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "";
            ResoniteUnityExporterEditorWindow.DebugProgressString = "Copying hierarchy";
            yield return null;
            hierarchy = ResoniteTransferHierarchy.CreateHierarchy(this, hierarchyName, rootTransform, bridgeClient);
            yield return null;
            Debug.Log("Converted hierarchy"); // finished
            methodCache = new Dictionary<Type, MethodInfo>();
            convertComponentMethod = ThisStaticType().GetMethod("ConvertComponent");
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
                        if (component.GetType() != typeof(UnityEngine.Transform))
                        {
                            var en = LookupComponent(component, new OutputHolder<object>());
                            while (en.MoveNext())
                            {
                                yield return null;
                            }
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
                string packagePath = null;

                while (String.IsNullOrEmpty(packagePath))
                {
                    packagePath = EditorUtility.SaveFilePanel(
                        "Select path to save .resonitepackage",
                        Application.dataPath,
                        hierarchyName,    // default filename
                        "resonitepackage"             // file extension
                    );
                }

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
                Debug.Log("Processing component: " + component);

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
                Debug.LogWarning("No converters available for type: " + typeof(T) + " on object " + holder.name);
                yield return null;
            }
        }

        public void UnregisterConverter<T>(Action<T> converter)
        {
            converters.Remove(typeof(T));
        }
    }
}
