using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("7F667AF6-9B4E-4CDE-9F2F-2DF4505BF877")]
	[InterfaceType(1)]
	public interface IBMDSwitcherSuperSourceBoxCallback
	{
		void Notify([In] _BMDSwitcherSuperSourceBoxEventType eventType);
	}
}