using Uno.Extensions.Navigation;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace figma_design_system_uno.Presentation;

public sealed partial class CardsPage : Page
{
    public List<string> PricingFeatures { get; } = new List<string>
    {
        "List item",
        "List item",
        "List item",
        "List item",
        "List item"
    };

    public CardsPage()
    {
        this.InitializeComponent();
    }

    private async void OnBackClick(object sender, RoutedEventArgs e)
    {
        var navigator = (this.XamlRoot?.Content as FrameworkElement)?.GetServiceProvider()?.GetService<INavigator>();
        if (navigator != null)
        {
            await navigator.NavigateRouteAsync(this, "");
        }
    }
}
