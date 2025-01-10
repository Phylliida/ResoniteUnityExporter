using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ResoniteUnityExporter
{
    public class ResoniteTransferManager
    {

        Dictionary<Type, object> converters = new Dictionary<Type, object>();
        public ResoniteTransferManager()
        {

        }

        static Type ThisStaticType()
        {
            // cursed shit to get typeof(this.GetType()) except for static methods
            return MethodBase.GetCurrentMethod().DeclaringType;
        }

        public void ConvertObjectAndChildren(string hierarchyName, Transform rootTransform, ResoniteBridgeClient bridgeClient)
        {
            HierarchyLookup hierarchy = ResoniteTransferHierarchy.CreateHierarchy(hierarchyName, rootTransform, bridgeClient);
            Dictionary<Type, MethodInfo> methodCache = new Dictionary<Type, MethodInfo>();
            foreach (ObjectHolder obj in hierarchy.GetObjects())
            {
                GameObject gameObject = obj.gameObject;
                RefID_U2Res refID = obj.slotRefId;
                var convertComponentMethod = ThisStaticType().GetMethod("ConvertComponent");
                foreach (UnityEngine.Component component in gameObject.GetComponents<UnityEngine.Component>())
                {
                    MethodInfo convertMethod = null;
                    if (!methodCache.TryGetValue(component.GetType(), out convertMethod))
                    {
                        convertMethod = convertComponentMethod.MakeGenericMethod(component.GetType());
                        methodCache.Add(component.GetType(), convertMethod);
                    }
                    convertMethod.Invoke(this, new object[]
                    {
                        component, hierarchy
                    });
                }
            }
        }

        public void RegisterConverter<T>(Action<T, GameObject, RefID_U2Res, HierarchyLookup> converter) where T : UnityEngine.Component
        {
            converters[typeof(T)] = converter;
        }

        public void ConvertComponent<T>(T component, HierarchyLookup hierarchy) where T : UnityEngine.Component
        {
            GameObject holder = component.transform.gameObject;
            if (converters.TryGetValue(typeof(T), out object converter))
            {
                Action<T, GameObject, RefID_U2Res, HierarchyLookup> convertAction = (Action<T, GameObject, RefID_U2Res, HierarchyLookup>)converter;
                RefID_U2Res holderRefID = hierarchy.LookupSlot(holder.GetInstanceID().ToString());
                convertAction(component, holder, holderRefID, hierarchy);
            }
            else
            {
                Debug.LogWarning("No converters available for type: " + typeof(T) + " on object " + holder.name);
            }
        }

        public void UnregisterConverter<T>(Action<T> converter)
        {
            converters.Remove(typeof(T));
        }
    }
}
