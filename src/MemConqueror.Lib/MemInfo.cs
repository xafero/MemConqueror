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
	
	public enum MemProtect : uint
	{
		PAGE_EXECUTE = 0x00000010,
		PAGE_EXECUTE_READ = 0x00000020,
		PAGE_EXECUTE_READWRITE = 0x00000040,
		PAGE_EXECUTE_WRITECOPY = 0x00000080,
		PAGE_NOACCESS = 0x00000001,
		PAGE_READONLY = 0x00000002,
		PAGE_READWRITE = 0x00000004,
		PAGE_WRITECOPY = 0x00000008,
		PAGE_GUARD = 0x00000100,
		PAGE_NOCACHE = 0x00000200,
		PAGE_WRITECOMBINE = 0x00000400
	}
	
	public enum MemState : uint
	{
		MEM_COMMIT = 0x1000,
		MEM_RESERVE = 0x2000,
		MEM_FREE = 0x10000
	}

	public enum MemType : uint
	{
		MEM_IMAGE = 0x1000000,
		MEM_MAPPED = 0x40000,
		MEM_PRIVATE = 0x20000
	}	
}