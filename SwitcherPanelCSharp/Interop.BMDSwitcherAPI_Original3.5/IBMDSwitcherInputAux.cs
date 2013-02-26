using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("52C745A8-89B1-449A-A149-C43F5108DAE7")]
	[InterfaceType(1)]
	public interface IBMDSwitcherInputAux
	{
		void AddCallback([In] IBMDSwitcherInputAuxCallback callback);

		void GetInputAvailabilityMask(out _BMDSwitcherInputAvailability availabilityMask);

		void GetInputSource(out long input);

		void RemoveCallback([In] IBMDSwitcherInputAuxCallback callback);

		void SetInputSource([In] long input);
	}
}