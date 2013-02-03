using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("7C8B477A-6BE3-4E85-B8EE-BE58BEC28958"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherSaveRecall
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
        void Save([In] _BMDSwitcherSaveRecallType type);
		[MethodImpl(MethodImplOptions.InternalCall)]
        void Clear([In] _BMDSwitcherSaveRecallType type);
	}
}
