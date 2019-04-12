using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace BindingsUndValidation
{
    class EmailValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is null || string.IsNullOrWhiteSpace((string)value))
                return new ValidationResult(false, "Es steht kein Wert in der TextBox");


            if (Regex.IsMatch((string)value, @"^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"))
                return new ValidationResult(true, null);
            else
                return new ValidationResult(false,"Keine gültige E-Mail");
        }
    }
}
