using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("FBF24499-06EB-4C54-BE92-21C403C1093C")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKeyPatternParametersCallback
	{
		void Notify([In] _BMDSwitcherKeyPatternParametersEventType eventType);
	}
}