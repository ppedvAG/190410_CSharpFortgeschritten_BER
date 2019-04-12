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
    class Farbkonverter : IValueConverter
    {
        // OneWay
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
                return new SolidColorBrush(Colors.Black);


            string farbe = (string)value;

            if (farbe == "Rot")
                return Brushes.Red;
            else if (farbe == "Grün")
                return Brushes.Green;
            else if (farbe == "Geil")
                return new LinearGradientBrush
                {
                    GradientStops = new GradientStopCollection
                    {
                        new GradientStop{Offset = 0,Color=Colors.PapayaWhip},
                        new GradientStop{Offset = 0.5,Color=Colors.Gray},
                        new GradientStop{Offset = 1,Color=Colors.OldLace},
                    }
                };
            else
                return Brushes.Black;
        }

        // TwoWay
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
