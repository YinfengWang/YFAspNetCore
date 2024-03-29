﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using YF.Data.Ef.Core;

namespace YF.Data.Ef.SqlServer {
    /// <summary>
    /// SqlServer工作单元
    /// </summary>
    public abstract class UnitOfWork : UnitOfWorkBase {
        /// <summary>
        /// 初始化SqlServer工作单元
        /// </summary>
        /// <param name="options">配置</param>
        /// <param name="serviceProvider">服务提供器</param>
        protected UnitOfWork( DbContextOptions options, IServiceProvider serviceProvider = null )
            : base( options, serviceProvider ) {
        }

        /// <summary>
        /// 获取映射实例列表
        /// </summary>
        /// <param name="assembly">程序集</param>
        protected override IEnumerable<YF.Data.Ef.Core.IMap> GetMapInstances( Assembly assembly ) {
            return YF.Core.Helpers.Reflection.GetInstancesByInterface<IMap>( assembly );
        }
    }
}
