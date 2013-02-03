using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("91C7C430-A3C7-4B28-BB96-C3E880BD144E"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransferCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void TransferComplete();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void TransferFailed();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void TransferProgress([In] double progress);
	}
}
