using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("6680C4D9-5981-49DB-8C95-5DDB36405539"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherTransitionWipeCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RateChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PatternChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void BorderSizeChanged();
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
		[MethodImpl(MethodImplOptions.InternalCall)]
		void FlipFlopChanged();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void InputBorderChanged();
	}
}
