using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("11974D55-45E0-49D8-AE06-EEF4D5F81DF6"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherMixEffectBlock
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void CreateIterator([In] ref Guid iid, out IntPtr ppv);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherMixEffectBlockCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoveCallback([MarshalAs(UnmanagedType.Interface)] [In] IBMDSwitcherMixEffectBlockCallback callback);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetFlag([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, [In] int value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetFlag([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, out int value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetInt([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, [In] long value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInt([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, out long value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetFloat([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, [In] double value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetFloat([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, out double value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetString([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, [MarshalAs(UnmanagedType.BStr)] [In] string value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetString([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, [MarshalAs(UnmanagedType.BStr)] out string value);
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PerformAutoTransition();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PerformCut();
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PerformFadeToBlack();
        // John Joy added below
        [MethodImpl(MethodImplOptions.InternalCall)]
        void GetPreviewTransition(out int previewing);
        [MethodImpl(MethodImplOptions.InternalCall)]
        void SetPreviewTransition([In] int previewing);
	}
}
