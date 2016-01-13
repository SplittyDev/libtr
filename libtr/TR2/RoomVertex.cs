using System;
using System.Runtime.InteropServices;

namespace libtr.TR2
{
	/// <summary>
	/// TR2 Room Vertex
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 12)]
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
		/// The raw value of the rendering flags
		/// </summary>
		[FieldOffset (8)]
		readonly public UInt16 RawAttributes;

		/// <summary>
		/// The rendering flags
		/// </summary>
		[FieldOffset (8)]
		#pragma warning disable 649
		// Analysis disable once UnassignedReadonlyField.Compiler
		readonly public RoomRenderingEffect Attributes;
		#pragma warning restore 649

		/// <summary>
		/// The second lighting value
		/// Almost always equal to <see cref="Lighting1"/>
		/// </summary>
		[FieldOffset (10)]
		readonly public Int16 Lighting2;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR2.RoomVertex"/> struct.
		/// </summary>
		/// <param name="vertex">The vertex.</param>
		/// <param name="lighting1">The first lighting value.</param>
		/// <param name="rawattributes">The rendering flags.</param>
		/// <param name="lighting2">The second lighting value.</param>
		public RoomVertex (
			Vertex vertex, Int16 lighting1,
			UInt16 rawattributes, Int16 lighting2) : this () {
			Vertex = vertex;
			Lighting1 = lighting1;
			Lighting2 = lighting2;
			RawAttributes = rawattributes;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR2.RoomVertex"/> struct.
		/// </summary>
		/// <param name="vertex">The vertex.</param>
		/// <param name="lighting1">The first lighting value.</param>
		/// <param name="attributes">The rendering flags.</param>
		/// <param name="lighting2">The second lighting value.</param>
		public RoomVertex (
			Vertex vertex, Int16 lighting1,
			RoomRenderingEffect attributes, Int16 lighting2
		) : this (vertex, lighting1, (UInt16) attributes, lighting2) { }
	}
}

