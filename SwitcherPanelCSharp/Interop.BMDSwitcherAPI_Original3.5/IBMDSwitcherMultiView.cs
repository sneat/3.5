using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("231AA55F-EC1D-4FFF-ACE7-3806BA7894BB")]
	[InterfaceType(1)]
	public interface IBMDSwitcherMultiView
	{
		void AddCallback([In] IBMDSwitcherMultiViewCallback callback);

		void CanRouteInputs(out int canRoute);

		void GetInputAvailabilityMask(out _BMDSwitcherInputAvailability availabilityMask);

		void GetLayout(out _BMDSwitcherMultiViewLayout layout);

		void GetWindowCount(out uint windowCount);

		void GetWindowInput([In] uint window, out long input);

		void RemoveCallback([In] IBMDSwitcherMultiViewCallback callback);

		void SetLayout([In] _BMDSwitcherMultiViewLayout layout);

		void SetWindowInput([In] uint window, [In] long input);
	}
}