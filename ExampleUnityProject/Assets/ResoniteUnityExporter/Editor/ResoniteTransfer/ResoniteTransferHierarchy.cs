using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public ResoniteBridgeClient bridgeClient;
        List<ObjectHolder> objects = new List<ObjectHolder>();
        Dictionary<string, GameObject> gameObjectLookup;
        Dictionary<string, RefID_U2Res> refIdLookup;
        Dictionary<ulong, GameObject> refIdToGameObject;
        Dictionary<string, RefID_U2Res> assetLookup = new Dictionary<string, RefID_U2Res>();

        public HierarchyLookup(Dictionary<string, GameObject> gameObjectLookup, Dictionary<string, RefID_U2Res> refIdLookup, ResoniteBridgeClient bridgeClient, RefID_U2Res rootAssetsSlot)
        {
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

        delegate RefID_U2Res CreateAssetDelegate();

        RefID_U2Res CreateAssetIfNotExist(string assetId, CreateAssetDelegate createAsset)
        {
            RefID_U2Res outRefId;
            if (!assetLookup.TryGetValue(assetId, out outRefId))
            {
                outRefId = createAsset();
                assetLookup.Add(assetId, outRefId);
            }
            return outRefId;

        }

        public OutType Call<OutType, InType>(string callMethodName, InType input)
        {
            byte[] messageBytes = ResoniteBridgeUtils.EncodeObject(input);
            bridgeClient.SendMessageSync(
                   callMethodName,
                   messageBytes,
                   -1,
                   out byte[] outBytes,
                   out bool isError
                   );

            if (isError)
            {
                throw new Exception(ResoniteBridgeUtils.DecodeString(outBytes));
            }
            return ResoniteBridgeUtils.DecodeObject<OutType>(outBytes);
        } 

        public RefID_U2Res SendOrGetMesh(UnityEngine.Mesh mesh, string[] boneNames)
        {
            return CreateAssetIfNotExist(mesh.GetInstanceID().ToString(), () =>
            {
                return ResoniteTransferMesh.SendMeshToResonite(this, mesh, boneNames, bridgeClient);
            });
        }

        public RefID_U2Res SendOrGetMaterial(UnityEngine.Material material)
        {
            return CreateAssetIfNotExist(material.GetInstanceID().ToString(), () =>
            {
                return ResoniteTransferMaterial.SendMaterialToResonite(this, material, bridgeClient);
            });
        }

        public RefID_U2Res SendOrGetTexture(UnityEngine.Texture2D texture)
        {
            return CreateAssetIfNotExist(texture.GetInstanceID().ToString(), () =>
            {
                return ResoniteTransferTexture2D.SendTextureToResonite(this, texture, bridgeClient);
            });
        }
    }

    public class ResoniteTransferHierarchy
    {
        public static HierarchyLookup CreateHierarchy(string hierarchyName, Transform rootTransform, ResoniteBridgeClient bridgeClient)
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

            byte[] encoded = ResoniteBridgeUtils.EncodeObject(hierarchyData);

            Debug.Log("Encoded:" + encoded.Length + " bytes");

            bridgeClient.SendMessageSync(
                "ImportSlotHierarchy",
                encoded,
                -1,
                out byte[] outBytes,
                out bool isError
                );
            if (isError)
            {
                throw new Exception(ResoniteBridgeUtils.DecodeString(outBytes));
            }
            ObjectLookups_U2Res lookups = ResoniteBridgeUtils.DecodeObject<ObjectLookups_U2Res>(outBytes);

            Dictionary<string, RefID_U2Res> refIdLookup = new Dictionary<string, RefID_U2Res>();
            foreach (ObjectLookup_U2Res lookup in lookups.lookups)
            {
                refIdLookup.Add(lookup.uniqueId, lookup.refId);
            }

            HierarchyLookup hierarchyLookup = new HierarchyLookup(gameObjectLookup, refIdLookup, bridgeClient, lookups.rootAssetSlot);

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
                localPosition = new Float3_U2Res()
                {
                    x = obj.transform.localPosition.x,
                    y = obj.transform.localPosition.y,
                    z = obj.transform.localPosition.z
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
