using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("1E38E305-49EE-499F-82A9-6795A9EDD263"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherMultiViewIterator
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Next([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherMultiView multiView);
	}
}
