using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("6EC13FEC-A4AE-4089-98E7-69570F4C7B2F"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKeyChromaCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void HueChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GainChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void YSuppressChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void LiftChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void NarrowChanged();
	}
}
