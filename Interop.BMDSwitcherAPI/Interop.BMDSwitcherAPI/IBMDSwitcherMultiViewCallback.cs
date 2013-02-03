using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("B601CA2F-F222-4EEA-98D5-1BFE0DB11B46"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherMultiViewCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void LayoutChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void WindowChanged([In] uint window);
	}
}
