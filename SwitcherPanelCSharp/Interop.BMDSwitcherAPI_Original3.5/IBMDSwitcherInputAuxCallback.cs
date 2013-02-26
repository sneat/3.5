using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("5AD1FF91-143F-49E9-9964-1B9FAF9A712A")]
	[InterfaceType(1)]
	public interface IBMDSwitcherInputAuxCallback
	{
		void Notify([In] _BMDSwitcherInputAuxEventType eventType);
	}
}