using System;
using System.Runtime.InteropServices;

namespace libtr.TR4
{
	/// <summary>
	/// TR4 32-Bit Texture Tile
	/// </summary>
	[StructLayout (LayoutKind.Explicit, Size = 262144)]
	public unsafe struct TexTile32
	{
		/// <summary>
		/// The tiles
		/// </summary>
		[FieldOffset (0)]
		public fixed UInt32 Tiles [65536]; // 262144 bytes (256 * 256 * 4)

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR4.TexTile32"/> struct.
		/// </summary>
		/// <param name="tiles">The tiles.</param>
		public TexTile32 (UInt32 [] tiles) : this () {
			fixed (UInt32 *ptr = Tiles) {
				for (var i = 0; i < Math.Min (tiles.Length, 65536); i++)
					*(ptr + i) = tiles [i];
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="libtr.TR4.TexTile32"/> struct.
		/// </summary>
		/// <param name="tiles">The tiles.</param>
		public TexTile32 (Argb32Color4 [] tiles) : this () {
			fixed (UInt32 *ptr = Tiles) {
				for (var i = 0; i < Math.Min (tiles.Length, 65536); i++)
					*(ptr + i) = tiles [i].Value;
			}
		}
	}
}

