using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Uno.Extensions.Navigation;
using Microsoft.Extensions.DependencyInjection;

namespace figma_design_system_uno.Presentation;

public sealed partial class AvatarPage : Page
{
    public AvatarPage()
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
