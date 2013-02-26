using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("66F3D466-8C8C-4DB4-B313-8DD2EC665DBB")]
	[InterfaceType(1)]
	public interface IBMDSwitcherInput
	{
		void AddCallback([In] IBMDSwitcherInputCallback callback);

		void GetFlag([In] _BMDSwitcherInputPropertyId propertyId, out int value);

		void GetFloat([In] _BMDSwitcherInputPropertyId propertyId, out double value);

		void GetInputId(out long inputId);

		void GetInt([In] _BMDSwitcherInputPropertyId propertyId, out long value);

		void GetString([In] _BMDSwitcherInputPropertyId propertyId, out string value);

		void RemoveCallback([In] IBMDSwitcherInputCallback callback);

		void SetFlag([In] _BMDSwitcherInputPropertyId propertyId, [In] int value);

		void SetFloat([In] _BMDSwitcherInputPropertyId propertyId, [In] double value);

		void SetInt([In] _BMDSwitcherInputPropertyId propertyId, [In] long value);

		void SetString([In] _BMDSwitcherInputPropertyId propertyId, [In] string value);
	}
}