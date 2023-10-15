using System.ComponentModel.DataAnnotations;

namespace Project.Validations
{
    public class RequiredIf : ValidationAttribute
    {
        private readonly string RequiredIfNameOfPropertyName;
        private readonly string RequiredIfValueOfPropertyName;

        public RequiredIf(string _RequiredIfNameOfPropertyName, string _RequiredIfValueOfPropertyName)
        {
            RequiredIfNameOfPropertyName = _RequiredIfNameOfPropertyName;
            RequiredIfValueOfPropertyName = _RequiredIfValueOfPropertyName;
        }

        protected override ValidationResult? IsValid(object? DependentActualValue, ValidationContext validationContext)
        {
            var AssociatedPropertyActualValue = validationContext.ObjectType.GetProperty(RequiredIfNameOfPropertyName)?.GetValue(validationContext.ObjectInstance)?.ToString();

            if (AssociatedPropertyActualValue != null && AssociatedPropertyActualValue.Equals(RequiredIfValueOfPropertyName) && string.IsNullOrEmpty(DependentActualValue?.ToString()))
            {
                var memberNames = validationContext.MemberName != null ? new[] { validationContext.MemberName } : null;
                return new ValidationResult(ErrorMessage, memberNames);
            }
            else
            {
                return ValidationResult.Success;
            }

        }
     }
}
