using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class MenuPage : Page
{
    public MenuPage()
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
