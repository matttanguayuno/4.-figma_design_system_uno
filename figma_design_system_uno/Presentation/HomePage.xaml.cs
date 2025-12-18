using Microsoft.UI.Xaml.Media;

namespace figma_design_system_uno.Presentation;

public sealed partial class HomePage : Page
{
    public HomePage()
    {
        this.InitializeComponent();
    }

    public void SetNavigationFrame(Frame frame)
    {
        if (DataContext == null)
        {
            DataContext = new HomeModel(frame);
        }
    }

    private void OnPageLoaded(object sender, RoutedEventArgs e)
    {
        // This will be set by Shell now
    }
}
