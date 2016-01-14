using System;
using System.Runtime.InteropServices;

namespace libtr
{
	/// <summary>
	/// TR Room Sprite
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 4)]
	public struct RoomSprite
	{
		/// <summary>
		/// Offset into vertex list
		/// </summary>
		[FieldOffset (0)]
		readonly public Int16 Vertex;

		/// <summary>
		/// Offset into sprite texture list
		/// </summary>
		[FieldOffset (2)]
		readonly public Int16 Texture;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.RoomSprite"/> struct.
		/// </summary>
		/// <param name="vertex">The vertex.</param>
		/// <param name="texture">The texture.</param>
		public RoomSprite (Int16 vertex, Int16 texture) {
			Vertex = vertex;
			Texture = texture;
		}
	}
}

