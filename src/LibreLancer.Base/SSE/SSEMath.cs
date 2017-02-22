﻿﻿using System;
using System.Security;
using System.Runtime.InteropServices;
namespace LibreLancer {
	static partial class SSEMath {
	#pragma warning disable 414
		[SuppressUnmanagedCodeSecurity]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void MatrixInvertDelegate(ref Matrix4 input, out Matrix4 output);
		[AsmMethod("__MatrixInvert__unix","__MatrixInvert__windows","__MatrixInvert__cdecl")]
		public static MatrixInvertDelegate MatrixInvert;
		static byte[] __MatrixInvert__unix = new byte[] {
		0x55,0x48,0x89,0xe5,0xf3,0x0f,0x7e,0x07,0x66,0x0f,0x16,0x47,0x10,0xf3,0x44,0x0f,0x7e,0x67,0x20,0x66,0x44,0x0f,0x16,0x67,0x30,0x66,0x0f,0x28,0xc8,0x41,0x0f,0xc6,0xcc,0x88,0x0f,0x28,0xd1,0x44,0x0f,0xc6,0xe0,0xdd,0xf3,0x0f,0x7e,0x47,0x08,0x66,0x0f,0x16,0x47,0x18,0xf3,0x44,0x0f,0x7e,0x6f,0x28,0x66,0x44,0x0f,0x16,0x6f,0x38,0x66,0x0f,0x28,0xc8,0x41,0x0f,0xc6,0xcd,0x88,0x44,0x0f,0xc6,0xe8,0xdd,0x44,0x0f,0x28,0xc9,0x45,0x0f,0x59,0xcd,0x45,0x0f,0xc6,0xc9,0xb1,0x41,0x0f,0x28,0xec,0x0f,0x59,0xe9,0x44,0x0f,0x28,0xc1,0x41,0x0f,0x28,0xfc,0x66,0x0f,0xc6,0xff,0x01,0x41,0x0f,0x59,0xfd,0x41,0x0f,0x28,0xc0,0x66,0x0f,0xc6,0xc0,0x01,0x66,0x0f,0x29,0x45,0xf0,0x66,0x0f,0x28,0xf0,0x0f,0x28,0xc2,0x0f,0x28,0xd8,0x41,0x0f,0x59,0xdc,0x0f,0xc6,0xdb,0xb1,0x0f,0x28,0xcb,0x41,0x0f,0x59,0xcd,0x0f,0x29,0x4d,0xe0,0x44,0x0f,0x28,0xd3,0x44,0x0f,0x59,0xd6,0x0f,0x28,0xcb,0x66,0x0f,0xc6,0xc9,0x01,0x41,0x0f,0x59,0xcd,0x0f,0x29,0x4d,0xd0,0x41,0x0f,0x59,0xd8,0x0f,0x28,0xc8,0x41,0x0f,0x59,0xcd,0x0f,0xc6,0xc9,0xb1,0x0f,0x59,0xd6,0x0f,0x59,0xf1,0x0f,0x29,0x75,0xc0,0x41,0x0f,0x28,0xf4,0x0f,0x59,0xf1,0x44,0x0f,0x29,0x45,0xa0,0x44,0x0f,0x59,0xc1,0x44,0x0f,0x29,0x45,0xb0,0x66,0x0f,0xc6,0xc9,0x01,0x41,0x0f,0x59,0xcc,0x0f,0xc6,0xd2,0xb1,0x45,0x0f,0x28,0xfd,0x44,0x0f,0x59,0xfa,0x41,0x0f,0x28,0xe4,0x0f,0x59,0xe2,0x0f,0x29,0x65,0x90,0x66,0x0f,0xc6,0xd2,0x01,0x45,0x0f,0x28,0xc5,0x45,0x0f,0x28,0xdd,0x44,0x0f,0x59,0xea,0x41,0x0f,0x59,0xd4,0x45,0x0f,0x28,0xf4,0x45,0x0f,0x59,0xe1,0x0f,0x28,0xe0,0x41,0x0f,0x59,0xc1,0x66,0x45,0x0f,0xc6,0xc9,0x01,0x45,0x0f,0x59,0xf1,0x45,0x0f,0x5c,0xf4,0x44,0x0f,0x28,0xe4,0x45,0x0f,0x59,0xcc,0x44,0x0f,0x5c,0xc8,0x0f,0xc6,0xed,0xb1,0x44,0x0f,0x59,0xc5,0x45,0x0f,0x58,0xc6,0x41,0x0f,0x28,0xc4,0x0f,0x59,0xc5,0x66,0x0f,0xc6,0xed,0x01,0x44,0x0f,0x59,0xdd,0x45,0x0f,0x5c,0xc3,0x41,0x0f,0x59,0xec,0x0f,0x5c,0xe8,0x0f,0xc6,0xff,0xb1,0x0f,0x28,0x45,0xf0,0x0f,0x59,0xc7,0x41,0x0f,0x58,0xc0,0x0f,0x28,0x65,0xa0,0x0f,0x59,0xe7,0x66,0x0f,0xc6,0xe4,0x01,0x0f,0x5c,0xc4,0x44,0x0f,0x28,0xc0,0x41,0x0f,0x28,0xc4,0x0f,0x59,0xc7,0x66,0x0f,0xc6,0xff,0x01,0x41,0x0f,0x59,0xfc,0x0f,0x5c,0xf8,0x66,0x0f,0xc6,0xff,0x01,0x0f,0x28,0x45,0xe0,0x0f,0x58,0xc7,0x66,0x0f,0xc6,0xed,0x01,0x44,0x0f,0x5c,0xd5,0x0f,0x28,0x6d,0xd0,0x0f,0x5c,0xe8,0x66,0x0f,0xc6,0xdb,0x01,0x44,0x0f,0x5c,0xd3,0x66,0x45,0x0f,0xc6,0xc9,0x01,0x44,0x0f,0x5c,0x4d,0xc0,0x0f,0x58,0xf5,0x66,0x0f,0x28,0x45,0xb0,0x66,0x0f,0xc6,0xc0,0x01,0x41,0x0f,0x58,0xc1,0x0f,0x5c,0xf1,0x44,0x0f,0x58,0xf8,0x44,0x0f,0x5c,0x55,0x90,0x45,0x0f,0x5c,0xfd,0x41,0x0f,0x58,0xd2,0x45,0x0f,0x59,0xe0,0x41,0x0f,0x28,0xc4,0x66,0x0f,0xc6,0xc0,0x01,0x41,0x0f,0x58,0xc4,0xf3,0x0f,0x16,0xc8,0xf3,0x0f,0x58,0xc8,0x0f,0xc6,0xc0,0xb0,0x66,0x0f,0x3a,0x0c,0xc1,0x01,0xf3,0x0f,0x53,0xc0,0x0f,0x28,0xd8,0xf3,0x0f,0x58,0xdb,0xf3,0x0f,0x59,0xc0,0xf3,0x0f,0x59,0xc1,0xf3,0x0f,0x5c,0xd8,0x0f,0xc6,0xdb,0x00,0x44,0x0f,0x59,0xc3,0x44,0x0f,0x11,0x06,0x44,0x0f,0x59,0xfb,0x44,0x0f,0x11,0x7e,0x10,0x0f,0x59,0xf3,0x0f,0x11,0x76,0x20,0x0f,0x59,0xda,0x0f,0x11,0x5e,0x30,0x5d,0xc3,
		};
		static byte[] __MatrixInvert__windows = new byte[] {
		0x55,0x48,0x89,0xe5,0x48,0x81,0xec,0x10,0x01,0x00,0x00,0x44,0x0f,0x29,0x7d,0xf0,0x44,0x0f,0x29,0x75,0xe0,0x44,0x0f,0x29,0x6d,0xd0,0x44,0x0f,0x29,0x65,0xc0,0x44,0x0f,0x29,0x5d,0xb0,0x44,0x0f,0x29,0x55,0xa0,0x44,0x0f,0x29,0x4d,0x90,0x44,0x0f,0x29,0x45,0x80,0x0f,0x29,0xbd,0x70,0xff,0xff,0xff,0x0f,0x29,0xb5,0x60,0xff,0xff,0xff,0xf3,0x0f,0x7e,0x01,0x66,0x0f,0x16,0x41,0x10,0xf3,0x44,0x0f,0x7e,0x61,0x20,0x66,0x44,0x0f,0x16,0x61,0x30,0x66,0x0f,0x28,0xc8,0x41,0x0f,0xc6,0xcc,0x88,0x0f,0x28,0xd1,0x44,0x0f,0xc6,0xe0,0xdd,0xf3,0x0f,0x7e,0x41,0x08,0x66,0x0f,0x16,0x41,0x18,0xf3,0x44,0x0f,0x7e,0x69,0x28,0x66,0x44,0x0f,0x16,0x69,0x38,0x66,0x0f,0x28,0xc8,0x41,0x0f,0xc6,0xcd,0x88,0x44,0x0f,0xc6,0xe8,0xdd,0x44,0x0f,0x28,0xc9,0x45,0x0f,0x59,0xcd,0x45,0x0f,0xc6,0xc9,0xb1,0x41,0x0f,0x28,0xec,0x0f,0x59,0xe9,0x44,0x0f,0x28,0xc1,0x41,0x0f,0x28,0xfc,0x66,0x0f,0xc6,0xff,0x01,0x41,0x0f,0x59,0xfd,0x41,0x0f,0x28,0xc0,0x66,0x0f,0xc6,0xc0,0x01,0x66,0x0f,0x29,0x85,0x50,0xff,0xff,0xff,0x66,0x0f,0x28,0xf0,0x0f,0x28,0xc2,0x0f,0x28,0xd8,0x41,0x0f,0x59,0xdc,0x0f,0xc6,0xdb,0xb1,0x0f,0x28,0xcb,0x41,0x0f,0x59,0xcd,0x0f,0x29,0x8d,0x40,0xff,0xff,0xff,0x44,0x0f,0x28,0xd3,0x44,0x0f,0x59,0xd6,0x0f,0x28,0xcb,0x66,0x0f,0xc6,0xc9,0x01,0x41,0x0f,0x59,0xcd,0x0f,0x29,0x8d,0x30,0xff,0xff,0xff,0x41,0x0f,0x59,0xd8,0x0f,0x28,0xc8,0x41,0x0f,0x59,0xcd,0x0f,0xc6,0xc9,0xb1,0x0f,0x59,0xd6,0x0f,0x59,0xf1,0x0f,0x29,0xb5,0x20,0xff,0xff,0xff,0x41,0x0f,0x28,0xf4,0x0f,0x59,0xf1,0x44,0x0f,0x29,0x85,0x00,0xff,0xff,0xff,0x44,0x0f,0x59,0xc1,0x44,0x0f,0x29,0x85,0x10,0xff,0xff,0xff,0x66,0x0f,0xc6,0xc9,0x01,0x41,0x0f,0x59,0xcc,0x0f,0xc6,0xd2,0xb1,0x45,0x0f,0x28,0xfd,0x44,0x0f,0x59,0xfa,0x41,0x0f,0x28,0xe4,0x0f,0x59,0xe2,0x0f,0x29,0xa5,0xf0,0xfe,0xff,0xff,0x66,0x0f,0xc6,0xd2,0x01,0x45,0x0f,0x28,0xc5,0x45,0x0f,0x28,0xdd,0x44,0x0f,0x59,0xea,0x41,0x0f,0x59,0xd4,0x45,0x0f,0x28,0xf4,0x45,0x0f,0x59,0xe1,0x0f,0x28,0xe0,0x41,0x0f,0x59,0xc1,0x66,0x45,0x0f,0xc6,0xc9,0x01,0x45,0x0f,0x59,0xf1,0x45,0x0f,0x5c,0xf4,0x44,0x0f,0x28,0xe4,0x45,0x0f,0x59,0xcc,0x44,0x0f,0x5c,0xc8,0x0f,0xc6,0xed,0xb1,0x44,0x0f,0x59,0xc5,0x45,0x0f,0x58,0xc6,0x41,0x0f,0x28,0xc4,0x0f,0x59,0xc5,0x66,0x0f,0xc6,0xed,0x01,0x44,0x0f,0x59,0xdd,0x45,0x0f,0x5c,0xc3,0x41,0x0f,0x59,0xec,0x0f,0x5c,0xe8,0x0f,0xc6,0xff,0xb1,0x0f,0x28,0x85,0x50,0xff,0xff,0xff,0x0f,0x59,0xc7,0x41,0x0f,0x58,0xc0,0x0f,0x28,0xa5,0x00,0xff,0xff,0xff,0x0f,0x59,0xe7,0x66,0x0f,0xc6,0xe4,0x01,0x0f,0x5c,0xc4,0x44,0x0f,0x28,0xc0,0x41,0x0f,0x28,0xc4,0x0f,0x59,0xc7,0x66,0x0f,0xc6,0xff,0x01,0x41,0x0f,0x59,0xfc,0x0f,0x5c,0xf8,0x66,0x0f,0xc6,0xff,0x01,0x0f,0x28,0x85,0x40,0xff,0xff,0xff,0x0f,0x58,0xc7,0x66,0x0f,0xc6,0xed,0x01,0x44,0x0f,0x5c,0xd5,0x0f,0x28,0xad,0x30,0xff,0xff,0xff,0x0f,0x5c,0xe8,0x66,0x0f,0xc6,0xdb,0x01,0x44,0x0f,0x5c,0xd3,0x66,0x45,0x0f,0xc6,0xc9,0x01,0x44,0x0f,0x5c,0x8d,0x20,0xff,0xff,0xff,0x0f,0x58,0xf5,0x66,0x0f,0x28,0x85,0x10,0xff,0xff,0xff,0x66,0x0f,0xc6,0xc0,0x01,0x41,0x0f,0x58,0xc1,0x0f,0x5c,0xf1,0x44,0x0f,0x58,0xf8,0x44,0x0f,0x5c,0x95,0xf0,0xfe,0xff,0xff,0x45,0x0f,0x5c,0xfd,0x41,0x0f,0x58,0xd2,0x45,0x0f,0x59,0xe0,0x41,0x0f,0x28,0xc4,0x66,0x0f,0xc6,0xc0,0x01,0x41,0x0f,0x58,0xc4,0xf3,0x0f,0x16,0xc8,0xf3,0x0f,0x58,0xc8,0x0f,0xc6,0xc0,0xb0,0x66,0x0f,0x3a,0x0c,0xc1,0x01,0xf3,0x0f,0x53,0xc0,0x0f,0x28,0xd8,0xf3,0x0f,0x58,0xdb,0xf3,0x0f,0x59,0xc0,0xf3,0x0f,0x59,0xc1,0xf3,0x0f,0x5c,0xd8,0x0f,0xc6,0xdb,0x00,0x44,0x0f,0x59,0xc3,0x44,0x0f,0x11,0x02,0x44,0x0f,0x59,0xfb,0x44,0x0f,0x11,0x7a,0x10,0x0f,0x59,0xf3,0x0f,0x11,0x72,0x20,0x0f,0x59,0xda,0x0f,0x11,0x5a,0x30,0x0f,0x28,0xb5,0x60,0xff,0xff,0xff,0x0f,0x28,0xbd,0x70,0xff,0xff,0xff,0x44,0x0f,0x28,0x45,0x80,0x44,0x0f,0x28,0x4d,0x90,0x44,0x0f,0x28,0x55,0xa0,0x44,0x0f,0x28,0x5d,0xb0,0x44,0x0f,0x28,0x65,0xc0,0x44,0x0f,0x28,0x6d,0xd0,0x44,0x0f,0x28,0x75,0xe0,0x44,0x0f,0x28,0x7d,0xf0,0x48,0x81,0xc4,0x10,0x01,0x00,0x00,0x5d,0xc3,
		};
		static byte[] __MatrixInvert__cdecl = new byte[] {
		0x55,0x89,0xe5,0x81,0xec,0x08,0x01,0x00,0x00,0x8b,0x45,0x08,0xf3,0x0f,0x7e,0x00,0x66,0x0f,0x3a,0x21,0x40,0x10,0x20,0x66,0x0f,0x3a,0x21,0x40,0x14,0x30,0xf3,0x0f,0x7e,0x58,0x20,0x66,0x0f,0x3a,0x21,0x58,0x30,0x20,0x66,0x0f,0x3a,0x21,0x58,0x34,0x30,0x0f,0x28,0xc8,0x0f,0xc6,0xcb,0x88,0x0f,0x29,0x4d,0xc8,0x0f,0x28,0xe1,0x0f,0xc6,0xd8,0xdd,0xf3,0x0f,0x7e,0x40,0x08,0x66,0x0f,0x3a,0x21,0x40,0x18,0x20,0x66,0x0f,0x3a,0x21,0x40,0x1c,0x30,0xf3,0x0f,0x7e,0x48,0x28,0x66,0x0f,0x3a,0x21,0x48,0x38,0x20,0x66,0x0f,0x3a,0x21,0x48,0x3c,0x30,0x0f,0x28,0xe8,0x0f,0xc6,0xe9,0x88,0x0f,0xc6,0xc8,0xdd,0x0f,0x28,0xc5,0x0f,0x59,0xc1,0x0f,0xc6,0xc0,0xb1,0x0f,0x29,0x45,0xe8,0x0f,0x28,0xd3,0x0f,0x59,0xd5,0x0f,0x29,0x55,0xb8,0x0f,0x28,0xf3,0x66,0x0f,0xc6,0xf6,0x01,0x0f,0x59,0xf1,0x0f,0x28,0xc5,0x66,0x0f,0xc6,0xc0,0x01,0x0f,0x28,0xd4,0x0f,0x59,0xe3,0x0f,0xc6,0xe4,0xb1,0x0f,0x28,0xfc,0x0f,0x59,0xf9,0x0f,0x29,0x7d,0xa8,0x0f,0x28,0xfc,0x0f,0x59,0xf8,0x0f,0x29,0x7d,0x98,0x0f,0x28,0xfc,0x66,0x0f,0xc6,0xff,0x01,0x0f,0x59,0xf9,0x0f,0x29,0x7d,0x88,0x0f,0x59,0xe5,0x0f,0x29,0xa5,0x78,0xff,0xff,0xff,0x0f,0x28,0xe2,0x0f,0x59,0xe1,0x0f,0xc6,0xe4,0xb1,0x0f,0x28,0xfa,0x0f,0x59,0xf8,0x0f,0x29,0x45,0xd8,0x0f,0x59,0xc4,0x0f,0x29,0x85,0x68,0xff,0xff,0xff,0x0f,0x28,0xc3,0x0f,0x59,0xc4,0x0f,0x29,0x85,0x58,0xff,0xff,0xff,0x0f,0x29,0xad,0x38,0xff,0xff,0xff,0x0f,0x59,0xec,0x0f,0x29,0xad,0x48,0xff,0xff,0xff,0x66,0x0f,0xc6,0xe4,0x01,0x0f,0x59,0xe3,0x0f,0xc6,0xff,0xb1,0x0f,0x28,0xc1,0x0f,0x59,0xcf,0x0f,0x29,0x8d,0x28,0xff,0xff,0xff,0x0f,0x28,0xcb,0x0f,0x59,0xcf,0x0f,0x29,0x8d,0x18,0xff,0xff,0xff,0x66,0x0f,0xc6,0xff,0x01,0x0f,0x28,0xd0,0x0f,0x29,0x85,0xf8,0xfe,0xff,0xff,0x0f,0x59,0xc7,0x0f,0x29,0x85,0x08,0xff,0xff,0xff,0x0f,0x59,0xfb,0x0f,0x28,0xcb,0x0f,0x28,0x45,0xe8,0x0f,0x59,0xd8,0x0f,0x28,0x6d,0xc8,0x0f,0x59,0xe8,0x66,0x0f,0xc6,0xc0,0x01,0x0f,0x59,0xc8,0x0f,0x5c,0xcb,0x0f,0x28,0x5d,0xc8,0x0f,0x59,0xc3,0x0f,0x5c,0xc5,0x0f,0x29,0x45,0xe8,0x0f,0x28,0x45,0xb8,0x0f,0xc6,0xc0,0xb1,0x0f,0x59,0xd0,0x0f,0x58,0xd1,0x0f,0x28,0xcb,0x0f,0x59,0xc8,0x66,0x0f,0xc6,0xc0,0x01,0x0f,0x28,0xad,0xf8,0xfe,0xff,0xff,0x0f,0x59,0xe8,0x0f,0x5c,0xd5,0x0f,0x59,0xc3,0x0f,0x5c,0xc1,0x0f,0x28,0xc8,0x0f,0xc6,0xf6,0xb1,0x0f,0x28,0x45,0xd8,0x0f,0x59,0xc6,0x0f,0x58,0xc2,0x0f,0x28,0x95,0x38,0xff,0xff,0xff,0x0f,0x59,0xd6,0x66,0x0f,0xc6,0xd2,0x01,0x0f,0x5c,0xc2,0x0f,0x29,0x45,0xd8,0x0f,0x28,0xc3,0x0f,0x59,0xc6,0x66,0x0f,0xc6,0xf6,0x01,0x0f,0x59,0xf3,0x0f,0x5c,0xf0,0x66,0x0f,0xc6,0xf6,0x01,0x0f,0x28,0x45,0xa8,0x0f,0x58,0xc6,0x66,0x0f,0xc6,0xc9,0x01,0x0f,0x28,0x55,0x98,0x0f,0x5c,0xd1,0x0f,0x28,0x6d,0x88,0x0f,0x5c,0xe8,0x66,0x0f,0x28,0x85,0x78,0xff,0xff,0xff,0x66,0x0f,0xc6,0xc0,0x01,0x0f,0x5c,0xd0,0x66,0x0f,0x28,0x4d,0xe8,0x66,0x0f,0xc6,0xc9,0x01,0x0f,0x5c,0x8d,0x68,0xff,0xff,0xff,0x0f,0x28,0xb5,0x58,0xff,0xff,0xff,0x0f,0x58,0xf5,0x66,0x0f,0x28,0x85,0x48,0xff,0xff,0xff,0x66,0x0f,0xc6,0xc0,0x01,0x0f,0x58,0xc1,0x0f,0x5c,0xf4,0x0f,0x28,0x8d,0x28,0xff,0xff,0xff,0x0f,0x58,0xc8,0x0f,0x5c,0x95,0x18,0xff,0xff,0xff,0x0f,0x5c,0x8d,0x08,0xff,0xff,0xff,0x0f,0x28,0xe1,0x0f,0x58,0xfa,0x0f,0x28,0x6d,0xd8,0x0f,0x59,0xdd,0x0f,0x28,0xc3,0x66,0x0f,0xc6,0xc0,0x01,0x0f,0x58,0xc3,0xf3,0x0f,0x16,0xc8,0xf3,0x0f,0x58,0xc8,0x0f,0xc6,0xc0,0xb0,0x66,0x0f,0x3a,0x0c,0xc1,0x01,0xf3,0x0f,0x53,0xc0,0x0f,0x28,0xd0,0xf3,0x0f,0x59,0xc0,0xf3,0x0f,0x59,0xc1,0xf3,0x0f,0x58,0xd2,0xf3,0x0f,0x5c,0xd0,0x8b,0x45,0x0c,0x0f,0xc6,0xd2,0x00,0x0f,0x28,0xc5,0x0f,0x59,0xc2,0x0f,0x11,0x00,0x0f,0x59,0xe2,0x0f,0x11,0x60,0x10,0x0f,0x59,0xf2,0x0f,0x11,0x70,0x20,0x0f,0x59,0xd7,0x0f,0x11,0x50,0x30,0x81,0xc4,0x08,0x01,0x00,0x00,0x5d,0xc3,
		};
		[SuppressUnmanagedCodeSecurity]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void MatrixMultiplyDelegate(ref Matrix4 a, ref Matrix4 b, out Matrix4 output);
		[AsmMethod("__MatrixMultiply__unix","__MatrixMultiply__windows","__MatrixMultiply__cdecl")]
		public static MatrixMultiplyDelegate MatrixMultiply;
		static byte[] __MatrixMultiply__unix = new byte[] {
		0x0f,0x10,0x06,0x0f,0x10,0x4e,0x10,0x0f,0x10,0x56,0x20,0x0f,0x10,0x5e,0x30,0x48,0xc7,0xc0,0x30,0x00,0x00,0x00,0xf3,0x0f,0x10,0x24,0x07,0x0f,0xc6,0xe4,0x00,0x0f,0x59,0xe0,0x0f,0x10,0xec,0xf3,0x0f,0x10,0x64,0x07,0x04,0x0f,0xc6,0xe4,0x00,0x0f,0x59,0xe1,0x0f,0x58,0xec,0xf3,0x0f,0x10,0x64,0x07,0x08,0x0f,0xc6,0xe4,0x00,0x0f,0x59,0xe2,0x0f,0x58,0xec,0xf3,0x0f,0x10,0x64,0x07,0x0c,0x0f,0xc6,0xe4,0x00,0x0f,0x59,0xe3,0x0f,0x58,0xec,0x0f,0x11,0x2c,0x02,0x48,0x83,0xe8,0x10,0x7d,0xb7,0xc3,
		};
		static byte[] __MatrixMultiply__windows = new byte[] {
		0x0f,0x10,0x02,0x0f,0x10,0x4a,0x10,0x0f,0x10,0x52,0x20,0x0f,0x10,0x5a,0x30,0x48,0xc7,0xc0,0x30,0x00,0x00,0x00,0xf3,0x0f,0x10,0x24,0x01,0x0f,0xc6,0xe4,0x00,0x0f,0x59,0xe0,0x0f,0x10,0xec,0xf3,0x0f,0x10,0x64,0x01,0x04,0x0f,0xc6,0xe4,0x00,0x0f,0x59,0xe1,0x0f,0x58,0xec,0xf3,0x0f,0x10,0x64,0x01,0x08,0x0f,0xc6,0xe4,0x00,0x0f,0x59,0xe2,0x0f,0x58,0xec,0xf3,0x0f,0x10,0x64,0x01,0x0c,0x0f,0xc6,0xe4,0x00,0x0f,0x59,0xe3,0x0f,0x58,0xec,0x41,0x0f,0x11,0x2c,0x00,0x48,0x83,0xe8,0x10,0x7d,0xb6,0xc3,
		};
		static byte[] __MatrixMultiply__cdecl = new byte[] {
		0x53,0x8b,0x5c,0x24,0x08,0x8b,0x4c,0x24,0x0c,0x8b,0x54,0x24,0x10,0x0f,0x10,0x01,0x0f,0x10,0x49,0x10,0x0f,0x10,0x51,0x20,0x0f,0x10,0x59,0x30,0xb8,0x30,0x00,0x00,0x00,0xf3,0x0f,0x10,0x24,0x03,0x0f,0xc6,0xe4,0x00,0x0f,0x59,0xe0,0x0f,0x10,0xec,0xf3,0x0f,0x10,0x64,0x03,0x04,0x0f,0xc6,0xe4,0x00,0x0f,0x59,0xe1,0x0f,0x58,0xec,0xf3,0x0f,0x10,0x64,0x03,0x08,0x0f,0xc6,0xe4,0x00,0x0f,0x59,0xe2,0x0f,0x58,0xec,0xf3,0x0f,0x10,0x64,0x03,0x0c,0x0f,0xc6,0xe4,0x00,0x0f,0x59,0xe3,0x0f,0x58,0xec,0x0f,0x11,0x2c,0x02,0x83,0xe8,0x10,0x7d,0xb8,0x5b,0xc3,
		};
	#pragma warning restore 414
	}
}
