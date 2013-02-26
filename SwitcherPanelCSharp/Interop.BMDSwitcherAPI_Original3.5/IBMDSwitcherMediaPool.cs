using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("D9B2A1E7-023E-42EC-96C9-5FFE28CE8399")]
	[InterfaceType(1)]
	public interface IBMDSwitcherMediaPool
	{
		void AddCallback([In] IBMDSwitcherMediaPoolCallback callback);

		void CreateAudio([In] uint sizeBytes, out IBMDSwitcherAudio audio);

		void CreateFrame([In] _BMDSwitcherPixelFormat pixelFormat, [In] uint width, [In] uint height, out IBMDSwitcherFrame frame);

		void GetClip([In] uint clipIndex, out IBMDSwitcherClip clip);

		void GetClipCount(out uint clipCount);

		void GetClipMaxFrameCounts([In] uint clipCount, out uint clipMaxFrameCounts);

		void GetFrameTotalForClips(out uint total);

		void GetStills(out IBMDSwitcherStills stills);

		void RemoveCallback([In] IBMDSwitcherMediaPoolCallback callback);

		void SetClipMaxFrameCounts([In] uint clipCount, [In] ref uint clipMaxFrameCounts);
	}
}