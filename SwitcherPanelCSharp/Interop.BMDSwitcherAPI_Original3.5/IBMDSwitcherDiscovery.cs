using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("A676047A-D3A4-44B1-B8B5-31D7289D266A")]
	[InterfaceType(1)]
	public interface IBMDSwitcherDiscovery
	{
		void ConnectTo([In] string deviceAddress, out IBMDSwitcher switcherDevice, out _BMDSwitcherConnectToFailure failReason);
	}
}