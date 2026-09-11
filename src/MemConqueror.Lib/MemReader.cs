using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MEMORY_BASIC_INFORMATION = MemConqueror.Lib.MemInfo;

namespace MemConqueror.Lib
{
	public class MemReader : IDisposable
	{
		private const uint MEM_COMMIT = 0x1000;
		private const uint PAGE_READONLY = 0x02;
		private const uint PAGE_WRITECOPY = 0x08;
		private const uint PAGE_READWRITE = 0x04;
		private const uint PAGE_EXECUTE_READ = 0x20;
		private const uint PAGE_EXECUTE_WRITECOPY = 0x80;
		private const uint PAGE_EXECUTE_READWRITE = 0x40;
		private const uint PAGE_GUARD = 0x100;

		private uint _pid;
		private string _pName;
		private IntPtr _handle;

		public MemReader(uint pid, bool rw = false)
		{
			_handle = MemTool.OpenProc(_pid = pid, out _pName, rw);
		}

		protected virtual bool IsUsable(MEMORY_BASIC_INFORMATION mbi)
		{
			bool isCommitted = mbi.State == MEM_COMMIT;
			uint protect = mbi.Protect;
			bool isReadable = (protect & PAGE_READONLY) != 0
					|| (protect & PAGE_WRITECOPY) != 0
					|| (protect & PAGE_READWRITE) != 0
					|| (protect & PAGE_EXECUTE_READ) != 0
					|| (protect & PAGE_EXECUTE_WRITECOPY) != 0
					|| (protect & PAGE_EXECUTE_READWRITE) != 0;
			bool notGuarded = (protect & PAGE_GUARD) == 0;
			return isCommitted && isReadable && notGuarded;
		}

		protected virtual byte[] Read(MEMORY_BASIC_INFORMATION mbi)
		{
			int regSize = (int)mbi.RegionSize;
			IntPtr regBuffer = Marshal.AllocHGlobal(regSize);
			try
			{
				UIntPtr bytesRead;
				if (Win32.ReadProcessMemory(_handle, mbi.BaseAddress, regBuffer, (UIntPtr)regSize,
											out bytesRead) && bytesRead.ToUInt32() != 0)
				{
					byte[] manBuffer = new byte[(uint)bytesRead.ToUInt32()];
					Marshal.Copy(regBuffer, manBuffer, 0, manBuffer.Length);
					return manBuffer;
				}
			}
			finally
			{
				Marshal.FreeHGlobal(regBuffer);
			}
			return null;
		}

		protected virtual IMemGot Get(MEMORY_BASIC_INFORMATION mbi)
		{
			var buffer = Read(mbi);
			if (buffer == null) return null;
			return new MemGot(_pName, mbi, buffer);
		}

		public IEnumerable<IMemGot> ReadAll()
		{
			Type mbiType = typeof(MEMORY_BASIC_INFORMATION);
			int mbiSize = Marshal.SizeOf(mbiType);
			IntPtr mbiPtr = Marshal.AllocHGlobal(mbiSize);
			try
			{
				IntPtr address = IntPtr.Zero;
				while ((int)Win32.VirtualQueryEx(_handle, address, mbiPtr, (UIntPtr)mbiSize) != 0)
				{
					var mbi = (MEMORY_BASIC_INFORMATION)Marshal.PtrToStructure(mbiPtr, mbiType);
					if (IsUsable(mbi))
					{
						var it = Get(mbi);
						if (it != null) yield return it;
					}
					long next = mbi.BaseAddress.ToInt64() + (long)mbi.RegionSize;
					if (next <= address.ToInt64())
						break;
					address = new IntPtr(next);
				}
			}
			finally
			{
				Marshal.FreeHGlobal(mbiPtr);
			}
		}

		public void Dispose()
		{
			if (!Win32.CloseHandle(_handle))
				return;
			_handle = IntPtr.Zero;
		}

		public bool IsDisposed { get { return _handle == IntPtr.Zero; } }

		public override string ToString()
		{
			return string.Format("[MR] id={0}, name={1}, handle={2}", _pid, _pName, _handle);
		}
	}
}