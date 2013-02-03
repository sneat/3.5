using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("B8617A16-1B17-4FD6-93BF-664FA71F2A50"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherMediaPoolCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void StillChanged([In] uint stillIndex);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClipFrameChanged([In] uint clipIndex, [In] uint frameIndex);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClipChanged([In] uint clipIndex);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClipFrameCountsChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void NumClipFramesChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void TrackChanged([In] uint trackIndex);
	}
}
