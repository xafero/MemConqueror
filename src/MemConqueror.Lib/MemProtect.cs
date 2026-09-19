namespace MemConqueror.Lib
{
    public enum MemProtect : uint
    {
        /// <summary>
        /// PAGE_EXECUTE
        /// </summary>
        Exe = 0x00000010,
		
        /// <summary>
        /// PAGE_EXECUTE_READ
        /// </summary>
        ExeRead = 0x00000020,
		
        /// <summary>
        /// PAGE_EXECUTE_READWRITE
        /// </summary>
        ExeReadWrite = 0x00000040,
		
        /// <summary>
        /// PAGE_EXECUTE_WRITECOPY
        /// </summary>
        ExeWriteCopy = 0x00000080,
		
        /// <summary>
        /// PAGE_NOACCESS
        /// </summary>
        NoAccess = 0x00000001,
		
        /// <summary>
        /// PAGE_READONLY
        /// </summary>
        ReadOnly = 0x00000002,
		
        /// <summary>
        /// PAGE_READWRITE
        /// </summary>
        ReadWrite = 0x00000004,
		
        /// <summary>
        /// PAGE_WRITECOPY
        /// </summary>
        WriteCopy = 0x00000008,
		
        /// <summary>
        /// PAGE_GUARD
        /// </summary>
        Guard = 0x00000100,
		
        /// <summary>
        /// PAGE_NOCACHE
        /// </summary>
        NoCache = 0x00000200,
		
        /// <summary>
        /// PAGE_WRITECOMBINE
        /// </summary>
        WriteCombine = 0x00000400
    }
}