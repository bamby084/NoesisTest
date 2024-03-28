#if UNITY_5_3_OR_NEWER
    #define NOESIS
#endif

using System;
using System.Globalization;

#if NOESIS
using Noesis;
#else
using System.Windows.Data;
#endif

namespace Testing
{
    public class DateTimeFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is DateTime date)
            {
                var format = parameter == null ? "dd/MM/yyyy" : parameter.ToString();
                return date.ToString(format);
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
