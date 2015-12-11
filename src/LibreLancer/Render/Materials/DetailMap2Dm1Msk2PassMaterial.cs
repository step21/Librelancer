﻿using System;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using LibreLancer.Vertices;
namespace LibreLancer
{
	public class DetailMap2Dm1Msk2PassMaterial : RenderMaterial
	{
		public Color4 Ac = Color4.White;
		public Color4 Dc = Color4.White;
		public Texture DtSampler;
		public Texture Dm1Sampler;
		public int FlipU;
		public int FlipV;
		public float TileRate;

		public DetailMap2Dm1Msk2PassMaterial ()
		{
		}
		Shader GetShader(IVertexType vertextype)
		{
			if (vertextype.GetType ().Name == "VertexPositionTexture") {
				return ShaderCache.Get (
					"PositionTextureFlip.vs",
					"DetailMap2Dm1Msk2PassMaterial.frag"
				);
			}
			throw new NotImplementedException ();
		}
		public override void Use (IVertexType vertextype, Lighting lights)
		{
			Shader sh = GetShader (vertextype);
			sh.SetMatrix ("World", ref World);
			sh.SetMatrix ("ViewProjection", ref ViewProjection);

			sh.SetColor4 ("Ac", Ac);
			sh.SetColor4 ("Dc", Dc);
			sh.SetFloat ("TileRate", TileRate);
			sh.SetInteger ("FlipU", FlipU);
			sh.SetInteger ("FlipV", FlipV);

			sh.SetInteger ("DtSampler", 0);
			BindTexture (DtSampler, TextureUnit.Texture0);
			sh.SetInteger ("Dm1Sampler", 1);
			BindTexture (Dm1Sampler, TextureUnit.Texture1);

			sh.UseProgram ();
		}
	}
}
