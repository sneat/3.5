using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("11974D55-45E0-49D8-AE06-EEF4D5F81DF6")]
	[InterfaceType(1)]
	public interface IBMDSwitcherMixEffectBlock
	{
		void AddCallback([In] IBMDSwitcherMixEffectBlockCallback callback);

		void CreateIterator([In] ref Guid iid, out IntPtr ppv);

		void GetFlag([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, out int value);

		void GetFloat([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, out double value);

		void GetInt([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, out long value);

		void GetString([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, out string value);

		void PerformAutoTransition();

		void PerformCut();

		void PerformFadeToBlack();

		void RemoveCallback([In] IBMDSwitcherMixEffectBlockCallback callback);

		void SetFlag([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, [In] int value);

		void SetFloat([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, [In] double value);

		void SetInt([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, [In] long value);

		void SetString([In] _BMDSwitcherMixEffectBlockPropertyId propertyId, [In] string value);
	}
}