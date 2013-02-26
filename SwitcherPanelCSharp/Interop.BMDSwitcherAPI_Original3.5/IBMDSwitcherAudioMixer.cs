using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("58739C15-063E-4FC1-B59B-CC3D9A012D99")]
	[InterfaceType(1)]
	public interface IBMDSwitcherAudioMixer
	{
		void AddCallback([In] IBMDSwitcherAudioMixerCallback callback);

		void CreateIterator([In] ref Guid iid, out IntPtr ppv);

		void GetProgramOutBalance(out double balance);

		void GetProgramOutGain(out double gain);

		void RemoveCallback([In] IBMDSwitcherAudioMixerCallback callback);

		void ResetAllLevelNotificationPeaks();

		void ResetProgramOutLevelNotificationPeaks();

		void SetAllLevelNotificationsEnable([In] int enable);

		void SetProgramOutBalance([In] double balance);

		void SetProgramOutGain([In] double gain);
	}
}