using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace VNC.Core.Xaml
{
    public class VisToBool : IValueConverter
    {
        Boolean inverted = false;
        public Boolean Inverted
        {
            get { return inverted; }
            set
            {
                inverted = value;
            }
        }

        Boolean not = false;
        public Boolean Not
        {
            get { return not; }
            set
            {
                not = value;
            }
        }

        private object VisibilityToBool(object value)
        {
            if (!(value is Visibility))
                return DependencyProperty.UnsetValue;

            return (((Visibility)value) == Visibility.Visible) ^ Not;
        }

        private object BoolToVisibility(object value)
        {
            if (!(value is Boolean))
                return DependencyProperty.UnsetValue;

            return ((Boolean)value ^ Not) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object Convert(object value, Type targetType,
        object parameter, CultureInfo culture)
        {
            return Inverted ? BoolToVisibility(value) : VisibilityToBool(value);
        }

        public object ConvertBack(object value, Type targetType,
        object parameter, CultureInfo culture)
        {
            return Inverted ? VisibilityToBool(value) : BoolToVisibility(value);
        }
    }
}
