using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("07658026-6AE3-4694-B814-2AB7EBBE7D1C")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKeyChromaParameters
	{
		void AddCallback([In] IBMDSwitcherKeyChromaParametersCallback callback);

		void GetGain(out double gain);

		void GetHue(out double hue);

		void GetLift(out double lift);

		void GetNarrow(out int narrow);

		void GetYSuppress(out double ySuppress);

		void RemoveCallback([In] IBMDSwitcherKeyChromaParametersCallback callback);

		void SetGain([In] double gain);

		void SetHue([In] double hue);

		void SetLift([In] double lift);

		void SetNarrow([In] int narrow);

		void SetYSuppress([In] double ySuppress);
	}
}