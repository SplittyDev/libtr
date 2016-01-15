using System;
using System.Runtime.InteropServices;

namespace libtr.TR5
{
	/// <summary>
	/// TR5 Room Light
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 88)]
	public unsafe struct RoomLight
	{
		/// <summary>
		/// The X position in world coordinates
		/// </summary>
		[FieldOffset (0)]
		readonly public Single X;

		/// <summary>
		/// The Y position in world coordinates
		/// </summary>
		[FieldOffset (4)]
		readonly public Single Y;

		/// <summary>
		/// The Z position in world coordinates
		/// </summary>
		[FieldOffset (8)]
		readonly public Single Z;

		/// <summary>
		/// The color of the light
		/// </summary>
		[FieldOffset (12)]
		readonly public Color Color;

		/// <summary>
		/// The hotspot (?)
		/// cos (IN) / sizeof (IN)
		/// </summary>
		[FieldOffset (28)]
		readonly public Single In;

		/// <summary>
		/// The falloff (?)
		/// cos (OUT) / sizeof (OUT)
		/// </summary>
		[FieldOffset (32)]
		readonly public Single Out;

		/// <summary>
		/// 2 * rad (IN)
		/// </summary>
		[FieldOffset (36)]
		readonly public Single RadIn;

		/// <summary>
		/// 2 * rad (OUT)
		/// </summary>
		[FieldOffset (40)]
		readonly public Single RadOut;

		/// <summary>
		/// The range of the light
		/// </summary>
		[FieldOffset (44)]
		readonly public Single Range;

		/// <summary>
		/// The target X position
		/// </summary>
		[FieldOffset (48)]
		readonly public Single Dx;

		/// <summary>
		/// The target Y position
		/// </summary>
		[FieldOffset (52)]
		readonly public Single Dy;

		/// <summary>
		/// The target Z position
		/// </summary>
		[FieldOffset (56)]
		readonly public Single Dz;

		/// <summary>
		/// The X position as integer
		/// </summary>
		[FieldOffset (60)]
		readonly public Int32 X2;

		/// <summary>
		/// The Y position as integer
		/// </summary>
		[FieldOffset (64)]
		readonly public Int32 Y2;

		/// <summary>
		/// The Z position as integer
		/// </summary>
		[FieldOffset (68)]
		readonly public Int32 Z2;

		/// <summary>
		/// The target X position as integer
		/// </summary>
		[FieldOffset (72)]
		readonly public Int32 Dx2;

		/// <summary>
		/// The target Y position as integer
		/// </summary>
		[FieldOffset (76)]
		readonly public Int32 Dy2;

		/// <summary>
		/// The target Z position as integer
		/// </summary>
		[FieldOffset (80)]
		readonly public Int32 Dz2;

		/// <summary>
		/// The type of the light
		/// </summary>
		[FieldOffset (84)]
		readonly public Byte RawLightType;

		/// <summary>
		/// The type of the light
		/// </summary>
		[FieldOffset (84)]
		readonly public TR4.RoomLightType LightType;

		/// <summary>
		/// Useless filler bytes
		/// </summary>
		[FieldOffset (85)]
		public fixed Byte Filler [3];

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR5.RoomLight"/> struct.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		/// <param name="color">The light color.</param>
		/// <param name="_in">Hotspot?</param>
		/// <param name="_out">Falloff?</param>
		/// <param name="radin">2 * rad (IN)</param>
		/// <param name="radout">2 * rad (OUT)</param>
		/// <param name="range">The range.</param>
		/// <param name="dx">The target X coordinate.</param>
		/// <param name="dy">The target Y coordinate.</param>
		/// <param name="dz">The target Z coordinate.</param>
		/// <param name="type">The light type.</param>
		public RoomLight (
			Single x, Single y, Single z, Color color,
			Single _in, Single _out, Single radin, Single radout,
			Single range, Single dx, Single dy, Single dz, Byte type) : this () {
			X = x;
			Y = y;
			Z = z;
			Color = color;
			In = _in;
			Out = _out;
			RadIn = radin;
			RadOut = radout;
			Range = range;
			Dx = dx;
			Dy = dy;
			Dz = dz;
			RawLightType = type;
			X2 = (Int32) X;
			Y2 = (Int32) Y;
			Z2 = (Int32) Z;
			Dx2 = (Int32) Dx;
			Dy2 = (Int32) Dy;
			Dz2 = (Int32) Dz;
			fixed (Byte *ptr = Filler) {
				for (var i = 0; i < 3; i++)
					*(ptr + i) = 0xCD;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR5.RoomLight"/> struct.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		/// <param name="color">The light color.</param>
		/// <param name="_in">Hotspot?</param>
		/// <param name="_out">Falloff?</param>
		/// <param name="radin">2 * rad (IN)</param>
		/// <param name="radout">2 * rad (OUT)</param>
		/// <param name="range">The range.</param>
		/// <param name="dx">The target X coordinate.</param>
		/// <param name="dy">The target Y coordinate.</param>
		/// <param name="dz">The target Z coordinate.</param>
		/// <param name="type">The light type.</param>
		public RoomLight (
			Single x, Single y, Single z, Color color,
			Single _in, Single _out, Single radin, Single radout,
			Single range, Single dx, Single dy, Single dz, TR4.RoomLightType type) : this (
			x, y, z, color, _in, _out, radin, radout,
			range, dx, dy, dz, (Byte) type) {
		}
	}
}

