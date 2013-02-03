using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[ComConversionLoss, Guid("DD28FEDB-B7BE-4D35-96A5-720E2779F40E"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransfer
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Queue();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Cancel();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetDownloadedFrame([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherFrame frame);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetDownloadedTrack([Out] IntPtr audioData, out uint audioDataBytes);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherTransferCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherTransferCallback callback);
	}
}
