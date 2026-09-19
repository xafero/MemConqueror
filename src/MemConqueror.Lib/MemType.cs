namespace MemConqueror.Lib
{
    public enum MemType : uint
    {
        /// <summary>
        /// MEM_IMAGE
        /// </summary>
        Image = 0x1000000,
		
        /// <summary>
        /// MEM_MAPPED
        /// </summary>
        Mapped = 0x40000,
		
        /// <summary>
        /// MEM_PRIVATE
        /// </summary>
        Private = 0x20000
    }
}