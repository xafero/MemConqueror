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
			bld.AppendFormat(" Size={0:X8}", mg.Buffer.Length);
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
				foreach (MemGot item in ReadAll(pid))
				{
					byte[] debug = enc.GetBytes(item.Info.ToStr() + "\r\n");
					outPut.Write(debug, 0, debug.Length);
					byte[] array = item.Buffer;
					outPut.Write(array, 0, item.Buffer.Length);
				}
				outPut.Flush();
			}
			Process.Start(fName);
		}
		
		private static IEnumerable<MemGot> ReadAll(uint pid)
		{
			string pName;
			var hProc = OpenProc(pid, out pName, rw: false);
			IntPtr address = IntPtr.Zero;
			Type mbiType = typeof(MEMORY_BASIC_INFORMATION);
			int mbiSize = Marshal.SizeOf(mbiType);
			IntPtr mbiPtr = Marshal.AllocHGlobal(mbiSize);
			try
			{
				while ((int)Win32.VirtualQueryEx(hProc, address, mbiPtr, (UIntPtr)mbiSize) != 0)
				{
					MEMORY_BASIC_INFORMATION mbi = (MEMORY_BASIC_INFORMATION)Marshal.PtrToStructure(mbiPtr, mbiType);
					bool isCommitted = mbi.State == 4096;
					uint protect = mbi.Protect;
					bool isReadable = (protect & 2) != 0 || (protect & 8) != 0 || (protect & 4) != 0 || (protect & 0x20) != 0 || (protect & 0x80) != 0 || (protect & 0x40) != 0;
					bool notGuarded = (protect & 0x100) == 0;
					if (isCommitted & isReadable & notGuarded)
					{
						int regSize = (int)mbi.RegionSize;
						IntPtr regBuffer = Marshal.AllocHGlobal(regSize);
						try
						{
							UIntPtr bytesRead;
							if (Win32.ReadProcessMemory(hProc, mbi.BaseAddress, regBuffer, (UIntPtr)regSize, out bytesRead) && bytesRead.ToUInt32() != 0)
							{
								byte[] manBuffer = new byte[(uint)bytesRead.ToUInt32()];
								Marshal.Copy(regBuffer, manBuffer, 0, manBuffer.Length);
								yield return new MemGot(pName, mbi, manBuffer);
							}
						}
						finally
						{
							Marshal.FreeHGlobal(regBuffer);
						}
					}
					long next = mbi.BaseAddress.ToInt64() + (long)mbi.RegionSize;
					if (next <= address.ToInt64())
					{
						break;
					}
					address = new IntPtr(next);
				}
			}
			finally
			{
				Marshal.FreeHGlobal(mbiPtr);
			}
		}
	}
}