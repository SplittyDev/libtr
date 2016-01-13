using System;
using System.Runtime.InteropServices;

namespace libtr
{
	[StructLayout (LayoutKind.Explicit, Size = 6)]
	public struct Vertex
	{
		/// <summary>
		/// Relative X coordinate
		/// </summary>
		[FieldOffset (0)]
		readonly public Int16 X;

		/// <summary>
		/// Relative Y coordinate
		/// </summary>
		[FieldOffset (2)]
		readonly public Int16 Y;

		/// <summary>
		/// Relative Z coordinate
		/// </summary>
		[FieldOffset (4)]
		readonly public Int16 Z;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.Vertex"/> struct.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		public Vertex (Int16 x, Int16 y, Int16 z) : this () {
			X = x;
			Y = y;
			Z = z;
		}
	}
}

