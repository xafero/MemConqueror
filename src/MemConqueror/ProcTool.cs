using System;
using System.Collections.Generic;
using System.Management;
using System.Diagnostics;

// ReSharper disable UseObjectOrCollectionInitializer

namespace MemConqueror
{
    public static class ProcTool
    {
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