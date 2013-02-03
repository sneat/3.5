using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("4CA9A05E-3439-4AB6-922C-2C1136DD1441"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransitionStinger
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
        void GetSource(out _BMDSwitcherStingerTransitionSource src);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void SetSource([In] _BMDSwitcherStingerTransitionSource src);
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
		void GetPreroll(out uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetPreroll([In] uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetClipDuration(out uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetClipDuration([In] uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetTriggerPoint(out uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetTriggerPoint([In] uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetMixRate(out uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetMixRate([In] uint frames);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherTransitionStingerCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherTransitionStingerCallback callback);
	}
}
