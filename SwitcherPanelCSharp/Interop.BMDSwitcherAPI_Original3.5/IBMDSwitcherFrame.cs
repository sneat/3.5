using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("35A1F6A6-D317-4F89-A565-0F0BD414CF77")]
	[InterfaceType(1)]
	public interface IBMDSwitcherFrame
	{
		void GetBytes(out IntPtr buffer);

		int GetHeight();

		_BMDSwitcherPixelFormat GetPixelFormat();

		int GetRowBytes();

		int GetWidth();
	}
}