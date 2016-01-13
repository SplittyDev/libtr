using System;
using System.Runtime.InteropServices;

namespace libtr
{
	/// <summary>
	/// TR2 Rectanglular Face
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 10)]
	public unsafe struct Face4
	{
		/// <summary>
		/// Vertices
		/// </summary>
		[FieldOffset (0)]
		public fixed UInt16 Vertices [4];

		/// <summary>
		/// Texture index
		/// </summary>
		[FieldOffset (8)]
		readonly public UInt16 Texture;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.Face4"/> struct.
		/// </summary>
		/// <param name="vertices">The vertices.</param>
		/// <param name="texture">The texture id.</param>
		public Face4 (UInt16 [] vertices, UInt16 texture) : this () {

			// Check array size
			if (vertices.Length != 4)
				throw new ArgumentException ("Vertex array must contain exactly four elements.", "vertices");

			// Set fields
			Texture = texture;
			fixed (UInt16 *ptr = Vertices) {
				for (var i = 0; i < 4; i++)
					*(ptr + i) = vertices [i];
			}
		}
	}
}

