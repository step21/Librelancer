﻿/* The contents of this file are subject to the Mozilla Public License
 * Version 1.1 (the "License"); you may not use this file except in
 * compliance with the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 * 
 * Software distributed under the License is distributed on an "AS IS"
 * basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
 * License for the specific language governing rights and limitations
 * under the License.
 * 
 * 
 * The Initial Developer of the Original Code is Callum McGing (mailto:callum.mcging@gmail.com).
 * Portions created by the Initial Developer are Copyright (C) 2013-2016
 * the Initial Developer. All Rights Reserved.
 */
using System;
using LibreLancer.Vertices;
using LibreLancer.Utf.Mat;
namespace LibreLancer
{
	public class AtmosphereMaterial : RenderMaterial
	{
		public Color4 Ac = Color4.White;
		public Color4 Dc = Color4.White;
		public string DtSampler;
		public SamplerFlags DtFlags;
		public Vector3 CameraPosition;
		public float Alpha;
		public float Fade;
		public float Scale;

		ShaderVariables GetShader(IVertexType vertextype)
		{
			switch (vertextype.GetType ().Name) {
			case "VertexPositionNormalTexture":
				return ShaderCache.Get (
					"Atmosphere.vs",
					"AtmosphereMaterial_PositionTexture.frag"
				);
			default:
				throw new NotImplementedException ();
			}
		}

		public override void Use (RenderState rstate, IVertexType vertextype, Lighting lights)
		{
			/*rstate.DepthEnabled = true;
			rstate.BlendMode = BlendMode.Normal;
			var sh = GetShader (vertextype);
			//mat4x4 normalMatrix = transpose(inverse(View * World));

			sh.SetAc(Ac);
			sh.SetDc(Dc);
			sh.SetVector3 ("CameraPosition", CameraPosition);
			sh.SetFloat ("Alpha", Alpha);
			sh.SetFloat ("Fade", Fade);
			sh.SetFloat ("Scale", Scale);
			sh.SetWorld(ref World);
			sh.SetMatrix ("ViewProjection", ref ViewProjection);
			sh.SetMatrix("View", ref View);
			//BindTexture (DtSampler, 0, DtFlags);
			var normalmat = View * World;
			normalmat.Invert();
			normalmat.Normalize();
			sh.SetMatrix("NormalMatrix", ref normalmat);
			sh.UseProgram ();*/
		}
		public override bool IsTransparent
		{
			get
			{
				return true;
			}
		}
	}
}

