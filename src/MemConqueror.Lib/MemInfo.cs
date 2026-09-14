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
		/// <summary>
		/// PAGE_EXECUTE
		/// </summary>
		Exec = 0x00000010,
		
		/// <summary>
		/// PAGE_EXECUTE_READ
		/// </summary>
		ExecRead = 0x00000020,
		
		/// <summary>
		/// PAGE_EXECUTE_READWRITE
		/// </summary>
		ExecReadWrite = 0x00000040,
		
		/// <summary>
		/// PAGE_EXECUTE_WRITECOPY
		/// </summary>
		ExecWriteCopy = 0x00000080,
		
		/// <summary>
		/// PAGE_NOACCESS
		/// </summary>
		NoAccess = 0x00000001,
		
		/// <summary>
		/// PAGE_READONLY
		/// </summary>
		ReadOnly = 0x00000002,
		
		/// <summary>
		/// PAGE_READWRITE
		/// </summary>
		ReadWrite = 0x00000004,
		
		/// <summary>
		/// PAGE_WRITECOPY
		/// </summary>
		WriteCopy = 0x00000008,
		
		/// <summary>
		/// PAGE_GUARD
		/// </summary>
		Guard = 0x00000100,
		
		/// <summary>
		/// PAGE_NOCACHE
		/// </summary>
		NoCache = 0x00000200,
		
		/// <summary>
		/// PAGE_WRITECOMBINE
		/// </summary>
		WriteCombine = 0x00000400
	}
	
	public enum MemState : uint
	{
		/// <summary>
		/// MEM_COMMIT
		/// </summary>
		Commit = 0x1000,
		
		/// <summary>
		/// MEM_RESERVE
		/// </summary>
		Reserve = 0x2000,
		
		/// <summary>
		/// MEM_FREE
		/// </summary>
		Free = 0x10000
	}

	public enum MemType : uint
	{
		/// <summary>
		/// MEM_IMAGE
		/// </summary>
		Image = 0x1000000,
		
		/// <summary>
		/// MEM_MAPPED
		/// </summary>
		Mapped = 0x40000,
		
		/// <summary>
		/// MEM_PRIVATE
		/// </summary>
		Private = 0x20000
	}	
}