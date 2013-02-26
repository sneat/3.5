using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("6C6E4441-9421-4729-9951-988659E3A44A")]
	[InterfaceType(1)]
	public interface IBMDSwitcherCallback
	{
		void Disconnected();

		void PropertyChanged([In] _BMDSwitcherPropertyId propertyId);
	}
}