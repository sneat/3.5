using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("87B99021-FA29-4720-9526-4512CA553858")]
	[InterfaceType(1)]
	public interface IBMDSwitcherAudioInput
	{
		void AddCallback([In] IBMDSwitcherAudioInputCallback callback);

		void GetAudioInputId(out long audioInputId);

		void GetBalance(out double balance);

		void GetGain(out double gain);

		void GetMixOption(out _BMDSwitcherAudioMixOption mixOption);

		void GetType(out _BMDSwitcherAudioInputType type);

		void IsMixedIn(out int mixedIn);

		void RemoveCallback([In] IBMDSwitcherAudioInputCallback callback);

		void ResetLevelNotificationPeaks();

		void SetBalance([In] double balance);

		void SetGain([In] double gain);

		void SetMixOption([In] _BMDSwitcherAudioMixOption mixOption);
	}
}