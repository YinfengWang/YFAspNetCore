﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace YF.Core.Applications.Operations {
    /// <summary>
    /// 获取全部数据
    /// </summary>
    public interface IGetAllAsync<TDto> where TDto : new() {
        /// <summary>
        /// 获取全部
        /// </summary>
        Task<List<TDto>> GetAllAsync();
    }
}
