using System;
using System.Runtime.InteropServices;

namespace libtr.TR3
{
	/* Rotation:
	 * high two bits (0xC000) indicate steps of
	 * 90 degrees (e.g. (Rotation >> 14) * 90)
	 */

	/// <summary>
	/// TR3 Static Room Mesh
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 20)]
	public struct RoomStaticMesh
	{
		/// <summary>
		/// The absolute X position in world coordinates
		/// </summary>
		[FieldOffset (0)]
		readonly public UInt32 X;

		/// <summary>
		/// The absolute Y position in world coordinates
		/// </summary>
		[FieldOffset (4)]
		readonly public UInt32 Y;

		/// <summary>
		/// The absolute Z position in world coordinates
		/// </summary>
		[FieldOffset (8)]
		readonly public UInt32 Z;

		/// <summary>
		/// The rotation
		/// </summary>
		[FieldOffset (12)]
		readonly public UInt16 Rotation;

		/// <summary>
		/// The color
		/// </summary>
		[FieldOffset (14)]
		readonly public Argb16Color4 Color;

		// [FieldOffset (16)]
		// Unused uint16_t

		/// <summary>
		/// Index of the StaticMesh to draw
		/// </summary>
		[FieldOffset (18)]
		readonly public UInt16 MeshId;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR2.RoomStaticMesh"/> struct.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		/// <param name="rotation">The rotation.</param>
		/// <param name = "color">The color.</param>
		/// <param name="meshid">The mesh id.</param>
		public RoomStaticMesh (
			UInt32 x, UInt32 y, UInt32 z,
			UInt16 rotation, Argb16Color4 color, UInt16 meshid) : this () {
			X = x;
			Y = y;
			Z = z;
			Rotation = rotation;
			Color = color;
			MeshId = meshid;
		}
	}
}

