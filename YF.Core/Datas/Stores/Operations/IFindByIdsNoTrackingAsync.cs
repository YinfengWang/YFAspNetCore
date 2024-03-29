﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using YF.Core.Domains;

namespace YF.Core.Datas.Stores.Operations {
    /// <summary>
    /// 通过标识列表查找
    /// </summary>
    /// <typeparam name="TEntity">对象类型</typeparam>
    /// <typeparam name="TKey">对象标识类型</typeparam>
    public interface IFindByIdsNoTrackingAsync<TEntity, in TKey> where TEntity : class, IKey<TKey> {
        /// <summary>
        /// 查找实体列表,不跟踪
        /// </summary>
        /// <param name="ids">标识列表</param>
        Task<List<TEntity>> FindByIdsNoTrackingAsync( params TKey[] ids );
        /// <summary>
        /// 查找实体列表,不跟踪
        /// </summary>
        /// <param name="ids">标识列表</param>
        /// <param name="cancellationToken">取消令牌</param>
        Task<List<TEntity>> FindByIdsNoTrackingAsync( IEnumerable<TKey> ids, CancellationToken cancellationToken = default( CancellationToken ) );
        /// <summary>
        /// 查找实体列表,不跟踪
        /// </summary>
        /// <param name="ids">逗号分隔的标识列表，范例："1,2"</param>
        Task<List<TEntity>> FindByIdsNoTrackingAsync( string ids );
    }
}
