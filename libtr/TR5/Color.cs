using System;
using System.Runtime.InteropServices;

namespace libtr.TR5
{
	/// <summary>
	/// TR5 Color
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 16)]
	public struct Color
	{
		/// <summary>
		/// Red component [0..255]
		/// </summary>
		[FieldOffset (0)]
		readonly public Single Red;

		/// <summary>
		/// Green component [0..255]
		/// </summary>
		[FieldOffset (4)]
		readonly public Single Green;

		/// <summary>
		/// Blue component [0..255]
		/// </summary>
		[FieldOffset (8)]
		readonly public Single Blue;

		/// <summary>
		/// Filler component
		/// (Usually 0xCDCDCDCD)
		/// </summary>
		[FieldOffset (12)]
		readonly public Single Unused;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR5.Color"/> struct.
		/// </summary>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		public Color (Single r, Single g, Single b, Single filler = 0xCDCDCDCD) : this () {
			Red = r;
			Green = g;
			Blue = b;
			Unused = filler;
		}
	}
}

