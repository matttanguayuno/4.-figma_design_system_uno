using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using System;

namespace figma_design_system_uno.Presentation;

public class EqualsConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        return value?.ToString() == parameter?.ToString();
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        return (bool)value ? parameter : DependencyProperty.UnsetValue;
    }
}

public class EqualsToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        return value?.ToString() == parameter?.ToString() ? Visibility.Visible : Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}

public class InverseBoolToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        return value is bool b && b ? Visibility.Collapsed : Visibility.Visible;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}

public class RoundingConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is double d)
        {
            return Math.Round(d).ToString();
        }
        if (value is float f)
        {
            return Math.Round(f).ToString();
        }
        return value?.ToString() ?? "0";
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        if (double.TryParse(value?.ToString(), out var d))
        {
            return d;
        }
        return 0.0;
    }
}
