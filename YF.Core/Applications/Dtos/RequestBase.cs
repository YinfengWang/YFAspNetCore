﻿using System.Linq;
using YF.Core.Exceptions;
using YF.Core.Ui.Attributes;
using YF.Core.Validations;

namespace YF.Core.Applications.Dtos {
    /// <summary>
    /// 请求参数
    /// </summary>
    [Model]
    public abstract class RequestBase : IRequest {
        /// <summary>
        /// 验证
        /// </summary>
        public virtual ValidationResultCollection Validate() {
            var result = DataAnnotationValidation.Validate( this );
            if( result.IsValid )
                return ValidationResultCollection.Success;
            throw new Warning( result.First().ErrorMessage );
        }
    }
}
