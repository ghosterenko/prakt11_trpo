using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace prakt8.ValidationRules
{
    public class StringValidation :ValidationRule
    {
        public override ValidationResult Validate (object value, CultureInfo cultureInfo)
        {
            var input = (value ?? "").ToString( ).Trim( );
            if(input == string.Empty)
            {
                return new ValidationResult(false, "Ввод в поля обязателен");
            }

            bool f = true;
            foreach (var c in input)
            {
                if(!char.IsLetter(c))
                {
                    f = false;
                    break;
                }
            }
            if(f == false)
            {
                return new ValidationResult(false, "Ввод только буквы");
            }

            return ValidationResult.ValidResult;
        }
    }
}
