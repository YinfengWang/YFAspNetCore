﻿using System;
using YF.Core.Datas.Sql;
using YF.Core.Datas.Sql.Builders;
using YF.Core.Datas.Sql.Builders.Core;
using YF.Data.Sql.Builders;
using YF.Data.Sql.Builders.Core;

namespace YF.Data.Sql {
    /// <summary>
    /// 公用表表达式CTE操作扩展
    /// </summary>
    public static partial class Extensions {
        /// <summary>
        /// 设置公用表表达式CTE
        /// </summary>
        /// <param name="source">源</param>
        /// <param name="name">公用表表达式CTE的名称</param>
        /// <param name="builder">Sql生成器</param>
        public static T With<T>( this T source, string name, ISqlBuilder builder ) where T : ICte {
            if( source == null )
                throw new ArgumentNullException( nameof( source ) );
            if( string.IsNullOrWhiteSpace( name ) || builder == null )
                return source;
            if( source is ICteAccessor accessor )
                accessor.CteItems.Add( new BuilderItem( name, builder ) );
            return source;
        }
    }
}