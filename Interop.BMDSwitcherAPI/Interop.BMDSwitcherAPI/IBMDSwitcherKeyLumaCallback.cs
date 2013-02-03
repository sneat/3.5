using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("6FF1CDFC-E4F7-4B95-ADC2-E1D9126F3D28"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKeyLumaCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ShapedChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClipChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GainChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ReverseChanged();
	}
}
