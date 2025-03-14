Shader "ASE/ASE_StandartCutout2Sided" {
	Properties {
		_Cutoff ("Mask Clip Value", Float) = 0.5
		_Albedo ("Albedo", 2D) = "white" {}
		_AlbedoColor ("AlbedoColor", Vector) = (1,1,1,1)
		_EmissionMap ("EmissionMap", 2D) = "white" {}
		_EmissionColor ("EmissionColor", Vector) = (0,0,0,0)
		_EmissionMultiplayer ("EmissionMultiplayer", Float) = 0
		_NormalMap ("NormalMap", 2D) = "bump" {}
		[Toggle] _SmoothFromMapSwitch ("SmoothFromMapSwitch", Float) = 1
		[Toggle] _EmissionSwitch ("EmissionSwitch", Float) = 1
		[Toggle] _SmoothRough ("Smooth/Rough", Float) = 0
		_SmoothnessMap ("SmoothnessMap", 2D) = "white" {}
		_MetallicMap ("MetallicMap", 2D) = "white" {}
		_Snoothness ("Snoothness", Float) = 1
		_Metallic ("Metallic", Float) = 1
		_NormalMapDepth ("NormalMapDepth", Float) = 1
		_TransmisionValue ("TransmisionValue", Float) = 1
		_TransmissionColor ("TransmissionColor", Vector) = (1,1,1,0)
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "Diffuse"
	//CustomEditor "ASEMaterialInspector"
}