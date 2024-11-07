using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace VNC.WPF.Presentation.Converters
{
    /// <summary>
    /// Value converter that translates true to <see cref="Visibility.Collapsed"/> 
    /// and false to<see cref="Visibility.Visible"/>.
    /// </summary>
    public sealed class InverseBooleanToVisibilityConverter : MarkupExtension, IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is bool && (bool)value) ? Visibility.Collapsed : Visibility.Visible;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culturee)
        {
            return value is Visibility && (Visibility)value == Visibility.Visible;
        }
    }
}
