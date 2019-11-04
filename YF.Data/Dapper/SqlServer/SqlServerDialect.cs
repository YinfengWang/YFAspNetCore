using YF.Core.Datas.Sql.Builders.Core;
using YF.Data.Sql.Builders.Core;

namespace YF.Data.Dapper.SqlServer {
    /// <summary>
    /// Sql Server方言
    /// </summary>
    public class SqlServerDialect : DialectBase {
        /// <summary>
        /// 获取安全名称
        /// </summary>
        /// <param name="name">名称</param>
        protected override string GetSafeName( string name ) {
            return $"[{name}]";
        }
    }
}
