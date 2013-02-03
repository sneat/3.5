using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("F6BB60B6-9080-41D8-BD16-F7C3218369A0"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransitionDip
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetRate(out uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetRate([In] uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInputDip(out long input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetInputDip([In] long input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherTransitionDipCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherTransitionDipCallback callback);
	}
}
