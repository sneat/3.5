using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("1E8701D0-258F-43ED-9EDC-434FD16E922D")]
	[InterfaceType(1)]
	public interface IBMDSwitcher
	{
		void AddCallback([In] IBMDSwitcherCallback callback);

		void CreateIterator([In] ref Guid iid, out IntPtr ppv);

		void GetFlag([In] _BMDSwitcherPropertyId propertyId, out int value);

		void GetFloat([In] _BMDSwitcherPropertyId propertyId, out double value);

		void GetInt([In] _BMDSwitcherPropertyId propertyId, out long value);

		void GetString([In] _BMDSwitcherPropertyId propertyId, out string value);

		void RemoveCallback([In] IBMDSwitcherCallback callback);

		void SetFlag([In] _BMDSwitcherPropertyId propertyId, [In] int value);

		void SetFloat([In] _BMDSwitcherPropertyId propertyId, [In] double value);

		void SetInt([In] _BMDSwitcherPropertyId propertyId, [In] long value);

		void SetString([In] _BMDSwitcherPropertyId propertyId, [In] string value);
	}
}