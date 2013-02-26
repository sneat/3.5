using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("0F449A50-4083-49E8-BBF5-C3D95BFA1908")]
	[InterfaceType(1)]
	public interface IBMDSwitcherTransitionStingerParameters
	{
		void AddCallback([In] IBMDSwitcherTransitionStingerParametersCallback callback);

		void GetClip(out double clip);

		void GetClipDuration(out uint frames);

		void GetGain(out double gain);

		void GetInverse(out int inverse);

		void GetMixRate(out uint frames);

		void GetPreMultiplied(out int preMultiplied);

		void GetPreroll(out uint frames);

		void GetSource(out _BMDSwitcherStingerTransitionSource src);

		void GetTriggerPoint(out uint frames);

		void RemoveCallback([In] IBMDSwitcherTransitionStingerParametersCallback callback);

		void SetClip([In] double clip);

		void SetClipDuration([In] uint frames);

		void SetGain([In] double gain);

		void SetInverse([In] int inverse);

		void SetMixRate([In] uint frames);

		void SetPreMultiplied([In] int preMultiplied);

		void SetPreroll([In] uint frames);

		void SetSource([In] _BMDSwitcherStingerTransitionSource src);

		void SetTriggerPoint([In] uint frames);
	}
}