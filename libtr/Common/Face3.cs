using System;
using System.Runtime.InteropServices;

namespace libtr
{
	/// <summary>
	/// TR Triangular Face
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 8)]
	public unsafe struct Face3
	{
		/// <summary>
		/// Vertices
		/// </summary>
		[FieldOffset (0)]
		public fixed UInt16 Vertices [3];

		/// <summary>
		/// Texture index
		/// </summary>
		[FieldOffset (6)]
		readonly public UInt16 Texture;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.Face3"/> struct.
		/// </summary>
		/// <param name="vertices">The vertices.</param>
		/// <param name="texture">The texture id.</param>
		public Face3 (UInt16 [] vertices, UInt16 texture) : this () {

			// Check array size
			if (vertices.Length != 3)
				throw new ArgumentException ("Vertex array must contain exactly three elements.", "vertices");

			// Set fields
			Texture = texture;
			fixed (UInt16 *ptr = Vertices) {
				for (var i = 0; i < 3; i++)
					*(ptr + i) = vertices [i];
			}
		}
	}
}

