using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("A203DA24-9910-450C-AA6A-9AA05C5C856E")]
	[InterfaceType(1)]
	public interface IBMDSwitcherAudioMixerCallback
	{
		void Notify([In] _BMDSwitcherAudioMixerEventType eventType);

		void ProgramOutLevelNotification([In] double left, [In] double right, [In] double peakLeft, [In] double peakRight);
	}
}