using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming

namespace MemConqueror
{
    public static class Win32
    {
        public const uint PROCESS_QUERY_INFORMATION = 0x0400;
        public const uint PROCESS_VM_READ = 0x0010;

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(uint access, bool inherit, int pid);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr handle);

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