using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("EFD545AE-2879-412B-84B7-17A04E4707ED")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKeyIterator
	{
		void Next(out IBMDSwitcherKey key);
	}
}