using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("3CC10CA1-3E13-4C69-9FFC-A37A62B05869")]
	[InterfaceType(1)]
	public interface IBMDSwitcherClip
	{
		void AddCallback([In] IBMDSwitcherClipCallback callback);

		void CancelTransfer();

		void DownloadAudio();

		void DownloadFrame([In] uint frameIndex);

		void GetAudioHash([ComAliasName("BMDSwitcherAPI.BMDSwitcherHash")] out BMDSwitcherHash hash);

		void GetAudioName(out string name);

		void GetFrameCount(out uint frameCount);

		void GetFrameHash([In] uint frameIndex, [ComAliasName("BMDSwitcherAPI.BMDSwitcherHash")] out BMDSwitcherHash hash);

		void GetIndex(out uint index);

		void GetMaxFrameCount(out uint maxFrameCount);

		void GetName(out string name);

		void GetProgress(out double progress);

		void IsAudioValid(out int valid);

		void IsFrameValid([In] uint frameIndex, out int valid);

		void IsValid(out int valid);

		void Lock([In] IBMDSwitcherLockCallback lockCallback);

		void RemoveCallback([In] IBMDSwitcherClipCallback callback);

		void SetAudioInvalid();

		void SetInvalid();

		void SetValid([In] string name, [In] uint frameCount);

		void Unlock([In] IBMDSwitcherLockCallback lockCallback);

		void UploadAudio([In] string name, [In] IBMDSwitcherAudio audio);

		void UploadFrame([In] uint frameIndex, [In] IBMDSwitcherFrame frame);
	}
}