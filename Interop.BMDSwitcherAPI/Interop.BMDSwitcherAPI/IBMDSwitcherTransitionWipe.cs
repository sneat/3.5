using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("4146B95F-3807-485C-8202-9842A18624C4"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransitionWipe
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetRate(out uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetRate([In] uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetPattern(out _BMDSwitcherPatternStyle pattern);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void SetPattern([In] _BMDSwitcherPatternStyle pattern);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetBorderSize(out double size);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetBorderSize([In] double size);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetSymmetry(out double symmetry);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetSymmetry([In] double symmetry);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetSoft(out double soft);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetSoft([In] double soft);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetHorizontalOffset(out double hOffset);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetHorizontalOffset([In] double hOffset);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetVerticalOffset(out double vOffset);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetVerticalOffset([In] double vOffset);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetReverse(out int reverse);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetReverse([In] int reverse);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetFlipFlop(out int flipflop);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetFlipFlop([In] int flipflop);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInputBorder([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetInputBorder([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherInput input);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherTransitionWipeCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherTransitionWipeCallback callback);
	}
}
