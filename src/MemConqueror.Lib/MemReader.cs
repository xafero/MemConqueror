using System;

namespace MemConqueror.Lib
{
	public class MemReader : IDisposable
	{
		private uint _pid;
		private IntPtr _handle;
		private string _pName;
		
		public MemReader(uint pid, bool rw = false)
		{
			_handle = MemTool.OpenProc(_pid = pid, out _pName, rw);
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
			return string.Format("[MR] Id={0}, Handle={1}, Name={2}", _pid, _handle, _pName);
		}
	}
}