using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("137028E5-87B2-407E-846F-283B18C82CE9")]
	[InterfaceType(1)]
	public interface IBMDSwitcherSuperSourceBox
	{
		void AddCallback([In] IBMDSwitcherSuperSourceBoxCallback callback);

		void GetCropBottom(out double bottom);

		void GetCropLeft(out double left);

		void GetCropped(out int cropped);

		void GetCropRight(out double right);

		void GetCropTop(out double top);

		void GetEnabled(out int enabled);

		void GetInputAvailabilityMask([In] ref _BMDSwitcherInputAvailability mask);

		void GetInputSource(out long input);

		void GetPositionX(out double positionX);

		void GetPositionY(out double positionY);

		void GetSize(out double size);

		void RemoveCallback([In] IBMDSwitcherSuperSourceBoxCallback callback);

		void ResetCrop();

		void SetCropBottom([In] double bottom);

		void SetCropLeft([In] double left);

		void SetCropped([In] int cropped);

		void SetCropRight([In] double right);

		void SetCropTop([In] double top);

		void SetEnabled([In] int enabled);

		void SetInputSource([In] long input);

		void SetPositionX([In] double positionX);

		void SetPositionY([In] double positionY);

		void SetSize([In] double size);
	}
}