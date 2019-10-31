using System;
using System.Globalization;
using Xamarin.Forms;

namespace Chapter5Examples.Converters
{
    public class IsEmptyStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((int)value > 0) ? true : false;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
