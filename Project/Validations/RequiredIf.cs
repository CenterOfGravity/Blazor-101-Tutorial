using System.ComponentModel.DataAnnotations;

namespace Project.Validations
{
    public class RequiredIf : ValidationAttribute
    {
        private readonly string PropertyNameInsideRequiredIf;
        private readonly string PropertyValueInsideRequiredIf;

        public RequiredIf(string propertyNameInsideRequiredIf, string propertyValueInsideRequiredIf)
        {
            PropertyNameInsideRequiredIf = propertyNameInsideRequiredIf;
            PropertyValueInsideRequiredIf = propertyValueInsideRequiredIf;
        }

        protected override ValidationResult? IsValid(object? DependentActualValue, ValidationContext validationContext)
        {
            var AssociatedPropertyActualValue = validationContext.ObjectType.GetProperty(PropertyNameInsideRequiredIf)?.GetValue(validationContext.ObjectInstance)?.ToString();

            if (AssociatedPropertyActualValue != null && AssociatedPropertyActualValue.Equals(PropertyValueInsideRequiredIf) && string.IsNullOrEmpty(DependentActualValue?.ToString()))
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
