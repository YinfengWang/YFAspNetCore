﻿using System;
using YF.Core.Datas.Sql;
using YF.Core.Datas.Sql.Builders;
using YF.Core.Datas.Sql.Matedatas;
using YF.Data.Sql;
using YF.Data.Sql.Builders;
using YF.Data.Sql.Builders.Clauses;
using YF.Data.Sql.Builders.Core;

namespace YF.Data.Dapper.MySql {
    /// <summary>
    /// MySql 表连接子句
    /// </summary>
    public class MySqlJoinClause : JoinClause {
        /// <summary>
        /// 初始化MySql 表连接子句
        /// </summary>
        /// <param name="sqlBuilder">Sql生成器</param>
        /// <param name="dialect">方言</param>
        /// <param name="resolver">实体解析器</param>
        /// <param name="register">实体注册器</param>
        /// <param name="parameterManager">参数管理器</param>
        /// <param name="tableDatabase">表数据库</param>
        public MySqlJoinClause( ISqlBuilder sqlBuilder, IDialect dialect, IEntityResolver resolver, IEntityAliasRegister register, 
            IParameterManager parameterManager, ITableDatabase tableDatabase )
            : base( sqlBuilder, dialect, resolver, register, parameterManager, tableDatabase ) {
        }

        /// <summary>
        /// 创建连接项
        /// </summary>
        /// <param name="joinType">连接类型</param>
        /// <param name="table">表名</param>
        /// <param name="schema">架构名</param>
        /// <param name="alias">别名</param>
        /// <param name="type">实体类型</param>
        protected override JoinItem CreateJoinItem( string joinType, string table, string schema, string alias, Type type = null ) {
            return new JoinItem( joinType, table, schema, alias, false, false, type );
        }
    }
}
