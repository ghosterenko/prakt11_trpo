using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace prakt8.Converters
{
    public class DayConverter :IValueConverter
    {
        public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            if(DateTime.TryParse(value.ToString(), out DateTime dt))
            {
                TimeSpan ts = DateTime.Now - dt;
                if(ts.Days == 0)
                {
                    return $"Первый прием в клинике";
                }
                return $"{ts.Days} дней c предыдущего приема";
            }

            return String.Empty;
        }

        public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
