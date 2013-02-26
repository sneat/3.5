using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("DED1876A-38E3-418E-8044-F3C126C626E7")]
	[InterfaceType(1)]
	public interface IBMDSwitcherTransitionParametersCallback
	{
		void Notify([In] _BMDSwitcherTransitionParametersEventType eventType);
	}
}