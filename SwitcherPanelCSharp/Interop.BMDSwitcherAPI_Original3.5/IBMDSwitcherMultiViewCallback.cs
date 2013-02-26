using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("345CE414-0BF1-46F9-97AC-FB1A47499005")]
	[InterfaceType(1)]
	public interface IBMDSwitcherMultiViewCallback
	{
		void Notify([In] _BMDSwitcherMultiViewEventType eventType, [In] int window);
	}
}