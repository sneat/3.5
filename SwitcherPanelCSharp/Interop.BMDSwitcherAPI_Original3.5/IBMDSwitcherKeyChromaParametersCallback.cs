using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("FE3F97EC-5F2D-4E47-AA7A-38962F9CB3CE")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKeyChromaParametersCallback
	{
		void Notify([In] _BMDSwitcherKeyChromaParametersEventType eventType);
	}
}