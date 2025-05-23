using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Animations;
using VF.Injector;

namespace VF.Service {
    [VFService]
    internal class LayerSourceService {
        [VFAutowired] private readonly GlobalsService globals;
        
        public const string AvatarDescriptorSource = "VRC Avatar Descriptor";
        public const string VrcDefaultSource = "VRC Default";

        private readonly Dictionary<AnimatorStateMachine, string> sources = new Dictionary<AnimatorStateMachine, string>();

        public void SetSource(AnimatorStateMachine sm, string source) {
            sources[sm] = source;
        }
        
        public void SetSourceToCurrent(AnimatorStateMachine sm) {
            SetSource(sm, globals.currentFeatureNameProvider());
        }

        public void CopySource(AnimatorStateMachine from, AnimatorStateMachine to) {
            if (sources.TryGetValue(from, out var source)) {
                sources[to] = source;
            }
        }

        [CanBeNull]
        public string GetSource(AnimatorStateMachine sm) {
            return sources.TryGetValue(sm, out var source) ? source : null;
        }
    }
}
