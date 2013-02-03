using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("FB243D87-88C9-48BF-A589-E78DEA12A5C4"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherInputColorCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ColorChanged();
	}
}
