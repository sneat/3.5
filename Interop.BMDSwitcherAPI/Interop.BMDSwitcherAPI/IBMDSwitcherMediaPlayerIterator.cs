using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace BMDSwitcherAPI
{
	[Guid("E910816F-59CB-4224-A77F-06DE3D232275"), InterfaceType(1)]
	[ComImport]
	public interface IBMDSwitcherMediaPlayerIterator
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Next([MarshalAs(UnmanagedType.Interface)] out IBMDSwitcherMediaPlayer mediaPlayer);
	}
}
