using System;

namespace libtr.TR4
{
	/// <summary>
	/// TR4 Room Light Type
	/// </summary>
	public enum RoomLightType : byte {

		/// <summary>
		/// Sunlight
		/// </summary>
		Sun = 0x0,

		/// <summary>
		/// Normal light
		/// </summary>
		Light = 0x1,

		/// <summary>
		/// Spotlight
		/// </summary>
		Spot = 0x2,

		/// <summary>
		/// No idea.
		/// Maybe a directional light that casts shadows
		/// </summary>
		Shadow = 0x3,

		/// <summary>
		/// Volumetric fog effect
		/// </summary>
		FogBulb = 0x4,
	}
}

