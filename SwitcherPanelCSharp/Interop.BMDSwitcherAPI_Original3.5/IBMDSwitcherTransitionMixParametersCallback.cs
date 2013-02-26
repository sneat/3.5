using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("FE9730BB-F60B-46DF-B182-2992FFC884DE")]
	[InterfaceType(1)]
	public interface IBMDSwitcherTransitionMixParametersCallback
	{
		void Notify([In] _BMDSwitcherTransitionMixParametersEventType eventType);
	}
}