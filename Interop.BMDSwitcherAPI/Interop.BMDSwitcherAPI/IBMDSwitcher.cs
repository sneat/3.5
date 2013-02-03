using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("1E8701D0-258F-43ED-9EDC-434FD16E922D"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcher
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void CreateIterator([In] ref Guid iid, out IntPtr ppv);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetFlag([In] _BMDSwitcherPropertyId propertyId, [In] int value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetFlag([In] _BMDSwitcherPropertyId propertyId, out int value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetInt([In] _BMDSwitcherPropertyId propertyId, [In] long value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInt([In] _BMDSwitcherPropertyId propertyId, out long value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetFloat([In] _BMDSwitcherPropertyId propertyId, [In] double value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetFloat([In] _BMDSwitcherPropertyId propertyId, out double value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetString([In] _BMDSwitcherPropertyId propertyId, [MarshalAs(UnmanagedType.BStr)] [In] string value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetString([In] _BMDSwitcherPropertyId propertyId, [MarshalAs(UnmanagedType.BStr)] out string value);
	}
}
