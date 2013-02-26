using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("918E234D-67C1-452F-80A0-DB39FE6BCB21")]
	[InterfaceType(1)]
	public interface IBMDSwitcherKey
	{
		void AddCallback([In] IBMDSwitcherKeyCallback callback);

		void CanBeDVEKey(out int canDVE);

		void GetInputCut(out long input);

		void GetInputFill(out long input);

		void GetMaskBottom(out double bottom);

		void GetMasked(out int maskEnabled);

		void GetMaskLeft(out double left);

		void GetMaskRight(out double right);

		void GetMaskTop(out double top);

		void GetOnAir(out int onAir);

		void GetTransitionSelectionMask(out _BMDSwitcherTransitionSelection selectionMask);

		void GetType(out _BMDSwitcherKeyType type);

		void RemoveCallback([In] IBMDSwitcherKeyCallback callback);

		void ResetMask();

		void SetInputCut([In] long input);

		void SetInputFill([In] long input);

		void SetMaskBottom([In] double bottom);

		void SetMasked([In] int maskEnabled);

		void SetMaskLeft([In] double left);

		void SetMaskRight([In] double right);

		void SetMaskTop([In] double top);

		void SetOnAir([In] int onAir);

		void SetType([In] _BMDSwitcherKeyType type);
	}
}