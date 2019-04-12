using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace BindingsUndValidation
{
    class RGBConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            byte R = System.Convert.ToByte(values[0]);
            byte G = System.Convert.ToByte(values[1]);
            byte B = System.Convert.ToByte(values[2]);

            return new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
