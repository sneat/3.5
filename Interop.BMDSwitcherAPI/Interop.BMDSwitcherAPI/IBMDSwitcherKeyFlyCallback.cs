using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("DB9371D3-2730-4239-B70C-C224AD8A4955"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKeyFlyCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void FlyChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void CanFlyChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PositionChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SizeChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RateChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RotationChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void KeyLocationStateChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RunningStateChanged();
	}
}
