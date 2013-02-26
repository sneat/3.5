using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("6535115F-B64C-4512-BF5A-12969253E2F9")]
	[InterfaceType(1)]
	public interface IBMDSwitcherTransitionDVEParametersCallback
	{
		void Notify([In] _BMDSwitcherTransitionDVEParametersEventType eventType);
	}
}