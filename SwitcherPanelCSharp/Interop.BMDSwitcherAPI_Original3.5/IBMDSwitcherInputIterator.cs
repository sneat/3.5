using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("92AB7A73-C6F6-47FC-92A7-C8EEADC9EAAC")]
	[InterfaceType(1)]
	public interface IBMDSwitcherInputIterator
	{
		void GetById([In] long inputId, out IBMDSwitcherInput input);

		void Next(out IBMDSwitcherInput input);
	}
}