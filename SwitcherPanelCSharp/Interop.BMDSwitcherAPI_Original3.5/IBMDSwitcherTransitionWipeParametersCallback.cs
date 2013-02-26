using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("0FC4E095-DF7A-4128-933A-AAE4B7FD6119")]
	[InterfaceType(1)]
	public interface IBMDSwitcherTransitionWipeParametersCallback
	{
		void Notify([In] _BMDSwitcherTransitionWipeParametersEventType eventType);
	}
}