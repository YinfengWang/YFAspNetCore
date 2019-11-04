using System.ComponentModel.DataAnnotations;

namespace YF.Core.Validations {
    /// <summary>
    /// 验证规则
    /// </summary>
    public interface IValidationRule {
        /// <summary>
        /// 验证
        /// </summary>
        ValidationResult Validate();
    }
}
