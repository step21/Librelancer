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
using System.Collections.Generic;
using SharpFont;

namespace LibreLancer
{
	public class Font : IDisposable
	{
		const int TEXTURE_SIZE = 1024;

		List<Texture2D> textures = new List<Texture2D>();
		Dictionary<uint, GlyphInfo> glyphs = new Dictionary<uint, GlyphInfo>();
		int currentX = 0;
		int currentY = 0;
		int lineMax = 0;
		float lineHeight;
		internal Face Face;
		string facename;
		float facesize;
		bool emulate_bold = false;
		bool emulate_italics = false;
		public float LineHeight {
			get {
				return lineHeight;
			}
		}
		public Font (Renderer2D t, string filename, float size, bool bold = false, bool italic = false)
			: this (t, new Face(t.FT, filename), size, bold, italic)
		{
		}

		public static Font FromSystemFont(Renderer2D t, string name, float size, FontStyles styles = FontStyles.Regular)
		{
			FontStyles s = styles;
			var face = Platform.LoadSystemFace(t.FT, name, ref s);
			bool emulate_bold = false;
			bool emulate_italics = false;
			if (s != styles)
			{
				switch (styles)
				{
					case FontStyles.Bold:
						emulate_bold = true;
						break;
					case FontStyles.Italic:
						emulate_italics = true;
						break;
					case FontStyles.Bold | FontStyles.Italic:
						emulate_bold = s != FontStyles.Bold;
						emulate_italics = s != FontStyles.Italic;
						break;
				}
			}
			return new Font(t, face, size, emulate_bold, emulate_italics);
		}

		private Font(Renderer2D t, Face f, float sz, bool bold, bool italic)
		{
			emulate_bold = bold;
			emulate_italics = italic;
			this.Face = f;
			f.SetCharSize (0, sz, 0, 96);
			lineHeight = (float)Face.Size.Metrics.Height;
			textures.Add (new Texture2D (
				TEXTURE_SIZE,
				TEXTURE_SIZE,
				false,
				SurfaceFormat.R8
			));
			facename = Face.FamilyName;
			facesize = sz;
			//Generate standard ASCII
			for (int i = 32; i < 127; i++) {
				AddCharacter ((uint)i);
			}
		}

		internal GlyphInfo GetGlyph(uint codepoint)
		{
			if (!glyphs.ContainsKey (codepoint))
				AddCharacter (codepoint);
			return glyphs [codepoint];
		}

		unsafe void AddCharacter(uint cp)
		{
			if (cp == (uint)'\t') {
				var spaceGlyph = GetGlyph ((uint)' ');
				glyphs.Add (cp, new GlyphInfo (spaceGlyph.AdvanceX * 4, spaceGlyph.AdvanceY, spaceGlyph.CharIndex, spaceGlyph.Kerning));
			}
			uint index = Face.GetCharIndex (cp);

			if (index == 0) {
				//Glyph does not exist in font
				if (cp == (uint)'?')
					throw new Exception ("Font does not have required ASCII character '?'");
				var qmGlyph = GetGlyph ((uint)'?');
				glyphs.Add (cp, qmGlyph);
				return;
			}
			Face.LoadGlyph (index, LoadFlags.Default | LoadFlags.ForceAutohint, LoadTarget.Normal);
			if (emulate_bold) {
				//Automatically determine a strength
				var strength = (Face.UnitsPerEM * Face.Size.Metrics.ScaleY.Value) / 0x10000;
				strength /= 24;
				Face.Glyph.Outline.Embolden(Fixed26Dot6.FromRawValue(strength));
			}
			if (emulate_italics) {
				Face.Glyph.Outline.Transform(new FTMatrix(0x10000, 0x0366A, 0x00000, 0x10000));
			}
			Face.Glyph.RenderGlyph (RenderMode.Normal);
			if (Face.Glyph.Bitmap.Width == 0 || Face.Glyph.Bitmap.Rows == 0) {
				glyphs.Add (cp,
					new GlyphInfo (
						(int)Math.Ceiling((float)Face.Glyph.Advance.X),
						(int)Math.Ceiling((float)Face.Glyph.Advance.Y),
						index,
						Face.HasKerning
					)
				);
			} else {
				if (Face.Glyph.Bitmap.PixelMode != PixelMode.Gray)
					throw new NotImplementedException ();
				if (currentX + Face.Glyph.Bitmap.Width > TEXTURE_SIZE) {
					currentX = 0;
					currentY += lineMax;
					lineMax = 0;
				}
				if (currentY + Face.Glyph.Bitmap.Rows > TEXTURE_SIZE) {
					currentX = 0;
					currentY = 0;
					lineMax = 0;
					textures.Add (new Texture2D (
						TEXTURE_SIZE,
						TEXTURE_SIZE,
						false,
						SurfaceFormat.R8
					));
					FLLog.Debug ("Text", string.Format ("{0}@{1}, New Texture", facename, facesize));
				}
				lineMax = (int)Math.Max (lineMax, Face.Glyph.Bitmap.Rows);
				var rect = new Rectangle (
					           currentX,
					           currentY,
					           Face.Glyph.Bitmap.Width,
					           Face.Glyph.Bitmap.Rows
				           );
				var tex = textures [textures.Count - 1];
				GL.PixelStorei (GL.GL_UNPACK_ALIGNMENT, 1);
				tex.SetData (0, rect, Face.Glyph.Bitmap.Buffer);
				GL.PixelStorei (GL.GL_UNPACK_ALIGNMENT, 4);
				currentX += Face.Glyph.Bitmap.Width;
				//tex.SetData (0, rect, Face.Glyph.Bitmap.Buffer,0, Face.Glyph.Bitmap.Width * Face.Glyph.Bitmap.Rows);
				glyphs.Add (
					cp,
					new GlyphInfo (
						tex,
						rect,
						(int)Math.Ceiling((float)Face.Glyph.Advance.X),
						(int)Math.Ceiling((float)Face.Glyph.Advance.Y),
						(int)Math.Ceiling((float)Face.Glyph.Metrics.HorizontalAdvance),
						Face.Glyph.BitmapLeft,
						Face.Glyph.BitmapTop,
						index,
						Face.HasKerning
					)
				);
			}
		}
		public void Dispose()
		{
			Face.Dispose ();
			foreach (var tex in textures)
				tex.Dispose ();
		}
	}
}

