using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("8E583D89-0BAF-4447-AB8C-6A12CD8724CB"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherInputCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PropertyChanged([In] _BMDSwitcherInputPropertyId propertyId);
	}
}
