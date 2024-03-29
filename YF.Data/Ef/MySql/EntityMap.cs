﻿using YF.Data.Ef.Core;

namespace YF.Data.Ef.MySql {
    /// <summary>
    /// 实体映射配置
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    public abstract class EntityMap<TEntity> : MapBase<TEntity>, IMap where TEntity : class {
    }
}
