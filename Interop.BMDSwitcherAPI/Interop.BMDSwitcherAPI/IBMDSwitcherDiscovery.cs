using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("A676047A-D3A4-44B1-B8B5-31D7289D266A"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherDiscovery
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ConnectTo([MarshalAs(UnmanagedType.BStr)] [In] string deviceAddress, [MarshalAs(UnmanagedType.Interface)] out IBMDSwitcher switcherDevice, out _BMDSwitcherConnectToFailure failReason);
	}
}
