using System;
using System.Text;
using System.Windows.Data;

namespace DemoWPF2
{
    class FullnameConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            StringBuilder fullNameBuilder = new StringBuilder();
            foreach (object name in values)
            {
                fullNameBuilder.AppendFormat("{0} ", name.ToString());
            }
            return fullNameBuilder.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}