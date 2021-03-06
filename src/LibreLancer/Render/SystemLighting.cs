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
 * Portions created by the Initial Developer are Copyright (C) 2013-2017
 * the Initial Developer. All Rights Reserved.
 */
using System;
using System.Collections.Generic;
namespace LibreLancer
{
	public class SystemLighting
	{
		public Color4 Ambient = Color4.Black;
		public List<DynamicLight> Lights = new List<DynamicLight>();
		public FogModes FogMode = FogModes.None;
		public float FogDensity = 0f;
		public Color4 FogColor = Color4.Black;
		public Vector2 FogRange = Vector2.Zero;
	}
}
