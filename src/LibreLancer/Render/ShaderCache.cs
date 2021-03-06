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
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibreLancer
{
    static class ShaderCache
    {
        static Dictionary<Strings2, ShaderVariables> shaders = new Dictionary<Strings2, ShaderVariables>();
        public static ShaderVariables Get(string vs, string fs)
		{
			var k = new Strings2 (vs, fs);
            ShaderVariables sh;
			if (!shaders.TryGetValue(k, out sh)) {
				FLLog.Debug ("Shader", "Compiling [ " + vs + " , " + fs + " ]");
                sh = new ShaderVariables(
					new Shader(LoadEmbedded("LibreLancer.Shaders." + vs), ProcessIncludes(LoadEmbedded("LibreLancer.Shaders." + fs)))
                );
                shaders.Add(k, sh);
			}
            return sh;
		}
        //includes in form '#pragma include (file.inc)'
        static string ProcessIncludes(string src)
		{
			Regex findincludes = new Regex(@"^\s*#\s*pragma include\s+[<\(]([^>\)]*)[>\)]\s*", RegexOptions.Multiline);
			var m = findincludes.Match(src);
			string newsrc = src;
			while (m.Success)
			{
				var inc = ProcessIncludes(LoadEmbedded("LibreLancer.Shaders." + m.Groups[1].Value)) + "\n";
				newsrc = newsrc.Remove(m.Index, m.Length).Insert(m.Index, inc);
				m = findincludes.Match(newsrc);
			}
			return newsrc;
		}
        static string LoadEmbedded(string name)
        {
            using(var stream = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(name)))
            {
                return stream.ReadToEnd();
            }
        }
        #region Custom Dictionary Key Structs
        struct Strings2
        {
            public string A;
            public string B;
            public Strings2(string a, string b)
            {
                A = a;
                B = b;
            }
            public override bool Equals(object obj)
            {
                if (!(obj is Strings2))
                    return false;
                var other = (Strings2)obj;
                return other.A == A && other.B == B;
            }
            public override int GetHashCode()
            {
                int hash = 17;
                unchecked
                {
                    hash = hash * 23 + A.GetHashCode();
                    hash = hash * 23 + B.GetHashCode();
                }
                return hash;
            }
        }
        #endregion
    }
}
