using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Controls;

public sealed partial class HeroFormControl : UserControl
{
    public static readonly DependencyProperty IsMobileProperty =
        DependencyProperty.Register(
            nameof(IsMobile),
            typeof(bool),
            typeof(HeroFormControl),
            new PropertyMetadata(false));

    public bool IsMobile
    {
        get => (bool)GetValue(IsMobileProperty);
        set => SetValue(IsMobileProperty, value);
    }

    public HeroFormControl()
    {
        InitializeComponent();
    }
}
