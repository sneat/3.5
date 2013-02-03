using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("96010829-2029-4DA3-A34B-70368605ABAA"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherMixEffectBlockCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PropertyChanged([In] _BMDSwitcherMixEffectBlockPropertyId propertyId);
	}
}
