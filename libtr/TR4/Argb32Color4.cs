using System;
using System.Runtime.InteropServices;

namespace libtr.TR4
{
	/* Layout (ARGB MSB-to-LSB):
	* 8-bit transparency
	* 8-bit red channel
	* 8-bit green channel
	* 8-bit blue channel
	*/

	/// <summary>
	/// TR4 Encoded 32-Bit Color with Transparency
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 4)]
	public struct Argb32Color4
	{
		/// <summary>
		/// The value.
		/// </summary>
		[FieldOffset (0)]
		readonly public UInt32 Value;

		/// <summary>
		/// The alpha component
		/// </summary>
		[FieldOffset (0)]
		readonly public Byte A;

		/// <summary>
		/// The red component
		/// </summary>
		[FieldOffset (1)]
		readonly public Byte R;

		/// <summary>
		/// The green component
		/// </summary>
		[FieldOffset (2)]
		readonly public Byte G;

		/// <summary>
		/// The blue component
		/// </summary>
		[FieldOffset (3)]
		readonly public Byte B;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR4.Argb32Color4"/> struct.
		/// </summary>
		/// <param name="value">The value.</param>
		public Argb32Color4 (UInt32 value) : this () {
			Value = value;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR4.Argb32Color4"/> struct.
		/// </summary>
		/// <param name="a">The alpha component.</param>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		public Argb32Color4 (Byte a, Byte r, Byte g, Byte b) : this () {
			A = a;
			R = r;
			G = g;
			B = b;
		}
	}
}

