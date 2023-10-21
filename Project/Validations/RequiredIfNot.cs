using System.ComponentModel.DataAnnotations;

namespace Project.Validations
{
    public class RequiredIfNot : ValidationAttribute
    {
        private readonly string PropertyNameInsideRequiredIfNot;
        private readonly string PropertyValueInsideRequiredIfNot;

        public RequiredIfNot(string propertyNameInsideRequiredIfNot, string propertyValueInsideRequiredIfNot)
        {
            PropertyNameInsideRequiredIfNot = propertyNameInsideRequiredIfNot;
            PropertyValueInsideRequiredIfNot = propertyValueInsideRequiredIfNot;
        }

        protected override ValidationResult? IsValid(object? DependentActualValue, ValidationContext validationContext)
        {
            var AssociatedPropertyActualValue = validationContext.ObjectType.GetProperty(PropertyNameInsideRequiredIfNot)?.GetValue(validationContext.ObjectInstance)?.ToString();

            if (AssociatedPropertyActualValue != null && AssociatedPropertyActualValue.Equals(PropertyValueInsideRequiredIfNot) == false && string.IsNullOrEmpty(DependentActualValue?.ToString()))
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
