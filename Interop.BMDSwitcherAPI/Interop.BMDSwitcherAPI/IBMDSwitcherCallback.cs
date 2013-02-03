using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("6C6E4441-9421-4729-9951-988659E3A44A"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PropertyChanged([In] _BMDSwitcherPropertyId propertyId);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Disconnected();
	}
}
