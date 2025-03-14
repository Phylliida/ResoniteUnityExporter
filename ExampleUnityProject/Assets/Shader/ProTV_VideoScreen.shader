Shader "ProTV/VideoScreen" {
	Properties {
		_MainTex ("Emissive (RGB)", 2D) = "black" {}
		_Emission ("Emission Scale", Float) = 1
		_AspectRatio ("Aspect Ratio", Float) = 1.777777
		[Toggle(APPLY_GAMMA)] _ApplyGamma ("Apply Gamma", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Diffuse"
}