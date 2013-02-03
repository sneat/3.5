using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
    [ClassInterface(ClassInterfaceType.None), Guid("F2DC5149-9599-47E4-84B9-054C78A1A46D"), TypeLibType(2)]
	[ComImport]
	public class CBMDSwitcherDiscoveryClass : IBMDSwitcherDiscovery, CBMDSwitcherDiscovery
	{
        //[MethodImpl(MethodImplOptions.InternalCall)]
		//public extern CBMDSwitcherDiscoveryClass();
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ConnectTo([MarshalAs(UnmanagedType.BStr)] [In] string deviceAddress, [MarshalAs(UnmanagedType.Interface)] out IBMDSwitcher switcherDevice, out _BMDSwitcherConnectToFailure failReason);
	}
}
