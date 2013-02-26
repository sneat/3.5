using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("AB31E347-5177-4595-8E52-650BF9B08B7F")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKeyLumaParametersCallback
	{
		void Notify([In] _BMDSwitcherKeyLumaParametersEventType eventType);
	}
}