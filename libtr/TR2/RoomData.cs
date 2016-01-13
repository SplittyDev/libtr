using System;
using System.Runtime.InteropServices;

namespace libtr.TR2
{
	/// <summary>
	/// TR2 Room Data
	/// </summary>
	[StructLayout (LayoutKind.Sequential)]
	public struct RoomData
	{
		/// <summary>
		/// The number of vertices in the room
		/// </summary>
		readonly public Int16 VertexCount;

		/// <summary>
		/// The vertices
		/// </summary>
		readonly public RoomVertex [] Vertices;

		/// <summary>
		/// The number of textured rectangles in the room
		/// </summary>
		readonly public Int16 RectangleCount;

		/// <summary>
		/// The rectangles
		/// </summary>
		readonly public Face4 [] Rectangles;

		/// <summary>
		/// The number of textured triangles in the room
		/// </summary>
		readonly public Int16 TriangleCount;

		/// <summary>
		/// The triangles
		/// </summary>
		readonly public Face3 [] Triangles;

		/// <summary>
		/// The number of sprites in the room
		/// </summary>
		readonly public Int16 SpriteCount;

		/// <summary>
		/// The sprites
		/// </summary>
		readonly public RoomSprite [] Sprites;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR2.RoomData"/> struct.
		/// </summary>
		/// <param name="vertices">The vertices.</param>
		/// <param name="rectangles">The textured rectangles.</param>
		/// <param name="triangles">The textured triangles.</param>
		/// <param name="sprites">The sprites.</param>
		public RoomData (
			RoomVertex [] vertices, Face4 [] rectangles,
			Face3 [] triangles, RoomSprite [] sprites) : this () {
			VertexCount = (Int16) vertices.Length;
			RectangleCount = (Int16) rectangles.Length;
			TriangleCount = (Int16) triangles.Length;
			SpriteCount = (Int16) sprites.Length;
			Vertices = vertices;
			Rectangles = rectangles;
			Triangles = triangles;
			Sprites = sprites;
		}
	}
}

