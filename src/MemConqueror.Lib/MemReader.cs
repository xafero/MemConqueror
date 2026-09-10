using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MEMORY_BASIC_INFORMATION = MemConqueror.Lib.MemInfo;

namespace MemConqueror.Lib
{
	public class MemReader : IDisposable
	{
		private uint _pid;
		private string _pName;
		private IntPtr _handle;

		public MemReader(uint pid, bool rw = false)
		{
			_handle = MemTool.OpenProc(_pid = pid, out _pName, rw);
		}

		public static IEnumerable<MemGot> ReadAll()
		{
			IntPtr mbiPtr = AllocMbi();
			try
			{
				
			}
			finally
			{
				Marshal.FreeHGlobal(mbiPtr);
			}
		}

		private static IntPtr AllocMbi()
		{
			Type mbiType = typeof(MEMORY_BASIC_INFORMATION);
			int mbiSize = Marshal.SizeOf(mbiType);
			return Marshal.AllocHGlobal(mbiSize);
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