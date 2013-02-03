using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("96F32AE8-9936-49C8-ABDC-EC2C839605FD"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransitionStingerCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SourceChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ShapedChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClipChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GainChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ReversedChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PrerollChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ClipDurationChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void TriggerPointChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void MixRateChanged();
	}
}
