using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("92AA5433-70FB-423D-9435-646D171C9D82")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKeyDVEParameters
	{
		void AddCallback([In] IBMDSwitcherKeyDVEParametersCallback callback);

		void GetBorderBevel(out _BMDSwitcherBorderBevelOption bevelOption);

		void GetBorderBevelPosition(out double bevelPosition);

		void GetBorderBevelSoftness(out double bevelSoft);

		void GetBorderEnabled(out int on);

		void GetBorderHue(out double hue);

		void GetBorderLuma(out double luma);

		void GetBorderOpacity(out double opacity);

		void GetBorderSaturation(out double sat);

		void GetBorderSoftnessIn(out double softIn);

		void GetBorderSoftnessOut(out double softOut);

		void GetBorderWidthIn(out double widthIn);

		void GetBorderWidthOut(out double widthOut);

		void GetLightSourceAltitude(out double altitude);

		void GetLightSourceDirection(out double degrees);

		void GetMaskBottom(out double bottom);

		void GetMasked(out int maskEnabled);

		void GetMaskLeft(out double left);

		void GetMaskRight(out double right);

		void GetMaskTop(out double top);

		void GetShadow(out int shadowOn);

		void RemoveCallback([In] IBMDSwitcherKeyDVEParametersCallback callback);

		void ResetMask();

		void SetBorderBevel([In] _BMDSwitcherBorderBevelOption bevelOption);

		void SetBorderBevelPosition([In] double bevelPosition);

		void SetBorderBevelSoftness([In] double bevelSoft);

		void SetBorderEnabled([In] int on);

		void SetBorderHue([In] double hue);

		void SetBorderLuma([In] double luma);

		void SetBorderOpacity([In] double opacity);

		void SetBorderSaturation([In] double sat);

		void SetBorderSoftnessIn([In] double softIn);

		void SetBorderSoftnessOut([In] double softOut);

		void SetBorderWidthIn([In] double widthIn);

		void SetBorderWidthOut([In] double widthOut);

		void SetLightSourceAltitude([In] double altitude);

		void SetLightSourceDirection([In] double degrees);

		void SetMaskBottom([In] double bottom);

		void SetMasked([In] int maskEnabled);

		void SetMaskLeft([In] double left);

		void SetMaskRight([In] double right);

		void SetMaskTop([In] double top);

		void SetShadow([In] int shadowOn);
	}
}