using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("7FEAA76A-7E8F-4853-8A6B-59742AFB3F26"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherMultiView
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
        void GetLayout(out _BMDSwitcherMultiViewLayout layout);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void SetLayout([In] _BMDSwitcherMultiViewLayout layout);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetWindowInput([In] uint window, [MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetWindowInput([In] uint window, [MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetWindowCount(out uint windowCount);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void GetInputAvailabilityMask(out _BMDSwitcherInputAvailability availabilityMask);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void CanRouteInputs(out int canRoute);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherMultiViewCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherMultiViewCallback callback);
	}
}
