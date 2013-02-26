using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("FD063042-B7FD-4819-BD1E-809DC380DFE9")]
	[InterfaceType(1)]
	public interface IBMDSwitcherDownstreamKeyIterator
	{
		void Next(out IBMDSwitcherDownstreamKey downstreamKey);
	}
}