using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("930BDE3B-4A78-43D0-8FD3-6E82ABA0E117"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherMixEffectBlockIterator
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Next([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherMixEffectBlock mixEffectBlock);
	}
}
