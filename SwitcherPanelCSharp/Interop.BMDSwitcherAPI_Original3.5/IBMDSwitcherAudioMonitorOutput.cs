using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("21E041C3-6C69-4A95-A6CC-AE7A57257407")]
	[InterfaceType(1)]
	public interface IBMDSwitcherAudioMonitorOutput
	{
		void AddCallback([In] IBMDSwitcherAudioMonitorOutputCallback callback);

		void GetDim(out int dim);

		void GetDimLevel(out double gain);

		void GetGain(out double gain);

		void GetMonitorEnable(out int enable);

		void GetMute(out int mute);

		void GetSolo(out int solo);

		void GetSoloInput(out long audioInput);

		void RemoveCallback([In] IBMDSwitcherAudioMonitorOutputCallback callback);

		void ResetLevelNotificationPeaks();

		void SetDim([In] int dim);

		void SetDimLevel([In] double gain);

		void SetGain([In] double gain);

		void SetMonitorEnable([In] int enable);

		void SetMute([In] int mute);

		void SetSolo([In] int solo);

		void SetSoloInput([In] long audioInput);
	}
}