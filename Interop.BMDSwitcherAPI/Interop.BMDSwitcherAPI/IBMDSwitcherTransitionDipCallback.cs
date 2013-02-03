using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("332CFB9C-B6EB-4899-B8FC-7C0B8AD9C834"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransitionDipCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RateChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void InputDipChanged();
	}
}
