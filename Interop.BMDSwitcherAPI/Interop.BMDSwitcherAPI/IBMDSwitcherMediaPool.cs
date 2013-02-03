using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("7435E055-4C24-4386-9ECA-1B08F33CE8B6"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherMediaPool
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
        void CreateFrame([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherFrame frame, [MarshalAs(UnmanagedType.BStr)] [In] string name, [In] ref Guid uuid, [In] _BMDSwitcherPixelFormat pixelFormat, [In] ref byte pixelData, [In] uint width, [In] uint height);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetNumStills(out uint stills);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetStillProperties([In] uint stillIndex, [MarshalAs(UnmanagedType.BStr)] out string name, out Guid uuid, out int valid);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void DownloadStill([In] uint stillIndex, [MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherTransfer transfer);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void UploadStill([In] uint stillIndex, [MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherFrame frame, [MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherTransfer transfer);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetNumClips(out uint clips);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetClipProperties([In] uint clipIndex, [MarshalAs(UnmanagedType.BStr)] out string name, out int valid, out uint frameCount);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClearClip([In] uint clipIndex);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetClip([In] uint clipIndex, [MarshalAs(UnmanagedType.BStr)] [In] string name, [In] uint frameCount);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetClipFrameProperties([In] uint clipIndex, [In] uint frameIndex, out Guid uuid, out int valid);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void DownloadClipFrame([In] uint clipIndex, [In] uint frameIndex, [MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherTransfer transfer);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void UploadClipFrame([In] uint clipIndex, [In] uint frameIndex, [MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherFrame still, [MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherTransfer transfer);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetNumClipFrames(out uint count);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetClipFrameCount(out uint mediaPlayer1Clips, out uint mediaPlayer2Clips);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetClipFrameCount([In] uint mediaPlayer1Clips);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetNumTracks(out uint tracks);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetTrackProperties([In] uint trackIndex, [MarshalAs(UnmanagedType.BStr)] out string name, out Guid uuid, out int valid);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void DownloadTrack([In] uint trackIndex, [MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherTransfer transfer);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void UploadTrack([In] uint trackIndex, [MarshalAs(UnmanagedType.BStr)] [In] string name, [In] ref Guid uuid, [In] ref byte audioData, [In] uint audioDataBytes, [MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherTransfer transfer);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClearTrack([In] uint trackIndex);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherMediaPoolCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherMediaPoolCallback callback);
	}
}
