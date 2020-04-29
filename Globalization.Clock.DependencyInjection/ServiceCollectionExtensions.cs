using Microsoft.Extensions.DependencyInjection;

namespace System
{
    /// <summary>
    /// 
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 设置全局时区，获取当前带时区时间使用Clock.Now
        /// </summary>
        /// <param name="services"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static IServiceCollection GlobalizationClock(this IServiceCollection services, int offset)
        {
            Clock.Configuration(new GlobalizationClockConfiguration(offset));
            return services;
        }
    }
}
