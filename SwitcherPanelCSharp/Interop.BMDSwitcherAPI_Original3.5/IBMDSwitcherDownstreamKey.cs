using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("6D10D51E-71FA-4031-BC13-95BE3653D0E6")]
	[InterfaceType(1)]
	public interface IBMDSwitcherDownstreamKey
	{
		void AddCallback([In] IBMDSwitcherDownstreamKeyCallback callback);

		void GetClip(out double clip);

		void GetFramesRemaining(out uint framesRemaining);

		void GetGain(out double gain);

		void GetInputAvailabilityMask(out _BMDSwitcherInputAvailability availabilityMask);

		void GetInputCut(out long input);

		void GetInputFill(out long input);

		void GetInverse([In] ref int inverse);

		void GetMaskBottom(out double bottom);

		void GetMasked(out int maskEnabled);

		void GetMaskLeft(out double left);

		void GetMaskRight(out double right);

		void GetMaskTop(out double top);

		void GetOnAir(out int onAir);

		void GetPreMultiplied(out int preMultiplied);

		void GetRate(out uint frames);

		void GetTie(out int tie);

		void IsAutoTransitioning(out int IsAutoTransitioning);

		void IsTransitioning(out int IsTransitioning);

		void PerformAutoTransition();

		void RemoveCallback([In] IBMDSwitcherDownstreamKeyCallback callback);

		void ResetMask();

		void SetClip([In] double clip);

		void SetGain([In] double gain);

		void SetInputCut([In] long input);

		void SetInputFill([In] long input);

		void SetInverse([In] int inverse);

		void SetMaskBottom([In] double bottom);

		void SetMasked([In] int maskEnabled);

		void SetMaskLeft([In] double left);

		void SetMaskRight([In] double right);

		void SetMaskTop([In] double top);

		void SetOnAir([In] int onAir);

		void SetPreMultiplied([In] int preMultiplied);

		void SetRate([In] uint frames);

		void SetTie([In] int tie);
	}
}