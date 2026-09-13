using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming

namespace MemConqueror
{
    /// <summary>
    /// PROCESS_MEMORY_COUNTERS
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ProcMemInfo
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