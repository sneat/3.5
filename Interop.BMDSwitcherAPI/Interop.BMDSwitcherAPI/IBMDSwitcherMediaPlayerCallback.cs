using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("3A82C121-18FA-469E-AE9A-73255356CA5B"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherMediaPlayerCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SourceTypeChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void StillIndexChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClipIndexChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PlayingChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void LoopChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AtBeginningChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClipFrameChanged();
	}
}
