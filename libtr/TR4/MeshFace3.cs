using System;
using System.Runtime.InteropServices;

namespace libtr.TR4
{
	/// <summary>
	/// TR4 Triangular Mesh Face
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 10)]
	public unsafe struct MeshFace3
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
		/// Effects that should be applied to the mesh
		/// Bit 0: Additive alpha blending
		/// Bit 1..7: Strength of environmental mapping
		/// </summary>
		[FieldOffset (8)]
		readonly public UInt16 Effects;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR4.MeshFace3"/> struct.
		/// </summary>
		/// <param name="vertices">The vertices.</param>
		/// <param name="texture">The texture id.</param>
		/// <param name = "effects">The effects.</param>
		public MeshFace3 (UInt16 [] vertices, UInt16 texture, UInt16 effects) : this () {

			// Check array size
			if (vertices.Length != 3)
				throw new ArgumentException ("Vertex array must contain exactly three elements.", "vertices");

			// Set fields
			Texture = texture;
			Effects = effects;
			fixed (UInt16 *ptr = Vertices) {
				for (var i = 0; i < 3; i++)
					*(ptr + i) = vertices [i];
			}
		}
	}
}

