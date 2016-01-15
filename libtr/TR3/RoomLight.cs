using System;
using System.Runtime.InteropServices;

namespace libtr.TR3
{
	/// <summary>
	/// TR3 Room Light
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
		/// The color of the light
		/// </summary>
		[FieldOffset (12)]
		readonly public TR1.Color4 Color;

		/// <summary>
		/// The intensity of the light
		/// </summary>
		[FieldOffset (16)]
		readonly public UInt32 Intensity;

		/// <summary>
		/// The falloff value
		/// </summary>
		[FieldOffset (20)]
		readonly public UInt32 Fade;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR1.RoomLight"/> struct.
		/// </summary>
		/// <param name="x">The x coordinate in world coordinates.</param>
		/// <param name="y">The y coordinate in world coordinates.</param>
		/// <param name="z">The z coordinate in world coordinates.</param>
		/// <param name="color">The light color.</param>
		/// <param name="intensity">The intensity of the light.</param> 
		/// <param name="fade">The falloff value.</param>
		public RoomLight (
			Int32 x, Int32 y, Int32 z, TR1.Color4 color,
			UInt32 intensity, UInt32 fade) : this () {
			X = x;
			Y = y;
			Z = z;
			Color = color;
			Intensity = intensity;
			Fade = fade;
		}
	}
}

