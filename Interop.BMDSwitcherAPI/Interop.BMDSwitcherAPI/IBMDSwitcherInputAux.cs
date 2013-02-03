// Type: BMDSwitcherAPI.IBMDSwitcherInputAux
// Assembly: Interop.BMDSwitcherAPI, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Assembly location: C:\Users\Frank\Downloads\QuickAUXDemo\bin\Debug\Interop.BMDSwitcherAPI.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
    [Guid("9B4B828A-B127-4FB8-9870-58547C869747")]
    [InterfaceType((short)1)]
    [ComImport]
    public interface IBMDSwitcherInputAux
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        void GetSource(out long input);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void SetSource([In] long input);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void GetInputAvailabilityMask(out _BMDSwitcherInputAvailability availabilityMask);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void AddCallback([MarshalAs(UnmanagedType.Interface), In] IBMDSwitcherInputAuxCallback callback);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void RemoveCallback([MarshalAs(UnmanagedType.Interface), In] IBMDSwitcherInputAuxCallback callback);
    }
}
