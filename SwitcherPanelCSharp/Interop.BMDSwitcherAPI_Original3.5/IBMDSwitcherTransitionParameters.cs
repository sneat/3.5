using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("83755CE5-748B-4E49-A856-AC95B8CCD215")]
	[InterfaceType(1)]
	public interface IBMDSwitcherTransitionParameters
	{
		void AddCallback([In] IBMDSwitcherTransitionParametersCallback callback);

		void GetNextTransitionSelection(out _BMDSwitcherTransitionSelection selection);

		void GetNextTransitionStyle(out _BMDSwitcherTransitionStyle style);

		void GetTransitionSelection(out _BMDSwitcherTransitionSelection selection);

		void GetTransitionStyle(out _BMDSwitcherTransitionStyle style);

		void RemoveCallback([In] IBMDSwitcherTransitionParametersCallback callback);

		void SetNextTransitionSelection([In] _BMDSwitcherTransitionSelection selection);

		void SetNextTransitionStyle([In] _BMDSwitcherTransitionStyle style);
	}
}