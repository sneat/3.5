using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("88C0C89F-5017-4DF5-A6C0-1859D7FC4481"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKeyDVECallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void EnabledChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ShadowChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void BevelChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void WidthChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SoftChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void BevelSoftChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void BevelPositionChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void OpacityChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ColorChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void LightChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void MaskedChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void MaskPropertiesChanged();
	}
}
