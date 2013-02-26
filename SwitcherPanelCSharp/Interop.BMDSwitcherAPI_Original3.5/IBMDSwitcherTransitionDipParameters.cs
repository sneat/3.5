using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("DACC2FF3-6B54-4459-AAA6-2B1EA2D6887A")]
	[InterfaceType(1)]
	public interface IBMDSwitcherTransitionDipParameters
	{
		void AddCallback([In] IBMDSwitcherTransitionDipParametersCallback callback);

		void GetInputDip(out long input);

		void GetRate(out uint frames);

		void RemoveCallback([In] IBMDSwitcherTransitionDipParametersCallback callback);

		void SetInputDip([In] long input);

		void SetRate([In] uint frames);
	}
}