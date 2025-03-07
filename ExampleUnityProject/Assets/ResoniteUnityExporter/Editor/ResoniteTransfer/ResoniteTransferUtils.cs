using MemoryMappedFileIPC;
using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
#if RUE_HAS_AVATAR_VRCSDK
using VRC.SDK3.Avatars.Components;
#endif

namespace ResoniteUnityExporter
{
    // Helper class to safely iterate without try-catch in iterator blocks
    public class ExceptionSafeIterator
    {
        private readonly IEnumerator<object> _innerEnumerator;
        public object Current { get; private set; }
        public Exception CaughtException { get; private set; }
        public bool ExceptionOccurred { get; private set; }

        public ExceptionSafeIterator(IEnumerator<object> innerEnumerator)
        {
            _innerEnumerator = innerEnumerator;
            Current = null;
        }

        public bool MoveNext()
        {
            if (ExceptionOccurred)
                return false;

            try
            {
                if (_innerEnumerator.MoveNext())
                {
                    Current = _innerEnumerator.Current;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ExceptionOccurred = true;
                CaughtException = ex;
                return false;
            }
        }
    }

    public static class LinqExtraExtensions
    {
        public static IEnumerable<TSource> Unique<TSource, TKey>(this IEnumerable<TSource> arr, Func<TSource, TKey> keyFunc)
        {
            HashSet<TKey> keys = new HashSet<TKey>();

            return arr.Where(value =>
            {
                TKey key = keyFunc(value);
                if (keys.Contains(key))
                {
                    return false;
                }
                else
                {
                    keys.Add(key);
                    return true;
                }
            });
        }
    }

    public class ResoniteTransferUtils
    {
        public static bool TryGetHeadPosition(Transform parentObject, out bool foundHead, out UnityEngine.Vector3 headPosition, out GameObject headObject)
        {
            headPosition = new UnityEngine.Vector3(0, 0, 0);
            headObject = FindHeadObject(parentObject);
            foundHead = headObject != null;
            if (TryGetAvatarDescriptorPosition(parentObject, out headPosition))
            {
                return true;
                // good, it's assigned
            }
            else
            {
                if (headObject != null)
                {
                    headPosition = headObject.transform.position;
                    return true;
                }
            }
            return false;
        }

        public static GameObject[] FindObjectsWithName(GameObject parent, string searchTerm)
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

        public static GameObject FindHeadObject(Transform parentObject)
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
                if (head == null) // if none have neck just take first
                {
                    head = heads[0];
                }
            }
            return head;
        }


        public static bool IsAvatarsSDKAvailable()
        {
#if RUE_HAS_AVATAR_VRCSDK
            return true;
#else
			return false;
#endif
        }


        public static Component[] GetAvatarDescriptors(Transform parentObject)
        {
#if RUE_HAS_AVATAR_VRCSDK
            GameObject[] gameObjects = (parentObject == null)
             ? UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects()
             // otherwise, just do the given object as root
             : new GameObject[] { parentObject.gameObject };
            var res = gameObjects.SelectMany(go => go.GetComponents(typeof(VRCAvatarDescriptor))).ToArray();
            return res;
#else
            return new Component[] { };
#endif
        }

        public static bool TryGetAvatarDescriptorPosition(Transform parentObject, out UnityEngine.Vector3 pos)
        {
#if RUE_HAS_AVATAR_VRCSDK
            foreach (Component avatarDescriptorComp in GetAvatarDescriptors(parentObject))
            {
                VRCAvatarDescriptor avatarDescriptor = (VRCAvatarDescriptor)avatarDescriptorComp;
                pos = avatarDescriptor.ViewPosition;
                return true;
            }
#endif
            pos = UnityEngine.Vector3.zero;
            return false;
        }

        public class Timer : IDisposable
        {
            string name;
            long startMillis;
            public Timer(string name)
            {
                this.name = name;
                startMillis = System.Diagnostics.Stopwatch.GetTimestamp();
            }

            public void Dispose()
            {
                long elapsedMillis = System.Diagnostics.Stopwatch.GetTimestamp() - startMillis;
            }
        }

