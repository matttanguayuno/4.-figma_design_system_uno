using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Controls;

public sealed partial class HeaderControl : UserControl
{
    public static readonly DependencyProperty IsMobileProperty =
        DependencyProperty.Register(nameof(IsMobile), typeof(bool), typeof(HeaderControl), new PropertyMetadata(false, OnPropertiesChanged));

    public static readonly DependencyProperty IsMenuOpenProperty =
        DependencyProperty.Register(nameof(IsMenuOpen), typeof(bool), typeof(HeaderControl), new PropertyMetadata(false, OnPropertiesChanged));

    public static readonly DependencyProperty ShowMobileClosedProperty =
        DependencyProperty.Register(nameof(ShowMobileClosed), typeof(bool), typeof(HeaderControl), new PropertyMetadata(false));

    public static readonly DependencyProperty ShowMobileOpenProperty =
        DependencyProperty.Register(nameof(ShowMobileOpen), typeof(bool), typeof(HeaderControl), new PropertyMetadata(false));

    public bool IsMobile
    {
        get => (bool)GetValue(IsMobileProperty);
        set => SetValue(IsMobileProperty, value);
    }

    public bool IsMenuOpen
    {
        get => (bool)GetValue(IsMenuOpenProperty);
        set => SetValue(IsMenuOpenProperty, value);
    }

    public bool ShowMobileClosed
    {
        get => (bool)GetValue(ShowMobileClosedProperty);
        private set => SetValue(ShowMobileClosedProperty, value);
    }

    public bool ShowMobileOpen
    {
        get => (bool)GetValue(ShowMobileOpenProperty);
        private set => SetValue(ShowMobileOpenProperty, value);
    }

    public HeaderControl()
    {
        this.InitializeComponent();
        UpdateVisibility();
    }

    private static void OnPropertiesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is HeaderControl control)
        {
            control.UpdateVisibility();
        }
    }

    private void UpdateVisibility()
    {
        ShowMobileClosed = IsMobile && !IsMenuOpen;
        ShowMobileOpen = IsMobile && IsMenuOpen;
    }

    private void OnToggleMenu(object sender, RoutedEventArgs e)
    {
        IsMenuOpen = !IsMenuOpen;
    }
}
