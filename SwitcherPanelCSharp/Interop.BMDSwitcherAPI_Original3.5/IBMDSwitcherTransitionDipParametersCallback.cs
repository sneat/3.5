using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("410BE711-DB1A-48D1-93E7-382A0B1781B5")]
	[InterfaceType(1)]
	public interface IBMDSwitcherTransitionDipParametersCallback
	{
		void Notify([In] _BMDSwitcherTransitionDipParametersEventType eventType);
	}
}