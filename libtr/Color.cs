using System;
using System.Runtime.InteropServices;

namespace libtr
{
	/// <summary>
	/// TR2 Color
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 3)]
	public struct Color
	{
		/// <summary>
		/// Red component [0..255]
		/// </summary>
		[FieldOffset (0)]
		readonly public Byte Red;

		/// <summary>
		/// Green component [0..255]
		/// </summary>
		[FieldOffset (1)]
		readonly public Byte Green;

		/// <summary>
		/// Blue component [0..255]
		/// </summary>
		[FieldOffset (2)]
		readonly public Byte Blue;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.Color"/> struct.
		/// </summary>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		public Color (byte r, byte g, byte b) : this () {
			Red = r;
			Green = g;
			Blue = b;
		}
	}
}

