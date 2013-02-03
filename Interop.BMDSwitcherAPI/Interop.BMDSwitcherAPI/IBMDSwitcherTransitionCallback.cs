using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("D8806CC1-24AA-4A41-AEDC-787ADA479409"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransitionCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void TransitionTypeChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void NextTransitionTypeChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void TransitionLayersChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void NextTransitionLayersChanged();
	}
}
