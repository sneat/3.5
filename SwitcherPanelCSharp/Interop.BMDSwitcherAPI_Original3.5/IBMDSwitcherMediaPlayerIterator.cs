using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("E910816F-59CB-4224-A77F-06DE3D232275")]
	[InterfaceType(1)]
	public interface IBMDSwitcherMediaPlayerIterator
	{
		void Next(out IBMDSwitcherMediaPlayer mediaPlayer);
	}
}