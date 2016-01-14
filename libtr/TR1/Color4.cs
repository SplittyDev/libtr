using System;
using System.Runtime.InteropServices;

namespace libtr.TR1
{
	/// <summary>
	/// TR1 Color4
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 4)]
	public struct Color4
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
		/// Unused, initialized to 0
		/// </summary>
		[FieldOffset (3)]
		readonly public Byte Unused;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR1.Color4"/> struct.
		/// </summary>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		/// <param name="u">Unused.</param>
		public Color4 (byte r, byte g, byte b, byte u = 0) : this () {
			Red = r;
			Green = g;
			Blue = b;
			Unused = u;
		}
	}
}

