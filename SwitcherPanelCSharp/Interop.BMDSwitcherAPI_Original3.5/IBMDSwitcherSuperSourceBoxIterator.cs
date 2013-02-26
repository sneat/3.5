using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("96153CDA-C894-42EA-BA90-C387018CC334")]
	[InterfaceType(1)]
	public interface IBMDSwitcherSuperSourceBoxIterator
	{
		void Next(out IBMDSwitcherSuperSourceBox box);
	}
}