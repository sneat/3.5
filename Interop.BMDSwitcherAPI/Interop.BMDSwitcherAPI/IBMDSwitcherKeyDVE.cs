using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("111F98EB-629E-438B-8B5C-1804A001446C"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKeyDVE
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetEnabled(out int on);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetEnabled([In] int on);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetShadow(out int shadowOn);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetShadow([In] int shadowOn);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetBevel(out int bevelIn, out int bevelOut);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetBevel([In] int bevelIn, [In] int bevelOut);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetWidth(out double widthIn, out double widthOut);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetWidth([In] double widthIn, [In] double widthOut);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetSoft(out double softIn, out double softOut);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetSoft([In] double softIn, [In] double softOut);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetBevelSoft(out double bevelSoft);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetBevelSoft([In] double bevelSoft);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetBevelPosition(out double bevelPosition);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetBevelPosition([In] double bevelPosition);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetOpacity(out double opacity);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetOpacity([In] double opacity);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetColor(out double hue, out double sat, out double luma);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetColor([In] double hue, [In] double sat, [In] double luma);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetLight(out double degrees, out double alt);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetLight([In] double degrees, [In] double alt);
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
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherKeyDVECallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherKeyDVECallback callback);
	}
}
