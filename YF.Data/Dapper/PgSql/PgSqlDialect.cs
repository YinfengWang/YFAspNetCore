﻿using YF.Core.Datas.Sql.Builders.Core;
using YF.Data.Sql.Builders.Core;

namespace YF.Data.Dapper.PgSql {
    /// <summary>
    /// PgSql方言
    /// </summary>
    public class PgSqlDialect : DialectBase {
        /// <summary>
        /// 起始转义标识符
        /// </summary>
        public override string OpeningIdentifier => "\"";

        /// <summary>
        /// 结束转义标识符
        /// </summary>
        public override string ClosingIdentifier => "\"";

        /// <summary>
        /// 获取安全名称
        /// </summary>
        /// <param name="name">名称</param>
        protected override string GetSafeName( string name ) {
            return $"\"{name}\"";
        }
    }
}