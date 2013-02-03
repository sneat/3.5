using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("F64FFCA5-D76B-4471-ADD0-96DCD2749812"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransitionDVEParameters
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetRate(out uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetRate([In] uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetLogoRate(out uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetLogoRate([In] uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetReverse(out int reverse);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetReverse([In] int reverse);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetFlipFlop(out int flipflop);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetFlipFlop([In] int flipflop);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void GetStyle(out _BMDSwitcherDVETransitionStyle style);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void SetStyle([In] _BMDSwitcherDVETransitionStyle style);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInputFill([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetInputFill([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInputCut([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetInputCut([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetEnableKey(out int enableKey);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetEnableKey([In] int enableKey);
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
		void GetReversed(out int reversed);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetReversed([In] int reversed);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherTransitionDVECallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherTransitionDVECallback callback);
	}
}
