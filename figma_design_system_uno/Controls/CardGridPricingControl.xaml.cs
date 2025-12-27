using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;

namespace figma_design_system_uno.Controls;

public sealed partial class CardGridPricingControl : UserControl
{
    public List<string> PricingFeatures { get; } = new List<string>
    {
        "List item",
        "List item",
        "List item",
        "List item",
        "List item"
    };

    public static readonly DependencyProperty IsMobileProperty =
        DependencyProperty.Register(
            nameof(IsMobile),
            typeof(bool),
            typeof(CardGridPricingControl),
            new PropertyMetadata(false));

    public bool IsMobile
    {
        get => (bool)GetValue(IsMobileProperty);
        set => SetValue(IsMobileProperty, value);
    }

    public CardGridPricingControl()
    {
        this.InitializeComponent();
        this.DataContext = this;
    }
}
