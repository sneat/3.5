using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("267EDB96-5921-4BA5-88BA-C83123E153D2")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKeyPatternParameters
	{
		void AddCallback([In] IBMDSwitcherKeyPatternParametersCallback callback);

		void GetHorizontalOffset(out double hOffset);

		void GetInverse(out int inverse);

		void GetPattern(out _BMDSwitcherPatternStyle pattern);

		void GetSize(out double size);

		void GetSoftness(out double softness);

		void GetSymmetry(out double symmetry);

		void GetVerticalOffset(out double vOffset);

		void RemoveCallback([In] IBMDSwitcherKeyPatternParametersCallback callback);

		void SetHorizontalOffset([In] double hOffset);

		void SetInverse([In] int inverse);

		void SetPattern([In] _BMDSwitcherPatternStyle pattern);

		void SetSize([In] double size);

		void SetSoftness([In] double softness);

		void SetSymmetry([In] double symmetry);

		void SetVerticalOffset([In] double vOffset);
	}
}