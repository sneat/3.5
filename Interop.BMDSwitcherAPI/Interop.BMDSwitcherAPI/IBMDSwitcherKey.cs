using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("98701DEF-EDBB-444C-BA05-281AD6D2284D"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKey
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetLayer(out _BMDSwitcherTransitionLayers layer);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetOnAir(out int onAir);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetOnAir([In] int onAir);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetType(out _BMDSwitcherKeyType type);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetType([In] _BMDSwitcherKeyType type);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void CanBeDVEKey(out int canDVE);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInputCut(out long input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetInputCut([In] long input);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void GetInputFill(out long input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetInputFill([In] long input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetMasked(out int maskEnabled);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetMasked([In] int maskEnabled);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetMaskProperties(out double top, out double bottom, out double left, out double right);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetMaskProperties([In] double top, [In] double bottom, [In] double left, [In] double right);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetMask();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherKeyCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherKeyCallback callback);
	}
}
