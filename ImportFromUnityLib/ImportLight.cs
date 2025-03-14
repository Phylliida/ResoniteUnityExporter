extern alias Froox;

using Froox::Elements.Core;
using Froox::FrooxEngine;
using MemoryMappedFileIPC;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class ImportLight
    {
        public static void ImportLightHelper(byte[] lightBytes, OutputBytesHolder outputBytes)
        {
            Light_U2Res lightData = SerializationUtils.DecodeObject<Light_U2Res>(lightBytes);

            RefID lightRefID = RefID.Null;
            Slot lightSlot = (Slot)ImportFromUnityUtils.LookupRefID(lightData.target);
            if (lightSlot != null)
            {
                Light light = lightSlot.AttachComponent<Light>();
                LightType lightType = LightType.Point;
                switch (lightData.type)
                {
                    case LightType_U2Res.Directional: lightType = LightType.Directional; break;
                    case LightType_U2Res.Point: lightType = LightType.Point; break;
                    case LightType_U2Res.Spot: lightType = LightType.Spot; break;
                    // unsupported
                    case LightType_U2Res.Rectangle: lightType = LightType.Point; break;
                    case LightType_U2Res.Area: lightType = LightType.Point; break;
                    case LightType_U2Res.Disc: lightType = LightType.Point; break;
                }
                if (lightType == LightType.Point)
                {
                    // need to scale up the lights if point light
                    lightSlot.Scale_Field.Value *= new float3(lightData.rescaleFactor, lightData.rescaleFactor, lightData.rescaleFactor);
                }
                light.LightType.Value = lightType;
                // lightData.shape
                light.SpotAngle.Value = lightData.spotAngle;
                // lightData.innerSpotAngle
                light.Color.Value = new colorX(
                    lightData.color.r,
                    lightData.color.g,
                    lightData.color.b,
                    lightData.color.a);
                // lightData.colorTemperature
                // lightData.useColorTemperature
                light.Intensity.Value = lightData.intensity;
                // lightData.bounceIntensity
                // lightData.useBoundingSphereOverride
                // lightData.boundingSphereOverride
                // lightData.useViewFrustumForShadowCasterCull
                // lightData.shadowCustomResolution;
                light.ShadowBias.Value = lightData.shadowBias;
                light.ShadowNormalBias.Value = lightData.shadowNormalBias;
                light.ShadowNearPlane.Value = lightData.shadowNearPlane;
                // lightData.useShadowMatrixOverride
                // lightData.shadowMatrixOverride
                light.Range.Value = lightData.range;
                // lightData.bakingOutput
                // lightData.cullingMask
                // lightData.renderingLayerMask
                // lightData.lightShadowCasterMode
                // lightData.shadowRadius
                // lightData.shadowAngle
                ShadowType shadowType = ShadowType.None;
                switch (lightData.shadows)
                {
                    case LightShadows_U2Res.None: shadowType = ShadowType.None; break;
                    case LightShadows_U2Res.Soft: shadowType = ShadowType.Soft; break;
                    case LightShadows_U2Res.Hard: shadowType = ShadowType.Hard; break;
                }
                light.ShadowType.Value = shadowType;
                light.ShadowStrength.Value = lightData.shadowStrength;
                light.ShadowMapResolution.Value = (int)lightData.shadowResolution;
                // lightData.layerShadowCullDistances
                // lightData.cookieSize
                if (lightData.cookieTexture.id != 0)
                {
                    StaticTexture2D cookieTexture = (StaticTexture2D)ImportFromUnityUtils.LookupRefID(lightData.cookieTexture);
                    if (cookieTexture != null)
                    {
                        light.Cookie.Value = cookieTexture.ReferenceID;
                    }
                }
                // lightData.renderMode
                // lightData.areaSize
                // lightData.lightmapBakeType
                // lightData.commandBufferCount

                lightRefID = light.ReferenceID;
            }

            RefID_U2Res outRefId = new RefID_U2Res()
            {
                id = (ulong)lightRefID
            };

            outputBytes.outputBytes = SerializationUtils.EncodeObject(outRefId);

        }
        public static async Task<byte[]> ImportLightFunc(byte[] lightBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => ImportLightHelper(lightBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }

    }
}
