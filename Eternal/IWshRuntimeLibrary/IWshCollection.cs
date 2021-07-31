using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x02000015 RID: 21
	[CompilerGenerated]
	[DefaultMember("Item")]
	[Guid("F935DC27-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeIdentifier]
	[ComImport]
	public interface IWshCollection : IEnumerable
	{
		// Token: 0x06000103 RID: 259
		[DispId(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object Item([MarshalAs(UnmanagedType.Struct)] [In] ref object Index);
	}
}
