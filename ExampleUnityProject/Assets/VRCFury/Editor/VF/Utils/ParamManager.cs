using System;
using System.Collections.Generic;
using System.Linq;
using VF.Inspector;
using VRC.SDK3.Avatars.ScriptableObjects;

namespace VF.Utils {

    internal class ParamManager {
        private readonly VRCExpressionParameters syncedParams;

        public ParamManager(VRCExpressionParameters syncedParams) {
            this.syncedParams = syncedParams;
            
            // Remove duplicates
            var seenNames = new HashSet<string>();
            syncedParams.parameters = syncedParams.parameters.Where(p => {
                var seen = seenNames.Contains(p.name);
                seenNames.Add(p.name);
                return !seen;
            }).ToArray();
        }

        public void AddSyncedParam(VRCExpressionParameters.Parameter param) {
            var exists = GetParam(param.name);
            if (exists != null) {
                if (param.valueType != exists.valueType) {
                    throw new Exception(
                        $"VRCF tried to create synced parameter {param.name} with type {param.valueType}," +
                        $" but parameter already exists with type {exists.valueType}");
                }
                return;
            }
            var syncedParamsList = new List<VRCExpressionParameters.Parameter>(syncedParams.parameters);
            syncedParamsList.Add(param);
            syncedParams.parameters = syncedParamsList.ToArray();
            VRCFuryEditorUtils.MarkDirty(syncedParams);
        }

        public VRCExpressionParameters.Parameter GetParam(string name) {
            return syncedParams.parameters.FirstOrDefault(p => p.name == name);
        }

        public VRCExpressionParameters GetRaw() {
            return syncedParams;
        }
    }

}
