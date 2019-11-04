﻿using Microsoft.Extensions.DependencyInjection;

namespace YF.Core.Dependency {
    /// <summary>
    /// 依赖注册器
    /// </summary>
    public interface IDependencyRegistrar {
        /// <summary>
        /// 注册依赖
        /// </summary>
        /// <param name="services">服务集合</param>
        void Register( IServiceCollection services );
    }
}
