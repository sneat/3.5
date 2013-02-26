using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("3A82C121-18FA-469E-AE9A-73255356CA5B")]
	[InterfaceType(1)]
	public interface IBMDSwitcherMediaPlayerCallback
	{
		void AtBeginningChanged();

		void ClipFrameChanged();

		void LoopChanged();

		void PlayingChanged();

		void SourceChanged();
	}
}