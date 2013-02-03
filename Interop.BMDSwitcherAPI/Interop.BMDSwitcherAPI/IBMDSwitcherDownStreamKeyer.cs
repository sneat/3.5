using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("68B038E1-5FC5-421E-AEDF-70BCD8C557EF"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherDownStreamKeyer
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInputCut([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetInputCut([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInputFill([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetInputFill([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetTie(out int tie);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetTie([In] int tie);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetRate(out uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetRate([In] uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetOnAir(out int onAir);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetOnAir([In] int onAir);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PerformAuto();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetIsTransitioning(out int isTransitioning, out int isAutoTransition, out uint framesRemaining);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetShaped(out int shaped);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetShaped([In] int shaped);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetClip(out double clip);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetClip([In] double clip);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetGain(out double gain);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetGain([In] double gain);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetReverse([In] ref int reverse);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetReverse([In] int reverse);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetMasked(out int maskEnabled);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetMasked([In] int maskEnabled);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetMaskProperties(out double top, out double bottom, out double left, out double right);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetMaskProperties([In] double top, [In] double bottom, [In] double left, [In] double right);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInputAvailabilityMask(out _BMDSwitcherInputAvailability availabilityMask);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetMask();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherDownStreamKeyerCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherDownStreamKeyerCallback callback);
	}
}
