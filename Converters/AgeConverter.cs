using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace prakt8.Converters
{
    public class AgeConverter :IValueConverter
    {
        public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return String.Empty;

            DateTime dateBday = DateTime.Parse(value.ToString( ));
            int age = DateTime.Now.Year - dateBday.Year;

            if(age >= 18)
            {
                return $"{age} - Совершеннолетний";
            }
            else
            {
                return $"{age} - Несовершеннолетний";
            }
        }

        public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException( );
        }
    }
}
