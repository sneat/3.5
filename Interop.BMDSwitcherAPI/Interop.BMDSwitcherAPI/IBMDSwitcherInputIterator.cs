using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("92AB7A73-C6F6-47FC-92A7-C8EEADC9EAAC"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherInputIterator
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Next([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetById([In] long inputId, [MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherInput input);
	}
}
