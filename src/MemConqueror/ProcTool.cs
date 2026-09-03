using System;
using System.Collections.Generic;
using System.Management;
using System.Diagnostics;
using System.Runtime.InteropServices;

// ReSharper disable UseObjectOrCollectionInitializer

namespace MemConqueror
{
    public static class ProcTool
    {
        public static Dictionary<string, object> GetWin32Info(this Process proc)
        {
            var handle = IntPtr.Zero;
            try
            {
                const uint acc = Win32.PROCESS_QUERY_INFORMATION | Win32.PROCESS_VM_READ;
                handle = Win32.OpenProcess(acc, false, proc.Id);
                if (handle == IntPtr.Zero)
                    return null;
                var counters = new Win32.PROCESS_MEMORY_COUNTERS
                {
                    cb = Marshal.SizeOf(typeof(Win32.PROCESS_MEMORY_COUNTERS))
                };
                if (!Win32.GetProcessMemoryInfo(handle, out counters, counters.cb))
                    return null;
                var dict = new Dictionary<string, object>();
                dict["PageFaultCount"] = counters.PageFaultCount;
                dict["PagefileUsage"] = counters.PagefileUsage;
                dict["PeakPagefileUsage"] = counters.PeakPagefileUsage;
                dict["PeakWorkingSetSize"] = counters.PeakWorkingSetSize;
                dict["PrivateUsage"] = counters.PrivateUsage;
                dict["QuotaNonPagedPoolUsage"] = counters.QuotaNonPagedPoolUsage;
                dict["QuotaPagedPoolUsage"] = counters.QuotaPagedPoolUsage;
                dict["QuotaPeakNonPagedPoolUsage"] = counters.QuotaPeakNonPagedPoolUsage;
                dict["QuotaPeakPagedPoolUsage"] = counters.QuotaPeakPagedPoolUsage;
                dict["WorkingSetSize"] = counters.WorkingSetSize;
                return dict;
            }
            catch (Exception)
            {
                // Nothing!
            }
            finally
            {
                Win32.CloseHandle(handle);
            }
            return null;
        }

        public static Dictionary<string, object> GetNetInfo(this Process proc)
        {
            try
            {
                var dict = new Dictionary<string, object>();
                dict["Pid"] = proc.Id;
                dict["Name"] = proc.ProcessName;
                var pMainMod = GetMainModule(proc);
                dict["Path"] = pMainMod?.FileName;
                dict["Desc"] = pMainMod?.FileVersionInfo.FileDescription;
                dict["VirtualMem"] = proc.VirtualMemorySize64;
                dict["PrivateMem"] = proc.PrivateMemorySize64;
                dict["WorkingSet"] = proc.WorkingSet64;
                return dict;
            }
            catch (Exception)
            {
                // Nothing!
            }
            return null;
        }

        private static ProcessModule GetMainModule(Process proc)
        {
            try
            {
                var main = proc.MainModule;
                if (main?.ModuleName != null)
                    return main;
            }
            catch (Exception)
            {
                // Nothing!
            }
            return null;
        }

        public static Dictionary<string, object> GetWmiInfo(this Process proc)
        {
            try
            {
                using (var searcher = new ManagementObjectSearcher(
                           $"SELECT * FROM Win32_Process WHERE ProcessId = {proc.Id}"))
                    foreach (var mbo in searcher.Get())
                    {
                        var dict = new Dictionary<string, object>();
                        foreach (var prop in mbo.Properties)
                            dict[prop.Name] = prop.Value;
                        return dict;
                    }
            }
            catch (Exception)
            {
                // Nothing!
            }
            return null;
        }
    }
}