using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("26E05D77-EFB9-4253-86D8-2F1E82E462F6")]
	[InterfaceType(1)]
	public interface IBMDSwitcherAudioInputCallback
	{
		void LevelNotification([In] double left, [In] double right, [In] double peakLeft, [In] double peakRight);

		void Notify([In] _BMDSwitcherAudioInputEventType eventType);
	}
}