using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("A9D6543D-0447-4048-B5AD-806622B9BF1A")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKeyFlyParametersCallback
	{
		void Notify([In] _BMDSwitcherKeyFlyParametersEventType eventType, [In] _BMDSwitcherFlyKeyFrame keyFrame);
	}
}