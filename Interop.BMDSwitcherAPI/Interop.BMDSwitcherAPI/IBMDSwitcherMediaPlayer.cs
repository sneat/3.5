using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("FABA1B78-E556-49FB-BFD7-FA44BD4AFF97"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherMediaPlayer
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
        void GetSourceType(out _BMDSwitcherMediaPlayerSourceType type);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void SetSourceType([In] _BMDSwitcherMediaPlayerSourceType type);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetStillIndex(out uint stillIndex);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetStillIndex([In] uint stillIndex);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetClipIndex(out uint clipIndex);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetClipIndex([In] uint clipIndex);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetPlaying(out int playing);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetPlaying([In] int playing);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetLoop(out int loop);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetLoop([In] int loop);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetAtBeginning(out int atBeggining);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetAtBeginning([In] int atBeggining);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetClipFrame(out uint clipFrameIndex);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetClipFrame([In] uint clipFrameIndex);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherMediaPlayerCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherMediaPlayerCallback callback);
	}
}
