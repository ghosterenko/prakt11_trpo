using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace prakt8.ValidationRules
{
    public class phoneNumberValidation : ValidationRule
    {
        public override ValidationResult Validate (object value, CultureInfo cultureInfo)
        {
            var input = (value ?? "").ToString( ).Trim( );
            if(input == string.Empty)
            {
                return new ValidationResult(false, "Ввод поля обязателен");
            }

            bool f = true;
            foreach (var c in input)
            {
                if (!char.IsDigit(c))
                {
                    f = false;
                    break;
                }
            }
            if (f == false)
            {
                return new ValidationResult(false, "Ввод только цифры");
            }

            if(input.Length != 11)
            {
                return new ValidationResult(false, "Некорректный номер телефона");
            }

            if (input [0] != '8' || (input [0] != '+' && input [1] != '7'))
            {
                return new ValidationResult(false, "Некорректный номер телефона");
            }

            return ValidationResult.ValidResult;
        }
    }
}
