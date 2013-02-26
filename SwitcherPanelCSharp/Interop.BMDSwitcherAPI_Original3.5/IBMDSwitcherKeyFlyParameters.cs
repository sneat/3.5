using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("C522E970-DDB1-4027-B492-F52C1DFA5D09")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKeyFlyParameters
	{
		void AddCallback([In] IBMDSwitcherKeyFlyParametersCallback callback);

		void GetCanFly(out int canFly);

		void GetFly(out int isFlyKey);

		void GetPositionX(out double offsetX);

		void GetPositionY(out double offsetY);

		void GetRate(out uint frames);

		void GetRotation(out double degrees);

		void GetSizeX(out double multiplierX);

		void GetSizeY(out double multiplierY);

		void IsAtKeyFrames(out _BMDSwitcherFlyKeyFrame keyFrames);

		void IsKeyFrameStored([In] _BMDSwitcherFlyKeyFrame keyFrame, out int stored);

		void IsRunning(out int IsRunning, out _BMDSwitcherFlyKeyFrame destination);

		void RemoveCallback([In] IBMDSwitcherKeyFlyParametersCallback callback);

		void ResetDVE();

		void ResetDVEFull();

		void ResetRotation();

		void RunToKeyFrame([In] _BMDSwitcherFlyKeyFrame destination);

		void SetFly([In] int isFlyKey);

		void SetPositionX([In] double offsetX);

		void SetPositionY([In] double offsetY);

		void SetRate([In] uint frames);

		void SetRotation([In] double degrees);

		void SetSizeX([In] double multiplierX);

		void SetSizeY([In] double multiplierY);

		void StoreAsKeyFrame([In] _BMDSwitcherFlyKeyFrame keyFrame);
	}
}