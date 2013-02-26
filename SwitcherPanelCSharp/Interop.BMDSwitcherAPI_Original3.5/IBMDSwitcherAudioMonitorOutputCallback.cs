using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("CB5EFB16-0474-4FAA-B071-17FA0DADD19F")]
	[InterfaceType(1)]
	public interface IBMDSwitcherAudioMonitorOutputCallback
	{
		void LevelNotification([In] double left, [In] double right, [In] double peakLeft, [In] double peakRight);

		void Notify([In] _BMDSwitcherAudioMonitorOutputEventType eventType);
	}
}