using System;
using System.Runtime.InteropServices;

namespace libtr
{
	/// <summary>
	/// TR 16-Bit Texture Tile
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 131072)]
	public unsafe struct TexTile16
	{
		/// <summary>
		/// The tiles
		/// </summary>
		[FieldOffset (0)]
		public fixed UInt16 Tiles [65536]; // 131072 bytes (256 * 256 * 2)

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TexTile16"/> struct.
		/// </summary>
		/// <param name="tiles">The tiles.</param>
		public TexTile16 (UInt16 [] tiles) : this () {
			fixed (UInt16 *ptr = Tiles) {
				for (var i = 0; i < Math.Min (tiles.Length, 65536); i++)
					*(ptr + i) = tiles [i];
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TexTile16"/> struct.
		/// </summary>
		/// <param name="tiles">The tiles.</param>
		public TexTile16 (Argb16Color4 [] tiles) : this () {
			fixed (UInt16 *ptr = Tiles) {
				for (var i = 0; i < Math.Min (tiles.Length, 65536); i++)
					*(ptr + i) = tiles [i].Value;
			}
		}
	}
}

