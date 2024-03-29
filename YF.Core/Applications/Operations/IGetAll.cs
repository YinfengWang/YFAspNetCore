﻿using System.Collections.Generic;

namespace YF.Core.Applications.Operations {
    /// <summary>
    /// 获取全部数据
    /// </summary>
    public interface IGetAll<TDto> where TDto : new() {
        /// <summary>
        /// 获取全部
        /// </summary>
        List<TDto> GetAll();
    }
}
