using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("7AF82DC6-9A43-4CD2-9712-585E6BA159BA")]
	[InterfaceType(1)]
	public interface IBMDSwitcherStillsCallback
	{
		void Notify([In] _BMDSwitcherMediaPoolEventType eventType, [In] IBMDSwitcherFrame frame, [In] int index);
	}
}