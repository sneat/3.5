using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("D1D85AB1-B491-4BCB-BC31-4CCE750AE18C"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKeyFly
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetFly(out int isFlyKey);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetFly([In] int isFlyKey);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetCanFly(out int canFly);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetRate(out uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetRate([In] uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetSize(out double multiplierX, out double multiplierY);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetSize([In] double multiplierX, [In] double multiplierY);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetPosition(out double offsetX, out double offsetY);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetPosition([In] double offsetX, [In] double offsetY);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetRotation(out double degrees);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetRotation([In] double degrees);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RunToFull();
		[MethodImpl(MethodImplOptions.InternalCall)]
        void RunToLocation([In] _BMDSwitcherKeyFlyLocation location);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void HasKeyLocation([In] _BMDSwitcherKeyFlyLocation location, out int hasLocation);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void SetKeyLocation([In] _BMDSwitcherKeyFlyLocation location);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void GetCurrentLocation(out _BMDSwitcherKeyFlyLocation location);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void IsRunning(out int IsRunning, out _BMDSwitcherKeyFlyLocation destination);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetRotation();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetDVE();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ResetDVEFull();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherKeyFlyCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherKeyFlyCallback callback);
	}
}
