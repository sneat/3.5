using System;

namespace BMDSwitcherAPI
{
	public enum _BMDSwitcherExternalPortType
	{
		bmdSwitcherExternalPortTypeSDI = 1,
		bmdSwitcherExternalPortTypeHDMI = 2,
		bmdSwitcherExternalPortTypeComponent = 4,
		bmdSwitcherExternalPortTypeComposite = 8,
		bmdSwitcherExternalPortTypeSVideo = 16,
		bmdSwitcherExternalPortTypeInternal = 32
	}
}