﻿using YF.Core.Datas.Sql;
using YF.Core.Datas.Sql.Builders;
using YF.Core.Datas.Sql.Builders.Core;
using YF.Core.Datas.Sql.Matedatas;
using YF.Data.Sql;
using YF.Data.Sql.Builders;
using YF.Data.Sql.Builders.Clauses;
using YF.Data.Sql.Builders.Core;
using YF.Datas.Sql.Builders.Clauses;

namespace YF.Data.Dapper.Oracle {
    /// <summary>
    /// Oracle From子句
    /// </summary>
    public class OracleFromClause : FromClause {
        /// <summary>
        /// 初始化From子句
        /// </summary>
        /// <param name="builder">Sql生成器</param>
        /// <param name="dialect">方言</param>
        /// <param name="resolver">实体解析器</param>
        /// <param name="register">实体别名注册器</param>
        /// <param name="tableDatabase">表数据库</param>
        /// <param name="table">表</param>
        public OracleFromClause( ISqlBuilder builder, IDialect dialect, IEntityResolver resolver, IEntityAliasRegister register, ITableDatabase tableDatabase, SqlItem table = null )
            : base( builder, dialect, resolver, register, tableDatabase, table ) {
        }

        /// <summary>
        /// 复制From子句
        /// </summary>
        /// <param name="builder">Sql生成器</param>
        /// <param name="register">实体别名注册器</param>
        public override IFromClause Clone( ISqlBuilder builder, IEntityAliasRegister register ) {
            if( register != null )
                register.FromType = Register.FromType;
            return new OracleFromClause( builder, Dialect, Resolver, register, TableDatabase, Table );
        }
    }
}