        public static Matrix4x4_U2Res ConvertMatrix4x4(UnityEngine.Matrix4x4 mat)
        {
            return new Matrix4x4_U2Res()
            {
                m00 = mat.m00,
                m01 = mat.m01,
                m02 = mat.m02,
                m03 = mat.m03,
                m10 = mat.m10,
                m11 = mat.m11,
                m12 = mat.m12,
                m13 = mat.m13,
                m20 = mat.m20,
                m21 = mat.m21,
                m22 = mat.m22,
                m23 = mat.m23,
                m30 = mat.m30,
                m31 = mat.m31,
                m32 = mat.m32,
                m33 = mat.m33
            };
        }
        public static bool NotEmpty<T>(T[] arr)
        {
            return arr != null && arr.Length > 0;
        }


        public static void CheckAllEqual(object a, object b, string parentPrefix = "", Type type = null)
        {
            string fieldStr = parentPrefix + "." + (type == null ? "" : type.ToString());
            if (a == null || b == null)
            {
                if (a == b)
                {
                    Debug.Log("Matches " + fieldStr + " (both null)");
                }
                else
                {
                    Debug.LogError("Does not match (struct/class) " + fieldStr + " has values " + a + " and " + b);
                }
            }
            else
            {
                if (type == null) // default inits
                {
                    type = a.GetType();
                }
                if (SerializationUtils.primitiveTypes.Contains(type) || type == typeof(System.String))
                {
                    // equality doesn't work because they are boxed, just use to string as good enough
                    if (a.ToString() == b.ToString())
                    {
                        Debug.Log("Matches " + fieldStr + " with values " + a + " " + b);
                    }
                    else
                    {
                        Debug.LogError("Does not match (primitive) " + fieldStr + " has values " + a + " and " + b);
                    }
                }
                else if (type.IsArray)
                {
                    int aLen = (int)a.GetType().GetProperty("Length")
                                    .GetValue(a, new object[] { });
                    int bLen = (int)b.GetType().GetProperty("Length")
                                    .GetValue(b, new object[] { });
                    if (aLen != bLen)
                    {
                        Debug.LogError("Does not match (array length) " + fieldStr + ".Length, has values " + aLen + " and " + bLen);
                    }
                    else
                    {
                        Debug.Log("Array length matches " + fieldStr + ".Length with lengths of " + aLen + " " + bLen);
                        var aGetMethod = a.GetType().GetMethod("GetValue", new Type[] { typeof(int) });
                        var bGetMethod = b.GetType().GetMethod("GetValue", new Type[] { typeof(int) });

                        Type elementType = a.GetType().GetElementType();
                        if (SerializationUtils.TypeRecursivelyHasAllPrimitiveFields(elementType))
                        {
                            object[] args = new object[] { 0 };
                            int numNotMatches = 0;
                            byte[] aByte = SerializationUtils.ToByteArray(a, elementType, aLen);
                            byte[] bByte = SerializationUtils.ToByteArray(b, elementType, bLen);
                            for (int i = 0; i < aByte.Length; i++)
                            {
                                if (aByte[i] != bByte[i])
                                {
                                    numNotMatches += 1;
                                }
                            }
                            if (numNotMatches == 0)
                            {
                                Debug.Log("Array contents match " + fieldStr);
                            }
                            else
                            {
                                Debug.LogError("Array contents do not match " + fieldStr + " there are " + numNotMatches + " mismatched entries");
                            }
                        }
                        else
                        {
                            object[] parms = new object[] { 0 };

                            for (int i = 0; i < aLen; i++)
                            {
                                parms[0] = i;
                                var aVal = aGetMethod.Invoke(a, parms);
                                var bVal = bGetMethod.Invoke(b, parms);
                                CheckAllEqual(aVal, bVal, parentPrefix = parentPrefix + "." + type.ToString() + "[" + i + "]", type = elementType);
                            }
                        }
                    }
                }
                else
                {
                    foreach (FieldInfo field in SerializationUtils.GetTypeFields(a.GetType()))
                    {
                        object valueA = field.GetValue(a);
                        object valueB = field.GetValue(b);
                        CheckAllEqual(valueA, valueB, parentPrefix = parentPrefix + "." + type.ToString(), type = field.FieldType);
                    }
                }
            }
        }
    }
}
