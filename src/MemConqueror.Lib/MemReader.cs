using System;

namespace MemConqueror.Lib
{
	public class MemReader : IDisposable
	{
		private IntPtr _handle;
		
		public MemReader(uint pid)
		{
			_handle = Win32.OpenProcess(0, false, pid);
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
			return string.Format("[MemReader] handle={0:X8}", _handle);
		}
	}
}