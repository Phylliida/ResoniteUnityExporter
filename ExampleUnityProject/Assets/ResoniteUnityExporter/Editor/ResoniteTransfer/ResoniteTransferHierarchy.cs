using MemoryMappedFileIPC;
using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace ResoniteUnityExporter
{

    public class ObjectHolder
    {
        public ObjectHolder(GameObject gameObject, RefID_U2Res slotRefId)
        {
            this.gameObject = gameObject;
            this.slotRefId = slotRefId;
        }

        public GameObject gameObject;
        public RefID_U2Res slotRefId;
    }
    public class HierarchyLookup
    {
        public RefID_U2Res rootAssetsSlot;
        public RefID_U2Res rootHierarchySlot;
        public RefID_U2Res mainParentSlot;
        public ResoniteBridgeClient bridgeClient;
        public ResoniteTransferManager transferManager;
        List<ObjectHolder> objects = new List<ObjectHolder>();
        Dictionary<string, GameObject> gameObjectLookup;
        Dictionary<string, RefID_U2Res> refIdLookup;
        Dictionary<ulong, GameObject> refIdToGameObject;
        Dictionary<string, RefID_U2Res> assetLookup = new Dictionary<string, RefID_U2Res>();

        public HierarchyLookup(ResoniteTransferManager transferManager, Dictionary<string, GameObject> gameObjectLookup, Dictionary<string, RefID_U2Res> refIdLookup, ResoniteBridgeClient bridgeClient, RefID_U2Res rootAssetsSlot, RefID_U2Res mainParentSlot)
        {
            this.transferManager = transferManager;
            refIdToGameObject = new Dictionary<ulong, GameObject>();
            foreach (KeyValuePair<string, RefID_U2Res> keyRefID in refIdLookup)
            {
                GameObject gameObject = gameObjectLookup[keyRefID.Key];
                RefID_U2Res refId = keyRefID.Value;
                refIdToGameObject[keyRefID.Value.id] = gameObject;
                objects.Add(new ObjectHolder(gameObject, refId));
            }
            this.gameObjectLookup = gameObjectLookup;
            this.refIdLookup = refIdLookup;
            this.bridgeClient = bridgeClient;
            this.rootAssetsSlot = rootAssetsSlot;
            this.mainParentSlot = mainParentSlot;
        }

        public IEnumerable<ObjectHolder> GetObjects()
        {
            foreach (ObjectHolder obj in objects)
            {
                yield return obj;
            }
        }

        public Transform LookupTransform(RefID_U2Res refID)
        {
            return refIdToGameObject[refID.id].transform;
        }

        public Transform LookupTransform(string key)
        {
            return gameObjectLookup[key].transform;
        }

        public RefID_U2Res LookupSlot(string key)
        {
            return refIdLookup[key];
        }

        public RefID_U2Res LookupSlot(Transform transform)
        {
            return refIdLookup[transform.gameObject.GetInstanceID().ToString()];
        }

        public bool TryLookupSlot(Transform transform, out RefID_U2Res slotRefID)
        {
            return refIdLookup.TryGetValue(transform.gameObject.GetInstanceID().ToString(), out slotRefID);
        }

        delegate IEnumerator<object> CreateAssetDelegate();

        IEnumerator<object> CreateAssetIfNotExist(string assetId, CreateAssetDelegate createAsset, OutputHolder<object> output)
        {
            RefID_U2Res outRefId;
            if (!assetLookup.TryGetValue(assetId, out outRefId))
            {
                var en = createAsset();
                while (en.MoveNext())
                {
                    yield return null;
                }
                outRefId = (RefID_U2Res)output.value;
                assetLookup.Add(assetId, outRefId);
            }
            output.value = outRefId;
        }

        public IEnumerator<object> Call<OutType, InType>(string callMethodName, InType input, OutputHolder<object> output)
        {
            var en = Call<OutType, InType>(bridgeClient, callMethodName, input, output);
            while (en.MoveNext())
            {
                yield return en.Current;
            }
        }

        public class RemoteException : Exception
        {
            public string Message;
            public RemoteException(string stackTrace)
            {
                this.Message = stackTrace;
            }
        }

        public static IEnumerator<object> Call<OutType, InType>(ResoniteBridgeClient bridgeClient, string callMethodName, InType input, OutputHolder<object> output)
        {
            bool hasError = false;
            System.Threading.Tasks.TaskCompletionSource<bool> taskCompletionSource = new System.Threading.Tasks.TaskCompletionSource<bool>();
            Task<object> asyncTask = new Task<object>(() =>
            {
                try
                {
                    byte[] messageBytes = SerializationUtils.EncodeObject(input);
                    bridgeClient.SendMessageSync(
                           callMethodName,
                           messageBytes,
                           -1,
                           out byte[] outBytes,
                           out bool isError
                           );
                    if (isError)
                    {
                        hasError = true;
                        return SerializationUtils.DecodeString(outBytes);
                    }
                    return SerializationUtils.DecodeObject<OutType>(outBytes);
                }
                catch (Exception e)
                {
                    hasError = true;
                    return e.ToString();
                }

            });
            asyncTask.Start();
            // we need to poll it so unity doesn't freeze up
            while (!asyncTask.IsCompleted && !asyncTask.IsCanceled && !asyncTask.IsFaulted)
            {
                yield return null;
            }
            var result = asyncTask.Result;
            if (hasError)
            {
                string error = (string)result;
                // don't print disconnect exceptions, just ignore them
                if (!error.Contains("DisconnectException"))
                {
                    Debug.LogError(error);
                }
                else
                {
                    Debug.Log(error);
                }

                throw new RemoteException(error);
            }
            else
            {
                output.value = asyncTask.Result;
            }
        } 

        public IEnumerator<object> SendOrGetMesh(UnityEngine.Mesh mesh, string[] boneNames, OutputHolder<object> output)
        {
            var en = CreateAssetIfNotExist(mesh.GetInstanceID().ToString(), () =>
            {
                return ResoniteTransferMesh.SendMeshToResonite(this, mesh, boneNames, bridgeClient, output);
            }, output);
            while (en.MoveNext())
            {
                yield return null;
            }
        }

        public IEnumerator<object> SendOrGetMaterial(UnityEngine.Material material, OutputHolder<object> output)
        {
            var en = CreateAssetIfNotExist(material.GetInstanceID().ToString(), () =>
            {
                return ResoniteTransferMaterial.SendMaterialToResonite(this, material, bridgeClient, output);
            }, output);
            while (en.MoveNext())
            {
                yield return null;
            }
        }

        public IEnumerator<object> SendOrGetTexture(UnityEngine.Texture2D texture, OutputHolder<object> output)
        {
            var en = CreateAssetIfNotExist(texture.GetInstanceID().ToString(), () =>
            {
                return ResoniteTransferTexture2D.SendTextureToResonite(this, texture, bridgeClient, output);
            }, output);
            while (en.MoveNext())
            {
                yield return null;
            }
        }
    }

    public class ResoniteTransferHierarchy
    {
        public static HierarchyLookup CreateHierarchy(ResoniteTransferManager manager, string hierarchyName, Transform rootTransform, ResoniteBridgeClient bridgeClient)
        {
            // if rootTransform is null, grab all objects in scene
            GameObject[] gameObjects = (rootTransform == null)
                ? UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects()
                // otherwise, just do the given object as root
                : new GameObject[] { rootTransform.gameObject };


            Dictionary<string, GameObject> gameObjectLookup = new Dictionary<string, GameObject>();

            Object_U2Res[] convertedObjects = new Object_U2Res[gameObjects.Length];
            for (int i = 0; i < gameObjects.Length; i++)
            {
                convertedObjects[i] = GameObjectToObject(gameObjects[i], gameObjectLookup);
            }

            ObjectHierarchy_U2Res hierarchyData = new ObjectHierarchy_U2Res()
            {
                hierarchyName = hierarchyName,
                objects = convertedObjects
            };

            byte[] encoded = SerializationUtils.EncodeObject(hierarchyData);


            bridgeClient.SendMessageSync(
                "ImportSlotHierarchy",
                encoded,
                -1,
                out byte[] outBytes,
                out bool isError
                );
            if (isError)
            {
                throw new Exception(SerializationUtils.DecodeString(outBytes));
            }
            ObjectLookups_U2Res lookups = SerializationUtils.DecodeObject<ObjectLookups_U2Res>(outBytes);

            Dictionary<string, RefID_U2Res> refIdLookup = new Dictionary<string, RefID_U2Res>();
            foreach (ObjectLookup_U2Res lookup in lookups.lookups)
            {
                refIdLookup.Add(lookup.uniqueId, lookup.refId);
            }

            HierarchyLookup hierarchyLookup = new HierarchyLookup(manager, gameObjectLookup, refIdLookup, bridgeClient, lookups.rootAssetSlot, lookups.mainParentSlot);

            return hierarchyLookup;
        }

        public static Object_U2Res GameObjectToObject(UnityEngine.GameObject obj, Dictionary<string, GameObject> gameObjectLookup)
        {
            gameObjectLookup[obj.GetInstanceID().ToString()] = obj;
            Object_U2Res[] children = new Object_U2Res[obj.transform.childCount];
            for (int i = 0; i < obj.transform.childCount; i++)
            {
                children[i] = GameObjectToObject(obj.transform.GetChild(i).gameObject, gameObjectLookup);
            }
            Object_U2Res result = new Object_U2Res()
            {
                // note that this is unique during a session, but changes each time you reboot unity
                uniqueId = obj.GetInstanceID().ToString(),
                children = children,
                name = obj.name,
                enabled = obj.activeInHierarchy,
                localPosition = new Float3_U2Res()
                {
                    x = obj.transform.localPosition.x * ResoniteTransferMesh.FIXED_SCALE_FACTOR,
                    y = obj.transform.localPosition.y * ResoniteTransferMesh.FIXED_SCALE_FACTOR,
                    z = obj.transform.localPosition.z * ResoniteTransferMesh.FIXED_SCALE_FACTOR
                },
                localRotation = new Float4_U2Res()
                {
                    x = obj.transform.localRotation.x,
                    y = obj.transform.localRotation.y,
                    z = obj.transform.localRotation.z,
                    w = obj.transform.localRotation.w
                },
                localScale = new Float3_U2Res()
                {
                    x = obj.transform.localScale.x,
                    y = obj.transform.localScale.y,
                    z = obj.transform.localScale.z
                }
            };
            return result;
        }
    }
}
