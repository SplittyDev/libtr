using System;
using System.Runtime.InteropServices;

namespace libtr
{
	/// <summary>
	/// TR Room Sector
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 8)]
	public struct RoomSector
	{
		/// <summary>
		/// The index into FloorData []
		/// </summary>
		[FieldOffset (0)]
		readonly public UInt16 FloorDataIndex;

		/// <summary>
		/// The index into Boxes []
		/// UInt16 in spec, changed to Int16
		/// </summary>
		[FieldOffset (2)]
		readonly public Int16 BoxIndex;

		/// <summary>
		/// The index into Zones []
		/// UInt16 in spec, changed to Int16
		/// </summary>
		[FieldOffset (2)]
		#pragma warning disable 649
		// Analysis disable once UnassignedReadonlyField.Compiler
		readonly public Int16 ZoneIndex;
		#pragma warning restore 649

		/// <summary>
		/// The id of the room below this one
		/// </summary>
		[FieldOffset (4)]
		readonly public Byte RoomBelow;

		/// <summary>
		/// The absolute height of the floor
		/// </summary>
		[FieldOffset (5)]
		readonly public SByte Floor;

		/// <summary>
		/// The id of the room above this one
		/// </summary>
		[FieldOffset (6)]
		readonly public Byte RoomAbove;

		/// <summary>
		/// The absolute height of the ceiling
		/// </summary>
		[FieldOffset (7)]
		readonly public SByte Ceiling;

		/// <summary>
		/// Get the absolute height of the floor in world coordinates
		/// </summary>
		/// <value>The absolute height of the floor in world coordinates.</value>
		public Int16 FloorWorld { get { return (Int16) (Floor * 256); } }

		/// <summary>
		/// Get the absolute height of the ceiling in world coordinates
		/// </summary>
		/// <value>The absolute height of the ceiling in world coordinates.</value>
		public Int16 CeilingWorld { get { return (Int16) (Ceiling * 256); } }

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.RoomSector"/> struct.
		/// </summary>
		/// <param name="floordataid">The index into FloorData [].</param>
		/// <param name="boxid">The index into Boxes [] / Zones [].</param>
		/// <param name="roombelow">The id of the room below this one.</param>
		/// <param name="floorheight">The absolute height of the floor.</param>
		/// <param name="roomabove">The id of the room above this one.</param>
		/// <param name="ceilingheight">The absolute height of the ceiling.</param>
		public RoomSector (
			UInt16 floordataid, Int16 boxid,
			Byte roombelow, SByte floorheight,
			Byte roomabove, SByte ceilingheight) : this () {
			FloorDataIndex = floordataid;
			BoxIndex = boxid;
			RoomBelow = roombelow;
			Floor = floorheight;
			RoomAbove = roomabove;
			Ceiling = ceilingheight;
		}
	}
}

