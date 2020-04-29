namespace System
{
    /// <summary>
    /// 全局配置了时区的时间类
    /// </summary>
    public class Clock
    {
        /// <summary>
        /// 
        /// </summary>
        private static GlobalizationClockConfiguration _globalizationClockConfiguration;
        /// <summary>
        /// 配置时区(全局生效)
        /// </summary>
        /// <param name="configuration"></param>
        public static void Configuration(GlobalizationClockConfiguration configuration)
        {
            _globalizationClockConfiguration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        /// <summary>
        /// 当前时间
        /// </summary>
        public static DateTimeOffset Now => Convert(DateTimeOffset.Now);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        private static DateTimeOffset Convert(DateTimeOffset dateTime)
        {
            return dateTime.ToOffset(TimeSpan.FromHours(_globalizationClockConfiguration.Offset));
        }
    }
}
