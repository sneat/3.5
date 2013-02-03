using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("75C6528E-F4F8-44C8-9A8E-86BF9C5E915E"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherDownStreamKeyerIterator
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Next([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherDownStreamKeyer downStreamKeyer);
	}
}
