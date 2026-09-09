using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming

namespace MemConqueror
{
    public static class Win32
    {
    	/* State of the pages */
		public const int MEM_COMMIT = 0x1000;
		public const int MEM_FREE = 0x10000;
		public const int MEM_RESERVE = 0x2000;

		/* Type of the pages */
		public const int MEM_IMAGE = 0x1000000;
		public const int MEM_MAPPED = 0x40000;
		public const int MEM_PRIVATE = 0x20000;
    	
    	private const uint MEM_TYPE_MEM_PRIVATE = 131072u;
		private const uint MEM_TYPE_MEM_MAPPED = 262144u;
		private const uint MEM_TYPE_MEM_IMAGE = 16777216u;

		private const uint MEM_STATE_MEM_RESERVE = 8192u;
		private const uint MEM_STATE_MEM_FREE = 65536u;
		private const uint MEM_STATE_MEM_COMMIT = 4096u;
		
		public const uint PROCESS_VM_OPERATION = 8u;
		public const uint PROCESS_VM_WRITE = 32u;

        public const uint PROCESS_QUERY_INFORMATION = 0x0400;
        public const uint PROCESS_VM_READ = 0x0010;

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(uint access, bool inherit, uint pid);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr handle);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
            IntPtr lpBuffer, UIntPtr nSize, out UIntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern UIntPtr VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress,
                    IntPtr lpBuffer, UIntPtr dwLength);

        [DllImport("psapi.dll", SetLastError = true)]
        public static extern bool GetProcessMemoryInfo(IntPtr handle,
            out PROCESS_MEMORY_COUNTERS counters, int back);

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_MEMORY_COUNTERS
        {
            public int cb;
            public int PageFaultCount;

            public UIntPtr PeakWorkingSetSize;
            public UIntPtr WorkingSetSize;

            public UIntPtr QuotaPeakPagedPoolUsage;
            public UIntPtr QuotaPagedPoolUsage;

            public UIntPtr QuotaPeakNonPagedPoolUsage;
            public UIntPtr QuotaNonPagedPoolUsage;

            public UIntPtr PagefileUsage;
            public UIntPtr PeakPagefileUsage;

            public UIntPtr PrivateUsage;
        }
    }
}