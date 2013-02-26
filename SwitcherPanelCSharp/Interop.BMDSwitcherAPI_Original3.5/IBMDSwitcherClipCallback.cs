using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("407117B4-B6A8-46D2-9911-43254171B1B7")]
	[InterfaceType(1)]
	public interface IBMDSwitcherClipCallback
	{
		void Notify([In] _BMDSwitcherMediaPoolEventType eventType, [In] IBMDSwitcherFrame frame, [In] int frameIndex, [In] IBMDSwitcherAudio audio, [In] int clipIndex);
	}
}