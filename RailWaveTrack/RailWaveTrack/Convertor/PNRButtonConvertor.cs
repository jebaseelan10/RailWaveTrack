using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace RailWaveTrack.Convertor
{
    public class PNRButtonConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Xamarin.Forms.Color)
            {
                Color color = (Xamarin.Forms.Color)value;
                if (color == Color.Green)                    
                    return true;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
