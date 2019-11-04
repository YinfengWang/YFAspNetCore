using System;
using YF.Core.Helpers;
using YF.Core.Logs.Internal;

namespace YF.Logs.Exceptionless
{
    /// <summary>
    /// Exceptionless日志上下文
    /// </summary>
    public class LogContext : YF.Core.Logs.Core.LogContext
    {
        /// <summary>
        /// 创建日志上下文信息
        /// </summary>
        protected override LogContextInfo CreateInfo()
        {
            return new LogContextInfo
            {
                TraceId = Guid.NewGuid().ToString(),
                Stopwatch = GetStopwatch(),
                Url = Web.Url
            };
        }
    }
}
