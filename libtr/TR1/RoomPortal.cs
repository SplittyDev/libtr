using System;
using System.Runtime.InteropServices;

namespace libtr.TR1
{
	/// <summary>
	/// TR1 Room Portal
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 32)]
	public struct RoomPortal
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
		readonly public Vertex [] Vertices;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR1.RoomPortal"/> struct.
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
			Vertices = new Vertex [4];
			for (var i = 0; i < 4; i++)
				Vertices [i] = vertices [i];
		}
	}
}

