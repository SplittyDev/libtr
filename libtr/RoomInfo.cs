using System;
using System.Runtime.InteropServices;

namespace libtr
{
	/// <summary>
	/// TR2 Room Info
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 16)]
	public struct RoomInfo
	{
		/// <summary>
		/// X coordinate
		/// </summary>
		[FieldOffset (0)]
		readonly public Int32 X;

		/// <summary>
		/// Z coordinate
		/// </summary>
		[FieldOffset (4)]
		readonly public Int32 Z;

		/// <summary>
		/// Bottom Y coordinate
		/// </summary>
		[FieldOffset (8)]
		readonly public Int32 YBottom;

		/// <summary>
		/// Top Y coordinate
		/// </summary>
		[FieldOffset (12)]
		readonly public Int32 YTop;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.RoomInfo"/> struct.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		/// <param name="ybottom">The bottom Y coordinate.</param>
		/// <param name="ytop">The top Y coordinate.</param>
		public RoomInfo (Int32 x, Int32 z, Int32 ybottom, Int32 ytop) : this () {
			X = x;
			Z = z;
			YBottom = ybottom;
			YTop = ytop;
		}
	}
}

