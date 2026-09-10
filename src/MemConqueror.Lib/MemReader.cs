using System;

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