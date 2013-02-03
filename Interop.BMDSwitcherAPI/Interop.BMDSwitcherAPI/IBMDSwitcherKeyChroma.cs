using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("578B28ED-9755-4550-923A-48C669C25FF5"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKeyChroma
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetHue(out double hue);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetHue([In] double hue);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetGain(out double gain);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetGain([In] double gain);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetYSuppress(out double ySuppress);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetYSuppress([In] double ySuppress);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetLift(out double lift);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetLift([In] double lift);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetNarrow(out int narrow);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetNarrow([In] int narrow);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherKeyChromaCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherKeyChromaCallback callback);
	}
}
