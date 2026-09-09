using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace MemConqueror.Lib
{
	public static class Constants
	{
		/* State of the pages */
		public const int MEM_COMMIT = 0x1000;
		public const int MEM_FREE = 0x10000;
		public const int MEM_RESERVE = 0x2000;

		/* Type of the pages */
		public const int MEM_IMAGE = 0x1000000;
		public const int MEM_MAPPED = 0x40000;
		public const int MEM_PRIVATE = 0x20000;


		// ??

		private const uint MEM_TYPE_MEM_PRIVATE = 131072u;
		private const uint MEM_TYPE_MEM_MAPPED = 262144u;
		private const uint MEM_TYPE_MEM_IMAGE = 16777216u;

		private const uint MEM_STATE_MEM_RESERVE = 8192u;
		private const uint MEM_STATE_MEM_FREE = 65536u;
		private const uint MEM_STATE_MEM_COMMIT = 4096u;

		public const uint PROCESS_VM_READ = 16u;
		public const uint PROCESS_QUERY_INFORMATION = 1024u;
		public const uint PROCESS_VM_OPERATION = 8u;
		public const uint PROCESS_VM_WRITE = 32u;
	}

	public struct MEMORY_BASIC_INFORMATION
	{
		public IntPtr BaseAddress;
		public IntPtr AllocationBase;
		public uint AllocationProtect;
		public UIntPtr RegionSize;
		public uint State;
		public uint Protect;
		public uint Type;
	}

	public struct MemGot
	{
		public MemGot(string name, MEMORY_BASIC_INFORMATION info, byte[] buffer)
		{
			Name = name;
			Info = info;
			Buffer = buffer;
		}

		public string Name;
		public MEMORY_BASIC_INFORMATION Info;
		public byte[] Buffer;
	}

	public static class WinFu
	{
		public static void WriteFullDump(uint pid, string wName)
		{
			string bName = string.Format("proc_{0}_dmp", pid);
			string fName = bName + ".bin";
			using (FileStream outPut = File.Create(fName))
			{
				foreach (MemGot item in ReadAll(pid))
				{
					byte[] debug = Encoding.ASCII.GetBytes(item.Info.ToStr() + "\r\n");
					outPut.Write(debug, 0, debug.Length);
					byte[] array = item.Buffer;
					outPut.Write(array, 0, item.Buffer.Length);
				}
				outPut.Flush();
			}
			Process.Start(fName);
		}

		public static IEnumerable<MemGot> ReadAll(uint pid)
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

		public static IntPtr OpenProc(uint pid, out string pName, bool rw)
		{
			Process proc = Process.GetProcessById((int)pid);
			pName = proc.ProcessName.Replace(' ', '_');
			var acc = Constants.PROCESS_VM_READ | Constants.PROCESS_QUERY_INFORMATION;
			if (rw)
			{
				acc |= Constants.PROCESS_VM_OPERATION | Constants.PROCESS_VM_WRITE;
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

		public static string ToStr(this MemGot mg)
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
	}
}