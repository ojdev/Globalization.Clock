namespace System
{
    /// <summary>
    /// 全局的时区配置类
    /// </summary>
    public sealed class GlobalizationClockConfiguration
    {
        /// <summary>
        /// 小时
        /// </summary>
        public int Offset { get; }
        /// <summary>
        /// 
        /// </summary>
        public GlobalizationClockConfiguration()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset">小时</param>
        public GlobalizationClockConfiguration(int offset = 8)
        {
            Offset = offset;
        }
    }
}
