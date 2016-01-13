using System;

namespace libtr
{
	public static class ByteExtensions
	{
		public static Byte Truncate (this Byte b, Byte n) {
			return (Byte) (b >> n);
		}
	}
}

