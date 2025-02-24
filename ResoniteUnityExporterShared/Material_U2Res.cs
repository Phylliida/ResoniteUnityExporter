using System;
using System.Collections.Generic;
using System.Text;

namespace ResoniteUnityExporterShared
{
    public class MaterialNames_U2Res
    {
        public const string XIEXE_TOON_MAT = "XiexeToonMaterial";
        public const string PBS_METALLIC_MAT = "PBS Metallic";
        public const string PBS_SPECULAR_MAT = "PBS Specular";
        public const string UNLIT_MAT = "Unlit";
    }
    public class Material_U2Res
    {
        public RefID_U2Res rootAssetsSlot;
        public string renderingMode;
        public string materialName;

        public string[] floatNames;
        public float[] floatValues;

        public string[] intNames;
        public int[] intValues;

        public string[] float2Names;
        public Float2_U2Res[] float2Values;

        public string[] float3Names;
        public Float3_U2Res[] float3Values;

        public string[] float4Names;
        public Float4_U2Res[] float4Values;

        public string[] colorNames;
        public Color32_U2Res[] colorValues;

        public string[] texture2DNames;
        public RefID_U2Res[] texture2DValues;
    }
}
