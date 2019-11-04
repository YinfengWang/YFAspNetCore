using System.Linq;
using YF.Core.Exceptions;
using YF.Core.Validations;

namespace YF.Core.Domains.Services {
    /// <summary>
    /// 参数
    /// </summary>
    public abstract class ParameterBase : IValidation {
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
