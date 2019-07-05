Shader "Unlit/HopeLight_Shader"
{
    Properties
    {
        _MainTex ("Lid background", 2D) = "white" {}
		_PlayerPos("Player Position",vector)=(0,0,0,0)
		_HopeRadius("Hope Light Radius", range(0,1000))= 1
		_HopeEgde("sharpness of Hope Light", range(0,5))= 3
		_Darkness(" background outside hope light", 2D) = "white" {}
			//_Darkness("Color outside hope light", Color) = (0,0,0,0)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM

	        #pragma vertex vert
            #pragma fragment frag
            

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
				
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
				float3 worldPos : TEXCOORD1;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
			float4 _PlayerPos;
			uniform float _HopeRadius;
			float _HopeEgde;
			sampler2D _Darkness;
			float4 _Darkness_ST;

            v2f vert (appdata v)
            {
				v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);

				o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                
				fixed4 col = 0;//
				col = tex2D(_Darkness, i.uv); // Outside color is set to this color;
				float dist = distance(i.worldPos, _PlayerPos.xyz);

				// Texture of lid area  
				if (dist < _HopeRadius) {
					col = tex2D(_MainTex, i.uv);
				}
				else if (dist > _HopeRadius && dist < _HopeRadius + _HopeEgde) {
					float blendEgde = dist - _HopeRadius;
					col = lerp(tex2D(_MainTex, i.uv), tex2D(_Darkness, i.uv), blendEgde / _HopeEgde);
				}



                return col; 
            }
            ENDCG
        }
    }
		
}
