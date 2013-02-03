using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("26ED4A24-E7D8-4367-AF76-6BD8029AB318"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherKeyPatternCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PatternChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SizeChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SymmetryChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SoftChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void HorizontalOffsetChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void VerticalOffsetChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ReverseChanged();
	}
}
