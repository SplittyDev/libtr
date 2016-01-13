using System;
using System.ComponentModel;

namespace libtr.TR2
{
	/// <summary>
	/// Room rendering effect
	/// </summary>
	[Flags]
	[DefaultValue (Normal)]
	public enum RoomRenderingEffect : ushort {

		/// <summary>
		/// Normal rendering
		/// </summary>
		Normal = 0x0010,

		/// <summary>
		/// Water/quicksand surface movement
		/// </summary>
		WaterSurfaceMovement = 0x2000,

		/// <summary>
		/// Under water lighting modulation and movement
		/// if viewed from above water surface
		/// </summary>
		UnderwaterLightModulation = 0x4000,

		/// <summary>
		/// Unknown effect, seems to have something
		/// to do with water surfaces
		/// </summary>
		UnknownWaterEffect = 0x8000,
	}
}

