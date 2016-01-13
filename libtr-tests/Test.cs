using NUnit.Framework;
using System;
using libtr;
using System.Linq;

namespace libtrtests
{
	[TestFixture]
	public class Test
	{
		[TestCase (new UInt16[] { 00001, 00002, 00003, 00004 }, (UInt16) 12345)]
		[TestCase (new UInt16[] { 65535, 65535, 65535, 65535 }, (UInt16) 65432)]
		[TestCase (new UInt16[] { 12345, 23456, 34567, 45678 }, (UInt16) 13243)]
		public void FaceOffsetCalculation (UInt16 [] vertices, UInt16 texture_and_result) {
			var face3 = new Face3 (vertices.Take (3).ToArray (), texture_and_result);
			var face4 = new Face4 (vertices, texture_and_result);
			Assert.AreEqual (texture_and_result, face3.Texture);
			Assert.AreEqual (texture_and_result, face4.Texture);
		}

		[TestCase (true )]
		[TestCase (false)]
		public void Argb16Color4Transparency (Boolean t) {
			var color = new Argb16Color4 (t, 12, 34, 56);
			Assert.That (t == color.Transparent);
		}
	}
}

