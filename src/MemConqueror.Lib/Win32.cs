using System;
using System.Runtime.InteropServices;
using PROCESS_MEMORY_COUNTERS = MemConqueror.ProcMemInfo;

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

        public const uint PROCESS_VM_OPERATION = 0x8;
        public const uint PROCESS_VM_WRITE = 0x20;

        public const uint PROCESS_QUERY_INFORMATION = 0x400;
        public const uint PROCESS_VM_READ = 0x10;

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
    }
}