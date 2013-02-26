using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("9A8B3FB6-DD56-4DFF-AEB3-2C8A26585389")]
	[InterfaceType(1)]
	public interface IBMDSwitcherTransitionStingerParametersCallback
	{
		void Notify([In] _BMDSwitcherTransitionStingerParametersEventType eventType);
	}
}