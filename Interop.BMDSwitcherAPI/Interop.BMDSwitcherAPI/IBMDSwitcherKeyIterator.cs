using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("99B60ACF-67E2-4094-AB4E-8707C9F03134"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKeyIterator
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Next([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherKey key);
	}
}
