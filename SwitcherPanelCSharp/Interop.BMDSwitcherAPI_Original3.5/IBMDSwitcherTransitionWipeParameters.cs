using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("FAC84D37-11A2-4152-8E5E-D9EB0DC48619")]
	[InterfaceType(1)]
	public interface IBMDSwitcherTransitionWipeParameters
	{
		void AddCallback([In] IBMDSwitcherTransitionWipeParametersCallback callback);

		void GetBorderSize(out double size);

		void GetFlipFlop(out int flipflop);

		void GetHorizontalOffset(out double hOffset);

		void GetInputBorder(out long input);

		void GetPattern(out _BMDSwitcherPatternStyle pattern);

		void GetRate(out uint frames);

		void GetReverse(out int reverse);

		void GetSoftness(out double soft);

		void GetSymmetry(out double symmetry);

		void GetVerticalOffset(out double vOffset);

		void RemoveCallback([In] IBMDSwitcherTransitionWipeParametersCallback callback);

		void SetBorderSize([In] double size);

		void SetFlipFlop([In] int flipflop);

		void SetHorizontalOffset([In] double hOffset);

		void SetInputBorder([In] long input);

		void SetPattern([In] _BMDSwitcherPatternStyle pattern);

		void SetRate([In] uint frames);

		void SetReverse([In] int reverse);

		void SetSoftness([In] double soft);

		void SetSymmetry([In] double symmetry);

		void SetVerticalOffset([In] double vOffset);
	}
}