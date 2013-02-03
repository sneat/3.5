using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("66F3D466-8C8C-4DB4-B313-8DD2EC665DBB"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherInput
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherInputCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherInputCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetFlag([In] _BMDSwitcherInputPropertyId propertyId, [In] int value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetFlag([In] _BMDSwitcherInputPropertyId propertyId, out int value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetInt([In] _BMDSwitcherInputPropertyId propertyId, [In] long value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInt([In] _BMDSwitcherInputPropertyId propertyId, out long value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetFloat([In] _BMDSwitcherInputPropertyId propertyId, [In] double value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetFloat([In] _BMDSwitcherInputPropertyId propertyId, out double value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetString([In] _BMDSwitcherInputPropertyId propertyId, [MarshalAs(UnmanagedType.BStr)] [In] string value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetString([In] _BMDSwitcherInputPropertyId propertyId, [MarshalAs(UnmanagedType.BStr)] out string value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInputId(out long inputId);
	}
}
