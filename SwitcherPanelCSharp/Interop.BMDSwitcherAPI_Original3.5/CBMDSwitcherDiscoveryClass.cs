using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("F2DC5149-9599-47E4-84B9-054C78A1A46D")]
	[TypeLibType(2)]
	public class CBMDSwitcherDiscoveryClass : IBMDSwitcherDiscovery, CBMDSwitcherDiscovery
	{
		public extern CBMDSwitcherDiscoveryClass();

		public virtual extern void ConnectTo([In] string deviceAddress, out IBMDSwitcher switcherDevice, out _BMDSwitcherConnectToFailure failReason);
	}
}