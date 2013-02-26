using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("E89BD25E-FD04-4FBE-A124-CCAF5ADBE5B2")]
	[InterfaceType(1)]
	public interface IBMDSwitcherAudio
	{
		void GetBytes(out IntPtr buffer);

		int GetSize();
	}
}