using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using MEMORY_BASIC_INFORMATION = MemConqueror.Lib.MemInfo;

namespace MemConqueror.Lib
{
	public static class MemTool
	{
		public static string ToStr(this IMemGot mg)
		{
			StringBuilder bld = new StringBuilder();
			bld.Append("[MG]");
			bld.AppendFormat(" Name={0}", mg.Name);
			var buff = mg.Buffer;
			var size = buff == null ? 0 : buff.Length;
			bld.AppendFormat(" Size={0:X8}", size);
			bld.AppendFormat(" {0} ", mg.Info.ToStr());
			return bld.ToString();
		}

		public static string ToStr(this MEMORY_BASIC_INFORMATION mbi)
		{
			StringBuilder bld = new StringBuilder();
			bld.Append("[MBI]");
			bld.AppendFormat(" BaseAddress={0:X8}", mbi.BaseAddress.ToInt32());
			bld.AppendFormat(" AllocationBase={0:X8}", mbi.AllocationBase.ToInt32());
			bld.AppendFormat(" AllocationProtect={0:X8}", mbi.AllocationProtect);
			bld.AppendFormat(" RegionSize={0:X8}", (uint)mbi.RegionSize);
			bld.AppendFormat(" State={0:X8}", mbi.State);
			bld.AppendFormat(" Protect={0:X8}", mbi.Protect);
			bld.AppendFormat(" Type={0:X8}", mbi.Type);
			bld.Append(" ");
			return bld.ToString();
		}
		
		public static IntPtr OpenProc(uint pid, out string pName, bool rw)
		{
			Process proc = Process.GetProcessById((int)pid);
			pName = proc.ProcessName.Replace(' ', '_');
			var acc = Win32.PROCESS_VM_READ | Win32.PROCESS_QUERY_INFORMATION;
			if (rw)
			{
				acc |= Win32.PROCESS_VM_OPERATION | Win32.PROCESS_VM_WRITE;
			}
			uint pac = (uint)acc;
			var hProc = Win32.OpenProcess(pac, false, pid);
			if (hProc == null || hProc == IntPtr.Zero)
			{
				var debug = string.Format("Failed to open process #{0}!", pid);
				throw new InvalidOperationException(debug);
			}
			return hProc;
		}
		
		public static void DumpAllMem(uint pid)
		{
			string bName = string.Format("proc_{0}_dmp", pid);
			string fName = bName + ".bin";
			var enc = Encoding.ASCII;
			using (FileStream outPut = File.Create(fName))
			{
				using (var mem = new MemReader(pid))
				{
					foreach (MemGot item in mem.ReadAll())
					{
						byte[] debug = enc.GetBytes(item.Info.ToStr() + "\r\n");
						outPut.Write(debug, 0, debug.Length);
						byte[] array = item.Buffer;
						outPut.Write(array, 0, item.Buffer.Length);
					}
				}
				outPut.Flush();
			}
			Process.Start(fName);
		}		
	}
}