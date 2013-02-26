using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("327DBE95-F003-409E-8FEB-D9C624C439BC")]
	[InterfaceType(1)]
	public interface IBMDSwitcherInputSuperSource
	{
		void AddCallback([In] IBMDSwitcherInputSuperSourceCallback callback);

		void CreateIterator([In] ref Guid iid, out IntPtr ppv);

		void GetArtOption(out _BMDSwitcherSuperSourceArtOption artOption);

		void GetBorderBevel(out _BMDSwitcherBorderBevelOption bevelOption);

		void GetBorderBevelPosition(out double bevelPosition);

		void GetBorderBevelSoftness(out double bevelSoftness);

		void GetBorderEnabled(out int enabled);

		void GetBorderHue(out double hue);

		void GetBorderLightSourceAltitude(out double altitude);

		void GetBorderLightSourceDirection(out double degrees);

		void GetBorderLuma(out double luma);

		void GetBorderSaturation(out double sat);

		void GetBorderSoftnessIn(out double softnessIn);

		void GetBorderSoftnessOut(out double softnessOut);

		void GetBorderWidthIn(out double widthIn);

		void GetBorderWidthOut(out double widthOut);

		void GetClip(out double clip);

		void GetGain(out double gain);

		void GetInputAvailabilityMask([In] ref _BMDSwitcherInputAvailability mask);

		void GetInputCut(out long input);

		void GetInputFill(out long input);

		void GetInverse([In] ref int inverse);

		void GetPreMultiplied(out int preMultiplied);

		void RemoveCallback([In] IBMDSwitcherInputSuperSourceCallback callback);

		void SetArtOption([In] _BMDSwitcherSuperSourceArtOption artOption);

		void SetBorderBevel([In] _BMDSwitcherBorderBevelOption bevelOption);

		void SetBorderBevelPosition([In] double bevelPosition);

		void SetBorderBevelSoftness([In] double bevelSoftness);

		void SetBorderEnabled([In] int enabled);

		void SetBorderHue([In] double hue);

		void SetBorderLightSourceAltitude([In] double altitude);

		void SetBorderLightSourceDirection([In] double degrees);

		void SetBorderLuma([In] double luma);

		void SetBorderSaturation([In] double sat);

		void SetBorderSoftnessIn([In] double softnessIn);

		void SetBorderSoftnessOut([In] double softnessOut);

		void SetBorderWidthIn([In] double widthIn);

		void SetBorderWidthOut([In] double widthOut);

		void SetClip([In] double clip);

		void SetGain([In] double gain);

		void SetInputCut([In] long input);

		void SetInputFill([In] long input);

		void SetInverse([In] int inverse);

		void SetPreMultiplied([In] int preMultiplied);
	}
}