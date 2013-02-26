using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("E437655F-32BB-4652-BA77-4083B435566A")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKeyDVEParametersCallback
	{
		void Notify([In] _BMDSwitcherKeyDVEParametersEventType eventType);
	}
}