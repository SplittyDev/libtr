using System;
using System.Runtime.InteropServices;

namespace libtr.TR1
{
	/// <summary>
	/// TR1 Room Vertex
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 8)]
	public struct RoomVertex
	{
		/// <summary>
		/// The position of the vertex relative to the room
		/// </summary>
		[FieldOffset (0)]
		Vertex Vertex;

		/// <summary>
		/// The lighting
		/// </summary>
		[FieldOffset (6)]
		readonly public Int16 Lighting1;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR2.RoomVertex"/> struct.
		/// </summary>
		/// <param name="vertex">The vertex.</param>
		/// <param name="lighting1">The first lighting value.</param>
		public RoomVertex (Vertex vertex, Int16 lighting1) : this () {
			Vertex = vertex;
			Lighting1 = lighting1;
		}
	}
}

