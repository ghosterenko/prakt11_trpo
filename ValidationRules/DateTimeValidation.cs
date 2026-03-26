using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace prakt8.ValidationRules
{
    public class DateTimeValidation :ValidationRule
    {
        public override ValidationResult Validate (object value, CultureInfo cultureInfo)
        {

            var input = (value ?? "").ToString( ).Trim( );

            if(input == string.Empty)
            {
                return new ValidationResult(false, "Ввод обязателен");
            }

            if(!DateTime.TryParse(input, out DateTime dateTimeValue))
            {
                return new ValidationResult(false, "Необходимо ввести дату");
            }

            if (dateTimeValue.Year < 1800)
            {
                return new ValidationResult(false, "Год должен быть корректный");
            }


            return ValidationResult.ValidResult;
        }
    }
}
