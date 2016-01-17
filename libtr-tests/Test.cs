using System;
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

		[TestCase (false, (Byte) 000, (Byte) 000, (Byte) 000)]
		[TestCase (false, (Byte) 123, (Byte) 123, (Byte) 123)]
		[TestCase (false, (Byte) 255, (Byte) 255, (Byte) 255)]
		[TestCase (true , (Byte) 000, (Byte) 000, (Byte) 000)]
		[TestCase (true , (Byte) 123, (Byte) 123, (Byte) 123)]
		[TestCase (true , (Byte) 255, (Byte) 255, (Byte) 255)]
		public void Argb16Color4 (Boolean t, Byte r, Byte g, Byte b) {
			var color = new libtrx.Argb16Color4 (t, r, g, b);
			Console.WriteLine ("R: {0}/{1}", color.R, r);
			Console.WriteLine ("G: {0}/{1}", color.G, g);
			Console.WriteLine ("B: {0}/{1}", color.B, b);
			Assert.That (t == color.Transparent, "Transparency check failed");
			Assert.That (Math.Abs (r - color.R) <= 7, string.Format ("R check failed: Error was {0}", r - color.R));
			Assert.That (Math.Abs (g - color.G) <= 7, "G check failed");
			Assert.That (Math.Abs (b - color.B) <= 7, "B check failed");
		}
	}

	[TestFixture]
	public class TR2
	{
		[TestCase ((UInt16) 0x0010, libtr2.RoomRenderingEffect.Normal)]
		[TestCase ((UInt16) 0x2000, libtr2.RoomRenderingEffect.WaterSurfaceMovement)]
		[TestCase ((UInt16) 0x4000, libtr2.RoomRenderingEffect.UnderwaterLightModulation)]
		[TestCase ((UInt16) 0x8000, libtr2.RoomRenderingEffect.UnknownWaterEffect)]
		public void RoomVertexRenderingEffect (UInt16 value, libtr2.RoomRenderingEffect result) {
			var basevert = new libtr1.Vertex (0, 0, 0);
			var roomvert = new libtr2.RoomVertex (basevert, 0, value, 0);
			Assert.That (roomvert.Attributes == result);
		}
	}
}

