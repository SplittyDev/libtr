using System;
using System.Runtime.InteropServices;

namespace libtr.TR1
{
	/// <summary>
	/// TR1 Room Light
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 18)]
	public struct RoomLight
	{
		/// <summary>
		/// The X position of the light in world coordinates
		/// </summary>
		[FieldOffset (0)]
		readonly public Int32 X;

		/// <summary>
		/// The Y position of the light in world coordinates
		/// </summary>
		[FieldOffset (4)]
		readonly public Int32 Y;

		/// <summary>
		/// The Z position of the light in world coordinates
		/// </summary>
		[FieldOffset (8)]
		readonly public Int32 Z;

		/// <summary>
		/// The intensity of the light
		/// </summary>
		[FieldOffset (12)]
		readonly public UInt16 Intensity1;

		/// <summary>
		/// The first falloff value
		/// </summary>
		[FieldOffset (14)]
		readonly public UInt32 Fade1;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR1.RoomLight"/> struct.
		/// </summary>
		/// <param name="x">The x coordinate in world coordinates.</param>
		/// <param name="y">The y coordinate in world coordinates.</param>
		/// <param name="z">The z coordinate in world coordinates.</param>
		/// <param name="intensity1">The light intensity.</param>
		/// <param name="fade1">First falloff value.</param>
		public RoomLight (
			Int32 x, Int32 y, Int32 z,
			UInt16 intensity1, UInt32 fade1) : this () {
			X = x;
			Y = y;
			Z = z;
			Intensity1 = intensity1;
			Fade1 = fade1;
		}
	}
}

