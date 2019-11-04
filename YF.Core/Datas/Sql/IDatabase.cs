﻿using System.Data;

namespace YF.Core.Datas.Sql {
    /// <summary>
    /// 数据库
    /// </summary>
    [YF.Core.Aspects.Ignore]
    public interface IDatabase {
        /// <summary>
        /// 获取数据库连接
        /// </summary>
        IDbConnection GetConnection();
    }
}
