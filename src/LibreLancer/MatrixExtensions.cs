﻿using System;
using OpenTK;
namespace LibreLancer
{
	public static class MatrixExtensions
	{
		public static Vector3 Transform(this Matrix4 mat, Vector3 toTransform)
		{
			return Vector3.Transform (toTransform, mat);
		}
	}
}
