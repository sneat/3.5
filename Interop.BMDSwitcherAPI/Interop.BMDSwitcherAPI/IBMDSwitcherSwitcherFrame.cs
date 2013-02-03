using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[ComConversionLoss, Guid("35A1F6A6-D317-4F89-A565-0F0BD414CF77"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherFrame
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetName([MarshalAs(UnmanagedType.BStr)] out string name);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetUUID(out Guid uuid);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetWidth(out uint width);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetHeight(out uint height);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetPixelFormat(out _BMDSwitcherPixelFormat pixelFormat);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetPixelData([Out] IntPtr pixelData);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetPixelDataBytes(out uint pixelDataBytes);
	}
}
