﻿using System;

namespace YF.Core.Datas.Sql {
    /// <summary>
    /// 忽略生成列
    /// </summary>
    [AttributeUsage( AttributeTargets.Property )]
    public class IgnoreAttribute : Attribute {
    }
}
