using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("BBEB91DA-6593-430F-B62F-355DF52C8ED8"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherInputAuxCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SourceChanged();
	}
}
