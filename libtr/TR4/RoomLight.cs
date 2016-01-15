using System;
using System.Runtime.InteropServices;

namespace libtr.TR4
{
	/// <summary>
	/// TR4 Room Light
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 46)]
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
		readonly public TR1.Color Color;

		/// <summary>
		/// The type of the light
		/// </summary>
		[FieldOffset (15)]
		readonly public Byte RawLightType;

		/// <summary>
		/// The type of the light
		/// </summary>
		[FieldOffset (15)]
		readonly public RoomLightType LightType;

		/// <summary>
		/// Unknown
		/// Almost always 0xFF
		/// </summary>
		[FieldOffset (16)]
		readonly public Byte Unknown; // Seems to be always 0xFF

		/// <summary>
		/// The intensity of the light
		/// </summary>
		[FieldOffset (17)]
		readonly public Byte Intensity;

		/// <summary>
		/// The hotspot
		/// </summary>
		[FieldOffset (18)]
		readonly public Single In;

		/// <summary>
		/// The falloff
		/// </summary>
		[FieldOffset (22)]
		readonly public Single Out;

		/// <summary>
		/// The length
		/// </summary>
		[FieldOffset (26)]
		readonly public Single Length;

		/// <summary>
		/// The cutoff
		/// </summary>
		[FieldOffset (30)]
		readonly public Single Cutoff;

		/// <summary>
		/// Target X position of the light
		/// </summary>
		[FieldOffset (34)]
		readonly public Single Dx;

		/// <summary>
		/// Target Y position of the light
		/// </summary>
		[FieldOffset (38)]
		readonly public Single Dy;

		/// <summary>
		/// Target Z position of the light
		/// </summary>
		[FieldOffset (42)]
		readonly public Single Dz;

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR4.RoomLight"/> struct.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		/// <param name="color">The light color.</param>
		/// <param name="type">The light type.</param>
		/// <param name="intensity">The light intensity.</param>
		/// <param name="_in">The hotspot.</param>
		/// <param name="_out">The falloff.</param>
		/// <param name="length">The length.</param>
		/// <param name="cutoff">The cutoff.</param>
		/// <param name="dx">Target X position.</param>
		/// <param name="dy">Target Y position.</param>
		/// <param name="dz">Target Z position.</param>
		/// <param name="unknown">Unknown.</param>
		public RoomLight (
			Int32 x, Int32 y, Int32 z,
			TR1.Color color, Byte type, Byte intensity,
			Single _in, Single _out, Single length, Single cutoff,
			Single dx, Single dy, Single dz, Byte unknown = 0xFF) : this () {
			X = x;
			Y = y;
			Z = z;
			Color = color;
			RawLightType = type;
			Intensity = intensity;
			In = _in;
			Out = _out;
			Length = length;
			Cutoff = cutoff;
			Dx = dx;
			Dy = dy;
			Dz = dz;
			Unknown = unknown;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR4.RoomLight"/> struct.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		/// <param name="color">The light color.</param>
		/// <param name="type">The light type.</param>
		/// <param name="intensity">The light intensity.</param>
		/// <param name="_in">The hotspot.</param>
		/// <param name="_out">The falloff.</param>
		/// <param name="length">The length.</param>
		/// <param name="cutoff">The cutoff.</param>
		/// <param name="dx">Target X position.</param>
		/// <param name="dy">Target Y position.</param>
		/// <param name="dz">Target Z position.</param>
		/// <param name="unknown">Unknown.</param>
		public RoomLight (
			Int32 x, Int32 y, Int32 z,
			TR1.Color color, RoomLightType type, Byte intensity,
			Single _in, Single _out, Single length, Single cutoff,
			Single dx, Single dy, Single dz, Byte unknown = 0xFF) : this (
			x, y, z, color, (Byte) type, intensity,
			_in, _out, length, cutoff, dx, dy, dz, unknown) {
		}
	}
}

