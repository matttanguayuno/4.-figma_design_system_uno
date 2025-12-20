using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;

namespace figma_design_system_uno.Presentation;

public sealed partial class NavigationPage : Page
{
    public NavigationPage()
    {
        this.InitializeComponent();
    }

    private void OnBackClick(object sender, RoutedEventArgs e)
    {
        if (Frame.CanGoBack)
        {
            Frame.GoBack();
        }
    }
}
