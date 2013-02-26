using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("C76BAC6A-DFEE-4F2F-B161-226B481D556A")]
	[InterfaceType(1)]
	public interface IBMDSwitcherAudioMonitorOutputIterator
	{
		void Next(out IBMDSwitcherAudioMonitorOutput audioMonitorOutput);
	}
}