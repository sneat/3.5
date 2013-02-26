using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("31CA3097-D178-4398-B041-059C1312F129")]
	[InterfaceType(1)]
	public interface IBMDSwitcherTransitionDVEParameters
	{
		void AddCallback([In] IBMDSwitcherTransitionDVEParametersCallback callback);

		void GetClip(out double clip);

		void GetEnableKey(out int enableKey);

		void GetFlipFlop(out int flipflop);

		void GetGain(out double gain);

		void GetInputCut(out long input);

		void GetInputFill(out long input);

		void GetInverse(out int inverse);

		void GetLogoRate(out uint frames);

		void GetPreMultiplied(out int preMultiplied);

		void GetRate(out uint frames);

		void GetReverse(out int reverse);

		void GetStyle(out _BMDSwitcherDVETransitionStyle style);

		void RemoveCallback([In] IBMDSwitcherTransitionDVEParametersCallback callback);

		void SetClip([In] double clip);

		void SetEnableKey([In] int enableKey);

		void SetFlipFlop([In] int flipflop);

		void SetGain([In] double gain);

		void SetInputCut([In] long input);

		void SetInputFill([In] long input);

		void SetInverse([In] int inverse);

		void SetLogoRate([In] uint frames);

		void SetPreMultiplied([In] int preMultiplied);

		void SetRate([In] uint frames);

		void SetReverse([In] int reverse);

		void SetStyle([In] _BMDSwitcherDVETransitionStyle style);
	}
}