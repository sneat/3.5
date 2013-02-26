using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("B8617A16-1B17-4FD6-93BF-664FA71F2A50")]
	[InterfaceType(1)]
	public interface IBMDSwitcherMediaPoolCallback
	{
		void ClipFrameMaxCountsChanged();

		void FrameTotalForClipsChanged();
	}
}