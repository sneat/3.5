using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("0BBAEDB3-A642-47AE-8D18-5DB34B78D763"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransition
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetTransitionType(out long type);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetNextTransitionType(out long type);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetNextTransitionType([In] _BMDSwitcherTransitionType type);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetTransitionLayers(out long layers);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetNextTransitionLayers([In] int layers);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetNextTransitionLayers(out int layers);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherTransitionCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherTransitionCallback callback);
	}
}
