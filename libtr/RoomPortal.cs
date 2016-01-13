using System;
using System.Runtime.InteropServices;

namespace libtr
{
	/// <summary>
	/// TR2 Room Portal
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 32)]
	public unsafe struct RoomPortal
	{
		/// <summary>
		/// The adjoining room
		/// </summary>
		[FieldOffset (0)]
		readonly public UInt16 AdjoiningRoom;

		/// <summary>
		/// The normal vertex
		/// </summary>
		[FieldOffset (2)]
		readonly public Vertex Normal;

		/// <summary>
		/// The vertices
		/// </summary>
		[FieldOffset (8)]
		public fixed Vertex Vertices [4];

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.RoomPortal"/> struct.
		/// </summary>
		/// <param name="adjoiningroom">The id of the adjoining room.</param>
		/// <param name="normal">The normal vertex.</param>
		/// <param name="vertices">The vertices.</param>
		public RoomPortal (UInt16 adjoiningroom, Vertex normal, Vertex [] vertices) : this () {

			// Check array size
			if (vertices.Length != 4)
				throw new ArgumentException ("Vertex array must contain exactly four elements.", "vertices");

			// Set fields
			AdjoiningRoom = adjoiningroom;
			Normal = normal;
			fixed (Vertex *ptr = Vertices) {
				for (var i = 0; i < 4; i++)
					*(ptr + i) = vertices [i];
			}
		}
	}
}

