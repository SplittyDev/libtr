using System;
using System.Runtime.InteropServices;

namespace libtr
{
	/* Layout (ARGB MSB-to-LSB):
	* 1-bit transparency (0 ::= transparent, 1 ::= opaque) (0x8000) 
	* 5-bit red channel (0x7c00) 
	* 5-bit green channel (0x03e0) 
	* 5-bit blue channel (0x001f)
	*/

	/// <summary>
	/// TR2 Encoded 16-Bit Color with Transparency
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 2)]
	public struct Argb16Color4
	{
		/// <summary>
		/// The value.
		/// </summary>
		[FieldOffset (0)]
		readonly public UInt16 Value;

		/// <summary>
		/// Gets a value indicating whether this <see cref="libtr.Argb16Color4"/> is transparent.
		/// </summary>
		/// <value><c>true</c> if transparent; otherwise, <c>false</c>.</value>
		public bool Transparent { get { return (Value >> 15) == 0; } }

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.Argb16Color4"/> struct.
		/// </summary>
		/// <param name="value">The value.</param>
		public Argb16Color4 (UInt16 value) : this () {
			Value = value;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.Argb16Color4"/> struct.
		/// </summary>
		/// <param name="transparent">Whether or not the tile is transparent.</param>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		public Argb16Color4 (bool transparent, Byte r, Byte g, Byte b) : this () {
			Value = (UInt16) (
			    0x0
			    | (transparent ? 0 : 1) << 15
			    | r.Truncate (3) << 10
			    | g.Truncate (3) << 5
			    | b.Truncate (3)
			);
		}
	}
}

