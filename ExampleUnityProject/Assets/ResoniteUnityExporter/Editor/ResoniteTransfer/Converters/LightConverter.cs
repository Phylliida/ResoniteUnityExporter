

using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace ResoniteUnityExporter.Converters
{
    public class LightConverter
    {
        public static IEnumerator<object> ConvertLight(UnityEngine.Light light, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            Light_U2Res lightData = new Light_U2Res()
            {
                target = objRefID,
                type = Enum.Parse<LightType_U2Res>(Enum.GetName(typeof(LightType), light.type)),
                shape = Enum.Parse<LightShape_U2Res>(Enum.GetName(typeof(LightShape), light.shape)),
                spotAngle = light.spotAngle,
                innerSpotAngle = light.innerSpotAngle,
                color = new Color_U2Res()
                {
                    r = light.color.r,
                    g = light.color.g,
                    b = light.color.b,
                    a = light.color.a
                },
                colorTemperature = light.colorTemperature,
                useColorTemperature = light.useColorTemperature,
                intensity = light.intensity,
                bounceIntensity = light.bounceIntensity,
                useBoundingSphereOverride = light.useBoundingSphereOverride,
                boundingSphereOverride = new Float4_U2Res()
                {
                    x = light.boundingSphereOverride.x,
                    y = light.boundingSphereOverride.y,
                    z = light.boundingSphereOverride.z,
                    w = light.boundingSphereOverride.w
                },
                useViewFrustumForShadowCasterCull = light.useViewFrustumForShadowCasterCull,
                shadowCustomResolution = light.shadowCustomResolution,
                shadowBias = light.shadowBias,
                shadowNormalBias = light.shadowNormalBias,
                shadowNearPlane = light.shadowNearPlane,
                useShadowMatrixOverride = light.useShadowMatrixOverride,
                range = light.range,
                cullingMask = light.cullingMask,
                renderingLayerMask = light.renderingLayerMask,
                lightShadowCasterMode = Enum.Parse<LightShadowCasterMode_U2Res>(Enum.GetName(typeof(LightShadowCasterMode), light.lightShadowCasterMode)),
                shadowRadius = light.shadowRadius,
                shadowAngle = light.shadowAngle,
                shadows = Enum.Parse<LightShadows_U2Res>(Enum.GetName(typeof(LightShadows), light.shadows)),
                shadowStrength = light.shadowStrength,
                shadowResolution = Enum.Parse<LightShadowResolution_U2Res>(Enum.GetName(typeof(LightShadowResolution), light.shadowResolution)),
                layerShadowCullDistances = light.layerShadowCullDistances,
                cookieSize = light.cookieSize,
                renderMode = Enum.Parse<LightRenderMode_U2Res>(Enum.GetName(typeof(LightRenderMode), light.renderMode)),
                areaSize = new Float2_U2Res()
                {
                    x = light.areaSize.x,
                    y = light.areaSize.y,
                },
                lightmapBakeType = (int)light.lightmapBakeType,
                commandBufferCount = light.commandBufferCount,
            };

            if (light.cookie != null && (light.cookie as Texture2D) != null)
            {
                OutputHolder<object> cookieTextureRefIDHolder = new OutputHolder<object>();
                var cookieEn = hierarchy.SendOrGetTexture((light.cookie as Texture2D), cookieTextureRefIDHolder);
                while (cookieEn.MoveNext())
                {
                    yield return null;
                }
                lightData.cookieTexture = (RefID_U2Res)cookieTextureRefIDHolder.value;
            }

            if (light.useShadowMatrixOverride)
            {
                lightData.shadowMatrixOverride = ResoniteTransferUtils.ConvertMatrix4x4(light.shadowMatrixOverride);
            }

            var en = hierarchy.Call<RefID_U2Res, Light_U2Res>("ImportLight", lightData, output);
            while (en.MoveNext())
            {
                yield return null;
            }
        }
    }
}