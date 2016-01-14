using System;
using System.Runtime.InteropServices;

namespace libtr.TR4
{
	/// <summary>
	/// TR4 Rectanglular Mesh Face
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 12)]
	public unsafe struct MeshFace4
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
		/// Effects that should be applied to the mesh
		/// Bit 0: Additive alpha blending
		/// Bit 1..7: Strength of environmental mapping
		/// </summary>
		[FieldOffset (10)]
		readonly public UInt16 Effects;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR4.MeshFace4"/> struct.
		/// </summary>
		/// <param name="vertices">The vertices.</param>
		/// <param name="texture">The texture id.</param>
		/// <param name = "effects">The effects.</param>
		public MeshFace4 (UInt16 [] vertices, UInt16 texture, UInt16 effects) : this () {

			// Check array size
			if (vertices.Length != 4)
				throw new ArgumentException ("Vertex array must contain exactly four elements.", "vertices");

			// Set fields
			Texture = texture;
			Effects = effects;
			fixed (UInt16 *ptr = Vertices) {
				for (var i = 0; i < 4; i++)
					*(ptr + i) = vertices [i];
			}
		}
	}
}

