using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("EE88B575-6044-4372-B1D6-9733AF342DCA")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKeyLumaParameters
	{
		void AddCallback([In] IBMDSwitcherKeyLumaParametersCallback callback);

		void GetClip(out double clip);

		void GetGain(out double gain);

		void GetInverse(out int inverse);

		void GetPreMultiplied(out int preMultiplied);

		void RemoveCallback([In] IBMDSwitcherKeyLumaParametersCallback callback);

		void SetClip([In] double clip);

		void SetGain([In] double gain);

		void SetInverse([In] int inverse);

		void SetPreMultiplied([In] int preMultiplied);
	}
}