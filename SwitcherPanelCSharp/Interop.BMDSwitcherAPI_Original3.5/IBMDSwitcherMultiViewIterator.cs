using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("51FED981-C2AD-45A2-8618-61429CEED48D")]
	[InterfaceType(1)]
	public interface IBMDSwitcherMultiViewIterator
	{
		void Next(out IBMDSwitcherMultiView multiView);
	}
}