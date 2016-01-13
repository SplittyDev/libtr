using System;
using System.Runtime.InteropServices;

namespace libtr.TR2
{
	/// <summary>
	/// TR2 Room Light
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 24)]
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
		/// The intensity of the light
		/// Almost always equal to <see cref="Intensity1"/>
		/// </summary>
		[FieldOffset (14)]
		readonly public UInt16 Intensity2;

		/// <summary>
		/// The first falloff value
		/// </summary>
		[FieldOffset (16)]
		readonly public UInt32 Fade1;

		/// <summary>
		/// The second falloff value
		/// </summary>
		[FieldOffset (20)]
		readonly public UInt32 Fade2;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR2.RoomLight"/> struct.
		/// </summary>
		/// <param name="x">The x coordinate in world coordinates.</param>
		/// <param name="y">The y coordinate in world coordinates.</param>
		/// <param name="z">The z coordinate in world coordinates.</param>
		/// <param name="intensity1">The light intensity.</param>
		/// <param name="intensity2">The light intensity.</param>
		/// <param name="fade1">First falloff value.</param>
		/// <param name="fade2">Second falloff value.</param>
		public RoomLight (
			Int32 x, Int32 y, Int32 z,
			UInt16 intensity1, UInt16 intensity2,
			UInt32 fade1, UInt32 fade2) : this () {
			X = x;
			Y = y;
			Z = z;
			Intensity1 = intensity1;
			Intensity2 = intensity2;
			Fade1 = fade1;
			Fade2 = fade2;
		}
	}
}

