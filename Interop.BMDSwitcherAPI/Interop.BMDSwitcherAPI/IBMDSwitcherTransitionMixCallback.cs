using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("C361F9BA-FCFB-4541-BA6E-1285B0F66C10"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransitionMixCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RateChanged();
	}
}
