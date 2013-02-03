using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("5AC62BE7-5305-4522-A671-3BB8778D024B"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransitionDVECallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RateChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void LogoRateChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ReverseChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void FlipFlopChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void StyleChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void InputFillChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void InputCutChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void EnableKeyChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ShapedChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClipChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GainChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ReversedChanged();
	}
}
