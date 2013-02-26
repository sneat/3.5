using System;
using System.Runtime.InteropServices;

namespace BMDSwitcherAPI
{
	[Guid("AA26D656-2400-407B-8D3C-796B506F99DB")]
	[InterfaceType(1)]
	public interface IBMDSwitcherStills
	{
		void AddCallback([In] IBMDSwitcherStillsCallback callback);

		void CancelTransfer();

		void Download([In] uint index);

		void GetCount(out uint count);

		void GetHash([In] uint index, [ComAliasName("BMDSwitcherAPI.BMDSwitcherHash")] out BMDSwitcherHash hash);

		void GetName([In] uint index, out string name);

		void GetProgress(out double progress);

		void IsValid([In] uint index, out int valid);

		void Lock([In] IBMDSwitcherLockCallback lockCallback);

		void RemoveCallback([In] IBMDSwitcherStillsCallback callback);

		void SetInvalid([In] uint index);

		void Unlock([In] IBMDSwitcherLockCallback lockCallback);

		void Upload([In] uint index, [In] string name, [In] IBMDSwitcherFrame frame);
	}
}