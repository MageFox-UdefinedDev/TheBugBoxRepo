using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace BugBox.Converters
{
    public class IntStatusToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int)
            {
                switch ((int)value)
                {
                    case 1:
                        return App.Current.Resources["OrangeStatus"];

                    case 2:
                        return App.Current.Resources["GreenStatus"];

                    case 3:
                        return App.Current.Resources["RedStatus"];
                }
            }
            else
            {
                return App.Current.Resources["RedStatus"];
            }
            return App.Current.Resources["RedStatus"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}