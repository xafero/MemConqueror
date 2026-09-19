namespace MemConqueror.Lib
{
    public enum MemState : uint
    {
        /// <summary>
        /// MEM_COMMIT
        /// </summary>
        Commit = 0x1000,
		
        /// <summary>
        /// MEM_RESERVE
        /// </summary>
        Reserve = 0x2000,
		
        /// <summary>
        /// MEM_FREE
        /// </summary>
        Free = 0x10000
    }
}