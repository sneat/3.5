using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("151DDF6A-C42F-43A8-B1A3-43D6C05C65B4"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKeyPattern
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
        void GetPattern(out _BMDSwitcherPatternStyle pattern);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void SetPattern([In] _BMDSwitcherPatternStyle pattern);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetSize(out double size);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetSize([In] double size);
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
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherKeyPatternCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherKeyPatternCallback callback);
	}
}
