using System;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[CoClass(typeof(CBMDSwitcherDiscoveryClass)), Guid("A676047A-D3A4-44B1-B8B5-31D7289D266A")]
	[ComImport]
	public interface CBMDSwitcherDiscovery : IBMDSwitcherDiscovery
	{
	}
}
