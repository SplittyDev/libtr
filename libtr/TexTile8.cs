using System;
using System.Runtime.InteropServices;

namespace libtr
{
	/// <summary>
	/// TR2 8-Bit Texture Tile
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 65536)]
	public unsafe struct TexTile8
	{
		/// <summary>
		/// The tiles
		/// </summary>
		[FieldOffset (0)]
		public fixed Byte Tiles [65536]; // 65536 bytes (256 * 256 * 1)

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TexTile8"/> struct.
		/// </summary>
		/// <param name="tiles">The tiles.</param>
		public TexTile8 (Byte [] tiles) : this () {
			fixed (Byte *ptr = Tiles) {
				for (var i = 0; i < Math.Min (tiles.Length, 65536); i++)
					*(ptr + i) = tiles [i];
			}
		}
	}
}

