using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("5428AEE8-4357-4523-ACD0-74F4252344F8"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKeyCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void TypeChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void InputCutChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void InputFillChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void MaskedChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void MaskPropertiesChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void OnAirChanged();
	}
}
