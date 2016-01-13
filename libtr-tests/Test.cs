﻿using System;
using System.Linq;
using NUnit.Framework;
using libtrx = libtr;
using libtr1 = libtr.TR1;
using libtr2 = libtr.TR2;

namespace libtrtests
{
	[TestFixture]
	public class General
	{
		[TestCase (new UInt16[] { 00001, 00002, 00003, 00004 }, (UInt16) 12345)]
		[TestCase (new UInt16[] { 65535, 65535, 65535, 65535 }, (UInt16) 65432)]
		[TestCase (new UInt16[] { 12345, 23456, 34567, 45678 }, (UInt16) 13243)]
		public void FaceOffsetCalculation (UInt16 [] vertices, UInt16 texture_and_result) {
			var face3 = new libtrx.Face3 (vertices.Take (3).ToArray (), texture_and_result);
			var face4 = new libtrx.Face4 (vertices, texture_and_result);
			Assert.AreEqual (texture_and_result, face3.Texture);
			Assert.AreEqual (texture_and_result, face4.Texture);
		}

		[TestCase (true )]
		[TestCase (false)]
		public void Argb16Color4Transparency (Boolean t) {
			var color = new libtrx.Argb16Color4 (t, 12, 34, 56);
			Assert.That (t == color.Transparent);
		}
	}

	[TestFixture]
	public class TR2
	{
		[TestCase ((UInt16) 0x0010, libtr2.RoomRenderingEffect.Normal)]
		[TestCase ((UInt16) 0x2000, libtr2.RoomRenderingEffect.WaterSurfaceMovement)]
		[TestCase ((UInt16) 0x4000, libtr2.RoomRenderingEffect.UnderwaterLightModulation)]
		[TestCase ((UInt16) 0x8000, libtr2.RoomRenderingEffect.UnknownWaterEffect)]
		public void RoomVertexRenderingEffectUnion (UInt16 value, libtr2.RoomRenderingEffect result) {
			var basevert = new libtrx.Vertex (0, 0, 0);
			var roomvert = new libtr2.RoomVertex (basevert, 0, value, 0);
			Assert.That (roomvert.Attributes == result);
		}
	}
}

