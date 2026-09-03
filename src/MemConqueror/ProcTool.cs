using System;
using System.Collections.Generic;
using System.Management;
using System.Diagnostics;

namespace MemConqueror
{
    public static class ProcTool
    {
        public static string GetExePath(this Process proc)
        {
            try
            {
                var path = proc.MainModule?.FileName;
                return path;
            }
            catch
            {
                return null;
            }
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