using System;
using System.Runtime.InteropServices;

namespace libtr.TR1
{
	/* Rotation:
	 * high two bits (0xC000) indicate steps of
	 * 90 degrees (e.g. (Rotation >> 14) * 90)
	 */

	/// <summary>
	/// TR1 Static Room Mesh
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 18)]
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
		/// Constant lighting
		/// Use mesh lighting if value is set to -1
		/// UInt16 in spec, changed to Int16
		/// </summary>
		[FieldOffset (14)]
		readonly public Int16 Intensity1;

		/// <summary>
		/// Index of the StaticMesh to draw
		/// </summary>
		[FieldOffset (16)]
		readonly public UInt16 ObjectId;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR2.RoomStaticMesh"/> struct.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		/// <param name="rotation">Rotation.</param>
		/// <param name="intensity1">Intensity1.</param>
		/// <param name="objectid">Objectid.</param>
		public RoomStaticMesh (
			UInt32 x, UInt32 y, UInt32 z,
			UInt16 rotation, Int16 intensity1, UInt16 objectid) : this () {
			X = x;
			Y = y;
			Z = z;
			Rotation = rotation;
			Intensity1 = intensity1;
			ObjectId = objectid;
		}
	}
}

