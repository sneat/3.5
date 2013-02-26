using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("0C7D4DE3-E7D1-4062-86B4-9F82F7BB346D")]
	[InterfaceType(1)]
	public interface IBMDSwitcherDownstreamKeyCallback
	{
		void Notify([In] _BMDSwitcherDownstreamKeyEventType eventType);
	}
}