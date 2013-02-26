using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("A0AF18D9-CBE6-49F3-B548-A44E856054D1")]
	[InterfaceType(1)]
	public interface IBMDSwitcherInputColor
	{
		void AddCallback([In] IBMDSwitcherInputColorCallback callback);

		void GetHue(out double hue);

		void GetLuma(out double luma);

		void GetSaturation(out double sat);

		void RemoveCallback([In] IBMDSwitcherInputColorCallback callback);

		void SetHue([In] double hue);

		void SetLuma([In] double luma);

		void SetSaturation([In] double sat);
	}
}