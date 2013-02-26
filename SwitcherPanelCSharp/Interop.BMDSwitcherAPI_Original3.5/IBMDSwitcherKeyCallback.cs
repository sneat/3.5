using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("1972E4DF-1D5F-4C4E-A79B-E5A6E8CE1511")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKeyCallback
	{
		void Notify([In] _BMDSwitcherKeyEventType eventType);
	}
}