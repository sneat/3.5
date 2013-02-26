using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("6B02A84C-0085-4593-973A-5E458079BD16")]
	[InterfaceType(1)]
	public interface IBMDSwitcherInputSuperSourceCallback
	{
		void Notify([In] _BMDSwitcherInputSuperSourceEventType eventType);
	}
}