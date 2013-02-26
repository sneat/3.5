using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("0194C65A-3EDA-4853-A6D3-D59CD12B3C0A")]
	[InterfaceType(1)]
	public interface IBMDSwitcherAudioInputIterator
	{
		void GetById([In] long audioInputId, out IBMDSwitcherAudioInput audioInput);

		void Next(out IBMDSwitcherAudioInput audioInput);
	}
}