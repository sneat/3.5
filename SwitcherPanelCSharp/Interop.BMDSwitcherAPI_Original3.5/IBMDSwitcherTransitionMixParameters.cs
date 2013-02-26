using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("4C5D18C9-0955-4525-9947-527EA0679140")]
	[InterfaceType(1)]
	public interface IBMDSwitcherTransitionMixParameters
	{
		void AddCallback([In] IBMDSwitcherTransitionMixParametersCallback callback);

		void GetRate(out uint frames);

		void RemoveCallback([In] IBMDSwitcherTransitionMixParametersCallback callback);

		void SetRate([In] uint frames);
	}
}