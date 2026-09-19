using System;

namespace MemConqueror.Lib
{	
	/// <summary>
	/// MEMORY_BASIC_INFORMATION
	/// </summary>
	public struct MemInfo
	{
		public IntPtr BaseAddress;
		public IntPtr AllocationBase;
		public uint AllocationProtect;
		public UIntPtr RegionSize;
		public uint State;
		public uint Protect;
		public uint Type;
	}
}