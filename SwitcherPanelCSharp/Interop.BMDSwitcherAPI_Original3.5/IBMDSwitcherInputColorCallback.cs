using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("BAE02C95-9394-439C-BE18-CEF0C0784EC3")]
	[InterfaceType(1)]
	public interface IBMDSwitcherInputColorCallback
	{
		void Notify([In] _BMDSwitcherInputColorEventType eventType);
	}
}