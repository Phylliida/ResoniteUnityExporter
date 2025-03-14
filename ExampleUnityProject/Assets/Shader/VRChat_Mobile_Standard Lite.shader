Shader "VRChat/Mobile/Standard Lite" {
	Properties {
		_MainTex ("Albedo(RGB)", 2D) = "white" {}
		_Color ("Color", Vector) = (1,1,1,1)
		[NoScaleOffset] _MetallicGlossMap ("Metallic(R) Smoothness(A) Map", 2D) = "white" {}
		[Gamma] _Metallic ("Metallic", Range(0, 1)) = 1
		_Glossiness ("Smoothness", Range(0, 1)) = 1
		_BumpScale ("Scale", Float) = 1
		[NoScaleOffset] _BumpMap ("Normal Map", 2D) = "bump" {}
		[NoScaleOffset] _OcclusionMap ("Occlusion(G)", 2D) = "white" {}
		_OcclusionStrength ("Strength", Range(0, 1)) = 1
		[Toggle(_EMISSION)] _EnableEmission ("Enable Emission", Float) = 0
		[NoScaleOffset] _EmissionMap ("Emission(RGB)", 2D) = "white" {}
		_EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[Enum(UV0,0,UV1,1)] _UVSec ("UV Set for secondary textures", Float) = 0
		[NoScaleOffset] _DetailMask ("Detail Mask(A)", 2D) = "white" {}
		_DetailAlbedoMap ("Detail Albedo x2(RGB)", 2D) = "grey" {}
		_DetailNormalMapScale ("Scale", Float) = 1
		[NoScaleOffset] _DetailNormalMap ("Detail Normal Map", 2D) = "bump" {}
		[ToggleOff] _SpecularHighlights ("Specular Highlights", Float) = 0
		[ToggleOff] _GlossyReflections ("Glossy Reflections", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "VRChat/Mobile/Diffuse"
	//CustomEditor "StandardLiteShaderGUI"
}