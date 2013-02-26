using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("B5240E1F-CE0A-4C38-9FAB-D7FAC227205A")]
	[InterfaceType(1)]
	public interface IBMDSwitcherMediaPlayer
	{
		void AddCallback([In] IBMDSwitcherMediaPlayerCallback callback);

		void GetAtBeginning(out int atBegining);

		void GetClipFrame(out uint clipFrameIndex);

		void GetLoop(out int loop);

		void GetPlaying(out int playing);

		void GetSource(out _BMDSwitcherMediaPlayerSourceType type, out uint index);

		void RemoveCallback([In] IBMDSwitcherMediaPlayerCallback callback);

		void SetAtBeginning();

		void SetClipFrame([In] uint clipFrameIndex);

		void SetLoop([In] int loop);

		void SetPlaying([In] int playing);

		void SetSource([In] _BMDSwitcherMediaPlayerSourceType type, [In] uint index);
	}
}