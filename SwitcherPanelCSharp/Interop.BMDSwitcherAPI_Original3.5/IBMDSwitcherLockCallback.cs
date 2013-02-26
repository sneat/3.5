using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("56663D7A-85A8-4DA0-9B13-2A52D3C7740C")]
	[InterfaceType(1)]
	public interface IBMDSwitcherLockCallback
	{
		void Obtained();
	}
}