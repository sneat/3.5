using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("F8754D4B-6078-414A-A908-55CA32CBC97C"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherInputColor
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetColor(out double hue, out double sat, out double luma);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetColor([In] double hue, [In] double sat, [In] double luma);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherInputColorCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherInputColorCallback callback);
	}
}
