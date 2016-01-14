using System;
using System.Runtime.InteropServices;

namespace libtr.TR5
{
	/// <summary>
	/// TR5 Vertex
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 12)]
	public struct Vertex
	{
		/// <summary>
		/// Relative X coordinate
		/// </summary>
		[FieldOffset (0)]
		readonly public Single X;

		/// <summary>
		/// Relative Y coordinate
		/// </summary>
		[FieldOffset (4)]
		readonly public Single Y;

		/// <summary>
		/// Relative Z coordinate
		/// </summary>
		[FieldOffset (8)]
		readonly public Single Z;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR5.Vertex"/> struct.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		public Vertex (Single x, Single y, Single z) : this () {
			X = x;
			Y = y;
			Z = z;
		}
	}
}

