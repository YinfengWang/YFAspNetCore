using System.Collections.Generic;
using YF.Core.Extensions;

namespace YF.Logs.Exceptionless {
    /// <summary>
    /// 日志转换器
    /// </summary>
    public interface ILogConvert {
        /// <summary>
        /// 转换
        /// </summary>
        List<Item> To();
    }
}
