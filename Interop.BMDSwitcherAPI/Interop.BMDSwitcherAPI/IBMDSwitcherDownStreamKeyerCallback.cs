using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("2DD00D46-7A9C-4E0F-83C9-2299254B6C4C"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherDownStreamKeyerCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void TransitionStateChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void OnAirChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void InputCutChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void InputFillChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void TieChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RateChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClipChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GainChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ReverseChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ShapedChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void MaskedChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void MaskPropertiesChanged();
	}
}
