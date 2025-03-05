using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{

    public enum LightType_U2Res
    {
        Spot = 0,
        Directional = 1,
        Point = 2,
        Area = 3,
        Rectangle = 4,
        Disc = 5
    }

    public enum LightShape_U2Res
    {
        Cone = 0,
        Pyramid = 1,
        Box = 2
    }

    public enum LightShadowCasterMode_U2Res
    {
        // from unity:
        //
        // Summary:
        //     Use the global Shadowmask Mode from the quality settings.
        Default = 0,
        //
        // Summary:
        //     Render only non-lightmapped objects into the shadow map. This corresponds with
        //     the Shadowmask mode.
        NonLightmappedOnly = 1,
        //
        // Summary:
        //     Render all shadow casters into the shadow map. This corresponds with the distance
        //     Shadowmask mode.
        Everything = 2
    }

    public enum LightShadows_U2Res
    {
        // from unity
        //
        // Summary:
        //     Do not cast shadows (default).
        None = 0,
        //
        // Summary:
        //     Cast "hard" shadows (with no shadow filtering).
        Hard = 1,
        //
        // Summary:
        //     Cast "soft" shadows (with 4x PCF filtering).
        Soft = 2
    }


    public enum LightShadowResolution_U2Res
    {
        FromQualitySettings = -1,
        Low = 0,
        Medium = 1,
        High = 2,
        VeryHigh = 3
    }

    public enum LightRenderMode_U2Res
    {
        //
        // Summary:
        //     Automatically choose the render mode.
        Auto=0,
        //
        // Summary:
        //     Force the Light to be a pixel light.
        ForcePixel=1,
        //
        // Summary:
        //     Force the Light to be a vertex light.
        ForceVertex=2
    }

    [Flags]
    public enum LightmapBakeType_U2Res
    {
        //
        // Summary:
        //     Real-time lights cast run time light and shadows. They can change position, orientation,
        //     color, brightness, and many other properties at run time. No lighting gets baked
        //     into lightmaps or light probes..
        Realtime = 4,
        //
        // Summary:
        //     Baked lights cannot move or change in any way during run time. All lighting for
        //     static objects gets baked into lightmaps. Lighting and shadows for dynamic objects
        //     gets baked into Light Probes.
        Baked = 2,
        //
        // Summary:
        //     Mixed lights allow a mix of real-time and baked lighting, based on the Mixed
        //     Lighting Mode used. These lights cannot move, but can change color and intensity
        //     at run time. Changes to color and intensity only affect direct lighting as indirect
        //     lighting gets baked. If using Subtractive mode, changes to color or intensity
        //     are not calculated at run time on static objects.
        Mixed = 1
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Light_U2Res
    {
        public RefID_U2Res target;
        public LightType_U2Res type;
        public LightShape_U2Res shape;
        public float spotAngle;
        public float innerSpotAngle;
        public Color_U2Res color;
        public float colorTemperature;
        public bool useColorTemperature;
        public float intensity;
        public float bounceIntensity;
        public bool useBoundingSphereOverride;
        public Float4_U2Res boundingSphereOverride;
        public bool useViewFrustumForShadowCasterCull;
        public int shadowCustomResolution;
        public float shadowBias;
        public float shadowNormalBias;
        public float shadowNearPlane;
        public bool useShadowMatrixOverride;
        public Matrix4x4_U2Res shadowMatrixOverride;
        public float range;
        //public LightBakingOutput bakingOutput;
        public int cullingMask;
        public int renderingLayerMask;
        public LightShadowCasterMode_U2Res lightShadowCasterMode;
        public float shadowRadius;
        public float shadowAngle;
        public LightShadows_U2Res shadows;
        public float shadowStrength;
        public LightShadowResolution_U2Res shadowResolution;
        public float[] layerShadowCullDistances;
        public float cookieSize;
        public RefID_U2Res cookieTexture;
        public LightRenderMode_U2Res renderMode;
        public Float2_U2Res areaSize;
        public int lightmapBakeType;
        public int commandBufferCount;
        // public float shadowConstantBias;
        // public float shadowObjectSizeBias;
        // public bool attenuate;
        // public LightmappingMode lightmappingMode;

    }
}
