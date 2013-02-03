using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("69B5183C-5A95-45BF-8CE9-93DD5D68FA0B"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKeyLuma
	{
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
		void GetReverse(out int reverse);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetReverse([In] int reverse);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherKeyLumaCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherKeyLumaCallback callback);
	}
}
